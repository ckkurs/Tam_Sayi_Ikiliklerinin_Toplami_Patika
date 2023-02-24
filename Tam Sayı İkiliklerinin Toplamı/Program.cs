using System;

namespace Tam_Sayı_İkiliklerinin_Toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çift Sayı Giriniz: ");
            int sayı = int.Parse((Console.ReadLine()));
            int[] sayıListesi = new int[sayı];

            if (sayı % 2 == 0)
            {
                for (int i = 0; i < sayı; i++)
                {
                    Console.WriteLine("{0}. sayınız: ", i + 1);
                    sayıListesi[i] = Convert.ToInt32(Console.ReadLine());
                }


                for (int i = 0; i < sayıListesi.Length; i += 2)
                {
                    if (sayıListesi[i] == sayıListesi[i + 1])
                    {
                        int toplam = sayıListesi[i] + sayıListesi[i + 1];
                        Console.Write(" " + toplam * toplam + " ");
                    }
                    else
                    {
                        int toplam = sayıListesi[i] + sayıListesi[i + 1];
                        Console.Write(" " + toplam + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("\aÇift sayı giriniz.");
            }
        }
    }
}
