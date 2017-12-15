using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZaksMarketplace.Models;

namespace ZaksMarketplace
{
    public static class WeatherAPI
    {
        public static string CallAPITomorrowWeather()
        {
            var client = new RestClient("http://api.openweathermap.org/data/2.5/forecast?zip=53202&APPID=ccdf583ef54ab1e26a4a253c86f092b4");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "282e63e8-b31b-9674-fa74-18b07a961331");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);

            var convertedData = JsonConvert.DeserializeObject<ApiStorage>(response.Content);
            var tomorrowsWeather = convertedData.List[2].Weather[0].Main;
            var currentWeather = convertedData.List[0].Weather[0].Main;
            return tomorrowsWeather;
        }

        public static string CallAPICurrentWeather()
        {
            var client = new RestClient("http://api.openweathermap.org/data/2.5/forecast?zip=53202&APPID=ccdf583ef54ab1e26a4a253c86f092b4");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "282e63e8-b31b-9674-fa74-18b07a961331");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);

            var convertedData = JsonConvert.DeserializeObject<ApiStorage>(response.Content);
            var tomorrowsWeather = convertedData.List[2].Weather[0].Main;
            var currentWeather = convertedData.List[0].Weather[0].Main;
            return currentWeather;
        }
    }
}