package com.projectdam.albartohnos;

import org.json.JSONObject;
import java.io.OutputStream;
import java.io.InputStream;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import javax.net.ssl.HttpsURLConnection;
import com.projectdam.albartohnos.Models.Usuario;
import com.projectdam.albartohnos.Models.Ruta;
import java.text.SimpleDateFormat;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.List;

public class Negocio {
    // URL de la API
    private static String BaseURL = "https://10.0.2.2:7256/api/";
    private static String Token;

    // Método para hacer login y guardar el token si es correcto
    public static String IniciarSesion(String login, String encryptedPassword) {
        HttpsURLConnection conn = null;
        try {
            URL url = new URL(BaseURL + "Auth/login");
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
                BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));
                StringBuilder sb = new StringBuilder();
                String line;
                while ((line = reader.readLine()) != null) {
                    sb.append(line);
                }
                reader.close();
                JSONObject responseJson = new JSONObject(sb.toString());
                Token = responseJson.optString("token");
                return Token;
            } else {
                System.out.println("Error en la respuesta de la API: Código " + responseCode);
            }
        } catch (Exception e) {
            // Manejo de errores opcional
            System.out.println("Excepción en ObtenerUsuario: " + e.getMessage());
            e.printStackTrace();
        } finally {
            if (conn != null) conn.disconnect();
        }
        return null;
    }

    // Método para buscar usuario por login
    public static Usuario ObtenerUsuario(String login) {
        HttpsURLConnection conn = null;
        try {
            URL url = new URL(BaseURL + "Usuarios/" + login);
            conn = (HttpsURLConnection) url.openConnection();
            conn.setRequestMethod("GET");
            conn.setRequestProperty("Authorization", "Bearer " + Token);
            conn.setRequestProperty("Accept", "application/json");

            int responseCode = conn.getResponseCode();
            if (responseCode == 200) {
                BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));
                StringBuilder sb = new StringBuilder();
                String line;
                while ((line = reader.readLine()) != null) {
                    sb.append(line);
                }
                reader.close();
                JSONObject obj = new JSONObject(sb.toString());

                // Parseo de fechas
                SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
                String fechaAltaStr = obj.optString("fechaAlta", null);
                String fechaBajaStr = obj.optString("fechaBaja", null);

                Usuario usuario = new Usuario(
                    obj.optString("login"),
                    obj.optString("password"),
                    obj.optInt("perfil"),
                    obj.optString("nombre"),
                    obj.optString("apellidos"),
                    obj.optString("dni"),
                    obj.optString("nss", null),
                    obj.optString("tlf", null),
                    obj.optString("email", null),
                    obj.optString("ccaa", null),
                    obj.optString("localidad", null),
                    obj.optString("direccion", null),
                    (byte) obj.optInt("activo"),
                    fechaAltaStr != null && !fechaAltaStr.equals("null") && !fechaAltaStr.isEmpty() ? sdf.parse(fechaAltaStr) : null,
                    fechaBajaStr != null && !fechaBajaStr.equals("null") && !fechaBajaStr.isEmpty() ? sdf.parse(fechaBajaStr) : null
                );
                return usuario;
            } else {
                System.out.println("Error en la respuesta de la API: Código " + responseCode);
            }
        } catch (Exception e) {
            // Manejo de errores opcional
            System.out.println("Excepción en ObtenerUsuario: " + e.getMessage());
            e.printStackTrace();
        } finally {
            if (conn != null) conn.disconnect();
        }
        return null;
    }

    // Método para obtener las rutas de un conductor
    public static List<Ruta> ObtenerRutasByConductor(String loginConductor) {
        HttpsURLConnection conn = null;
        List<Ruta> rutas = new ArrayList<>();
        try {
            URL url = new URL(BaseURL + "Rutas/Condcutor/" + loginConductor);
            conn = (HttpsURLConnection) url.openConnection();
            conn.setRequestMethod("GET");
            conn.setRequestProperty("Authorization", "Bearer " + Token);
            conn.setRequestProperty("Accept", "application/json");

            int responseCode = conn.getResponseCode();
            if (responseCode == 200) {
                BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));
                StringBuilder sb = new StringBuilder();
                String line;
                while ((line = reader.readLine()) != null) {
                    sb.append(line);
                }
                reader.close();

                org.json.JSONArray arr = new org.json.JSONArray(sb.toString());
                SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");

                for (int i = 0; i < arr.length(); i++) {
                    JSONObject obj = arr.getJSONObject(i);
                    Ruta ruta = new Ruta(
                        obj.optString("codRuta"),
                        obj.optInt("estado"),
                        obj.optString("descripcion", null),
                        obj.optString("conductor", null),
                        obj.optString("vehiculo", null),
                        obj.isNull("fechaPrevInicio") || obj.optString("fechaPrevInicio").isEmpty() || obj.optString("fechaPrevInicio").equals("null") ? null : sdf.parse(obj.optString("fechaPrevInicio")),
                        obj.isNull("fechaPrevFin") || obj.optString("fechaPrevFin").isEmpty() || obj.optString("fechaPrevFin").equals("null") ? null : sdf.parse(obj.optString("fechaPrevFin"))
                    );
                    rutas.add(ruta);
                }
            } else {
                System.out.println("Error en la respuesta de la API (Rutas): Código " + responseCode);
            }
        } catch (Exception e) {
            System.out.println("Excepción en ObtenerRutasDeConductor: " + e.getMessage());
            e.printStackTrace();
        } finally {
            if (conn != null) conn.disconnect();
        }
        return rutas;
    }

    public static String getToken() {
        return Token;
    }
}
