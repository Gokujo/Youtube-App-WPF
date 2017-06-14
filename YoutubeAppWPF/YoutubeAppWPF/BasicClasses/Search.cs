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
    class Search
    {
        [STAThread]
        public SearchListResponse SearchBasedOnKeyword(string Keyword, string LastID)
        {
            return Run(Keyword, LastID);
        }
        private SearchListResponse Run(string Keyword, string LastID)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCXOZJH2GUbdqwxZwsjTU93lFvgdnMOVD0",
                ApplicationName = GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.PageToken = LastID;
            searchListRequest.Q = Keyword; // Replace with your search term.
            searchListRequest.MaxResults = 50;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = searchListRequest.Execute();

            return searchListResponse;
        }
    }
}
