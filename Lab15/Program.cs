using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод арифметической прогрессии: ");
            ISeries arithProgression = new ArithProgression(1, 2);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arithProgression.GetNext());
            }
            arithProgression.Reset();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arithProgression.GetNext());
            }
            Console.WriteLine("Вывод геометрической прогрессии: ");
            ISeries geomProgression = new GeomProgression(2, 3);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(geomProgression.GetNext());
            }
            geomProgression.Reset();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(geomProgression.GetNext());
            }
            Console.ReadKey();
        }
    }
}
