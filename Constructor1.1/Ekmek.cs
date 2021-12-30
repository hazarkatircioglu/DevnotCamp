using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor1._1
{
    public class Ekmek
    {
        public string Tur { get; set; }
        public int Adet { get; set; }

        public Ekmek():this(1,"Beyaz Ekmek")
        {          
        }
        public Ekmek(int adet):this(adet,"Beyaz Ekmek")
        {            
        }
        public Ekmek(string tur):this(1,tur)
        {  
        }
        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;
        }
    }
}
