using System;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajero cajero1 = new Cajero(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Cajero cajero2 = new Cajero(8, 21,
                    23, 150, 20, 50, 100, 250, 300, 710,
                    43, 12, 8, 232, 27);
            Cajero cajero3 = new Cajero(2, 3, 1, 4, 6, 2, 7, 4, 5, 0, 0, 0, 0, 0, 0);
            Cajero cajero4 = new Cajero(0, 0, 0, 0, 0, 0, 0, 0, 0, 100, 100, 100, 100, 100, 101);

            Dinero dinero1 = new Dinero(-1);
            Dinero dinero2 = new Dinero(0);
            Dinero dinero3 = new Dinero(10000000);
            Dinero dinero4 = new Dinero(45.10M);
            Dinero dinero5 = new Dinero(45);
            Dinero dinero6 = new Dinero(0.2M);

            Dinero dinero7 = new Dinero(20434.71M);
            Dinero dinero9 = new Dinero(2043);
            Dinero dinero10 = new Dinero(88.01M);

            Dinero dinero8 = new Dinero(0.01M);

            /*SacarDinero(dinero1, cajero1);//Banco a 0 y retiramos dinero negativo
            SacarDinero(dinero2, cajero1);//Banco a 0 y dinero 0
            SacarDinero(dinero3, cajero1);//Banco a 0 y más dinero del disponible y luego dinero que podemos sacar
            SacarDinero(dinero2, cajero1);
            SacarDinero(dinero2, cajero1);//banco a 0, primero dinero normal que podemos devolver y luego más dinero que tiene el cajero
            SacarDinero(dinero3, cajero1);
            SacarDinero(dinero5, cajero1);//banco a 0 solo retiramos euros
            SacarDinero(dinero6, cajero1);//banco a 0, solo retiramos centimos
            SacarDinero(dinero2, cajero1);//banco a 0 primero retiramos todo el inero y luego intentamos retirar un centimo
            SacarDinero(dinero8, cajero1);*/


            /*SacarDinero(dinero1, cajero2);//Banco normal y retiramos dinero negativo
            SacarDinero(dinero2, cajero2);//Banco normal y dinero 0
            SacarDinero(dinero3, cajero2);//Banco normal y más dinero del disponible y luego dinero que podemos sacar
            SacarDinero(dinero4, cajero2);
            SacarDinero(dinero4, cajero2);//banco normal, primero dinero normal que podemos devolver y luego más dinero que tiene el cajero
            SacarDinero(dinero3, cajero2);
            SacarDinero(dinero5, cajero2);//banco, normal solo retiramos euros
            SacarDinero(dinero6, cajero2);//banco normal, solo retiramos centimos
            SacarDinero(dinero7, cajero2);//banco normal, primero retiramos todo el inero y luego intentamos retirar un centimo
            SacarDinero(dinero8, cajero2);*/

            /*SacarDinero(dinero1, cajero3);//Banco solo eruos y retiramos dinero negativo
            SacarDinero(dinero2, cajero3);//Banco solo euros y dinero 0
            SacarDinero(dinero3, cajero3);//Banco solo euros y más dinero del disponible y luego dinero que podemos sacar
            SacarDinero(dinero4, cajero3);
            SacarDinero(dinero4, cajero3);//banco solo euros, primero dinero normal que podemos devolver y luego más dinero que tiene el cajero
            SacarDinero(dinero3, cajero3);
            SacarDinero(dinero5, cajero3);//banco solo euros solo retiramos euros
            SacarDinero(dinero6, cajero3);//banco solo euros, solo retiramos centimos
            SacarDinero(dinero9, cajero3);//banco solo euros primero retiramos todo el inero y luego intentamos retirar un centimo
            SacarDinero(dinero8, cajero3);*/

            /*SacarDinero(dinero1, cajero4);//Banco solo centimos y retiramos dinero negativo
            SacarDinero(dinero2, cajero4);//Banco solo centimos y dinero 0
            SacarDinero(dinero3, cajero4);//Banco solo centimos y más dinero del disponible y luego dinero que podemos sacar
            SacarDinero(dinero4, cajero4);
            SacarDinero(dinero4, cajero4);//banco solo centimos, primero dinero normal que podemos devolver y luego más dinero que tiene el cajero
            SacarDinero(dinero3, cajero4);
            SacarDinero(dinero5, cajero4);//banco solo centimos solo retiramos euros
            SacarDinero(dinero6, cajero4);//banco solo centimos, solo retiramos centimos
            //SacarDinero(dinero10, cajero4);//banco solo centimos primero retiramos todo el inero y luego intentamos retirar un centimo
            //SacarDinero(dinero8, cajero4);*/

        }

        private static void SacarDinero(Dinero dinero1, Cajero cajero1)
        {
            cajero1.setDineroaSacar(dinero1);
            cajero1.devolverDinero();

        }
    }
}
