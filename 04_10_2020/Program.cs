using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04_10_2020
{
    class Program
    {
        //static double DaireAlan(double r)
        //{
        //    return Math.PI*r*r;
        //}
        //static double DaireCevre(double r)
        //{
        //    return 2 * Math.PI * r;
        //}

        static void Main(string[] args)
        {
            //ÇALIŞMA SORULARI...

            // Soru-1:  Bir dairenin alanını ve çevresini hesaplayan programı yazınız (methods)

            //double r;

            //Console.Write("Dairenin yarıçapını giriniz: ");
            //double.TryParse(Console.ReadLine(), out r);

            //Console.WriteLine("Dairenin çevresi: {0}", (2 * Math.PI * r));
            //Console.WriteLine("Dairenin alanı: {0}", (Math.PI * r * r));

            ////************************************************************

            //Console.WriteLine("Dairenin çevresi: {0}", DaireCevre(5));
            //Console.WriteLine("Dairenin alanı: {0}", DaireAlan(5));

            //---------------------------------------------------------------------

            // Soru-2: Rastgele değer ataması yapılan 10 elemanlı bir dizi içerisindeki tek sayı ve cift sayıların adedini bulan programı yazınız.(random ile)

            //int tekAdet = 0, ciftAdet = 0;
            //Random rnd = new Random();
            //int[] sayilar = new int[10];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = rnd.Next(1, 10);
            //    Console.WriteLine(sayilar[i]);
            //}
            //foreach (var item in sayilar)
            //{
            //    if (item % 2 == 0)
            //    {
            //        ciftAdet++;
            //    }
            //    else
            //    {
            //        tekAdet++;
            //    }
            //}
            //Console.WriteLine($"Çift sayı adedi {ciftAdet}");
            //Console.WriteLine($"Tek sayı adedi {tekAdet}");

            //---------------------------------------------------------------------

            // Soru-3: Kullanıcı tarafından girilen kenar uzunluklarına gore ekrana dikdörtgeni çizen programı yazınız.

            //int kısaKenar, uzunKenar;

            //Console.Write("Kısa kenar uzunluğunu giriniz:");
            //int.TryParse(Console.ReadLine(), out kısaKenar);
            //Console.Write("Uzun kenar uzunluğunu giriniz:");
            //int.TryParse(Console.ReadLine(), out uzunKenar);

            //for (int i = 1; i <= kısaKenar; i++)
            //{
            //    for (int j = 1; j <= uzunKenar; j++)
            //    {
            //        if (i == 1 || i == kısaKenar)
            //        {
            //            Console.Write("*");
            //        }
            //        else if (j == 1 || j == uzunKenar)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //---------------------------------------------------------------------
            // Soru-4:  1-10 arasında degerlerden olusan 20 uzunlugu(dizinin length'i(int[] s= new int[20];)) olan iki dizi arasındaki kesisim kumesini bulan programı yazınız(sayılar rastgele atanacak

            //Random rnd = new Random();
            //int[] dizi1 = new int[20];
            //int[] dizi2 = new int[20];
            //ArrayList list = new ArrayList();

            //Console.WriteLine("1. dizi elemanları");
            //for (int i = 0; i < 20; i++)
            //{
            //    dizi1[i] = rnd.Next(1, 10);
            //    Console.WriteLine(dizi1[i]);
            //}
            //Console.WriteLine("2. dizi elemanları");
            //for (int i = 0; i < 20; i++)
            //{
            //    dizi2[i] = rnd.Next(1, 10);
            //    Console.WriteLine(dizi2[i]);
            //}

            //for (int i = 0; i < dizi1.Length; i++)
            //{
            //    for (int j = 0; j < dizi2.Length; j++)
            //    {
            //        if (dizi1[i] == dizi2[j])
            //        {
            //            if (!list.Contains(dizi1[i]))
            //            {
            //                list.Add(dizi1[i]);
            //            }
            //        }
            //    }
            //}

            //if (list.Count > 0)
            //{
            //    Console.WriteLine("Kesişen Elemanlar");
            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.ReadLine();

            //---------------------------------------------------------------------


            // Soru-5:  Onluk bir dizi üzerinde sıralama işlemi yapan programı yazınız***(sort kullanmadan)

            //Console.WriteLine("***Array***");
            //int[] array = new int[10] { 5, 85, 66, 14, 68, 27, 44, 96, 30, 25 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("{0} ", array[i]);
            //}
            //Console.WriteLine("\n");

            //Console.Write("Sorting From Small To Large: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int k = 0; k < array.Length; k++)
            //    {
            //        var i_value = array[i];
            //        var k_value = array[k];

            //        if (i_value < k_value)
            //        {
            //            int casual = i_value;
            //            array[i] = k_value;
            //            array[k] = casual;
            //        }
            //    }
            //}
            //foreach (var item in array)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.WriteLine("\n");
            //Console.Write("Sorting From Large To Small: ");
            //for (int j = 0; j < array.Length; j++)
            //{
            //    for (int k = 0; k < array.Length; k++)
            //    {
            //        if (array[j] > array[k])
            //        {
            //            int casual = array[j];
            //            array[j] = array[k];
            //            array[k] = casual;
            //        }
            //    }
            //}
            //foreach (var item in array)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.WriteLine("\n");
            //Console.ReadLine();
        }
    }
}
