using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese coordenadas");

            Persona persona = new Persona();

            persona.Nombres = "Hugo";
            persona.Apellidos = "Torrico";
            

            

            string nombresCompletos;
            nombresCompletos = persona.DevolverNombresCompletos();


            Console.WriteLine(nombresCompletos);

            Console.ReadLine();
            Console.Read();
           

        }
    }
}
