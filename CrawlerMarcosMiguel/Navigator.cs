using CrawlerMarcosMiguel.Catcher;
using CrawlerMarcosMiguel.Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrawlerMarcosMiguel
{
    public class Navigator
    {
        private Utils _utils = new Utils();
        private Connect _connect = new Connect();
        private AnaliseDeSistemas _analiseDeSistemas = new AnaliseDeSistemas();

        public List<Registro> _listRegistro = new List<Registro>();

        public void NavToMainPage()
        {
            Uri url = _utils.SelectPageQuery("home");
            HtmlDocument html = _connect.RequestGET(url);
        }

        public void NavToAnaliseDeSistemasPage()
        {
            Uri url = _utils.SelectPageQuery("analise-de-sitemas");
            HtmlDocument html = _connect.RequestGET(url);
        }


    }
}
