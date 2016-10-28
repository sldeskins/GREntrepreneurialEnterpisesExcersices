using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProject
{
    class Program
    {
        static void Main(string[] args)
        {
            long factInput;      
            Console.WriteLine("Enter An Integer Between 1 & 10");
            bool isInteger = long.TryParse(Console.ReadLine(), out factInput);

            if(isInteger && factInput > 0 && factInput <= 10)
            {

                Factorial(ref factInput);
                Console.WriteLine(factInput);
                Console.Read();

            }


        }

        public static void  Factorial(ref long intFact)
        {
            for(long i = intFact-1; i >= 1; i--)
            {
                intFact *= i;
            }

        }
    }
}
