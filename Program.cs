using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar obj = new BangunDatar();

            int sisi;

            Console.WriteLine("menghitung luas persegi");
            Console.Write("masukkan nilai sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("luas persegi adalah="+obj.tampil_persegi(sisi));
            Console.WriteLine("========================");

            int alas, tinggi;
            
            Console.WriteLine("menghitung luas segitiga");
            Console.Write("masukkan nilai alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("luas segitiga adalah="+obj.tampil_segitiga(alas,tinggi));
            Console.WriteLine("========================");

            int rusuk;

            Console.WriteLine("menghitung luas lingkaran");
            Console.Write("masukkan nilai rusuk = ");
            rusuk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("luas lingkaran adalah="+obj.tampil_lingkaran(rusuk));
            
            BangunRuang obj2 = new BangunRuang();

            int p, l, t;

            Console.WriteLine("menghitung volumebalok");
            Console.Write("masukkan nilai p = ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai l = ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai t = ");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("volumebalok adalah "+obj2.tampil_volumebalok(p,l,t));

            int s;

            Console.WriteLine("menghitung volumekubus");
            Console.Write("masukkan nilai s = ");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("volumekubus adalah "+obj2.tampil_volumekubus(s));

        }
    }
}
