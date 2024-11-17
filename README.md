# API de Gestión de Libros

Este proyecto consiste en una API de **Gestión de Libros** desarrollada en **ASP.NET Core Web API**, diseñada para cumplir con los requisitos funcionales y técnicos establecidos en la tarea. La API permite a los usuarios interactuar con una colección digital de libros, incluyendo funcionalidades de registro de usuarios, gestión de libros, calificaciones y reseñas.

---

## Funcionalidades

### **1. Registro y Gestión de Usuarios**
La API permite gestionar los usuarios registrados en la plataforma, incluyendo las siguientes operaciones:

- **Registro de Usuarios**:  
  Los usuarios pueden registrarse proporcionando la siguiente información:  
  - Nombre.  
  - Apellido.  
  - Dirección de correo electrónico.  
  - Contraseña (almacenada de forma segura).  

- **Operaciones CRUD de Usuarios**:  
  - **Listar Usuarios**: Recupera una lista de todos los usuarios registrados.  
  - **Editar Usuarios**: Permite actualizar la información de un usuario específico.  
  - **Eliminar Usuarios**: Elimina usuarios de la base de datos.  

---

### **2. Gestión de Libros**
Los usuarios registrados pueden gestionar su colección digital de libros mediante las siguientes funcionalidades:

- **Añadir Libros**:  
  Permite incluir libros en la colección personal, indicando:  
  - Título del libro.  
  - Autor del libro.  
  - Año de publicación.  
  - Imagen de portada (opcional).

- **Operaciones CRUD de Libros**:  
  - **Listar Libros**: Devuelve la lista de libros registrados por el usuario.  
  - **Editar Libros**: Permite modificar los detalles de un libro existente.  
  - **Eliminar Libros**: Elimina un libro de la colección.

- **Calificaciones y Reseñas**:  
  - Los usuarios pueden calificar los libros con un puntaje entre 1 y 5 estrellas.  
  - También es posible agregar una reseña escrita para cada libro.  

---

## Requisitos Técnicos

- **Tecnología Base**:  
  El backend se ha desarrollado utilizando **ASP.NET Core Web API**.

- **Persistencia de Datos**:  
  La API emplea **Entity Framework Core** para interactuar con una base de datos **SQL Server**, asegurando un manejo eficiente de las operaciones CRUD.

- **Base de Datos**:  
  Se utiliza una estructura de tablas que incluye:
  - `Users`: Para almacenar información de los usuarios.
  - `Books`: Para registrar los libros y sus detalles.
  - `Reviews`: Para guardar reseñas y calificaciones de los libros.

---

## Uso de la API

### **Rutas Principales**

#### **Usuarios**
- `POST /api/users`: Registro de un nuevo usuario.  
- `GET /api/users`: Obtiene la lista de usuarios.  
- `PUT /api/users/{id}`: Actualiza los datos de un usuario existente.  
- `DELETE /api/users/{id}`: Elimina un usuario.

#### **Libros**
- `POST /api/books`: Añade un nuevo libro a la colección.  
- `GET /api/books`: Lista todos los libros de un usuario.  
- `PUT /api/books/{id}`: Actualiza los detalles de un libro.  
- `DELETE /api/books/{id}`: Elimina un libro.  

#### **Calificaciones y Reseñas**
- `POST /api/books/{id}/reviews`: Añade una calificación y reseña a un libro.  
- `GET /api/books/{id}/reviews`: Lista todas las reseñas de un libro.  

---

## Requisitos Previos

### **Configuración del Proyecto**
1. Asegúrate de tener instalado:
   - [.NET SDK](https://dotnet.microsoft.com/download)
   - SQL Server
2. Configura la cadena de conexión en `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=LibraryDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }
