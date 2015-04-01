/* * * * * * * * * * *
 * PRACTICA O2-1 RELOJ
 * DANIEL CEDILLO GUEVARA
 * ING. EN CIENCIAS COMPUTACIONALES
 * CUTONALA
 * PROGRAMACION III
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace reloj_cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (; ; ) //esto genera un ciclo infinito
            {
                DateTime fecha = DateTime.Now;
                Console.Clear();
                Console.WriteLine(fecha.TimeOfDay); //imprime la fecha y hora actual del sistema
                Thread.Sleep(1000); //pausa de 1 segundo
            }

        }
    }
}
