using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Luiso_Nick_SignInSignUp
{
    public partial class SignUpPage : ContentPage
    {

        //make a list off error messages
        //string[] errors = new string[3];
       

        public SignUpPage()
        {
            InitializeComponent();
            signInButton.Clicked += SignInButton_Clicked;
            signUpButton.Clicked += SignUpButton_Clicked;
        }

       async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            //check fields for valid entries
            bool go = RunChecks();

            //decide what to do
            if (go)
            {
                //log in if valid
                await Navigation.PushAsync(new EndPage());
            }
            else
            {
                //tell user there is problem
                await DisplayAlert("Entry Error", "Please Enter Valid Entries", "OK");

            }
        }

        private void SignInButton_Clicked(object sender, EventArgs e)
        {
            //go sign in if you already have an account
            Navigation.PushAsync(new SignInPage());
        }


        private bool RunChecks()
        {
            //make return variable
            bool isValid = false;
            //make check variables
            bool name = false;
            bool email = false;
            bool pass = false;
            bool confirm = false;

            //------------------------------------

            //USERNAME VALIDATION

            //check if name entry has valid info
            if (string.IsNullOrWhiteSpace(nameEntry.Text))
            {

                name = false;
            }
            else
            {
                name = true;
            }
            //------------------------------------

            //EMAIL VALIDATION -- DOES NOT WORK --

            //string s1 = emailEntry.Text;
            //string s2 = "@";
            //bool b = s1.Contains(s2);

            //if (b)
            //{
            //    email = true;
            //}

            //debug test
            //-----------
            email = true;
            //-----------

            //-----------------------------------------------

            //PASSWORD VALIDATIONS

            if(string.IsNullOrWhiteSpace(passEntry.Text))
            {

                pass = false;
            }
            else
            {
                pass = true;
            }

            //---------

            //PASSWORD CHECK VALIDATION

            if (confirmEntry.Text == passEntry.Text)
            {
                confirm = true;
            }
            else
            {
                confirm = false;
            }

            //-----------------------------------------------

            //COMPARE ALL CHECK
            if (name && email && pass && confirm)
            {
                isValid = true;
            }


            //return if all entries are good or not
            return isValid;
        }





    }
}
