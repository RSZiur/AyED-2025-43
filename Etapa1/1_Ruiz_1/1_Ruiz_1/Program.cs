using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ContraseñaGuardada = "Password";
            Console.WriteLine("Ingrese la contraseña");
            string ContraseñaIngresada = Console.ReadLine();
            if (ContraseñaGuardada == ContraseñaIngresada)
            {
                Console.WriteLine("La contraseña es correcta");
            }
            else
            {
                Console.WriteLine("La contraseña es incorrecta");
            }
            Console.ReadKey();
        }
    }
}
