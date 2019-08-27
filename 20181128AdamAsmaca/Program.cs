using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181128AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeHavuzu = { "kalem", "virgül", "zarf", "televizyon", "masa", "saat", "çanta", "tablo", "viyadük", "avize", "yemek", "şalgam", "elbise", "pantolon", "araba", "ceket", "tesbih", "gözlük", "zalım", "jamiryo", "aksiyon", "belgesel", "futbol", "müzik", "bilgisayar", "lamba", "telefon", "deniz", "okyanus", "taksi", "ekran", "klavye", "bellek" };

            Random rnd = new Random();
            string kelime = kelimeHavuzu[rnd.Next(kelimeHavuzu.Length)];

            int hak = 5, puan = kelime.Length;
            char[] kelimeHarf = kelime.ToCharArray();
            string tahmin = "", girilenHarfler = "";
            char[] harflerBos = new char[kelimeHarf.Length];
            for (int i = 0; i < kelimeHarf.Length; i++)
                harflerBos[i] = '_';

            for (hak = 5; hak > 0; hak--)
            {
                Console.Clear();
                Console.WriteLine(string.Join(" ", harflerBos)+"  " + harflerBos.Length + " karakter\tGirilen Harfler: " + girilenHarfler);

            x: Console.Write("Harf: ");
                char harf = Convert.ToChar(Console.ReadLine().ToLower());
                if (!char.IsLetter(harf))
                {
                    Console.WriteLine("Harf olmayan bir karakter girdiniz. Tekrar deneyin.");
                    goto x;
                }
                else if (girilenHarfler.Contains(harf.ToString()))
                {
                    Console.WriteLine($"{harf} harfi daha önce girilmiş. Tekrar deneyin.");
                    goto x;
                }


                for (int i = 0; i < kelimeHarf.Length; i++)
                {
                    if (kelimeHarf[i] == harf)
                    {
                        harflerBos[i] = harf;
                    }
                }
                girilenHarfler += harf.ToString();
                Console.WriteLine(string.Join(" ",harflerBos));
                Console.WriteLine("Tahmin gir: ");
                tahmin = Console.ReadLine().ToLower();
                if(tahmin==kelime)
                {
                    Console.WriteLine("Tebrikler! {0} kelimesini {1}. hakkınızda bildiniz.",kelime,5-hak);
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış tahmin");
                }

            }
            Console.WriteLine("Kelime: {0}   Bilemedin xD",kelime);

            Console.ReadKey();
        }
    }
}
