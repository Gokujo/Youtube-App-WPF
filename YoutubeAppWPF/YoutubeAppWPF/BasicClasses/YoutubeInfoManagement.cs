using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace YoutubeAppWPF.BasicClasses
{
    class YoutubeInfoManagement
    {
        public void Test()
        {
            List<string> IDs = new List<string> { };
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCXOZJH2GUbdqwxZwsjTU93lFvgdnMOVD0",
                ApplicationName = GetType().ToString()
            });
            try
            {
                var infoRequest = youtubeService.Videos.List("statistics");
                infoRequest.Id = "fwGrdTHXw68";

                var returnedData = infoRequest.Execute();
                Console.WriteLine(returnedData);
            }
            catch { }
        }
    }
}
