using HtmlAgilityPack;
using System;
using System.Net.Http;

//class Scrape
//{
//    static void Main(string[] args)
//    {
//        // Send get request to weather.com
//        string url = "https://weather.com/weather/today/l/624f0cccc10bececfa4c083056cef743837a76588790f476c9ebea44be35e51f";
//        var httpClient = new HttpClient();
//        var html = httpClient.GetStringAsync(url).Result;
//        var htmlDocument = new HtmlDocument();
//        htmlDocument.LoadHtml(html);
//        // Get the temperature
//        var temperatureElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='CurrentConditions--tempValue--MHmYY']");
//        var temperature = temperatureElement.InnerText.Trim();
//        Console.WriteLine("Temperature: " + temperature);
//
//    }
//}