﻿using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper;

class Program
{
    static void Main(string[] args)
    {
        String url =
            "https://weather.com/weather/today/l/a53ddac07a8fbe9ad7ae00926a04d6faea759fa1b144af6ec713b952d62066f8";

        var httpClient = new HttpClient();

        var html = httpClient.GetStringAsync(url).Result;
    }
}
