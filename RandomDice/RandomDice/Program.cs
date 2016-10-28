using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string conOn;
                do
                {

                    Console.WriteLine("Would you like to roll two some dice? If so, enter an integer");
                    int diceSides;
                    Boolean continueOn = int.TryParse(Console.ReadLine(), out diceSides);

                    if (diceSides < 0)
                    {
                        throw new Exception("Negative Numbers Not Allowed");

                    }


                    Random rnd = new Random();
                    int dice1 = rnd.Next(1, diceSides);
                    int dice2 = rnd.Next(1, diceSides);
                    int diceTotal = dice1 + dice2;

                    Console.WriteLine("Dice 1: {0}\nDice 2: {1}\nTotal: {2} \nContinue? (Y/N)", dice1, dice2, diceTotal);
                    conOn = Console.ReadLine();
                    conOn.ToLower();
                    Console.Clear();

                } while (conOn == "yes" || conOn == "y");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
