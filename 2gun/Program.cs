using System;

namespace _2gun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Urunler urun1 = new Urunler();
            urun1.urunKategori = "Ayakkabı";
            urun1.urunRengi = "Siyah";
            urun1.urunKodu = 10;
            urun1.urunGoruntulenme = 102.4M;

            Urunler urun2 = new Urunler();
            urun2.urunKategori = "Elbise";
            urun2.urunRengi = "Kırmızı";
            urun2.urunKodu = 199;
            urun2.urunGoruntulenme = 1032.9M;

            Urunler urun3 = new Urunler();
            urun3.urunKategori = "Aksesuar";
            urun3.urunRengi = "Mavi";
            urun3.urunKodu = 458;
            urun3.urunGoruntulenme = 2.35M;


            Urunler[] urun = new Urunler[] { urun1, urun2, urun3 };


            foreach (var Urunler in urun)
            {
                Console.WriteLine(Urunler.urunKategori + " : " + Urunler.urunRengi);
            }

            {
                Console.WriteLine("Foreach döngüsünü bitirdik.");
            }


            for (int i = 0; i <urun.Length; i++)
            {
                Console.WriteLine(urun[i].urunKodu + " : " + urun[i].urunGoruntulenme );
            }

            {
                Console.WriteLine("For döngüsünü bitirdik.");
            }

            int sayi = 0;
            int toplam = 0;
            while (sayi<urun.Length)
            {
                Console.WriteLine(urun[sayi].urunKodu + " ? " + urun[sayi].urunGoruntulenme, sayi++);
            }

            Console.WriteLine("while döngüsü bitirdik.");


        }
    }







    class Urunler
    {
        internal static int length;

        public string urunKategori { get; set; }
        public string urunRengi { get; set; }
        public int urunKodu { get; set; }
        public decimal urunGoruntulenme { get; set; }
    }
}
