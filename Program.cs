using System;

namespace TP_MODUL5
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();

            halo.SapaUser<string>("Ikki");

            Console.ReadLine();
        }
    }

    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }
}