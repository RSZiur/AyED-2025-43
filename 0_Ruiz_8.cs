using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumen, superficie;
            Console.WriteLine("Ingrese el radio de la esfera: ");
            int radio = Convert.ToInt32(Console.ReadLine());
            volumen = (4 / 3) * (int) Math.PI * (int)Math.Pow(radio,3) ;
            superficie = 4 * (int)Math.PI * (int)Math.Pow(radio, 2);
            Console.WriteLine("El volemen de la esfera es : " + volumen +" La superficie es  "+ superficie);
            Console.ReadKey();

        }
    }
}
