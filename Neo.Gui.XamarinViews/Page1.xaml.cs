﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Neo.Gui.XamarinViews
{
    public partial class MenuPage : ContentPage
    {
        HomeView root;
//        List<HomeMenuItem> menuItems;
        public MenuPage(HomeView root)
        {

            this.root = root;
            Title = "Toto";
            InitializeComponent();
          
            //BindingContext = new BaseViewModel
            //{
            //    Title = "Hanselman.Forms",
            //    Subtitle = "Hanselman.Forms",
            //    Icon = "slideout.png"
            //};

            //ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
            //{
            //    //new HomeMenuItem { Title = "About", MenuType = MenuType.About, Icon ="about.png" },
            //    //new HomeMenuItem { Title = "Blog", MenuType = MenuType.Blog, Icon = "blog.png" },
            //    //new HomeMenuItem { Title = "Twitter", MenuType = MenuType.Twitter, Icon = "twitternav.png" },
            //    //new HomeMenuItem { Title = "Hanselminutes", MenuType = MenuType.Hanselminutes, Icon = "hm.png" },
            //    //new HomeMenuItem { Title = "Ratchet", MenuType = MenuType.Ratchet, Icon = "ratchet.png" },
            //    //new HomeMenuItem { Title = "Developers Life", MenuType = MenuType.DeveloperLife, Icon = "tdl.png"},
            //    //new HomeMenuItem { Title = "Channel9 Videos", MenuType = MenuType.Videos, Icon = "channel9.png"},

            //};

            //ListViewMenu.SelectedItem = menuItems[0];

            //ListViewMenu.ItemSelected += async (sender, e) =>
            //{
            //    if (ListViewMenu.SelectedItem == null)
            //        return;

            //    await this.root.NavigateAsync((int)((HomeMenuItem)e.SelectedItem).MenuType);
            //};
        }
    }
}
