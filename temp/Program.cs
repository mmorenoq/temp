using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            Console.Write("Introduzca el numero del mes ");
            int numeroMes = 0;
            bool esEntero = Int32.TryParse(Console.ReadLine(), out numeroMes);
           
            if (!esEntero || numeroMes < 1 || numeroMes > 12)
            {
                for (int i = 0; i < 13; i++)
                {
                    Console.WriteLine(mes[i]);
                }
            }

            else 
            {
                Console.WriteLine("Seleccionaste el mes de: " + mes[numeroMes - 1]);
            }
        }
    }
}
