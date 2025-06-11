package com.projectdam.albartohnos.Models;

import java.io.Serializable;
import java.util.Date;

public class Usuario implements Serializable {
    private String login;
    private String password;
    private int perfil;
    private String nombre;
    private String apellidos;
    private String dni;
    private String nss;
    private String tlf;
    private String email;
    private String ccaa;
    private String localidad;
    private String direccion;
    private byte activo;
    private Date fechaAlta;
    private Date fechaBaja;

    public Usuario() {

    }

    public Usuario(String login, String password, int perfil, String nombre, String apellidos, String dni, String nss, String tlf, String email, String ccaa, String localidad, String direccion, byte activo, Date fechaAlta, Date fechaBaja) {
        this.login = login;
        this.password = password;
        this.perfil = perfil;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.dni = dni;
        this.nss = nss;
        this.tlf = tlf;
        this.email = email;
        this.ccaa = ccaa;
        this.localidad = localidad;
        this.direccion = direccion;
        this.activo = activo;
        this.fechaAlta = fechaAlta;
        this.fechaBaja = fechaBaja;
    }

    // Getters y Setters
    public String getLogin() {
        return login;
    }
    public void setLogin(String login) {
        this.login = login;
    }
    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
    public int getPerfil() {
        return perfil;
    }
    public void setPerfil(int perfil) {
        this.perfil = perfil;
    }
    public String getNombre() {
        return nombre;
    }
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public String getApellidos() {
        return apellidos;
    }
    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }
    public String getDni() {
        return dni;
    }
    public void setDni(String dni) {
        this.dni = dni;
    }
    public String getNss() {
        return nss;
    }
    public void setNss(String nss) {
        this.nss = nss;
    }
    public String getTlf() {
        return tlf;
    }
    public void setTlf(String tlf) {
        this.tlf = tlf;
    }
    public String getEmail() {
        return email;
    }
    public void setEmail(String email) {
        this.email = email;
    }
    public String getCcaa() {
        return ccaa;
    }
    public void setCcaa(String ccaa) {
        this.ccaa = ccaa;
    }
    public String getLocalidad() {
        return localidad;
    }
    public void setLocalidad(String localidad) {
        this.localidad = localidad;
    }
    public String getDireccion() {
        return direccion;
    }
    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }
    public byte getActivo() {
        return activo;
    }
    public void setActivo(byte activo) {
        this.activo = activo;
    }
    public Date getFechaAlta() {
        return fechaAlta;
    }
    public void setFechaAlta(Date fechaAlta) {
        this.fechaAlta = fechaAlta;
    }
    public Date getFechaBaja() {
        return fechaBaja;
    }
    public void setFechaBaja(Date fechaBaja) {
        this.fechaBaja = fechaBaja;
    }
}
