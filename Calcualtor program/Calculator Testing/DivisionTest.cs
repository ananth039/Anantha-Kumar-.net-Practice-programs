using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Testing
{
    [TestClass]
    public class DivisionTest
    {
        Calcualtor_program.Calculator cal = new Calcualtor_program.Calculator();
        [TestMethod]
        public void Divide_Positive()
        {
           
            Assert.AreEqual(0.34, cal.Division(17, 50)," invalid division method");
        }
         [TestMethod]
       [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_Negative()
        {
            cal.Division(5, 0);
        }
         [TestMethod]
        public void addition_postive()
         {
             Assert.AreEqual(88, cal.Addition(58, 30));
         }
        [TestMethod]
        public void addition_negative()
         {
           cal.Addition(-58, 30);
         }
        [TestMethod]
        public void multiplication_negative()
        {
            Assert.AreEqual(0.355, cal.Addition(0.1775,0.1755));
        }
        

    }
}
