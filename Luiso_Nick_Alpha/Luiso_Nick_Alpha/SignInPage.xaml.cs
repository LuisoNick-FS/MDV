using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luiso_Nick_Alpha
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
            signInButton.Clicked += SignInButton_Clicked;
        }

        async void SignInButton_Clicked(object sender, EventArgs e)
        {
            //check fields for valid entries
            bool go = RunChecks();

            //decide what to do
            if (go)
            {
                //log in if valid
                await Navigation.PushAsync(new DisplayPage());
            }
            else
            {
                //tell user there is problem
                await DisplayAlert("Entry Error", "Please Enter Valid Entries", "OK");

            }




        }




        private bool RunChecks()
        {
            //check if info is good variable
            bool isValid = false;

            //input variables
            bool email = false;
            bool pass = false;

            if (string.IsNullOrWhiteSpace(emailEntry.Text))
            {

                email = false;
            }
            else
            {
                email = true;
            }

            //------------------------------


            if (string.IsNullOrWhiteSpace(passEntry.Text))
            {

                pass = false;
            }
            else
            {
                pass = true;
            }

            //-------------------------

            //check all
            if (email && pass)
            {
                isValid = true;
            }


            //return
            return isValid;
        }



    }
}
