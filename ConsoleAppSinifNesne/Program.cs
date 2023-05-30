using System;

namespace ConsoleAppSinifNesne
{

    public class arac
    {
        public string yakit;
        public int hiz;
        public string renk;
        public string marka;

        public void aracInfo()
        {
            string tasit = "Taşıtın Markası: " + marka + "Aracın Rengi: " +
                renk + "Aracın Yakıt Türü: " + yakit + "Aracın Hızı: " + hiz;

            Console.WriteLine(tasit);

        }

    }


    class program
    {

        static void Main(string[] args)
        {


            arac otomobil = new arac();

            otomobil.hiz = 220;
            otomobil.yakit = "Dizel \n";
            otomobil.renk = "Kırmızı \n";
            otomobil.marka = "Opel \n";


            otomobil.aracInfo();
                }
    }




    


}