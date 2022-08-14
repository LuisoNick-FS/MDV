using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luiso_Nick_SignInSignUp
{
    public partial class EndPage : ContentPage
    {
        public EndPage()
        {
            InitializeComponent();

            logOutButton.Clicked += LogOutButton_Clicked;
        }

        //go back if clicked log out
        private void LogOutButton_Clicked(object sender, EventArgs e)
        {
            //go back to log in screen
            Navigation.PopToRootAsync();
        }
    }
}
