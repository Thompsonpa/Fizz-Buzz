using System;
using System.Collections.Generic;

namespace Fizz_Buzz.HelperLibrary
{
    public class CounterClass
    {
        public string CountUp(int maxValue, int minValue = 1)
        {
            //Users value is an integer... Continue
            for (int i = minValue; i < maxValue + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz&Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            return "";
        }

        public string CountUpList(List<ListClass.DevisableList> ItemList, int maxValue, int minValue = 1)
        {
            //Users value is an integer... Continue
            for (int i = minValue; i < maxValue + 1; i++)
            {
                string aLine = "";
                //Now we can loop through Devisable list that a user can create
                foreach (var item in ItemList)
                {
                    if (i % item.value == 0)
                    {
                        if (aLine.Length > 0)
                        {
                            aLine += "&"+item.text;
                        }
                        else
                        {
                            aLine += item.text;
                        }
                        
                    }
                }
                if(aLine != "")
                {
                    Console.WriteLine(aLine);
                }
                else
                {
                    Console.WriteLine(i);
                }
                              
            }
            return "";
        }

    }
}
