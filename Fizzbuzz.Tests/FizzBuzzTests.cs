using System;
using NUnit.Framework;
using FizzBuzz.Core;

namespace Fizzbuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void WhenGiven1Return1()
        {
            IFizzBuzz fizzBuzz = new FizzBuzzImpl();
            var result = fizzBuzz.Generate(1);
            Assert.That(result, Is.EqualTo("1,"));
        }

        [Test]
        public void WhenGiven2Return12()
        {
            IFizzBuzz fizzBuzz = new FizzBuzzImpl();
            var result = fizzBuzz.Generate(2);
            Assert.That(result, Is.EqualTo("1,2,"));
        }
    
        [Test]
        public void WhenGiven3Return12Fizz()
        {
            IFizzBuzz fizzBuzz = new FizzBuzzImpl();
            var result = fizzBuzz.Generate(3);
            Assert.That(result, Is.EqualTo("1,2,Fizz,"));
        }

        [Test]
        public void WhenGiven5Return12Fizz4Buzz()
        {
            IFizzBuzz fizzBuzz = new FizzBuzzImpl();
            var result = fizzBuzz.Generate(5);
            Assert.That(result, Is.EqualTo("1,2,Fizz,4,Buzz,"));
        }

        [Test]
        public void WhenGiven15ReturnFizzBuzz()
        {
            IFizzBuzz fizzBuzz = new FizzBuzzImpl();
            var result = fizzBuzz.Generate(15);
            Assert.That(result, Is.EqualTo("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,"));
        }
    }
}
