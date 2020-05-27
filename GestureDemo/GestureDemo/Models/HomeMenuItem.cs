using System;
using System.Collections.Generic;
using System.Text;

namespace GestureDemo.Models
{
    public enum MenuItemType

    {
        Browse,
        TapDemo,
        PinchDemo,
        PanDemo,
        SwipeDemo,
        SwipeBindingDemo,

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
