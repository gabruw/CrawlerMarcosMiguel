using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrawlerMarcosMiguel
{
    public class Navigator
    {
        // Globais privadas
        private Utils _utils = new Utils();
        private Connect _connect = new Connect();
        private Catcher_All _catcher = new Catcher_All();

        // Globais publicas
        public Consulta _consulta = new Consulta();

        public void NavToMainPage()
        {
            Uri url = _utils.SelectPageQuery(0);
            HtmlDocument html = _connect.RequestGET(url);
        }

        public void NavToMainPage()
        {
            Uri url = _utils.SelectPageQuery(1);
            HtmlDocument html = _connect.RequestGET(url);
        }


    }
}
