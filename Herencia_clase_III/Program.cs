// See https://aka.ms/new-console-template for more information
using Herencia_clase_III;

Vertebrado vertebrado = new Vertebrado();
Invertebrado invertebrado = new Invertebrado();

Console.WriteLine("Hello, World!");

int opcion;

Console.WriteLine("**************************");
Console.WriteLine("*          MENU          *");
Console.WriteLine("* 1. Animal Vertebrado   *");
Console.WriteLine("* 1. Animal Invertebrado *");
Console.WriteLine("**************************");
Console.WriteLine("Escoja la opcion:");
opcion = Convert.ToInt32(Console.ReadLine());
//ToInt32 convierte un valor string a un valor numerico y evita un error
Console.WriteLine();

switch(opcion)
{
    case 1:
        Console.WriteLine(" Escriba el Nombre: ");
        Vertebrado.Nombre =Console.ReadLine();



        break;


}
