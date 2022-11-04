using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();    
            
            long startValue=0;
            bool outCondition;
            do
            {
                Console.WriteLine("введите стартовое число прогресии");
                try
                {
                    startValue = Convert.ToInt64(Console.ReadLine());
                    outCondition = false; 
                }
                catch
                { 
                    outCondition = true; 
                }
            } while (outCondition);

            long stepValue=0;
            do
            {
                Console.WriteLine("введите шаг прогресии");
                try
                {
                    stepValue = Convert.ToInt64(Console.ReadLine());
                    outCondition = false;
                }
                catch
                {
                    outCondition = true;
                }
            } while (outCondition);

            arithProgression.SetStart(startValue);
            geomProgression.SetStart(startValue);
            arithProgression.SetStep(stepValue);
            geomProgression.SetStep(stepValue);

            Console.WriteLine("Для прибавления прогрессии нажмите кнопку +\nдля убавления прогресси нажмите кнопку -\nдля выхода нажмите кнопку Esc\nдля сброса нажмите кнопку Del");
            Console.WriteLine("Арифметическая      Геометрическая");

            do
            {
                outCondition = true;
                var key = Console.ReadKey(true);

                
                if (key.Key == ConsoleKey.Escape)
                {
                    outCondition = false;
                    Console.WriteLine("Стоп");
                }
                else
                if (key.Key == ConsoleKey.Add)
                {
                    Console.WriteLine("{0,14}{1,20}", arithProgression.GetNext(), geomProgression.GetNext());
                }
                else
                if (key.Key == ConsoleKey.Subtract)
                {
                    Console.WriteLine("{0,14}{1,20}", arithProgression.GetPrevious(), geomProgression.GetPrevious());
                } else
                if (key.Key == ConsoleKey.Delete)
                {
                    Console.WriteLine("Сброс к начальным значениям");
                    arithProgression.Reset();
                    geomProgression.Reset();
                }
            }
            while (outCondition);

            Console.ReadKey();
        }
    }
}
