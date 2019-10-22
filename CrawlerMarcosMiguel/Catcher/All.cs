using CrawlerMarcosMiguel.Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CrawlerMarcosMiguel.Catcher
{
    public class All
    {
        private Utils _utils = new Utils();

        public Registro GetData(HtmlDocument html)
        {
            Registro newRegistro = new Registro();

            string titulo = html.DocumentNode.SelectSingleNode("//div/div/div/h1").InnerText;
            newRegistro.Titulo = titulo;

            HtmlNodeCollection nodesData = html.DocumentNode.SelectNodes("//section//div/div/div/div/p[a]");
            if (nodesData == null)
            {
                throw new Exception("Erro ao capturar os nodes que contém os dados a serem capturados.");
            }

            foreach (HtmlNode node in nodesData)
            {
                string id = node.ChildNodes["#text"].InnerHtml;
                string[] idSplited = Regex.Split(id, "—");

                id = idSplited[idSplited.Length - 1].Trim();
                string link = node.ChildNodes["a"].Attributes["href"].Value;

                newRegistro.LinksPDF.Add(link, id);
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
