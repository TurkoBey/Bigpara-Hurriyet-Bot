using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigpara.Bot.VeriCek
{
    public class MerkezBankasiCek
    {
        public static void UzmanParaMerkezBankasiDovizCek()
        {
            try
            {
                var site = "https://bigpara.hurriyet.com.tr/doviz/merkez-bankasi-doviz-kurlari/";

                List<Doviz> DovizListesi = new List<Doviz>();

                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(site);

                var DovizXpath = "//div[@class='tBody']";
                var DovizX = document.DocumentNode.SelectNodes(DovizXpath);

                foreach (var Doviz in DovizX)
                {
                    for (int i = 1; i <= 19; i++)
                    {
                        string DovizCinsi = KarakterDuzelt.Duzelt(Doviz.SelectSingleNode("//div/div[2]/div/div/div[2]/ul[" + i + "]/li[2]/h3/text()").InnerText);
                        string DovizAlis = Doviz.SelectSingleNode("//div/div[2]/div/div/div[2]/ul[" + i + "]/li[3]").InnerText;
                        string DovizSatis = Doviz.SelectSingleNode("//div/div[2]/div/div/div[2]/ul[" + i + "]/li[4]").InnerText;

                        DovizListesi.Add(new Doviz()
                        {
                            DovizAD = DovizCinsi,
                            DovizAlis = DovizAlis,
                            DovizSatis = DovizSatis
                        });
                    }
                }
                Console.WriteLine("======================");
                foreach (var Doviz in DovizListesi)
                {
                    Console.WriteLine($"Döviz Cinsi :: {Doviz.DovizAD}");
                    Console.WriteLine($"Döviz Alış  :: {Doviz.DovizAlis}");
                    Console.WriteLine($"Döviz Satış :: {Doviz.DovizSatis}");
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
