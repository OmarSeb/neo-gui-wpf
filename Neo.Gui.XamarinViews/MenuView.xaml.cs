using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Neo.Gui.XamarinViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
		public MenuView ()
		{
			InitializeComponent ();
		    NeoLogo.Source = ImageSource.FromFile("neologo.png");

        }
	}
}