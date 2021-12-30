using System;

namespace Constructor1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekmek ekmek = new Ekmek();
            Ekmek ekmek1 = new Ekmek();
            Ekmek ekmek2 = new Ekmek { Adet = 3, Tur = "Kepekli" };
        }
    }
}
