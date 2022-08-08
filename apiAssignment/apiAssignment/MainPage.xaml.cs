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
            monkButton.Clicked += MonkButton_Clicked;
            sharkButton.Clicked += SharkButton_Clicked;
        }

        async void SharkButton_Clicked(object sender, EventArgs e)
        {
            DataManager fishToFind = new DataManager("/pacific-shortfin-mako-shark");
            FishData fishData = await fishToFind.GetFish();

            fishImage.Source = fishData.ImgSrc;
            nameLabel.Text = "Name:" + fishData.Name;
            locLabel.Text = "Location: " + fishData.Location;
            statLabel.Text = "Status: " + fishData.Status;
        }

        async void MonkButton_Clicked(object sender, EventArgs e)
        {
            DataManager fishToFind = new DataManager("/monkfish");
            FishData fishData = await fishToFind.GetFish();

            fishImage.Source = fishData.ImgSrc;
            nameLabel.Text = "Name:" + fishData.Name;
            locLabel.Text = "Location: " + fishData.Location;
            statLabel.Text = "Status: " + fishData.Status;
        }

        async void TuneButton_Clicked(object sender, EventArgs e)
        {
            DataManager fishToFind = new DataManager("/red-snapper");
            FishData fishData = await fishToFind.GetFish();

            fishImage.Source = fishData.ImgSrc;
            nameLabel.Text = "Name:" + fishData.Name;
            locLabel.Text = "Location: " + fishData.Location;
            statLabel.Text = "Status: " + fishData.Status;
        }
    }
}
