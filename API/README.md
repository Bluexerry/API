# Descripción Detallada del Proyecto API de Frases de Los Simpsons

## Introducción

El proyecto API de Frases de Los Simpsons es una API RESTful desarrollada en C# sobre .NET 8, diseñada para consumir la API externa de The Simpsons Quote. Su objetivo es ofrecer tres rutas principales para obtener frases de personajes de Los Simpsons, ya sea de forma aleatoria, filtradas por personaje o en una cantidad específica. Todas las respuestas se devuelven en formato JSON.

---

## Estructura del Proyecto

La organización del proyecto sigue buenas prácticas para APIs REST en C#, estructurándose en capas bien definidas:

### Carpetas Principales:

- **/Controllers**: Contiene los controladores de la API.
- **/Models**: Define los modelos de datos utilizados.
- **/Services**: Implementa la lógica de negocio y consume la API externa.
- **Program.cs**: Configura los servicios y middleware necesarios para la aplicación.

---

## Componentes Clave

### 1. Modelo: SimpsonsQuote

Definido en `/API/Models/SimpsonsQuote.cs`, este modelo representa la estructura de los datos recibidos de la API externa.

### 2. Servicio: ISimpsonsQuoteService y SimpsonsQuoteService

- **Interfaz ISimpsonsQuoteService**: Definida en `/API/Services/ISimpsonsQuoteService.cs`, declara los métodos que el servicio debe implementar.
- **Implementación SimpsonsQuoteService**: Implementada en `/API/Services/SimpsonsQuoteService.cs`, utiliza `HttpClient` para consumir la API externa, gestionando las solicitudes HTTP y el manejo de errores.

### 3. Controlador: SimpsonsQuoteController

Definido en `/API/Controllers/SimpsonsQuoteController.cs`, este controlador expone las rutas de la API y utiliza el servicio para procesar y devolver los datos.

### 4. Configuración: Program.cs

Configura los servicios y middleware esenciales, incluyendo la inyección de dependencias y la configuración de CORS para permitir cualquier origen, método y encabezado.

---

## Funcionamiento de la API

La API expone una ruta principal `/quotes` que permite personalizar las solicitudes mediante parámetros opcionales:

1. **Obtener una frase aleatoria**:
   - Método: `GET /quotes`

2. **Buscar frases por personaje**:
   - Método: `GET /quotes?character=bart`

3. **Obtener un número específico de frases**:
   - Método: `GET /quotes?count=2`

4. **Combinar parámetros**:
   - Método: `GET /quotes?count=15&character=ho`

### Formato de Respuesta

Las respuestas son objetos JSON con la siguiente estructura:

- **Swagger UI**: Se configura para estar disponible en la ruta raíz (`/`), facilitando la exploración y prueba de la API.
- **Redirección**: Se agrega un middleware para redirigir automáticamente a `/swagger/index.html` cuando se accede a la raíz.

---

## Manejo de Errores

- **403 Forbidden**: Se identificó un problema con solicitudes que resultaban en un error 403. Para solucionarlo, se agregó un encabezado `User-Agent` a las solicitudes HTTP.
- **Validación de Parámetros**: El controlador valida los parámetros de entrada, asegurándose de que `count` sea mayor que cero y que `character` no sea una cadena vacía.

### Archivo de Configuración: launchSettings.json

Este archivo define cómo se inicia la aplicación durante el desarrollo.

- **launchUrl**: Se ajusta para que la aplicación inicie en la raíz (`/`), aprovechando la redirección a Swagger.
- **Perfiles**: Define configuraciones para entornos `http`, `https` e `IIS Express`.

---

## Descarga y Compartición del Proyecto

Se proporcionaron instrucciones para comprimir y compartir el proyecto, ya sea mediante el Explorador de Archivos, PowerShell o CMD, asegurándose de incluir todos los archivos necesarios y excluyendo carpetas innecesarias como `bin` y `obj`.

---

## Tecnologías Utilizadas

- **C# 12.0**
- **.NET 8**
- **ASP.NET Core Web API**
- **HttpClient**
- **Swagger para documentación**
- **CORS**: Configurado para permitir cualquier origen, método y encabezado.

---

## Conclusión

Este proyecto implementa una API RESTful que consume la API de The Simpsons Quote, ofreciendo endpoints para obtener frases de los personajes, con la posibilidad de filtrar por personaje y cantidad de frases. La aplicación está estructurada siguiendo buenas prácticas de desarrollo, facilitando su mantenimiento y escalabilidad.

---

## Configuración de Swagger y Redirección

1. **Swagger UI**: Configurado para estar disponible en la ruta raíz (`/`), facilitando la exploración y prueba de la API.
2. **Redirección Automática**: Se agrega un middleware que redirige a `/swagger/index.html` al acceder a la raíz de la aplicación.

---

## Manejo de Errores

1. **Errores HTTP**:
   - **403 Forbidden**: Se solucionó añadiendo un encabezado `User-Agent` a las solicitudes HTTP realizadas por `HttpClient`.

2. **Validación de Parámetros**:
   - El controlador valida que el parámetro `count` sea mayor a cero y que `character` no sea una cadena vacía.

---

### Archivo de Configuración: launchSettings.json

Este archivo define las configuraciones para el entorno de desarrollo:

- **launchUrl**: Ajustado para iniciar en la raíz (`/`), aprovechando la redirección a Swagger.
- **Perfiles**: Configura entornos para HTTP, HTTPS e IIS Express.

---

## Tecnologías Utilizadas

- **C# 12.0**
- **.NET 8**
- **ASP.NET Core Web API**
- **HttpClient**
- **Swagger para documentación**
- **CORS**: Configurado para permitir cualquier origen, método y encabezado.

---

## Conclusión

Este proyecto implementa una API RESTful que consume la API de The Simpsons Quote, proporcionando una experiencia completa para obtener frases de personajes de Los Simpsons. Su diseño sigue buenas prácticas de desarrollo, asegurando mantenibilidad y escalabilidad. La implementación de Swagger, el manejo robusto de errores y la validación de parámetros garantizan una experiencia de uso confiable y profesional.
