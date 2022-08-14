using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Luiso_Nick_SignInSignUp
{
    public partial class SignUpPage : ContentPage
    {

        //make a list off error messages
        string[] errors = new string[3];
       

        public SignUpPage()
        {
            InitializeComponent();
            signInButton.Clicked += SignInButton_Clicked;
            signUpButton.Clicked += SignUpButton_Clicked;
        }

       async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            //check fields for valid entries
            if (nameEntry.Text == null)
            {
                await DisplayAlert("Entry Error","Please Enter A Name","OK");
            }

            //if (emailEntry.Text.Contains("@"))
            //{
            //}
            //else
            //{
            //    await DisplayAlert("Entry Error", "Please enter valid email", "OK");
            //}



        }

        private void SignInButton_Clicked(object sender, EventArgs e)
        {
            //go sign in if you already have an account
            Navigation.PushAsync(new SignInPage());
        }








    }
}
