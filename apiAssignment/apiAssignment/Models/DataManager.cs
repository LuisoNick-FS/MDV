﻿using System;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
namespace apiAssignment.Models
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

        public void GetFish()
        {
            string apiString = apiConnection.DownloadString(apiEndPoint);

            JObject jsonData = JObject.Parse(apiString);

            Debug.WriteLine(jsonData.ToString());
        }

        /*
        public async Task<List<FishData>> FindFish()
        {
            List<FishData> fishList = new List<FishData>();

            string apiString = await apiConnection.DownloadStringTaskAsync(apiEndPoint);

            //pass apiString into a JObject to be parsed into JSON data
            JObject jsonData = JObject.Parse(apiString);

            //debug to show data is being pulled
            Debug.WriteLine(jsonData.ToString());



            return fishList;
        

        }
        */




    }
}
