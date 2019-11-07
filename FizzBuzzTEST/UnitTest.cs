using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzzTEST
{

    [TestClass]
    public class UnitTest

    {
        [TestMethod]
        public void TestMethod()
        {
            Fizz_Buzz.HelperLibrary.CounterClass CC = new Fizz_Buzz.HelperLibrary.CounterClass();
            CC.CountUp(10000);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Fizz_Buzz.HelperLibrary.CounterClass CC = new Fizz_Buzz.HelperLibrary.CounterClass();
            List<ListClass.DevisableList> ItemList = new List<ListClass.DevisableList>();
            ItemList.Add(new ListClass.DevisableList { value = 3, text = "Fizz" });
            ItemList.Add(new ListClass.DevisableList { value = 5, text = "Buzz" });
            CC.CountUpList(ItemList, 10000);
        }
    }
}
