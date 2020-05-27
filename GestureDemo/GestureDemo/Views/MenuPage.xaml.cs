using GestureDemo.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.TapDemo, Title="Tap" },
                new HomeMenuItem {Id = MenuItemType.PinchDemo, Title="Pinch" },
                new HomeMenuItem {Id = MenuItemType.PanDemo, Title="Pan" },
                new HomeMenuItem {Id = MenuItemType.SwipeDemo, Title="Swipe" },
                new HomeMenuItem {Id = MenuItemType.SwipeBindingDemo, Title="Swipe Binding" },

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}