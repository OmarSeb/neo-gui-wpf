using System.Diagnostics;
using Autofac;
using Xamarin.Forms;
using Neo.Gui.Base;
using Neo.Gui.Base.Controllers;
using Neo.Gui.Base.Helpers;
using Neo.Gui.Base.Managers;
using Neo.Gui.Base.Messaging.Interfaces;
using Neo.Gui.Base.Services;
using Neo.Gui.ViewModels;
using Neo.Gui.ViewModels.Home;
using Prism.Autofac;
using Prism.Autofac.Forms;

namespace Neo.Gui.XamarinViews
{
    public partial class App : PrismApplication
    {

        public App()
        {
            GetMainPage();
        }

        private async void GetMainPage()
        {
            await NavigationService.NavigateAsync("HomeView");
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
        }

        protected override void RegisterTypes()
        {
            var autoFacContainerBuilder = new ContainerBuilder();

            autoFacContainerBuilder.RegisterModule<BaseRegistrationModule>();

            Container.RegisterTypeForNavigation<NavigationPage>("Navigation");
            //Binding MVVM
            Container.RegisterTypeForNavigation<HomeView, HomeViewModel>();
            Container.RegisterTypeForNavigation<MenuPage, HomeViewModel>();
            Container.RegisterTypeForNavigation<Page2, HomeViewModel>();
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
