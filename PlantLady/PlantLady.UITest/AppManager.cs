using System;
using Xamarin.UITest;

namespace PlantLady.UITest
{
    static class AppManager
    {
        static IApp app;
        public static IApp App
        {
            get
            {
                if (app == null)
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                return app;
            }
        }

        static Platform? platform;
        public static Platform Platform
        {
            get
            {
                if (platform == null)
                    throw new NullReferenceException("'AppManager.Platform' not set.");
                return platform.Value;
            }

            set
            {
                platform = value;
            }
        }

        public static void StartApp()
        {
            if (Platform == Platform.Android)
            {
                app = ConfigureApp
                    .Android
                    // Used to run a .apk file:
                    .ApkFile("/Users/swsat/Documents/WorkFolder/PlantLady/Binaries/com.companyname.plantlady-Signed.apk")
                    .StartApp();
            }

            if (Platform == Platform.iOS)
            {
                app = ConfigureApp
                    .iOS
                    // Used to run a .app file on an ios simulator:
                    .AppBundle("/Users/swsat/Documents/WorkFolder/PlantLady/Binaries/PlantLady.iOS.app")
                    //.DeviceIdentifier("08E49670-94FA-4303-8AD1-9C859D3FD6D3")
                    // Used to run a .ipa file on a physical ios device:
                    //.InstalledApp("com.companyname.PlantLady")
                    .StartApp();
            }
        }
    }
}