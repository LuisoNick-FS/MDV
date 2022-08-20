using System;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
namespace Luiso_Nick_Alpha.Models
{
    public class DataManager
    {
        //create web client object
        WebClient apiConnection = new WebClient();
        //define starting API URL
        string startAPI = "https://www.fishwatch.gov/api/species";
        //define search variable -- i.e the name we are looking for here
        string fishName { get; set; }
        //end point url is combo of start and search variable
        string apiEndPoint
        {
            get
            {
                return startAPI + fishName;
            }
        }
        //constructor required to take on desired fish to find and set it as fishName
        public DataManager(string fishToFind)
        {
            fishName = fishToFind;
        }



        public async Task<FishData> GetFish()
        {
            string apiString = await apiConnection.DownloadStringTaskAsync(apiEndPoint);

            JArray jsonData = JArray.Parse(apiString);

            Debug.WriteLine(jsonData[0]["Species Name"].ToString());
            Debug.WriteLine(jsonData[0]["Species Illustration Photo"]["src"].ToString());

            FishData fishData = new FishData();
            fishData.ImgSrc = jsonData[0]["Species Illustration Photo"]["src"].ToString();
            fishData.Name = jsonData[0]["Species Name"].ToString();
            fishData.Location = jsonData[0]["Location"].ToString();
            fishData.Status = jsonData[0]["Availability"].ToString();

            return fishData;
        }


        public async Task<List<FishData>> FindFish()
        {
            List<FishData> fishList = new List<FishData>();

            string apiString = await apiConnection.DownloadStringTaskAsync(apiEndPoint);

            //pass apiString into a JObject to be parsed into JSON data
            JObject jsonData = JObject.Parse(apiString);

            //debug to show data is being pulled
            Debug.WriteLine(jsonData[0]["Species Name"].ToString());



            return fishList;


        }

    }
}
