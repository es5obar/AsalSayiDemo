using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.başla
             * 2.1 sayı girin
             * 3.sayaç =2
             * 4.eğer sayı 2 ise sayı asal, adım 7 ye git
             * 5.sayi% sayaç =0 ise ekrana sayı asal değil , adım 6 ya git
             * 6.sayaç =sayaç +1 eğer sayaç < sayi ise adım 5 e git.
             * 7.bitir
             * 
             * 
             * 1. başla
             * 2. kullanıcıdan bir sayı istenir ve kullanıcı sayıyı girer
             * 3. bir sayaç değeri 2 den başlayarak sayıya kadar arttırılır
             * 4. eğer sayı sayaca bölümünden kalan 0 ise sayı asal değildir.
             * 5. eğer sayının sayacın hiç bir değerine bölümünden kalan 0 değilse sayı asaldır
             * 6. sayının asallık durumu ekrana yazdırılır
             * 7. bitir
             */
            Console.Write("Pozitif bir tam sayı girin (Çıkış = 0):");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                return;
            }
            do
            {

                
                if (sayi == 1)
                {
                    Console.WriteLine("Girilen sayı asal değildir.");
                }
                else
                {
                    bool asalMi = true; // flag
                    for (int sayac = 2; sayac < sayi; sayac++)
                    {
                        if (sayi % sayac == 0)
                        {
                            asalMi = false;
                            break;
                        }
                    }
                    if (asalMi)
                        Console.WriteLine("Sayı asal ");
                    else
                        Console.WriteLine("Sayı asal değil ");
                }
                Console.Write("Pozitif bir tam sayı girin (Çıkış = 0):");
                sayi = Convert.ToInt32(Console.ReadLine());
            } while (sayi != 0);
        }
    }
}
