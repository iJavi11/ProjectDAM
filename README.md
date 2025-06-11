# Albarhnos Desktop

Este documento sirve como manual de usuario para la aplicación **Albarhnos Desktop**, diseñada para la gestión de usuarios, vehículos, almacenes y productos.

## Índice

1. [Introducción](#introducción)
2. [Requisitos del Sistema](#requisitos-del-sistema)
3. [Instalación](#instalación)
4. [Inicio de Sesión](#inicio-de-sesión)
5. [Menú Principal](#menú-principal)
6. [Módulos Disponibles](#módulos-disponibles)
   - [Gestión de Usuarios](#gestión-de-usuarios)
   - [Gestión de Vehículos](#gestión-de-vehículos)
   - [Gestión de Almacenes](#gestión-de-almacenes)
   - [Gestión de Centros de Parada](#gestión-de-centros-de-parada)
   - [Gestión de Productos](#gestión-de-productos)
   - [Gestión de Rutas](#gestión-de-rutas)
     - [Gestión de Paradas](#gestión-de-paradas)
     - [Gestión de Pedidos en Paradas](#gestión-de-pedidos-en-paradas)
7. [Soporte](#soporte)

---

## Introducción

**Albarhnos Desktop** es una aplicación de escritorio desarrollada en Windows Forms que permite gestionar diferentes aspectos de una organización, como usuarios, vehículos y almacenes. Está diseñada para ser intuitiva y eficiente, facilitando la administración de datos.

---

## Requisitos del Sistema

- **Sistema Operativo**: Windows 7 o superior.
- **.NET Framework**: Versión 4.7.2 o superior.
- **Espacio en Disco**: Al menos 100 MB libres.
- **Resolución de Pantalla Recomendada**: 1366x768 o superior.

---

## Instalación

1. Descarga el instalador desde el repositorio o el enlace proporcionado por el administrador.
2. Ejecuta el archivo `.exe` y sigue las instrucciones del asistente de instalación.
3. Una vez instalado, abre la aplicación desde el acceso directo creado en el escritorio.

---

## Inicio de Sesión

1. Al abrir la aplicación, se mostrará la pantalla de inicio de sesión.

![Pantalla de Inicio de Sesión](screenshots/login.png)

2. Introduce tu **usuario** y **contraseña** en los campos correspondientes.
3. Haz clic en el botón **Iniciar Sesión**.
4. Si las credenciales son correctas, accederás al menú principal.

---

## Menú Principal

El menú principal es el punto de partida para acceder a los diferentes módulos de la aplicación. Desde aquí, puedes:

![Pantalla de Menú Principal](screenshots/mainMenu.png)

- Navegar a los diferentes módulos de gestión (Usuarios, Vehículos, Almacenes, Productos, Rutas y Centros de Parada).
- Cerrar sesión.

---

## Módulos Disponibles

### Gestión de Usuarios

- Accede al módulo de usuarios desde el menú principal.

<div align="center">
  <img src="screenshots/usuarios1.png" alt="Lista de Usuarios">
  <p><em>Lista de Usuarios</em></p>
</div>

- Funcionalidades principales:
  - **Crear Usuario**: Haz clic en el botón "Crear Usuario" para añadir un nuevo usuario.

    <div align="center">
     <img src="screenshots/usuarios2.png" alt="Crear Usuario">
     <p><em>Crear Usuario</em></p>
    </div>

  - **Editar Usuario**: Haz clic derecho sobre un usuario en la lista y selecciona "Editar".

    <div align="center">
     <img src="screenshots/usuarios3.png" alt="Editar Usuario">
     <p><em>Editar Usuario</em></p>
    </div>

  - **Cambiar Contraseña**: Los usuarios con perfil de Administrador pueden cambiar la contraseña de otros usuarios desde el menú contextual.

    <div align="center">
     <img src="screenshots/usuarios4.png" alt="Cambiar Contraseña Usuario">
     <p><em>Cambio de Contraseña</em></p>
    </div>

  - **Activar/Desactivar Usuario**: Cambia el estado de un usuario desde el menú contextual.

  - **Eliminar Usuario**: Elimina un usuario seleccionado.
  

### Gestión de Vehículos

- Accede al módulo de vehículos desde el menú principal.

<div align="center">
  <img src="screenshots/vehiculos1.png" alt="Lista de Vehículos">
  <p><em>Lista de Vehículos</em></p>
</div>

- Funcionalidades principales:
  - **Visualización de la Lista de Vehículos**: Consulta todos los vehículos registrados en el sistema.
  - **Crear Vehículo**: Añade un nuevo vehículo al sistema.
  
<div align="center">
  <img src="screenshots/vehiculos4.png" alt="Activar o Desactivar Vehículo">
  <p><em>Crear Vehículo</em></p>
</div>

  
  - **Editar Vehículo**: Modifica la información de un vehículo existente.

<div align="center">
  <img src="screenshots/vehiculos5.png" alt="Activar o Desactivar Vehículo">
  <p><em>Editar Vehículo</em></p>
</div>


  - **Activar/Desactivar Vehículo**: Cambia el estado de un vehículo desde el menú contextual para habilitarlo o deshabilitarlo.

<div align="center">
  <img src="screenshots/vehiculos2.png" alt="Activar o Desactivar Vehículo">
  <img src="screenshots/vehiculos3.png" alt="Activar o Desactivar Vehículo">
  <p><em>Activar o Desactivar Vehículo</em></p>
</div>

  - **Eliminar Vehículo**: Elimina un vehículo registrado.

### Gestión de Almacenes

- Accede al módulo de almacenes desde el menú principal.

<div align="center">
  <img src="screenshots/almacenes1.png" alt="Lista de Almacenes">
  <p><em>Lista de Almacenes</em></p>
</div>

- Funcionalidades principales:
  - **Visualización de Almacenes Disponibles**: Consulta todos los almacenes registrados en el sistema.
    <div align="center">
      <img src="screenshots/almacenes2.png" alt="Acciones Almacén">
      <p><em>Acciones<em></p>
    </div>
  - **Añadir Almacén**: Registra un nuevo almacén en el sistema.

    <div align="center">
      <img src="screenshots/almacenes3.png" alt="Añadir Almacén">
      <p><em>Añadir Almacén</em></p>
    </div>
    
  - **Editar Almacén**: Modifica la información de un almacén existente.
    
    <div align="center">
      <img src="screenshots/almacenes4.png" alt="Editar Almacén">
      <p><em>Editar Almacén</em></p>
    </div>

  - **Stock del Almacén**: Consulta el inventario disponible en cada almacén.
    
    <div align="center">
      <img src="screenshots/almacenes5.png" alt="Stock Almacén">
      <p><em>Stock del Almacén</em></p>
    </div>

  - **Eliminar Almacén**: Elimina un almacén registrado.
    

### Gestión de Centros de Parada

- Accede al módulo de centros de parada desde el menú principal.

<div align="center">
  <img src="screenshots/centrosparada1.png" alt="Lista de Centros de Parada">
  <p><em>Lista de Centros de Parada</em></p>
</div>

- Funcionalidades principales:
  - **Visualización de Centros de Parada**: Consulta todos los centros de parada registrados.
    <div align="center">
      <img src="screenshots/centrosparada2.png" alt="Acciones Centro Parada">
      <p><em>Acciones</em></p>
    </div>
  - **Añadir Centro de Parada**: Registra un nuevo centro de parada en el sistema.
    <div align="center">
      <img src="screenshots/centrosparada3.png" alt="Añadir Centro de Parada">
      <p><em>Añadir Centro de Parada</em></p>
    </div>
  - **Editar Centro de Parada**: Modifica la información de un centro de parada existente.
    <div align="center">
      <img src="screenshots/centrosparada4.png" alt="Editar Centro de Parada">
      <p><em>Editar Centro de Parada</em></p>
    </div>
  - **Eliminar Centro de Parada**: Elimina un centro de parada registrado.
    
### Gestión de Productos

- Accede al módulo de productos desde el menú principal.

<div align="center">
  <img src="screenshots/productos1.png" alt="Lista de Productos">
  <p><em>Lista de Productos</em></p>
</div>

- Funcionalidades principales:

    <div align="center">
      <img src="screenshots/productos2.png" alt="Acciones Producto 1">
      <img src="screenshots/productos3.png" alt="Acciones Producto 2">
      <p><em>Acciones</em></p>
    </div>

  - **Añadir Producto**: Registra nuevos productos en el sistema.
    
    <div align="center">
      <img src="screenshots/productos4.png" alt="Añadir Producto">
      <p><em>Añadir Producto</em></p>
    </div>

  - **Editar Producto**: Modifica la información de productos existentes.

    <div align="center">
      <img src="screenshots/productos5.png" alt="Editar Producto">
      <p><em>Editar Producto</em></p>
    </div>

 - **Eliminar Producto**: Elimina productos que ya no sean necesarios.
    
  - **Inventario**: Consulta el inventario disponible.

    <div align="center">
      <img src="screenshots/productos6.png" alt="Stock Producto">
      <p><em>Stock Producto</em></p>
    </div>

    <div align="center">
      <img src="screenshots/productos7.png" alt="Añadir Inventario">
      <p><em>Añadir Inventario</em></p>
    </div>

    <div align="center">
      <img src="screenshots/productos8.png" alt="Añadir Inventario">
      <p><em>Editar Inventario</em></p>
    </div>

### Gestión de Rutas

- Accede al módulo de rutas desde el menú principal.
    <div align="center">
      <img src="screenshots/rutas1.png" alt="Lista de Rutas">
      <p><em>Lista de Rutas</em></p>
    </div>
- Funcionalidades principales:
  - **Crear Ruta**: Genera nuevas rutas para la distribución de productos.
    <div align="center">
      <img src="screenshots/rutas2.png" alt="Crear Ruta">
      <p><em>Crear Ruta</em></p>
    </div>
  - **Editar Ruta**: Modifica rutas existentes.
    <div align="center">
      <img src="screenshots/rutas3.png" alt="Editar Ruta">
      <p><em>Editar Ruta</em></p>
    </div>
  - **Ver Paradas de la Ruta**
  - **Eliminar Ruta**: Elimina rutas que ya no sean necesarias.
  - **Cambio de Estado de Ruta**: Cambia el estado de una ruta (Planificada/En Progreso/Finalizada) desde el menú contextual.
    <div align="center">
      <img src="screenshots/rutas5.png" alt="Cambio de Estado de Ruta">
      <p><em>Cambio de Estado de Ruta</em></p>
    </div>

---

#### Gestión de Paradas

- Dentro del módulo de rutas, accede a la gestión de paradas, desde la opción 'Ver Paradas'

    <div align="center">
      <img src="screenshots/paradas1.png" alt="Lista de Paradas">
      <p><em>Lista de Paradas</em></p>
    </div>

- Funcionalidades principales:
  - **Añadir Parada**: Registra nuevas paradas en una ruta.
    <div align="center">
      <img src="screenshots/paradas2.png" alt="Añadir Parada">
      <p><em>Añadir Parada</em></p>
    </div>
  - **Editar Parada**: Modifica la información de paradas existentes.
    <div align="center">
      <img src="screenshots/paradas3.png" alt="Editar Parada">
      <p><em>Editar Parada</em></p>
    </div>
  - **Ver Pedidos de la Parada**
  - **Eliminar Parada**: Elimina paradas de una ruta.
  - **Cambio de Estado de Parada**: Cambia el estado de una parada (En Progreso/OK/KO) desde el menú contextual.
    <div align="center">
      <img src="screenshots/paradas5.png" alt="Cambio de Estado de Parada">
      <p><em>Cambio de Estado de Parada</em></p>
    </div>

---

#### Gestión de Pedidos en Paradas

- Dentro de cada parada, puedes gestionar los pedidos asociados, haciendo clic sobre 'Ver Pedidos' dentro de la Parada.
    <div align="center">
      <img src="screenshots/pedidos1.png" alt="Lista de Pedidos en Paradas">
      <p><em>Lista de Pedidos en Paradas</em></p>
    </div>
- Funcionalidades principales:
  - **Añadir Pedido a Parada**: Asocia un pedido a una parada específica.
    <div align="center">
      <img src="screenshots/pedidos2.png" alt="Añadir Pedido a Parada">
      <p><em>Añadir Pedido a Parada</em></p>
    </div>
  - **Editar Pedido en Parada**: Modifica los detalles de un pedido asociado a una parada.
    <div align="center">
      <img src="screenshots/pedidos3.png" alt="Editar Pedido en Parada">
      <p><em>Editar Pedido en Parada</em></p>
    </div>
  - **Eliminar Pedido de Parada**: Elimina un pedido de una parada.
  - **Cambio de Estado de Pedido**: Cambia el estado de un pedido (OK/Paracial/KO) desde el menú contextual.
    <div align="center">
      <img src="screenshots/pedidos5.png" alt="Cambio de Estado de Pedido">
      <p><em>Cambio de Estado de Pedido</em></p>
    </div>

---

## Soporte

Si tienes problemas o preguntas sobre el uso de la aplicación, contacta con el equipo de soporte técnico a través del correo electrónico **soporte@solinfobartolome.es**.