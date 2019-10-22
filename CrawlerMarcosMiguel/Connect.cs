using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace CrawlerMarcosMiguel
{
    public class Connect
    {
        private Utils _utils = new Utils();

        public HtmlDocument RequestGET(Uri url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "GET";
            webRequest.AllowAutoRedirect = false;

            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

            string html = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            HtmlDocument htmlDoc = _utils.ParseToHtmlDocument(html);

            return htmlDoc;
        }
    }
}
