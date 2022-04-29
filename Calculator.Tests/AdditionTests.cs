using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class AdditionTests
    {
        [Fact]
       public void Add_GivenTwoIntValues_ReturnInt()
        {
            var calc = new Calculate();
            var results = calc.Add(1, 2);
            Assert.Equal(3, results);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnDouble()
        {
            var calc = new Calculate();
            var results = calc.AddDouble(1.2, 3.5);
            Assert.Equal(4.7, results, 0);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotHaveAZero()
        {
            Calculate cal = new();
            Assert.All(cal.FiboNumbers, n => Assert.NotEqual(0, n));

        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            Calculate cal = new();
            Assert.Contains(13, cal.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboWithNoIncludes4()
        {
            Calculate cal = new();
            Assert.DoesNotContain(4, cal.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            var collection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            Calculate cal = new();

            Assert.Equal(collection, cal.FiboNumbers);
        }
    }
}
