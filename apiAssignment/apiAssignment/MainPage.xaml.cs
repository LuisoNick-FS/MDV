using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apiAssignment.Models;
using Xamarin.Forms;

namespace apiAssignment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            tuneButton.Clicked += TuneButton_Clicked;

        }

        private void TuneButton_Clicked(object sender, EventArgs e)
        {
            DataManager fishData = new DataManager("profiles/red-snapper");
        }
    }
}
