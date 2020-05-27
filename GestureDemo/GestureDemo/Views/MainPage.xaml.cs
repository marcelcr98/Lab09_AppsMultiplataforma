using GestureDemo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.TapDemo:
                        MenuPages.Add(id, new NavigationPage(new TapDemo()));
                        break;
                    case (int)MenuItemType.SwipeDemo:
                        MenuPages.Add(id, new NavigationPage(new SwipeDemo()));
                        break;
                    case (int)MenuItemType.PanDemo:
                        MenuPages.Add(id, new NavigationPage(new PanDemo()));
                        break;
                    case (int)MenuItemType.PinchDemo:
                        MenuPages.Add(id, new NavigationPage(new PinchDemo()));
                        break;
                    case (int)MenuItemType.SwipeBindingDemo:
                        MenuPages.Add(id, new NavigationPage(new SwipeBindingDemo()));
                        break;


                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}