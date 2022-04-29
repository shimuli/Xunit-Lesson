using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class NameTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            Names names = new();
            var results = names.MakeFullName("Cedric", "Shimuli");

            Assert.Equal("Cedric ShimulI", results, ignoreCase: true);

            //Assert.Contains("Ced", results, StringComparison.InvariantCultureIgnoreCase);
            //// Assert.StartWith, Assert.EndsWith

            ////Assert.Matches("[]")
            //Assert.NotNull(results);
            //Assert.False(string.IsNullOrEmpty(results));
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            Names name = new();
           // name.NickName = "Developer";
            Assert.Null(name.NickName);
        }
    }
}
