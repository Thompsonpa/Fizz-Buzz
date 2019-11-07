using System;
using System.Collections.Generic;

namespace Fizz_Buzz
{
    class Program
    {
        private static bool _CorrectValue = false;
        private static int _Attempts = 0;
        private readonly static HelperLibrary.CounterClass CC = new HelperLibrary.CounterClass(); // retrieve counter class
        private readonly static HelperLibrary.MessageClass MC = new HelperLibrary.MessageClass(); // retrieve message class

        static void Main(string[] args)
        {
            // First method count up based on user input (MaxValue) or upperbound
            Console.WriteLine(MC.Welcome()); // welcome user to application
            do
            {
                var UserInput = Console.ReadLine();
                Console.WriteLine();
                if (int.TryParse(UserInput, out int value))
                {
                    _CorrectValue = true;
                    Console.Write(CC.CountUp(value));
                }
                else
                {
                    Console.Write(MC.InvalidInput(_Attempts));
                    _Attempts++;
                }

            } while (_CorrectValue == false);

            Console.WriteLine(MC.PressKey()); // Key press to continue
            Console.ReadLine();

            // Second Method we could also define a list or mutli array of Divisible numbers and provide the word to print out, I will do a list for example
            Console.WriteLine(MC.SecondWelcome()); // Second welcome
            do
            {
                //Get User input for value
                var UserInput = Console.ReadLine();
                Console.WriteLine();

                // Reset counters
                _CorrectValue = false;
                _Attempts = 0;
                List<ListClass.DevisableList> ItemList = new List<ListClass.DevisableList>();
                ItemList.Add(new ListClass.DevisableList { value = 3, text = "Fizz" });
                ItemList.Add(new ListClass.DevisableList { value = 5, text = "Buzz" });

                if (int.TryParse(UserInput, out int value))
                {
                    _CorrectValue = true;
                    Console.Write(CC.CountUpList(ItemList, value));
                }
                else
                {
                    Console.Write(MC.InvalidInput(_Attempts));
                    _Attempts++;
                }

            } while (_CorrectValue == false);

            Console.ReadLine();
        }
    }
}
