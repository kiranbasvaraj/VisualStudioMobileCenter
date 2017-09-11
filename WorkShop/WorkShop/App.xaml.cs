using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkShop.ViewModels;
using WorkShop.Views;
using Xamarin.Forms;

namespace WorkShop
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            MobileCenter.Start("ios=3ea28329-bdd3-483a-9c0a-2bfb24cb5932;" +
                      "uwp={Your UWP App secret here};" +
                      "android=3ea28329-bdd3-483a-9c0a-2bfb24cb5932",
                      typeof(Analytics));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
