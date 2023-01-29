using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *askerlerimiz olduğunu düşünelim iki tarafın da 10 askeri olsun ordu1-ordu2
             *10 yüzlü iki adet zarımız olduğunun düşün zar1-zar2
             *random kütüphanesi ile rastgele değerler ürettirelim
             *büyükdeğeri atan taraf karşı tarafın asker sayısını azaltsın
             *1 tarafın asker sayısı 0 a inince o taraf kaybetsin            
            */
            int ordu1 = 10;
            int ordu2 = 10;
            Random zar1 = new Random();
            Random zar2 = new Random();
            int birinciOrduZar = zar1.Next(1, 11);
            int ikinciOrduZar = zar2.Next(1, 11);

            if (birinciOrduZar > ikinciOrduZar)
            {
                ordu2 = ordu2 - 1;
            }

            else
            {
                ordu1 = ordu1 - 1;
            }

            Console.WriteLine("zarlar; {0},{1}", birinciOrduZar,ikinciOrduZar);
            Console.WriteLine("asker sayıları= {0}, {1}", ordu1, ordu2);


        }
    }
}
