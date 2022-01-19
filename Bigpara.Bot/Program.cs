using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigpara.Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "bigpara.hurriyet.com.tr Botu";

            Console.WriteLine(
                "\n==========================================================\n" +
                "bigpara.hurriyet.com.tr'den Döviz & Altın Kuru Çeken Bot" +
                "\n==========================================================\n");

            Console.WriteLine(
                "[ 1 ] ==> Döviz ( Dolar & Euro & Sterlin )" + "\n" +
                "[ 2 ] ==> Altin ( Gram - Çeyrek - ONS )" + "\n" +
                "[ 3 ] ==> Merkez Bankası Kurları" + "\n" +
                "[ 4 ] ==> Serbest Piyasa Kurları" + "\n" +
                "[ 5 ] ==> Gündem Haber" + "\n" +
                "[ 6 ] ==> Borsa Haberleri [ Son 25 ]" + "\n" +
                "[ 7 ] ==> Döviz Haberleri [ Son 25 ]" + "\n" +
                "[ 8 ] ==> Altin Haberleri [ Son 25 ]" +
                "\n\n==========================================================\n");
            Console.Write("Seçim yapınız : ");

            try
            {
                Class1.NewMethod();
            }
            catch (Exception)
            {
                Console.Write("Sadece sayı değeri giriniz..");
            }
            finally
            {
                Console.Write("\n\nSeçim yapınız : ");
                Class1.NewMethod();
            }
            Console.ReadLine();
        }

    }
}
