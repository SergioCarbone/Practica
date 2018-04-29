using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio.Carbone._2C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Grupo c = new Grupo("Rio", Grupo.TipoManada.Unica);
            Perro p1 = new Perro("Moro", "Pitbull");
            Perro p2 = new Perro("Julio", "Cruza", 13,false);
            Perro p3 = new Perro("Ramon", "Salchica", 2, true);
            Gato g1 = new Gato("Jose", "Angora");
            Gato g2 = new Gato("Hernan","Cruza");
            Gato g3 = new Gato("Fer", "Siames");

            
            Console.WriteLine(c.ToString());
           // c.Llamadas.Add(g1);
          //  Console.WriteLine(c.ToString());
           
            Console.ReadKey();
        }
    }
}
