using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigpara.Bot.VeriCek
{
    class HaberBorsaCek
    {
        public static void BigParaHaberBorsaCek()
        {
            try
            {
                var site = "https://bigpara.hurriyet.com.tr/borsa/haber/";
                var link = "https://bigpara.hurriyet.com.tr";

                List<Gundem> GundemListesi = new List<Gundem>();

                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(site);

                var GundemXpath = "//div[@class='tBody']";
                var GundemX = document.DocumentNode.SelectNodes(GundemXpath);

                foreach (var Gundem in GundemX)
                {
                    for (int i = 1; i <= 25; i++)
                    {
                        string HaberBaslik = KarakterDuzelt.Duzelt(Gundem.SelectSingleNode("//div[2]/div[2]/ul[" + i + "]/li[1]/h2").InnerText);
                        string HaberTarih = Gundem.SelectSingleNode("//div[2]/div[2]/ul[" + i + "]/li[2]").InnerText;
                        string HaberSaat = Gundem.SelectSingleNode("//div[2]/div[2]/ul[" + i + "]/li[3]").InnerText;
                        string HaberLink = Gundem.SelectSingleNode("//div[2]/div[2]/ul[" + i + "]/li[1]/h2/a").Attributes["href"].Value;

                        GundemListesi.Add(new Gundem()
                        {
                            HaberBaslik = HaberBaslik,
                            HaberTarih = HaberTarih,
                            HaberSaat = HaberSaat,
                            HaberLink = HaberLink
                        });
                    }
                    break;
                }
                Console.WriteLine("======================");
                foreach (var Gundem in GundemListesi)
                {
                    Console.WriteLine($"Başlık :: {Gundem.HaberBaslik}");
                    Console.WriteLine($"Tarih  :: {Gundem.HaberTarih}");
                    Console.WriteLine($"Saat   :: {Gundem.HaberSaat}");
                    Console.WriteLine($"Link   :: {link}{Gundem.HaberLink}");
                    Console.WriteLine("======================");
                }
            }
            catch (Exception mesaj)
            {
                Console.WriteLine(">>" + mesaj.Message);
            }
        }
    }
}

