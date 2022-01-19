using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bigpara.Bot
{
   public static class Class1
    {
        public static void NewMethod()
        {
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("\nDöviz verileri çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.DovizCek.BigParaDovizCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 2:
                    Console.WriteLine("\nAltın verileri çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.AltinCek.BigParaAltinCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 3:
                    Console.WriteLine("\nMerkez Bankası doviz kurları çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.MerkezBankasiCek.BigParaMerkezBankasiDovizCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 4:
                    Console.WriteLine("\nSerbest Piyasa verileri çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.SerbestPiyasaCek.BigParaSerbestPiyasaCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 5:
                    Console.WriteLine("\nGündem Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.GundemCek.BigParaGundemCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 6:
                    Console.WriteLine("\nGündem Borsa Verileri Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.HaberBorsaCek.BigParaHaberBorsaCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 7:
                    Console.WriteLine("\nGündem Borsa Verileri Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.HaberDovizCek.BigParaHaberDovizCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 8:
                    Console.WriteLine("\nGündem Borsa Verileri Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.HaberAltinCek.BigParaHaberAltinCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 6:
                    Console.WriteLine("\nGündem Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.GundemCek.UzmanParaGundemCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                default:
                    Console.Write("Hatalı seçim yaptınız..");
                    break;
            }
        }
    }
}
