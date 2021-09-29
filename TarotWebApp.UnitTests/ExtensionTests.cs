using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TarotWebApp.UnitTests
{
    [TestClass]
    public class ExtensionTests
    {
        [DataTestMethod]
        [DataRow("test", "test")]
        [DataRow("testTest", "test Test")]
        [DataRow("TestTestTest", "Test Test Test")]
        [DataRow(null, null)]
        [DataRow("", "")]
        public void ToTitleTest(string input, string expectedOutput)
        {
            input.ToTitle().Should().Be(expectedOutput);
        }

        //reading loads correctly
    }
}
