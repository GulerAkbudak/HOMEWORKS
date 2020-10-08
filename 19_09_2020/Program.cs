using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            //Soru 1: Bir satis firmasında taban ucret + prim şeklinde çalışan personellerin maasini hesaplayan programı yazınız...
            //prim hesaplaması toplam satisin %2si olacak şekilde olacaktır


            //double tabanUcret, prim, toplamSatis, maas;


            //Console.Write("Personel Taban Ücretini Giriniz: ");
            //double.TryParse(Console.ReadLine(), out tabanUcret);

            //Console.Write("Personel Toplam Satışı Giriniz: ");
            //double.TryParse(Console.ReadLine(), out toplamSatis);

            //prim = toplamSatis * 0.02;
            //maas = tabanUcret + prim;

            //Console.WriteLine("Personel Maaşı: " + maas);

            //Console.WriteLine("Taban ücreti{0} olan kişinin yaptigi satis {1} ve alacagi maas ise {2} olacaktir", tabanUcret,toplamSatis,maas);

            //Console.WriteLine($"Hesaplanan Maas: {tabanUcret+prim}");



            //Soru 2: Yarıcapi kullanıcı tarafından girilen bir dairenin alan ve cevresini hesaplayan programı yazınız...

            double yaricap, cevre, alan;

            Console.WriteLine("Dairenin Yarıçapını Giriniz:");
            double.TryParse(Console.ReadLine(), out yaricap);

            cevre = 2 * Math.PI * yaricap;
            alan = Math.PI * yaricap * yaricap;

            Console.WriteLine("Dairenin Çevresi:" + cevre);
            Console.WriteLine("Dairenin Alanı:" + alan);


            // Haftaya Döngü ve Şart konuları anlatılacak..

        }
    }
}
