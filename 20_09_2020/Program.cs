using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            // Soru: Kullanıcı tarafından girilen 2 tam sayının toplamını alıp sonucu ekranda gösteren prog yazınız..


            int sayi1, sayi2, toplam;

            Console.Write("1.Sayiyi Giriniz:");

            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sayiyi Giriniz:");

            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("İki sayının toplamı:" + (sayi1 + sayi2));

            //Tip Dönüşümleri
            //1.Convert Kullanımı
            //2.Parse Kullanımı

            // "12" + "3" => 123
            // "12" + 3   => 123
            //  12 + 3   => 15
        }
    }
}
