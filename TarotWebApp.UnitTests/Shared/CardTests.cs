using Bunit;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarotWebApp.Models;
using TarotWebApp.Shared;

namespace TarotWebApp.UnitTests.Shared
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void NormalCardDisplaysCorrectly()
        {
            DrawViewModel normalCardDraw = Fakers.DrawFaker.Generate();
            using var ctx = new Bunit.TestContext();
            var component = ctx.RenderComponent<Card>(parameters => parameters.Add(p => p.Model, normalCardDraw));

            var role = component.Find("#role");
            role.InnerHtml.Should().Be(normalCardDraw.Role);

            var name = component.Find("#card-name");
            name.InnerHtml.Should().Be(normalCardDraw.Card.Name);
            name.ClassList.Should().NotContain("reversed-title");

            var img = component.Find("#card-img");
            img.Attributes["src"].Value.Should().Be(normalCardDraw.Card.ImgSrc);
            img.ClassList.Should().NotContain("reversed-card");

            var meanings = component.Find("#meanings");
            meanings.InnerHtml.Should().Be(normalCardDraw.Card.Meanings);
        }

        [TestMethod]
        public void ReversedCardDisplaysCorrectly()
        {
            DrawViewModel reversedCardDraw = Fakers.ReverseDrawFaker.Generate();
            using var ctx = new Bunit.TestContext();
            var component = ctx.RenderComponent<Card>(parameters => parameters.Add(p => p.Model, reversedCardDraw));

            var role = component.Find("#role");
            role.InnerHtml.Should().Be(reversedCardDraw.Role);

            var name = component.Find("#card-name");
            name.InnerHtml.Should().Be($"{reversedCardDraw.Card.Name} Reversed");
            name.ClassList.Should().Contain("reversed-title");

            var img = component.Find("#card-img");
            img.Attributes["src"].Value.Should().Be(reversedCardDraw.Card.ImgSrc);
            img.ClassList.Should().Contain("reversed-card");

            var meanings = component.Find("#meanings");
            meanings.InnerHtml.Should().Be(reversedCardDraw.Card.ReverseMeanings);
        }

    }
}
