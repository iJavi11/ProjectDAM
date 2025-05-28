package com.projectdam.albartohnos;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.appcompat.app.AppCompatActivity;
import android.os.AsyncTask;
import org.json.JSONObject;
import java.io.OutputStream;
import java.io.InputStream;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import javax.net.ssl.HostnameVerifier;
import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLContext;
import javax.net.ssl.SSLSession;
import javax.net.ssl.TrustManager;
import javax.net.ssl.X509TrustManager;
import java.security.cert.X509Certificate;
import java.security.MessageDigest;

public class MainActivity extends AppCompatActivity {
    private TextView loginTitleTextView;
    private EditText usernameEditText;
    private EditText passwordEditText;
    private TextView errorTextView;
    private ImageView logoImageView;

    // Clase para confiar en todos los certificados (solo para desarrollo)
    private void trustAllCertificates() {
        try {
            TrustManager[] trustAllCerts = new TrustManager[]{
                new X509TrustManager() {
                    public java.security.cert.X509Certificate[] getAcceptedIssuers() { return new X509Certificate[0]; }
                    public void checkClientTrusted(X509Certificate[] certs, String authType) {}
                    public void checkServerTrusted(X509Certificate[] certs, String authType) {}
                }
            };
            SSLContext sc = SSLContext.getInstance("SSL");
            sc.init(null, trustAllCerts, new java.security.SecureRandom());
            HttpsURLConnection.setDefaultSSLSocketFactory(sc.getSocketFactory());
            HttpsURLConnection.setDefaultHostnameVerifier(new HostnameVerifier() {
                public boolean verify(String hostname, SSLSession session) { return true; }
            });
        } catch (Exception ignored) {}
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        // Oculta la barra de título
        if (getSupportActionBar() != null) {
            getSupportActionBar().hide();
        }
        setContentView(R.layout.activity_main);

        trustAllCertificates();

        logoImageView = findViewById(R.id.logoImageView);
        loginTitleTextView = findViewById(R.id.loginTitleTextView);
        usernameEditText = findViewById(R.id.usernameEditText);
        passwordEditText = findViewById(R.id.passwordEditText);
        errorTextView = findViewById(R.id.errorTextView);
        Button loginButton = findViewById(R.id.loginButton);

        loginButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String username = usernameEditText.getText().toString();
                String password = passwordEditText.getText().toString();

                // Llama a la API en vez de comprobar localmente
                new LoginTask().execute(username, password);
            }
        });
    }

    // Método para encriptar la contraseña en SHA-256
    public static String encriptarSHA256(String password) {
        try {
            MessageDigest digest = MessageDigest.getInstance("SHA-256");
            byte[] hash = digest.digest(password.getBytes("UTF-8"));
            StringBuilder hexString = new StringBuilder();
            for (byte b : hash) {
                String hex = Integer.toHexString(0xff & b);
                if(hex.length() == 1) hexString.append('0');
                hexString.append(hex);
            }
            return hexString.toString();
        } catch (Exception ex) {
            return null;
        }
    }

    // AsyncTask para la petición de login
    private class LoginTask extends AsyncTask<String, Void, Boolean> {
        private String errorMsg = null;
        private String token = null;

        @Override
        protected Boolean doInBackground(String... params) {
            String login = params[0];
            String password = params[1];
            // Encriptar la contraseña antes de enviarla
            String encryptedPassword = encriptarSHA256(password);
            HttpsURLConnection conn = null;
            try {
                URL url = new URL("https://10.0.2.2:7256/api/Auth/login");
                conn = (HttpsURLConnection) url.openConnection();
                conn.setRequestMethod("POST");
                conn.setRequestProperty("Content-Type", "application/json; charset=UTF-8");
                conn.setDoOutput(true);

                JSONObject jsonParam = new JSONObject();
                jsonParam.put("login", login);
                jsonParam.put("password", encryptedPassword);

                OutputStream os = conn.getOutputStream();
                os.write(jsonParam.toString().getBytes("UTF-8"));
                os.close();

                int responseCode = conn.getResponseCode();
                if (responseCode == 200) {
                    // Leer respuesta para obtener el token
                    BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));
                    StringBuilder sb = new StringBuilder();
                    String line;
                    while ((line = reader.readLine()) != null) {
                        sb.append(line);
                    }
                    reader.close();
                    JSONObject responseJson = new JSONObject(sb.toString());
                    token = responseJson.optString("token");
                    return token != null && !token.isEmpty();
                } else {
                    InputStream errorStream = conn.getErrorStream();
                    if (errorStream != null) {
                        BufferedReader reader = new BufferedReader(new InputStreamReader(errorStream));
                        StringBuilder sb = new StringBuilder();
                        String line;
                        while ((line = reader.readLine()) != null) {
                            sb.append(line);
                        }
                        reader.close();
                        errorMsg = sb.toString();
                    } else {
                        errorMsg = "Error de autenticación";
                    }
                    return false;
                }
            } catch (Exception e) {
                errorMsg = "Error de conexión: " + e.getMessage();
                return false;
            } finally {
                if (conn != null) conn.disconnect();
            }
        }

        @Override
        protected void onPostExecute(Boolean success) {
            if (success && token != null) {
                errorTextView.setVisibility(View.GONE);
                usernameEditText.setVisibility(View.GONE);
                passwordEditText.setVisibility(View.GONE);
                loginTitleTextView.setVisibility(View.GONE);
                findViewById(R.id.loginButton).setVisibility(View.GONE);
                errorTextView.setText("¡Bienvenido!");
                errorTextView.setTextColor(getResources().getColor(android.R.color.holo_green_dark));
                errorTextView.setVisibility(View.VISIBLE);
            } else {
                errorTextView.setText(errorMsg != null ? errorMsg : "Usuario o contraseña incorrectos");
                errorTextView.setTextColor(getResources().getColor(android.R.color.holo_red_dark));
                errorTextView.setVisibility(View.VISIBLE);
            }
        }
    }
}
