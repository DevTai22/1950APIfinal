# 1950API
 prueba backend de 1950 labs

 Backend

 

Crea una API que permita realizar operaciones (Crear y Leer) sobre una entidad "Task". Cada tarea debe tener un identificador único, una descripción y un indicador de si ha sido completada o no.

La API debe exponer los siguientes endpoints:

GET /api/tasks: devuelve una lista de todas las tareas.
GET /api/tasks/{id}: devuelve la tarea con el identificador especificado en la URL.
POST /api/tasks: crea una nueva tarea con la información proporcionada en el cuerpo de la solicitud.

Por favor incluir validaciones básicas en la creación de tareas, como la validación de campos requeridos y la comprobación de que la descripción no está vacía y tenga un largo máximo de 100 carcteres.

 

Tecnologías requeridas

 

.NET Framework o .NET Core.

Simular la capa de datos con una lista almacenada en memoria, para que no lleve mucho tiempo.

logros:

1- se logran hacer todos los prompts del GET y GET id

2.- no se logra usar la clase "Task" debido a que es una clase reservada en .net, en su lugar se usa la clase "TAREA".

