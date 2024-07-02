using System;

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1) Ver todos los autores");
            Console.WriteLine("2) Crear autor");
            Console.WriteLine("3) Actualizar autor");
            Console.WriteLine("4) Eliminar autor");
            Console.WriteLine("5) Ver todos los libros");
            Console.WriteLine("6) Crear libro");
            Console.WriteLine("7) Actualizar libro");
            Console.WriteLine("8) Eliminar libro");
            Console.WriteLine("9) Salir del programa");

            string opcion = Console.ReadLine().Trim();

            switch (opcion)
            {
                case "1":
                    Metos_Opciones.VerTodosLosAutores();
                    break;
                case "2":
                    Metos_Opciones.CrearAutor();
                    break;
                case "3":
                    Metos_Opciones.ActualizarAutor();
                    break;
                case "4":
                    Metos_Opciones.EliminarAutor();
                    break;
                case "5":
                    Metos_Opciones.VerTodosLosLibros();
                    break;
                case "6":
                    Metos_Opciones.CrearLibro();
                    break;
                case "7":
                    Metos_Opciones.ActualizarLibro();
                    break;
                case "8":
                    Metos_Opciones.EliminarLibro();
                    break;
                case "9":
                    Metos_Opciones.SalirDelPrograma();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                    break;
            }
        }
    }
}
