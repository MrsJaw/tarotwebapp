using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarotWebApp.Models;

namespace TarotWebApp.UnitTests
{
    public class Fakers
    {
        private static readonly int _seed = 695496;

        public class BaseDrawFaker : Faker<DrawViewModel>
        {
            public BaseDrawFaker()
            {
                StrictMode(true);
                UseSeed(_seed);
                RuleFor(d => d.Card, p => CardFaker.Generate());
                RuleFor(d => d.Index, p => p.IndexFaker++);
                RuleFor(d => d.Role, p => p.Lorem.Sentence());
                Ignore(d => d.IsReversed);
            }
        }

        public static Faker<DrawViewModel> DrawFaker = new BaseDrawFaker()
            .RuleFor(d => d.IsReversed, p => false)
            ;

        public static Faker<DrawViewModel> ReverseDrawFaker = new BaseDrawFaker()
            .RuleFor(d => d.IsReversed, p => true)
            ;

        public static Faker<CardViewModel> CardFaker = new Faker<CardViewModel>()
            .StrictMode(true)
            .UseSeed(_seed)
            .RuleFor(c => c.ImgSrc, p => p.Image.LoremFlickrUrl())
            .RuleFor(c => c.Meanings, p => p.Lorem.Sentence())
            .RuleFor(c => c.Name, p => p.Name.JobTitle())
            .RuleFor(c => c.ReverseMeanings, p => p.Lorem.Sentence())
            ;
    }
}
