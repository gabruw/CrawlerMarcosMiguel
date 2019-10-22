using System.Collections.Generic;

namespace CrawlerMarcosMiguel.Model
{
    public class Registro
    {
        public string Titulo { get; set; }

        public Dictionary<string, string> LinksPDF = new Dictionary<string, string>();
    }
}
