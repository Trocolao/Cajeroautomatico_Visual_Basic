using System;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajero cajero1 = new Cajero(2, 3,
                5, 212, 20, 150, 100, 250, 300, 0,
                0, 10, 48, 10, 7);
            Cajero cajero2 = new Cajero(8, 21,
                    23, 150, 20, 50, 100, 250, 300, 710,
                    43, 12, 8, 232, 27);

            Dinero dinero1 = new Dinero(0.45M);
            SacarDinero(dinero1, cajero1);
            SacarDinero(dinero1, cajero2);

            Dinero dinero2 = new Dinero(2100.97M);
            SacarDinero(dinero2, cajero1);
            SacarDinero(dinero2, cajero2);

            Dinero dinero3 = new Dinero(1000000);
            SacarDinero(dinero3, cajero1);
            SacarDinero(dinero3, cajero2);

            Dinero dinero4 = new Dinero(4556.34M);
            SacarDinero(dinero4, cajero1);
            SacarDinero(dinero4, cajero2);


        }

        private static void SacarDinero(Dinero dinero1, Cajero cajero1)
        {
            cajero1.setDineroaSacar(dinero1);
            cajero1.devolverDinero();

        }
    }
}
