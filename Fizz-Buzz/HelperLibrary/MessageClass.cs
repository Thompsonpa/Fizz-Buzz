using System;
using System.Collections.Generic;
using System.Text;

namespace Fizz_Buzz.HelperLibrary
{
    public class MessageClass
    {
        public StringBuilder Welcome()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#############################################################");
            sb.AppendLine("#              Hi User, Welcome to FIZZ & BUZZ              #");
            sb.AppendLine("#############################################################");
            sb.AppendLine("Enter a number and this program will count up to this number");
            sb.AppendLine("if the number is Divisible by both 3 and 5 it will print out");
            sb.AppendLine("FIZZ & BUZZ. if it is just Divisible by 3 then it will print");
            sb.AppendLine("FIZZ. If it is just Divisible by 5 then it will print BUZZ");
            sb.AppendLine("if it is not Divisible it will just print out the number! \n");
            sb.AppendLine("Please enter a number now: ");
            return sb;
        }

        public StringBuilder SecondWelcome()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Second Method is about to commence, This is a list Method could ");
            sb.AppendLine("work for a multi array. But lets keep it simple and do a list.");
            sb.AppendLine("We have created a list of Divisible Items 3 and 5 we can add");
            sb.AppendLine("more if needed or wanted too. Pass the list into the CountUpList");
            sb.AppendLine("class along with Max Count Value and the results will be the same \n");
            sb.AppendLine("Please enter a number now: ");
            return sb;
        }

    }
}
