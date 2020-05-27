using GestureDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwipeBindingDemo : ContentPage
	{
		public SwipeBindingDemo ()
		{
			InitializeComponent ();
            BindingContext = new SwipeCommandPageViewModel();
        }
	}
}