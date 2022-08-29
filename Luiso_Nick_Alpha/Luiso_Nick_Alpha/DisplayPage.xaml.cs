using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luiso_Nick_Alpha.Models;
using Xamarin.Forms;


namespace Luiso_Nick_Alpha
{
    public partial class DisplayPage : ContentPage
    {
        public DisplayPage()
        {
            InitializeComponent();
            //fish button clicked events
            snapButton.Clicked += SnapButton_Clicked;
            monkButton.Clicked += MonkButton_Clicked;
            sharkButton.Clicked += SharkButton_Clicked;
            tunaButton.Clicked += TunaButton_Clicked;
            snowCrabButton.Clicked += SnowCrabButton_Clicked;
            lobsterButton.Clicked += LobsterButton_Clicked;
            herringButton.Clicked += HerringButton_Clicked;
            haddockButton.Clicked += HaddockButton_Clicked;
            salmonButton.Clicked += SalmonButton_Clicked;

        }

        private void SalmonButton_Clicked(object sender, EventArgs e)
        {
            DataManage("/atlantic-salmon");
        }

        private void HaddockButton_Clicked(object sender, EventArgs e)
        {
            DataManage("/haddock");
        }

        private void HerringButton_Clicked(object sender, EventArgs e)
        {
            DataManage("/atlantic-herring");
        }

        private void LobsterButton_Clicked(object sender, EventArgs e)
        {

            DataManage("/american-lobster");
        }

        private void SnowCrabButton_Clicked(object sender, EventArgs e)
        {
            DataManage("/alaska-snow-crab");
        }

        private void TunaButton_Clicked(object sender, EventArgs e)
        {
            DataManage("/pacific-bluefin-tuna");
        }

        private void SharkButton_Clicked(object sender, EventArgs e)
        {
            DataManage("/pacific-shortfin-mako-shark");
        }

        private void MonkButton_Clicked(object sender, EventArgs e)
        {
            DataManage("/monkfish");
        }

        private void SnapButton_Clicked(object sender, EventArgs e)
        {
            DataManage("/red-snapper");
        }

        //-------------------------------------------------------------
        //pull fdata
        //-------------------------------------------------------------

        async void DataManage(string message)
        {
            DataManager fishToFind = new DataManager(message);
            FishData fishData = await fishToFind.GetFish();

            fishImage.Source = fishData.ImgSrc;
            nameLabel.Text = "Name:" + fishData.Name;
            locLabel.Text = "Harvest Type: " + fishData.Location;
            statLabel.Text = "Availability: " + fishData.Status;
        }


    }
}
