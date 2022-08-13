using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Luiso_Nick_SignInSignUp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //make navigation pages
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
