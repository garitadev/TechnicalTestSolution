# Solución a la prueba técnica

Dentro del solution se encuentran 3 proyectos

1.Service: Dentro de esta librería se encuentran las tanto clases con sus respectivos atributos como el consumo de los servicios propuestos utilizando RestSharp y Newtonsoft para la deserialización de la respuesta. Cada método consulta un servicio distinto y retorna la data en forma de lista.


![image](https://user-images.githubusercontent.com/87222311/219713958-f768eadf-3e3d-4caf-932c-1850582c943a.png)

2.Web Project
Dentro de este projecto, desarrallado con .NET 6.0  se encuentra la referencia del proyecto anterior (Service) además de los controladores (uno para cada servicio), en donde se realiza la instancia al modelo respectivo para obtener la data y pasarla a la vista. Dentro de los modelos se realiza el consumo del servicio, en el caso del modelo de comentarios se incluye un método adicional que modifica cada body de los comentarios (bonus). Toda la información se muestra en distintas tablas, para el caso del post se incluye un filtro para realizar búsquedas por texto (bonus).
![image](https://user-images.githubusercontent.com/87222311/219714098-c29131fb-c3f2-4c21-9fb6-8b12c2b2ccbf.png)

![image](https://user-images.githubusercontent.com/87222311/219714113-50b1c05c-06e6-45da-a16a-1d456ef88fb9.png)


Adicional al consumo de servicios dentro de la interfaz se muestra un apartado adicional donde se muestra tanto el User Agent como la ip actual del navegador (bonus).
![image](https://user-images.githubusercontent.com/87222311/219714168-0d1e8e62-19dc-41ba-b5cc-c203f52fd84c.png)



3. Blazor Project
Dentro de este proyecto se añade la referencia del proyecto Service y se desarrolla una interfaz que contiene un campo para cada servicio y una clase en la cual se implementa y realiza el consumo del API mediante HttpClient. En este caso el servicio se usó únicamente para obtener las clases de los objetos que retorna el API.
Se desarrolla un componente para cada servicio en el cual se obtiene y se muestra la data

![image](https://user-images.githubusercontent.com/87222311/219714207-2452c9e4-f31c-47d9-997c-32cb1aea3bb0.png)
![image](https://user-images.githubusercontent.com/87222311/219714224-983fbc88-446d-4e58-bf60-0b799c0e6878.png)
