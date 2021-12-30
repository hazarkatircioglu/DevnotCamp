using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Asci asci = new Asci();
            asci.Pisir(new PirasaYemek());
            asci.Pisir(new KofteYemek());

            Baklava baklava = new Baklava();
            asci.SunumYap(baklava);
            

        }
    }


}
