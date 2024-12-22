# Descripci�n Detallada del Proyecto API de Frases de Los Simpsons

## Introducci�n

El proyecto API de Frases de Los Simpsons es una API RESTful desarrollada en C# sobre .NET 8, dise�ada para consumir la API externa de The Simpsons Quote. Su objetivo es ofrecer tres rutas principales para obtener frases de personajes de Los Simpsons, ya sea de forma aleatoria, filtradas por personaje o en una cantidad espec�fica. Todas las respuestas se devuelven en formato JSON.

---

## Estructura del Proyecto

La organizaci�n del proyecto sigue buenas pr�cticas para APIs REST en C#, estructur�ndose en capas bien definidas:

### Carpetas Principales:

- **/Controllers**: Contiene los controladores de la API.
- **/Models**: Define los modelos de datos utilizados.
- **/Services**: Implementa la l�gica de negocio y consume la API externa.
- **Program.cs**: Configura los servicios y middleware necesarios para la aplicaci�n.

---

## Componentes Clave

### 1. Modelo: SimpsonsQuote

Definido en `/API/Models/SimpsonsQuote.cs`, este modelo representa la estructura de los datos recibidos de la API externa.

### 2. Servicio: ISimpsonsQuoteService y SimpsonsQuoteService

- **Interfaz ISimpsonsQuoteService**: Definida en `/API/Services/ISimpsonsQuoteService.cs`, declara los m�todos que el servicio debe implementar.
- **Implementaci�n SimpsonsQuoteService**: Implementada en `/API/Services/SimpsonsQuoteService.cs`, utiliza `HttpClient` para consumir la API externa, gestionando las solicitudes HTTP y el manejo de errores.

### 3. Controlador: SimpsonsQuoteController

Definido en `/API/Controllers/SimpsonsQuoteController.cs`, este controlador expone las rutas de la API y utiliza el servicio para procesar y devolver los datos.

### 4. Configuraci�n: Program.cs

Configura los servicios y middleware esenciales, incluyendo la inyecci�n de dependencias y la configuraci�n de CORS para permitir cualquier origen, m�todo y encabezado.

---

## Funcionamiento de la API

La API expone una ruta principal `/quotes` que permite personalizar las solicitudes mediante par�metros opcionales:

1. **Obtener una frase aleatoria**:
   - M�todo: `GET /quotes`

2. **Buscar frases por personaje**:
   - M�todo: `GET /quotes?character=bart`

3. **Obtener un n�mero espec�fico de frases**:
   - M�todo: `GET /quotes?count=2`

4. **Combinar par�metros**:
   - M�todo: `GET /quotes?count=15&character=ho`

### Formato de Respuesta

Las respuestas son objetos JSON con la siguiente estructura:

- **Swagger UI**: Se configura para estar disponible en la ruta ra�z (`/`), facilitando la exploraci�n y prueba de la API.
- **Redirecci�n**: Se agrega un middleware para redirigir autom�ticamente a `/swagger/index.html` cuando se accede a la ra�z.

---

## Manejo de Errores

- **403 Forbidden**: Se identific� un problema con solicitudes que resultaban en un error 403. Para solucionarlo, se agreg� un encabezado `User-Agent` a las solicitudes HTTP.
- **Validaci�n de Par�metros**: El controlador valida los par�metros de entrada, asegur�ndose de que `count` sea mayor que cero y que `character` no sea una cadena vac�a.

### Archivo de Configuraci�n: launchSettings.json

Este archivo define c�mo se inicia la aplicaci�n durante el desarrollo.

- **launchUrl**: Se ajusta para que la aplicaci�n inicie en la ra�z (`/`), aprovechando la redirecci�n a Swagger.
- **Perfiles**: Define configuraciones para entornos `http`, `https` e `IIS Express`.

---

## Descarga y Compartici�n del Proyecto

Se proporcionaron instrucciones para comprimir y compartir el proyecto, ya sea mediante el Explorador de Archivos, PowerShell o CMD, asegur�ndose de incluir todos los archivos necesarios y excluyendo carpetas innecesarias como `bin` y `obj`.

---

## Tecnolog�as Utilizadas

- **C# 12.0**
- **.NET 8**
- **ASP.NET Core Web API**
- **HttpClient**
- **Swagger para documentaci�n**
- **CORS**: Configurado para permitir cualquier origen, m�todo y encabezado.

---

## Conclusi�n

Este proyecto implementa una API RESTful que consume la API de The Simpsons Quote, ofreciendo endpoints para obtener frases de los personajes, con la posibilidad de filtrar por personaje y cantidad de frases. La aplicaci�n est� estructurada siguiendo buenas pr�cticas de desarrollo, facilitando su mantenimiento y escalabilidad.

---

## Configuraci�n de Swagger y Redirecci�n

1. **Swagger UI**: Configurado para estar disponible en la ruta ra�z (`/`), facilitando la exploraci�n y prueba de la API.
2. **Redirecci�n Autom�tica**: Se agrega un middleware que redirige a `/swagger/index.html` al acceder a la ra�z de la aplicaci�n.

---

## Manejo de Errores

1. **Errores HTTP**:
   - **403 Forbidden**: Se solucion� a�adiendo un encabezado `User-Agent` a las solicitudes HTTP realizadas por `HttpClient`.

2. **Validaci�n de Par�metros**:
   - El controlador valida que el par�metro `count` sea mayor a cero y que `character` no sea una cadena vac�a.

---

### Archivo de Configuraci�n: launchSettings.json

Este archivo define las configuraciones para el entorno de desarrollo:

- **launchUrl**: Ajustado para iniciar en la ra�z (`/`), aprovechando la redirecci�n a Swagger.
- **Perfiles**: Configura entornos para HTTP, HTTPS e IIS Express.

---

## Tecnolog�as Utilizadas

- **C# 12.0**
- **.NET 8**
- **ASP.NET Core Web API**
- **HttpClient**
- **Swagger para documentaci�n**
- **CORS**: Configurado para permitir cualquier origen, m�todo y encabezado.

---

## Conclusi�n

Este proyecto implementa una API RESTful que consume la API de The Simpsons Quote, proporcionando una experiencia completa para obtener frases de personajes de Los Simpsons. Su dise�o sigue buenas pr�cticas de desarrollo, asegurando mantenibilidad y escalabilidad. La implementaci�n de Swagger, el manejo robusto de errores y la validaci�n de par�metros garantizan una experiencia de uso confiable y profesional.
