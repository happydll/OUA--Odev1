using System;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan input alma ve bu inputları bir metin içerisinde bastırma uygulaması.
            // Bugün İzmir'deyim. Hava sıcaklığı 25.5 derece. Burada bomba yedim. Tanesi 5 liraydı. Tadını çok beğendim.
            
            Console.WriteLine("Bugün neredeydin? ");
            string yer = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());

            Console.WriteLine("Hava kaç dereceydi? ");
            int derece = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("hangi yöresel lezzeti tattın? ");
            string yemek = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());

            Console.WriteLine("fiyatı ne kadardı.");
            int fiyat = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Tadını ne derece beğendin? ");
            string begeni = Console.ReadLine();

            Console.WriteLine("\nBugün " + yer +"deydim."
               + " Hava "+ derece+"dereceydi."
               + " Burada "+ yemek + " yedim."
               +" Tanesi "+ fiyat +" liraydı."
               + " Ben" + yemek +"yı" + begeni);



        }
    }
}
