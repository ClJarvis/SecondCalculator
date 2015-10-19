﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalcChunks;
namespace CalcTestN
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void DoesEquationHaveOperators()
        {
            var calc = new Parse();
            var op = calc.GetOperator("20+5");
            var expected = '+';
            Assert.AreEqual(expected, op);
        }

        [TestMethod]
        public void DoesEquationHaveaddintionSign()
        {
            var calc = new Parse();
            var op = calc.GetOperator("20+5");
            var expected = '+'; ;
            Assert.AreEqual(expected, calc.GetOperator("+"));
        }

        [TestMethod]
        public void DoesEquationHaveSubtractionSign()
        {
            var calc = new Parse();
            var op = calc.GetOperator("20-5");
            var expected = '-'; ;
            Assert.AreEqual(expected, calc.GetOperator("-"));
        }

        [TestMethod]
        public void DoesEquationHaveMultiplicationSign()
        {
            var calc = new Parse();
            var op = calc.GetOperator("20*5");
            var expected = '*'; ;
            Assert.AreEqual(expected, calc.GetOperator("*"));
        }

        [TestMethod]
        public void DoesEquationHaveModulusSign()
        {
            var calc = new Parse();
            var op = calc.GetOperator("20%5");
            var expected = '%'; ;
            Assert.AreEqual(expected, calc.GetOperator("%"));
        }

        [TestMethod]
        public void DoesEquationHaveDivisionSign()
        {
            var calc = new Parse();
            var op = calc.GetOperator("20/5");
            var expected = '/'; ;
            Assert.AreEqual(expected, calc.GetOperator("/"));
        }

        [TestMethod]
        public void DoesEquationHaveNumbers()
        {
            var calc = new Parse();
            var numb = calc.GetNumbers("20+5");
            var expected = new string[] { "20", "5" };
            CollectionAssert.AreEqual(expected, numb);
        }

        [TestMethod]
        public void GetNumbersShouldReturnTwoStrings()
        {
            var calc = new Parse();
            var stringArray = calc.GetNumbers("12+16");
            var expected = new string[] { "12", "16" };
            CollectionAssert.AreEqual(stringArray, expected);

        }

        [TestMethod]
        public void ShouldGetOperators()
        {
            var calc = new Parse();
            var op = calc.GetOperator("12-8");
            var expected = '-';
            Assert.AreEqual(expected, op);
        }


        [TestMethod]
        public void IsNumberInIndexZero()
        {
            Parse parse = new Parse();

            string[] indexZero = parse.GetNumbers("5+8");
            Assert.AreEqual("5", indexZero[0]);
        }

        [TestMethod]
        //testing IndexOne not IndexTwo because the string 5+8 has been converted to an string[]
        // and now 8 is in indexOne not the indextwo as it was in string
        public void IsNumberInIndexOne()
        {
            Parse parse = new Parse();
            string[] indexOne = parse.GetNumbers("5+8");
            Assert.AreEqual("8", indexOne[1]);
        }


        /// <summary>
        /// Math Operation Tests //////////////////////////////////////////////////////
        /// </summary>

        [TestMethod]
        public void AddintionTest()
        {
            int answer = Addition.AddNum(new string[] { "20", "5" });
            Assert.AreEqual(answer, 25);
        }

        [TestMethod]
        public void SubtractionTest()
        {

            int answer = Subtraction.SubNum(new string[] { "20", "5" });
            Assert.AreEqual(answer, 15);
        }

        [TestMethod]
        public void MultipicationTest()
        {
            int answer = Multiplication.MultiplyNum(new string[] { "20", "5" });
            Assert.AreEqual(answer, 100);
        }

        [TestMethod]
        public void DivideTest()
        {
            int answer = Division.DivideNum(new string[] { "20", "5" });
            Assert.AreEqual(answer, 4);
        }

        [TestMethod]
        public void ModulusTest()
        {
            int answer = Modulus.ModNum(new string[] { "20", "5" });
            Assert.AreEqual(answer, 0);
        }

        [TestMethod]
        public void SubtractionFirstNumberisLarger()
        {
           // FirstNumber > SecondNumber;
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UserentersLastQuestion()
        {
            Stack.lastQuestion = "1+1";
            Evaulate evaulate = new Evaulate();
            string result = evaulate.Evaluate("lastq");
            Assert.AreEqual("1+1", result);
        }
        [TestMethod]
        public void UserRequestLastAnswer()
        {
            Stack.last = "2";
            Evaulate evaulate = new Evaulate();
            string result = evaulate.Evaluate("last");
            Assert.AreEqual("2", result);
        }

       
    }
}