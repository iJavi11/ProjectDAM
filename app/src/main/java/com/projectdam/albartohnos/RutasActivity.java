package com.projectdam.albartohnos;

import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;
import com.projectdam.albartohnos.Models.Usuario;
import com.projectdam.albartohnos.Models.Ruta;
import android.os.AsyncTask;
import java.util.List;
import android.util.Log;
import androidx.recyclerview.widget.RecyclerView;
import androidx.recyclerview.widget.LinearLayoutManager;
import com.projectdam.albartohnos.Lists.RutaAdapter;

import android.view.View;
import android.widget.Button;
import android.content.Intent;

public class RutasActivity extends AppCompatActivity {
    private RecyclerView recyclerView;
    private RutaAdapter rutaAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_rutas);

        // Recuperar el usuario del intent
        Usuario usuario = (Usuario) getIntent().getSerializableExtra("usuario");

        recyclerView = findViewById(R.id.recyclerViewRutas);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        // Botón cerrar sesión
        Button btnCerrarSesion = findViewById(R.id.btnCerrarSesion);
        btnCerrarSesion.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(RutasActivity.this, MainActivity.class);
                intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_NEW_TASK);
                startActivity(intent);
                finish();
            }
        });

        // Petición asíncrona para obtener las rutas del conductor
        new ObtenerRutasTask().execute(usuario.getLogin());
    }

    private class ObtenerRutasTask extends AsyncTask<String, Void, List<Ruta>> {
        @Override
        protected List<Ruta> doInBackground(String... params) {
            return Negocio.ObtenerRutasByConductor(params[0]);
        }

        @Override
        protected void onPostExecute(List<Ruta> rutas) {
            rutaAdapter = new RutaAdapter(rutas);
            recyclerView.setAdapter(rutaAdapter);
        }
    }
}
