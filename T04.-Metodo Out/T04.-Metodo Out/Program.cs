using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04._Metodo_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos las variables que vamos a utilizar
            double TotalCentavo;
            double Pesos = 0;
            double Centavos = 0;
           
            //le damos la bienvenida al usuario y le pedimos que introduzca el valor en centavos
            Console.WriteLine("Hola bienvenido");
            Console.WriteLine("    ");
            Console.WriteLine("Introduzca la cantidad en Centavos:");
            TotalCentavo = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("   ");
            //instanciamos la clase datos para mandar a llamar al metodo convertir 
            Datos da = new Datos();
            //Mandamos los parametros para el metodo Convertir
            da.Convertir(TotalCentavo, out Pesos, out Centavos);

            //le mostramos al usuario el resultado en centavos y en pesos
            Console.WriteLine("Total en centavos:");
            Console.WriteLine(Centavos);
            Console.WriteLine("   ");
            Console.ReadLine();
            Console.WriteLine("Total en pesos:");
            Console.WriteLine(Pesos);
            Console.ReadKey();
        }


    }
}
