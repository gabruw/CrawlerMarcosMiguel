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

        public Uri SelectPageQuery(int tipo)
        {
            Uri url = new Uri("");

            switch (tipo)
            {
                case 1:
                    url = new Uri("https://sites.google.com/site/marcosamiguel/analise-de-sitemas?authuser=0");
                    break;
                case 2:
                    url = new Uri("https://sites.google.com/site/marcosamiguel/pos-graduacao?authuser=0");
                    break;
                case 3:
                    url = new Uri("https://sites.google.com/site/marcosamiguel/programacao-orientada-a-objetos-ii?authuser=0");
                    break;
                case 4:
                    url = new Uri("https://sites.google.com/site/marcosamiguel/programacao-orientada-a-objetos-iii?authuser=0");
                    break;
                default:
                    url = new Uri("https://sites.google.com/site/marcosamiguel/home?authuser=0");
                    break;
            }

            return url;
        }
    }
}
