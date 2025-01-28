

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Herencia_clase_III
{
    public class Invertebrado : Animal
    {
        public string? Tipo { get; set; }
        public bool TienePatas { get; set; }
        public int NumeroPatas { get; set; }
        public bool TieneConcha {  get; set; }

        public void Imprimir()
        {

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamano: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");

            Console.WriteLine($"Tiene Patas: {(TienePatas ? "Si" : "No")}");
            Console.WriteLine($"Tiene Concha: {(TieneConcha ? "Si" : "No")}");

            if(TienePatas)
        }

    }
}
