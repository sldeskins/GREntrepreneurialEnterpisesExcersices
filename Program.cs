using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Learn Your Squares and Cubes" + Environment.NewLine);
                bool continueOn = true;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter an Integer");
                    int loopThrough = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("#          SQ         CU" + Environment.NewLine + "===        ===        ===");

                    int number1 = 1;
                    int number2 = 1;
                    int number3 = 1;

                    for (int i = 1; i <= loopThrough; i++)
                    {
                        PrintSquares(ref number1, ref number2, ref number3);
                    }

                    Console.WriteLine(Environment.NewLine + "Continue On? (Y/N)");
                    string conOn = Console.ReadLine();
                    conOn = conOn.ToLower();
                    continueOn = conOn == "y";

                } while (continueOn == true);

            }

            catch (System.FormatException sysEx)

            {
                Console.WriteLine(sysEx.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }


        }




        public static void PrintSquares(ref int num1, ref int num2, ref int num3)
        {

            Console.WriteLine("{0}          {1}          {2}", num1, num2, num3);
            num1++;
            num2 = num1 * num1;
            num3 = num2 * num1;

        }
    }
}
