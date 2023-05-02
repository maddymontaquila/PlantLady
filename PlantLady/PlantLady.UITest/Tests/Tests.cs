using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using PlantLady.UITest.Pages;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PlantLady.UITest
{
    public class Tests : BaseTestFixture
    {
        public Tests(Platform platform)
        : base(platform)
        {
        }

        [Test]
        public void Repl()
        {
            app.Repl();
        }

        [Test]
        public void ChangeTabsTest()
        {
            new HomePage()
                .ChangeTabsTest();

        }

        [Test]
        public void SwipePlantTest()
        {
            new HomePage()
                .SwipeToPlant();
        }
    }
}
