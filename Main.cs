using System;
namespace Tarea1{
    public class Informacion{

		public string nombre;
		public string domicilio;
		public string facebook;
		public string telefono;
	
    public static void Main(){
	Informacion informacion = new Informacion();

	    Console.WriteLine("Dame tu Nombre: ");
	    informacion.nombre = Console.ReadLine();
		
	    Console.WriteLine("Dame tu Domicilio: ");
	    informacion.domicilio = Console.ReadLine();

	    Console.WriteLine("Dame tu Facebook: ");
	    informacion.facebook = Console.ReadLine();

	    Console.WriteLine("Dame tu Telefono: ");
	    informacion.telefono = Console.ReadLine();

		Console.WriteLine("\nTUS DATOS SON LOS SIGUIENTES: ");
	    Console.WriteLine("Tu nombre es: "+ informacion.nombre);
	    Console.WriteLine("Vives en: "+ informacion.domicilio);
	    Console.WriteLine("Tu Facebook es: "+ informacion.facebook);
	    Console.WriteLine("Tu Telefono es: "+ informacion.telefono);
        }
	}
}








