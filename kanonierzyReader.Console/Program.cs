using kanonierzyReader.Lib;
using System.Collections.Generic;
using System;

namespace kanonierzyReader.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<News> news = KanonierzyParser.GetNewsPageForDate(DateTime.Now.Year, DateTime.Now.Month);
            foreach (var item in news)
            {
                item.Comments = KanonierzyParser.GetCommentsPageForNews(item.Url, 1);
                break;
            }

            news.ForEach(item => System.Console.WriteLine(item.ToString()));
            System.Console.ReadKey();
        }
    }
}
