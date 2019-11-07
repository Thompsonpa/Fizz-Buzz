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
            Console.Clear();
            Console.WriteLine(MC.Welcome()); // welcome user to application

            do
            {
                var UserInput = Console.ReadLine();
                if (int.TryParse(UserInput, out int value))
                {
                    _CorrectValue = true;
                    // can also add minumum value if needed default will always be 1
                    // Example CC.CountUp(MaxValue,MinValue)
                    CC.CountUp(value);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, Integer number needed. this is your " + _Attempts + " try, good luck...\n");
                    _Attempts++;
                }

            } while (_CorrectValue == false);

            Console.WriteLine("Press any key to start a list/Multi Array Method");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine(MC.SecondWelcome()); // Second welcome

            // Second Method we could also define a list or mutli array of Divisible numbers and provide the word to print out, I will do a list for example
            List<ListClass.DevisableList> ItemList = new List<ListClass.DevisableList>();
            ItemList.Add(new ListClass.DevisableList { value = 3, text="Fizz" });
            ItemList.Add(new ListClass.DevisableList { value = 5, text = "Buzz" });

            // reset counters
            _CorrectValue = false;
            _Attempts = 0;

            do
            {
                var UserInput = Console.ReadLine();
                if (int.TryParse(UserInput, out int value))
                {
                    _CorrectValue = true;
                    // can also add minumum value if needed default will always be 1
                    // Example CC.CountUpList(ItemList,MaxValue,MinValue)
                    CC.CountUpList(ItemList, value);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, Integer number needed. this is your " + _Attempts + " try, good luck...\n");
                    _Attempts++;
                }

            } while (_CorrectValue == false);
        }
    }
}
