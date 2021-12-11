using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigpara.Bot.VeriCek
{
    public static class AltinCek
    {
        public static void UzmanParaAltinCek()
        {
            try
            {
                var site = "https://bigpara.hurriyet.com.tr/altin/";

                List<Doviz> DovizListesi = new List<Doviz>();

                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(site);

                var DovizXpath = "//div[@class='dovizBar mBot10']";
                var DovizX = document.DocumentNode.SelectNodes(DovizXpath);

                foreach (var Doviz in DovizX)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        string DovizCinsi = KarakterDuzelt.Duzelt(Doviz.SelectSingleNode("//div[1]/a[" + i + "]/span[1]/span[1]").InnerText);
                        string DovizAlis = Doviz.SelectSingleNode("//div/div[1]/a[" + i + "]/span[2]/span[2]").InnerText;
                        string DovizSatis = Doviz.SelectSingleNode("//div/div[1]/a[" + i + "]/span[3]/span[2]").InnerText;

                        DovizListesi.Add(new Doviz()
                        {
                            DovizAD = DovizCinsi,
                            DovizAlis = DovizAlis,
                            DovizSatis = DovizSatis
                        });
                    }
                }
                Console.WriteLine("============================");
                foreach (var Doviz in DovizListesi)
                {
                    Console.WriteLine($"Döviz Cinsi :: {Doviz.DovizAD}");
                    Console.WriteLine($"Döviz Alış  :: {Doviz.DovizAlis}" + " TL");
                    Console.WriteLine($"Döviz Satış :: {Doviz.DovizSatis}" + " TL");
                    Console.WriteLine("============================");

                }
            }
            catch (Exception mesaj)
            {
                Console.WriteLine(">>" + mesaj.Message);
            }
        }
    }
}
