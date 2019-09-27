using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04._Metodo_Out
{
    class Datos
    {
        //Hacemos un metodo donde convertimos los centavos a pesos
        //en el metodo le pasamos los parametros de progam con out
       public void Convertir(double Totalcentavos, out double Pesos, out double Centavos)
        {
            Pesos = Totalcentavos / 100;

            Centavos = Totalcentavos;
        }
        
    }

}
