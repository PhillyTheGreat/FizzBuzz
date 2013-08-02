using System;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        private const string TextForThreeDividables = "FIZZ";
        private const string TextForFiveDividables = "BUZZ";


        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                var textToPrint = GetTextToPrintForNumber(i);

                Console.WriteLine(textToPrint);
            }

            Console.ReadLine();

        }

        private static string GetTextToPrintForNumber(int index)
        {
            bool isFizz = index % 3 == 0;

            bool isBuzz = index % 5 == 0;

            string textToPrint = index.ToString(CultureInfo.InvariantCulture);

            if (isBuzz && isFizz)
            {
                textToPrint = TextForThreeDividables + TextForFiveDividables;
            }
            else if (isBuzz)
            {
                textToPrint = TextForFiveDividables;
            }
            else if (isFizz)
            {
                textToPrint = TextForThreeDividables;
            }

            return textToPrint;
        }
    }
}
