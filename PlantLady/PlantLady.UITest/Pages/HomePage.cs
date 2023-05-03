using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace PlantLady.UITest.Pages
{
    public class HomePage : BasePage
    {
        readonly Query cardItem;
        readonly Query MyPlantsTab;
        readonly Query CareTab;
        readonly Query MyPlantsPage;
        readonly Query plantName;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("Plant Care"),
            iOS = x => x.Marked("Plant Care")
        };

        public HomePage()
        {
            cardItem = x => x.Marked("Water");
            MyPlantsTab = x => x.Marked("My Plants");
            CareTab = x => x.Marked("Care");
            MyPlantsPage = x => x.Marked("Todo: Add swipe views!");
            plantName = x => x.Marked("dracaena");
        }

        public void ChangeTabsTest()
        {
            app.WaitForElement(MyPlantsTab);
            app.Tap(MyPlantsTab);
            app.WaitForElement(MyPlantsPage);
            app.Screenshot("On My Plants Tab");

            app.Tap(CareTab);
            app.WaitForElement(Trait.Current);
            app.Screenshot("On Care Tab");
        }

        public void SwipeToPlant()
        {
            app.SwipeRightToLeft(cardItem);
            //app.SwipeRightToLeft(cardItem);
            app.WaitForElement(plantName, timeout: TimeSpan.FromSeconds(5));
            app.Screenshot("On new Plant");
        }
        
    }
}
