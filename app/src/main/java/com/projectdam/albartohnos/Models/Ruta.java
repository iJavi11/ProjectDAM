package com.projectdam.albartohnos.Models;

import java.io.Serializable;
import java.util.Date;

public class Ruta implements Serializable {
    private String codRuta;
    private int estado;
    private String descripcion;
    private String conductor;
    private String vehiculo;
    private Date fechaPrevInicio;
    private Date fechaPrevFin;

    public Ruta() {

    }

    public Ruta(String codRuta, int estado, String descripcion, String conductor, String vehiculo, Date fechaPrevInicio, Date fechaPrevFin) {
        this.codRuta = codRuta;
        this.estado = estado;
        this.descripcion = descripcion;
        this.conductor = conductor;
        this.vehiculo = vehiculo;
        this.fechaPrevInicio = fechaPrevInicio;
        this.fechaPrevFin = fechaPrevFin;
    }

    // Getters y Setters
    public String getCodRuta() {
        return codRuta;
    }
    public void setCodRuta(String codRuta) {
        this.codRuta = codRuta;
    }
    public int getEstado() {
        return estado;
    }
    public void setEstado(int estado) {
        this.estado = estado;
    }
    public String getDescripcion() {
        return descripcion;
    }
    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    public String getConductor() {
        return conductor;
    }
    public void setConductor(String conductor) {
        this.conductor = conductor;
    }
    public String getVehiculo() {
        return vehiculo;
    }
    public void setVehiculo(String vehiculo) {
        this.vehiculo = vehiculo;
    }
    public Date getFechaPrevInicio() {
        return fechaPrevInicio;
    }
    public void setFechaPrevInicio(Date fechaPrevInicio) {
        this.fechaPrevInicio = fechaPrevInicio;
    }
    public Date getFechaPrevFin() {
        return fechaPrevFin;
    }
    public void setFechaPrevFin(Date fechaPrevFin) {
        this.fechaPrevFin = fechaPrevFin;
    }
}
