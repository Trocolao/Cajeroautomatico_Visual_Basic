using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public class Ticket
    {
        public int Devuelve500 { get; set; }
        public int Devuelve200 { get; set; }
        public int Devuelve100 { get; set; }
        public int Devuelve50 { get; set; }
        public int Devuelve20 { get; set; }
        public int Devuelve10 { get; set; }
        public int Devuelve5 { get; set; }
        public int Devuelve2 { get; set; }
        public int Devuelve1 { get; set; }
        public int Devuelve05 { get; set; }
        public int Devuelve02 { get; set; }
        public int Devuelve01 { get; set; }
        public int Devuelve005 { get; set; }
        public int Devuelve002 { get; set; }
        public int Devuelve001 { get; set; }
        Billete bill500 = new Billete(500);
        Billete bill200 = new Billete(200);
        Billete bill100 = new Billete(100);
        Billete bill50 = new Billete(50);
        Billete bill20 = new Billete(20);
        Billete bill10 = new Billete(10);
        Billete bill5 = new Billete(5);
        Moneda mon2e = new Moneda(2);
        Moneda mon1e = new Moneda(1);
        Moneda mon50cen = new Moneda(0.5M);
        Moneda mon20cen = new Moneda(0.2M);
        Moneda mon10cen = new Moneda(0.1M);
        Moneda mon5cen = new Moneda(0.05M);
        Moneda mon2cen = new Moneda(0.02M);
        Moneda mon1cen = new Moneda(0.01M);
        public Ticket(int devuelve500, int devuelve200, int devuelve100, int devuelve50, int devuelve20, int devuelve10, int devuelve5, int devuelve2, int devuelve1, int devuelve05, int devuelve02, int devuelve01, int devuelve005, int devuelve002, int devuelve001)
        {
            Devuelve500 = devuelve500;
            Devuelve200 = devuelve200;
            Devuelve100 = devuelve100;
            Devuelve50 = devuelve50;
            Devuelve20 = devuelve20;
            Devuelve10 = devuelve10;
            Devuelve5 = devuelve5;
            Devuelve2 = devuelve2;
            Devuelve1 = devuelve1;
            Devuelve05 = devuelve05;
            Devuelve02 = devuelve02;
            Devuelve01 = devuelve01;
            Devuelve005 = devuelve005;
            Devuelve002 = devuelve002;
            Devuelve001 = devuelve001;
        }

        public string toString()
        {
            return "Los billetes que devuelve el cajero son los siguientes: \n" +
            "Billetes de " + bill500.Valor + ": " + Devuelve500 + "\n" +
            "Billetes de " + bill200.Valor + ": " + Devuelve200 + "\n" +
            "Billetes de " + bill100.Valor + ": " + Devuelve100 + "\n" +
            "Billetes de " + bill50.Valor + ": " + Devuelve50 + "\n" +
            "Billetes de " + bill20.Valor + ": " + Devuelve20 + "\n" +
            "Billetes de " + bill10.Valor + ": " + Devuelve10 + "\n" +
            "Billetes de " + bill5.Valor + ": " + Devuelve5 + "\n" +
            "Monedas de " + mon2e.Valor + ": " + Devuelve2 + "\n" +
            "Monedas de " + mon1e.Valor + ": " + Devuelve1 + "\n" +
            "Monedas de " + mon50cen.Valor + ": " + Devuelve05 + "\n" +
            "Monedas de " + mon20cen.Valor + ": " + Devuelve02 + "\n" +
            "Monedas de " + mon10cen.Valor + ": " + Devuelve01 + "\n" +
            "Monedas de " + mon5cen.Valor + ": " + Devuelve005 + "\n" +
            "Monedas de " + mon2cen.Valor + ": " + Devuelve002 + "\n" +
            "Monedas de " + mon1cen.Valor + ": " + Devuelve001 + "\n";

        }
        public void actualizarDinero(Cajero cajero1)
        {
            cajero1.Unidades500 = cajero1.Unidades500 - cajero1.getBilletes500();
            cajero1.Unidades200 = cajero1.Unidades200 - cajero1.getBilletes200();
            cajero1.Unidades100 = cajero1.Unidades100 - cajero1.getBilletes100();
            cajero1.Unidades50 = cajero1.Unidades50 - cajero1.getBilletes50();
            cajero1.Unidades20 = cajero1.Unidades20 - cajero1.getBilletes20();
            cajero1.Unidades10 = cajero1.Unidades10 - cajero1.getBilletes10();
            cajero1.Unidades5 = cajero1.Unidades5 - cajero1.getBilletes5();
            cajero1.Unidades2 = cajero1.Unidades2 - cajero1.getMonedas2();
            cajero1.Unidades1 = cajero1.Unidades1 - cajero1.getMonedas1();
            cajero1.Unidades05 = cajero1.Unidades05 - cajero1.getCen50();
            cajero1.Unidades02 = cajero1.Unidades02 - cajero1.getCen20();
            cajero1.Unidades01 = cajero1.Unidades01 - cajero1.getCen10();
            cajero1.Unidades005 = cajero1.Unidades005 - cajero1.getCen5();
            cajero1.Unidades002 = cajero1.Unidades002 - cajero1.getCen2();
            cajero1.Unidades001 = cajero1.Unidades001 - cajero1.getCen1();
        }
    }
}
