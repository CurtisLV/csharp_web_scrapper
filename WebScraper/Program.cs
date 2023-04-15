using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper;

class Program
{
    static void Main(string[] args)
    {
        // send get request to weather.com
        String url =
            "https://weather.com/weather/today/l/a53ddac07a8fbe9ad7ae00926a04d6faea759fa1b144af6ec713b952d62066f8";
        var httpClient = new HttpClient();
        var html = httpClient.GetStringAsync(url).Result;

        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(html);

        // get temparature
        var temperatureElement = htmlDocument.DocumentNode.SelectSingleNode(
            "//span[@class='CurrentConditions--tempValue--MHmYY']"
        );
        var temperature = temperatureElement.InnerText.Trim();

        Console.WriteLine($"Temperature: {temperature} F");

        // get conditions
        var conditionsElement = htmlDocument.DocumentNode.SelectSingleNode(
            "//span[@class='CurrentConditions--phraseValue--mZC_p']"
        );
        var conditions = temperatureElement.InnerText.Trim();

        Console.WriteLine($"Conditions: {conditions}");

        // get location
    }
}
