using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigpara.Bot.VeriCek
{
    public static class GundemCek
    {
        public static void UzmanParaGundemCek()
        {
            try
            {
                var site = "https://bigpara.hurriyet.com.tr/haberler/";
                var link = "https://bigpara.hurriyet.com.tr";

                List<Gundem> GundemListesi = new List<Gundem>();

                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(site);

                var GundemXpath = "//div[@class='newsFeedBox']";
                var GundemX = document.DocumentNode.SelectNodes(GundemXpath);

                foreach (var Gundem in GundemX)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        string HaberBaslik = KarakterDuzelt.Duzelt(Gundem.SelectSingleNode("//div[2]/div[1]/ul/li[" + i + "]/a/span/span[2]").InnerText);
                        string HaberTarih = KarakterDuzelt.Duzelt(Gundem.SelectSingleNode("//div[2]/div[1]/ul/li[" + i + "]/a/span[1]/span[1]").InnerText);
                        string HaberLink = Gundem.SelectSingleNode("//div[2]/div[1]/ul/li[" + i + "]/a").Attributes["href"].Value;

                        GundemListesi.Add(new Gundem()
                        {
                            HaberBaslik = HaberBaslik,
                            HaberTarih = HaberTarih,
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
