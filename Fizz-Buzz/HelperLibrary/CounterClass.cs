using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;

namespace Fizz_Buzz.HelperLibrary
{
    public class CounterClass
    {
        public string CountUp(int currentValue)
        {
            string Line = "";
            for (int i = 1; i < currentValue + 1; i++)
            {
                Line += GetCountUpValue(i) + "\n";
            }
            return Line;
        }

        public string CountUpList(List<ListClass.DevisableList> ItemList, int currentValue)
        {
            //Now we can loop through Devisable list that a user can create
            string Line = "";
            for (int i = 1; i < currentValue + 1; i++)
            {
                Line += GetCountUpValue(i, ItemList) + "\n";
            }
            return Line;
        }

        public string GetCountUpValue(int currentValue, List<ListClass.DevisableList> ItemList = null)
        {
            string line = "";
            if (ItemList == null)
            {
                if (currentValue % 3 == 0)
                {
                    line += "Fizz";
                }
                else if (currentValue % 5 == 0)
                {
                    line += "Buzz";

                }
                else
                {
                    line = currentValue.ToString();
                }
                line += "\n"; // add end of line for console app
            }
            else
            {
                bool Devisable = false;
                foreach (var item in ItemList) // loop through list values and determine if value is Devisable by item list values
                {
                    if (currentValue % item.value == 0)
                    {
                        Devisable = true; // set counter 
                        line += item.text;
                    }
                }
                if (Devisable == false) // Check counter
                {
                    line = currentValue.ToString(); // Set default number value
                }
                line += "\n"; // add end of line for console app
            }
            return line;
        }
    }
}
