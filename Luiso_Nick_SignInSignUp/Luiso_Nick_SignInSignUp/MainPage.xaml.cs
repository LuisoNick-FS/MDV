using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Luiso_Nick_SignInSignUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            signInButton.Clicked += SignInButton_Clicked;
        }

        private void SignInButton_Clicked(object sender, EventArgs e)
        {
            //create new sign in page and go there
            Navigation.PushAsync(new SignInPage());
        }
    }
}
