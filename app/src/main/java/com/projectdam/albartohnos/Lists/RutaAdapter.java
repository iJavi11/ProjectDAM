package com.projectdam.albartohnos.Lists;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import android.widget.ImageView;
import android.graphics.PorterDuff;
import androidx.recyclerview.widget.RecyclerView;
import com.projectdam.albartohnos.Models.Ruta;
import com.projectdam.albartohnos.R;
import java.text.SimpleDateFormat;
import java.util.List;
import java.util.Locale;

public class RutaAdapter extends RecyclerView.Adapter<RutaAdapter.RutaViewHolder> {
    private List<Ruta> rutas;

    public RutaAdapter(List<Ruta> rutas) {
        this.rutas = rutas;
    }

    @Override
    public RutaViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_ruta, parent, false);
        return new RutaViewHolder(v);
    }

    @Override
    public void onBindViewHolder(RutaViewHolder holder, int position) {
        Ruta ruta = rutas.get(position);
        holder.textCodRuta.setText("Código: " + ruta.getCodRuta());
        holder.textDescripcion.setText("Descripción: " + (ruta.getDescripcion() != null ? ruta.getDescripcion() : ""));
        holder.textEstado.setText("Estado: " + ruta.getEstado());
        holder.textVehiculo.setText("Vehículo: " + (ruta.getVehiculo() != null ? ruta.getVehiculo() : ""));
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd", Locale.getDefault());
        String fechas = "";
        if (ruta.getFechaPrevInicio() != null)
            fechas += sdf.format(ruta.getFechaPrevInicio());
        if (ruta.getFechaPrevFin() != null)
            fechas += " - " + sdf.format(ruta.getFechaPrevFin());
        holder.textFecha.setText("Fechas: " + fechas);

        // Cambia el color del icono según el estado
        int color;
        switch (ruta.getEstado()) {
            case 1:
                color = 0xFFFFEB3B; // Amarillo
                break;
            case 2:
                color = 0xFF03A9F4; // Azul claro
                break;
            case 3:
                color = 0xFF4CAF50; // Verde
                break;
            case 4:
                color = 0xFFF44336; // Rojo (Finalizado)
                break;
            default:
                color = 0xFF9E9E9E; // Gris por defecto
                break;
        }
        holder.estadoIcon.setColorFilter(color, PorterDuff.Mode.SRC_IN);
    }

    @Override
    public int getItemCount() {
        return rutas.size();
    }

    public static class RutaViewHolder extends RecyclerView.ViewHolder {
        TextView textCodRuta, textDescripcion, textEstado, textVehiculo, textFecha;
        ImageView estadoIcon;

        public RutaViewHolder(View itemView) {
            super(itemView);
            textCodRuta = itemView.findViewById(R.id.textCodRuta);
            textDescripcion = itemView.findViewById(R.id.textDescripcion);
            textEstado = itemView.findViewById(R.id.textEstado);
            textVehiculo = itemView.findViewById(R.id.textVehiculo);
            textFecha = itemView.findViewById(R.id.textFecha);
            estadoIcon = itemView.findViewById(R.id.estadoIcon);
        }
    }
}
