using System;
using AutoFixture;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using CheckPrime;

namespace TestPrime
{
    public class TestPrime
    {
        [Test]
        public void NegativeValueException()
        {
            Assert.Throws<ArgumentException>(() => CheckPrimes.IsPrime(-5));
        }

        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        public void ValueIsPrime(int value, bool expectedValue)
        {
            // act
            var actualValue = CheckPrimes.IsPrime(value);

            // assert
            actualValue.Should().Be(expectedValue);
        }
    }
}
