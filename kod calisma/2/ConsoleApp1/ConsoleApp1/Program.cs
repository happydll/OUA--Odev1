using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // farklı classaki verilere kullanıcıdan aldığı sayıları alan ekrana alt alta değil de yan yana yazdıran uygulama. 

            Yeni yeni = new Yeni();
            Console.WriteLine("birinci sayıyı gir: ");
            yeni.a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı gir: ");
            yeni.b = Convert.ToInt32(Console.ReadLine());

           
            int sonuc = Convert.ToInt32(Math.Pow(yeni.a, yeni.b));
            Console.WriteLine("sonuç= {0},", sonuc); // buradaki {0}; virgülden sonra verilen sonuc değişkenini içine alır.       
            Console.ReadLine();


        }
    }

    class Yeni
    {
        
        public int a;
        public int b;

        public int toplama()
        {
            return a * b;
        }
    }
}
