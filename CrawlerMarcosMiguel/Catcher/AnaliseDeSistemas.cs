using CrawlerMarcosMiguel.Model;
using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;

namespace CrawlerMarcosMiguel.Catcher
{
    public class AnaliseDeSistemas
    {
        private Utils _utils = new Utils();

        public Registro GetData(HtmlDocument html)
        {
            Registro newRegistro = new Registro();

            string titulo = html.DocumentNode.SelectSingleNode("//div[@id='h.p_ID_5']/div/div/h1").OuterHtml;
            newRegistro.Titulo = titulo;

            HtmlNodeCollection nodesData = html.DocumentNode.SelectNodes("//div[@id='h.p_ID_35']/div/div/p/a/@href");
            if (nodesData == null)
            {
                throw new Exception("Erro ao capturar os nodes que contém os dados a serem capturados.");
            }

            foreach (HtmlNode node in nodesData)
            {
                HtmlDocument nodeHtmlDoc = _utils.ParseToHtmlDocument(node.InnerHtml);

                string link = nodeHtmlDoc.DocumentNode.SelectSingleNode("").OuterHtml;

                newRegistro.LinksPDF.Add(link);
            }

            return newRegistro;
        }

        public void HasNotFoundInformation(HtmlDocument htmlDoc)
        {
            Match node = Regex.Match(htmlDoc.ParsedText, "não existe");
            if (node.Success)
            {
                throw new Exception("Página não encontrada.");
            }
        }
    }
}
