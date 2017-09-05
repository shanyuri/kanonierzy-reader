using HtmlAgilityPack;

namespace kanonierzyReader.Lib
{
    public static class HtmlClient
    {
        public static HtmlDocument GetHtmlDocument(string url)
        {
            HtmlWeb client = new HtmlWeb();
            HtmlDocument htmlDoc;
            try
            {
                htmlDoc = client.Load(url);
            }
            catch
            {
                // log
                throw;
            }

            return htmlDoc;
        }
    }
}
