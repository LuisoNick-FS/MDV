using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Luiso_Nick_SignInSignUp
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            signInButton.Clicked += SignInButton_Clicked;
            signUpButton.Clicked += SignUpButton_Clicked;
        }

        private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            //check fields for valid entries
            RunChecks();
        }

        private void SignInButton_Clicked(object sender, EventArgs e)
        {
            //go sign in if you already have an account
            Navigation.PushAsync(new SignInPage());
        }





        async void RunChecks()
        {

            //make a list off error messages
            string[] errors = new string[3];

            if (nameEntry == null)
            {
                errors[0] = "Please enter a name";
                

            }

            Debug.WriteLine(errors[0]);

            await DisplayAlert("Entry Error", errors[0], "OK");


        }





    }
}
