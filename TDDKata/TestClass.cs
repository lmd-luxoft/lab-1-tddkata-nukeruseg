﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SimpleTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong actual value");
        }

        [Test]
        public void MoreThanTwoArgumentsShouldReturnError()
        {
            StringCalc calc = new StringCalc();
            string arguments = "3,3,3";
            int expected = -1;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EmptyStringShouldReturnZero()
        {
            StringCalc calc = new StringCalc();
            string arguments = string.Empty;
            int expected = 0;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SingleArgumentShouldReturnItself()
        {
            StringCalc calc = new StringCalc();
            string arguments = "3";
            int expected = 3;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NullArgumentShouldReturnError()
        {
            StringCalc calc = new StringCalc();
            string arguments = null;
            int expected = -1;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NegativeArgumentShouldReturnError()
        {
            StringCalc calc = new StringCalc();
            string arguments = "2,-1";
            int expected = -1;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TwoPositiveArgumentsShouldReturnSum()
        {
            StringCalc calc = new StringCalc();
            string arguments = "2,2";
            int expected = 4;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IncorrectArgumentShouldReturnError()
        {
            StringCalc calc = new StringCalc();
            string arguments = "two";
            int expected = -1;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneOfArgumentsIsStringShouldReturnError()
        {
            StringCalc calc = new StringCalc();
            string arguments = "2,two";
            int expected = -1;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ZeroShouldReturnZero()
        {
            StringCalc calc = new StringCalc();
            string arguments = "0";
            int expected = 0;
            int actual = calc.Sum(arguments);
            Assert.AreEqual(expected, actual);
        }
    }
}
