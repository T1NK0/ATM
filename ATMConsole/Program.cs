using ATMBank.Entities;
using ATMBank.Logic;
using System;

namespace ATMConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM _logic = new ATM();

            int userinput = 0;

            while (userinput == 0)
            {
                Console.WriteLine("Indsæt kort: 1");

                userinput = (int)Console.ReadKey().KeyChar;


                if (userinput == 49)
                {
                    Card card = new Card(0666);

                    Console.WriteLine("\nIndtast dit korts pinkode: ");

                    int userPinInput = Convert.ToInt32(Console.ReadLine());

                    if (_logic.CheckPin(card, userPinInput))
                    {
                        Console.WriteLine("Korrekt pin, velkommen!");
                    }
                    else
                    {
                        Console.WriteLine("Forkert pin!");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
