using CrawlerMarcosMiguel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrawlerMarcosMiguel
{
    public class Index
    {
        public static void Main(string[] args)
        {
            Index index = new Index();
            index.Menu();
        }

        private void Menu()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("[1] - Home");
            Console.WriteLine("[2] - Análise de Sistemas");
            Console.WriteLine("[3] - POO II");
            Console.WriteLine("[4] - POO III");
            Console.WriteLine("[5] - Todas");
            Console.Write("-> ");

            string op = Console.ReadLine();

            Console.Clear();

            Consulta(op);

            Console.WriteLine("<> Deseja efetuar uma nova consulta? [S/N]");
            string option = Console.ReadLine().ToUpper();

            Console.Clear();

            switch (option)
            {
                case "S":
                case "SIM":
                    Menu();
                    break;
                case "N":
                case "NAO":
                default:
                    Console.WriteLine("Obrigado por utilizar o programa.");
                    break;
            }
        }

        private void Consulta(string op)
        {
            Navigator Navigator = new Navigator();

            switch (op)
            {
                case "1":
                    Navigator = new Navigator();
                    Navigator.NavToHomePage();
                    break;
                case "2":
                    Navigator = new Navigator();
                    Navigator.NavToAnaliseDeSistemasPage();
                    break;
                case "3":
                    Navigator = new Navigator();
                    Navigator.NavToPOO2Page();
                    break;
                case "4":
                    Navigator = new Navigator();
                    Navigator.NavToPOO3Page();
                    break;
                case "5":
                    Navigator = new Navigator();
                    Navigator.NavToAnaliseDeSistemasPage();
                    Navigator.NavToPOO2Page();
                    Navigator.NavToPOO3Page();
                    break;
                default:
                    break;
            }

            List<Registro> ListaRegistro = Navigator._listRegistro;

            foreach(Registro registro in ListaRegistro)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine(registro.Titulo);
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine("[Links]\n");

                foreach (var link in registro.LinksPDF)
                {
                    Console.WriteLine(String.Format("{1}:\n{0}\n", link.Key, link.Value));
                }

                Console.WriteLine("\n\n");
            }
        }
    }
}
