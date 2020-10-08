using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            // ÇALIŞMA SORULARI


            ////////////// 1.SORU //////////////

            // 1-Kullanıcı tarafından girilen pozitif tamsayıların kaç tanesi çift sayıdır
            //(*Çift sayi nasıl bulunur!!!)


            //Console.Write("Başlangic Sayisi Giriniz: ");
            //int kucukSayi = int.Parse(Console.ReadLine());

            //Console.Write("Bitis Sayisi Giriniz: ");
            //int buyukSayi = int.Parse(Console.ReadLine());

            //if (buyukSayi > kucukSayi)
            //{
            //    int sayac = 0;
            //    for (int i = kucukSayi; i <= buyukSayi; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            sayac++;
            //        }
            //        //(i % 2 == 0 ? sayac++ : );
            //    }
            //    Console.WriteLine($"{sayac} tane çift sayı girdiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Bitiş sayısı başlangıç sayısından büyük olmalıdır...");
            //}


            ////////////// 2.SORU //////////////

            // 2-Kullanıcı tarafından girilen bir tam sayıyı ikili sayı sistemine çeviren programı yazınız
            // 3=11  5=101 gibi (*Mod op.)

            //int tamSayi;
            //int kalan;
            //string yaziKalan = "";

            //Console.Write("Bir tamsayı giriniz: ");

            //int.TryParse(Console.ReadLine(), out tamSayi);

            //while (tamSayi != 0)
            //{
            //    kalan = tamSayi % 2;
            //    tamSayi = tamSayi / 2;

            //    yaziKalan += kalan.ToString();
            //    //Console.WriteLine("2'lik Sistem: {0}", kalan);
            //}
            //Console.WriteLine($"2'lik Sistemde Karşılığı : {yaziKalan}");



            ////////////// 3.SORU //////////////

            // 3-Aklından bir sayı tut (1-100 arasında rastgele bir sayı tut!!!) Kullanıcının kaç hamlede bildiği tutulacak...

            //int tahmin = 0, tutulan, sayac = 0;
            //Random rasgele = new Random();
            //tutulan = rasgele.Next(1, 100);
            //while (tahmin != tutulan)
            //{
            //    sayac++;
            //    Console.Write("Sayı giriniz: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());


            //    if (tahmin > tutulan)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı girin");

            //    }
            //    else if (tahmin < tutulan)
            //    {
            //        Console.WriteLine("Daha büyük bir sayı girin");
            //    }
            //}

            //Console.WriteLine($"Tebrikler {sayac}.hakkınızda bildiniz");

            // Haftaya şimdiye kadar gördüğümüz konuların örneklerle tekrarını yapıp ,içiçe döngüler , diziler ve fonksiyonlara geçilecek
            
        }
    }
}
