using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class matematiksel
    {
        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public decimal cikarmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }
        public void menuHazirla()
        {
            Console.WriteLine("***** Menu Hazırla *****");
            Console.WriteLine("1- toplama");
            Console.WriteLine("2- cıkarma");
            Console.WriteLine("3- carpma");
            Console.WriteLine("4- bolme");
            Console.Write("Lutfen deger seciniz: ");
        }
        public void sonucEkranaYaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", kullaniciSayi1,operators,kullaniciSayi2, sonuc);
        }
    }
}
