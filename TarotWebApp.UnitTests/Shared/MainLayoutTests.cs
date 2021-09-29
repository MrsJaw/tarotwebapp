using Bunit;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarotWebApp.Shared;

namespace TarotWebApp.UnitTests.Shared
{
    [TestClass]
    public class MainLayoutTests
    {
        [TestMethod]
        public void MainLayoutDarkModeTest()
        {
            using var ctx = new Bunit.TestContext();
            var component = ctx.RenderComponent<MainLayout>();

            var style = component.Find("style");
            style.FirstChild.MarkupMatches("body { background-color: #343a40; }");

            var main = component.Find(".content");
            main.ClassList.Should().Contain("bg-dark").And.Contain("text-white");
        }
    }
}
