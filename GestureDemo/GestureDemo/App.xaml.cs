using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GestureDemo.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GestureDemo
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
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
