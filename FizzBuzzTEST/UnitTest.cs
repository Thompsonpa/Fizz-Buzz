using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Shouldly;

namespace FizzBuzzTEST
{

    [TestClass]
    public class UnitTest

    {
        [TestMethod]
        public void TestMethod()
        {
            Fizz_Buzz.HelperLibrary.CounterClass CC = new Fizz_Buzz.HelperLibrary.CounterClass();
            CC.CountUp(100).ShouldStartWith("1"); // should start with 1 we are counting 1 to 100
            CC.GetCountUpValue(100).ShouldBe("Buzz"); // divisible by 3
            CC.GetCountUpValue(98).ShouldBe("98"); // Not divisible by 3 or 5
        }

        [TestMethod]
        public void TestMethod2()
        {
            Fizz_Buzz.HelperLibrary.CounterClass CC = new Fizz_Buzz.HelperLibrary.CounterClass();
            List<ListClass.DevisableList> ItemList = new List<ListClass.DevisableList>();
            ItemList.Add(new ListClass.DevisableList { value = 3, text = "Fizz" });
            ItemList.Add(new ListClass.DevisableList { value = 5, text = "Buzz" });
            CC.CountUpList(ItemList, 100).ShouldStartWith("1"); // should start with 1 we are counting 1 to 100

        }
    }
}
