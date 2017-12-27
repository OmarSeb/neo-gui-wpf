using System;
using System.Collections.Generic;
using System.Text;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace Neo.Gui.XamarinViews.Controls
{
    public class ImageCircle : CachedImage
    {
        #region bindable properties

        public static readonly BindableProperty BorderThicknessProperty =
            BindableProperty.Create("BorderThickness", typeof(int), typeof(ImageCircle), 0);

        public int BorderThickness
        {
            get { return (int)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
               BindableProperty.Create("BorderColor", typeof(Color), typeof(ImageCircle), Color.White);


        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        #endregion

        public ImageCircle()
        {
            Aspect = Aspect.AspectFill;
            HorizontalOptions = LayoutOptions.Center;
            VerticalOptions = LayoutOptions.Center;
        }
    }
}
