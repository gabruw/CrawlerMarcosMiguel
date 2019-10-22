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
        private All _all = new All();

        public List<Registro> _listRegistro = new List<Registro>();

        public void NavToHomePage()
        {
            Uri url = _utils.SelectPageQuery("home");
            HtmlDocument html = _connect.RequestGET(url);

            _all.HasNotFoundInformation(html);
            _listRegistro.Add(_all.GetData(html));
        }

        public void NavToAnaliseDeSistemasPage()
        {
            Uri url = _utils.SelectPageQuery("analise-de-sitemas"); // Sitemas Marcos???
            HtmlDocument html = _connect.RequestGET(url);

            _all.HasNotFoundInformation(html);
            _listRegistro.Add(_all.GetData(html));
        }

        public void NavToPOO2Page()
        {
            Uri url = _utils.SelectPageQuery("programacao-orientada-a-objetos-ii");
            HtmlDocument html = _connect.RequestGET(url);

            _all.HasNotFoundInformation(html);
            _listRegistro.Add(_all.GetData(html));
        }

        public void NavToPOO3Page()
        {
            Uri url = _utils.SelectPageQuery("programacao-orientada-a-objetos-iii");
            HtmlDocument html = _connect.RequestGET(url);

            _all.HasNotFoundInformation(html);
            _listRegistro.Add(_all.GetData(html));
        }
    }
}
