using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Helth
{
    class quotes
    {
        public static string getQuotes()
        {
            string QuotesText;
            var client = new RestClient("https://quotes.rest/qod?category=inspire");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "X-TheySaidSo-Api-Secret");
            IRestResponse response = client.Execute(request);
            JsonObject qtsObj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject contentObj = (JsonObject)qtsObj["contents"];
            JsonArray quotesArray = (JsonArray)contentObj["quotes"];
            JsonObject quoteO = (JsonObject)quotesArray[0];
            QuotesText = (string)quoteO["quote"];
            return QuotesText;
        }
    }
}
