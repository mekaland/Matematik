using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           matematiksel M = new matematiksel();
            YenidenIslemYap:
            M.menuHazirla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.WriteLine("lutfen bir sayi degeri giriniz");
            decimal kullaniciSayi1  = decimal.Parse(Console.ReadLine());

            Console.WriteLine("lutfen 2. sayi degerinin giriniz");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch(kullaniciSecim)
            {
                case 1:
                   sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc = M.cikarmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                case 3:
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                case 4:
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                default:
                    Console.WriteLine("belirtmiş oldugunuz deger liste içerisinde bulunamadı");
                    Console.WriteLine("lutfen yeni bir deger giriniz");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslemYap;
            }
            Console.WriteLine("yeni islem yapmak istiyor musunuz? E/H");
            string EH = Console.ReadLine();
            if(EH == "E")
            {
                goto YenidenIslemYap;
            }
        }
    }
}
