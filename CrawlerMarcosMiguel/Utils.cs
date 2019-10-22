using HtmlAgilityPack;
using System;

namespace CrawlerMarcosMiguel
{
    public class Utils
    {
        public HtmlDocument ParseToHtmlDocument(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            return htmlDoc;
        }

        public Uri SelectPageQuery(string titulo)
        {
            return new Uri(String.Format("https://sites.google.com/site/marcosamiguel/{0}?authuser=0", titulo));
        }
    }
}
