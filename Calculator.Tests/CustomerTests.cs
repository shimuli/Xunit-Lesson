using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            Customer customer = new();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckValidAge()
        {
            Customer customer = new();
            Assert.InRange(customer.Age, 20, 30);
        }

        [Fact]
        public void GetOrdersByName()
        {
            Customer customer = new();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOdersByName(null));
            Assert.Equal("Add a Name", exceptionDetails.Message);
          
        }
    }
}
