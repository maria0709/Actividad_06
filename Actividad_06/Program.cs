using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_06
{
    class Program
    {
        //Lea las teclas presionadas y finalice al presionar Shift+Ctrl+F.
        static void Main(string[] args)

        { 
        ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey();
                Console.WriteLine();
                if ((tecla.Key == ConsoleKey.F) &&
                   ((tecla.Modifiers & ConsoleModifiers.Shift) != 0) &&
                   ((tecla.Modifiers & ConsoleModifiers.Control) != 0))

                 {
                    break;
                 }

            }
            while (true);
        }
    }
}

