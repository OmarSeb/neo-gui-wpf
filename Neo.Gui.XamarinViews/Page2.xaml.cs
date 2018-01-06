using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Neo.Gui.XamarinViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            //if (!AnimationView.IsPlaying)
            //    AnimationView.Play();
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void Handle_OnFinish(object sender, System.EventArgs e)
        {
            //  DisplayAlert($"{nameof(animationView.OnFinish)} invoked!");
        }

        private void DisplayAlert(string message)
        {
            //DisplayAlert(string.Empty, message, "OK");
        }
    }
}
