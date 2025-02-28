1. Descripción
	Este es un sistema desarrollado en ASP.NET Framework MCV, contiene Inicio de sesión, crud de productos y sus validaciones.

2. Funcionalidades

	Login: Acceso al sistema con autenticación, validación de campos y validación de base de datos.
	Inicio de sesión: debe ser obligatorio, no deja entrar a otros links sin antes estar logueado.
	Gestor de productos: Permite agregar, editar y eliminar productos, con sus validaciones de los campos vacíos y tipo de datos.

3. Requisitos
	Windows 10/11
	Microsoft Visual Studio
	.NET Framework (versión 4.7.2)
	SQL Server (para la base de datos)
	Bootstrap (para la interfaz de usuario)

4. Instalación
	4.1. Clonar el repositorio o descargar el código fuente
   		gh repo clone pedromendoza-system/ElectroTech	

	4.2. Abrir el proyecto en Visual Studio.
   		Ejecutando o abriendo el archivo   "ElectroTech.sln"

	4.3. Ejecutar los scripts incluidos en el archivo "Database.txt" en el entorno "Microsoft sql server management studio" para crear la BD.

	4.4. Configurar la cadena de conexion de BASE DE DATOS en la Ruta "conexion\DataBaseConnection"
		Carpeta Conexion y en la clase DataBaseConnectio "Linea 11"
		Cambiar el valor de la variable "ruta" segun la cadena de su conexion
		Ejemplo: (ruta = "Server=localhost\\SQLEXPRESS02;Database=ElectroTech;Trusted_Connection=True;";)
		
	5.5. Compilar y ejecutar el proyecto en Visual Studio.

4. Uso
	4.1. Inicio de sesión
		Para acceder al sistema, puedes usar los siguientes usuarios de prueba:
			Usuario: juanperez
			Contraseña: inter
			Usuario: mariagomez   carlosruiz
			Contraseña: inter
			Usuario: carlosruiz
			Contraseña: inter
			


	
