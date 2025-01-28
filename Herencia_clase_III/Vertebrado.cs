

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Herencia_clase_III
{
    public class Vertebrado : Animal
    {
        public string Tipo { get; set; }
        public bool TienePatas { get; set; }
        public bool EsDomestico {  get; set; }
        public bool EsHerbivoro { get; set; }
        public bool EsCarnivoro {  get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamano: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");

            Console.WriteLine($"Tiene Patas: {(TienePatas ? "Si" : "No")}");
            Console.WriteLine($"Es Domestico: {(EsDomestico ? "Si" : "No")}");
            Console.WriteLine($"Es Herbivoro: {(EsHerbivoro ? "Si" : "No")}");
            Console.WriteLine($"Es Carnivoro: {(EsCarnivoro ? "Si" : "No")}");

        }
    }
}
