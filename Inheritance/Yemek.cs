using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Yemek
    {
        public int Sure { get; set; }
        public void Pisir()
        {

        }
        public virtual void SunumYap()
        {
            Console.WriteLine($"{this.GetType().Name}   " +
                $"Yanında pilav");
        }
    }

    public enum PismeBicimi
    {
        Az,Orta,Cok
    }
    public class EtYemek : Yemek
    {
        public PismeBicimi PismeBicimi { get; set; }
    }
    public class SebzeYemek:Yemek
    {
        public bool ZeytinYagli { get; set; }
    }

    public class KofteYemek:EtYemek
    {

    }

    public class PirasaYemek : SebzeYemek { }

    public class Tatli : Yemek
    {

    }
    public class Baklava : Tatli
    {
        public override void SunumYap()
        {
             Console.WriteLine($"{this.GetType().Name}   " +
                $"Yanında dondurma");
        }
    }



}
