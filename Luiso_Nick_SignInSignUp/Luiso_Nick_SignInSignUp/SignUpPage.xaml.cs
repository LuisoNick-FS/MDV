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

            //The emailEntry throws an error saying that there is no object instance.
            //I do not know what to do

            //if (emailEntry.Text.Contains("@"))
            //{
            //}
            //else
            //{
            //    await DisplayAlert("Entry Error", "Please enter valid email", "OK");
            //}

            if (confirmEntry != passEntry)
            {
                //display error for passwords
                await DisplayAlert("Entry Error", "Passwords do not match", "OK");

                //this displays regardless of values. I do not know what to do.
            }


        }

        private void SignInButton_Clicked(object sender, EventArgs e)
        {
            //go sign in if you already have an account
            Navigation.PushAsync(new SignInPage());
        }








    }
}
