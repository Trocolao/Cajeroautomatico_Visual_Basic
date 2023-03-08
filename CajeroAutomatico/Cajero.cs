using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public class Cajero
    {

        public Cajero(int unidades500, int unidades100, int unidades20, int unidades5, int unidades1, int unidades02, int unidades005, int unidades001)
        {
            this.Unidades500 = unidades500;
            this.Unidades100 = unidades100;
            this.Unidades20 = unidades20;
            this.Unidades5 = unidades5;
            this.Unidades1 = unidades1;
            this.Unidades02 = unidades02;
            this.Unidades005 = unidades005;
            this.Unidades001 = unidades001;

        }
        public int Unidades500 { get; set; }
        public int Unidades200 { get; set; }
        public int Unidades100 { get; set; }
        public int Unidades50 { get; set; }
        public int Unidades20 { get; set; }
        public int Unidades10 { get; set; }
        public int Unidades5 { get; set; }
        public int Unidades2 { get; set; }
        public int Unidades1 { get; set; }
        public int Unidades05 { get; set; }
        public int Unidades02 { get; set; }
        public int Unidades01 { get; set; }
        public int Unidades005 { get; set; }
        public int Unidades002 { get; set; }
        public int Unidades001 { get; set; }
        public Cajero(int unidades500, int unidades200, int unidades100, int unidades50,
                      int unidades20, int unidades10, int unidades5,
                      int unidades2, int unidades1, int unidades05, int unidades02,
                      int unidades01, int unidades005, int unidades002, int unidades001)
        {
            Unidades500 = unidades500;
            Unidades200 = unidades200;
            Unidades100 = unidades100;
            Unidades50 = unidades50;
            Unidades20 = unidades20;
            Unidades10 = unidades10;
            Unidades5 = unidades5;
            Unidades2 = unidades2;
            Unidades1 = unidades1;
            Unidades05 = unidades05;
            Unidades02 = unidades02;
            Unidades01 = unidades01;
            Unidades005 = unidades005;
            Unidades002 = unidades002;
            Unidades001 = unidades001;

        }

        public decimal _dinero;
        public decimal _dinero1;
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
        Dinero _dineroasacar;
        public void setDineroaSacar(Dinero dinero)
        {
            _dineroasacar = dinero;
            getDineroDevuelveCajero();
            getDineroCajero();

        }

        public void getDineroCajero()
        {
            _dinero = Unidades500 * bill500.Valor + Unidades200 * bill200.Valor
                    + Unidades100 * bill100.Valor + Unidades50 * bill50.Valor +
                    Unidades20 * bill20.Valor + Unidades10 * bill10.Valor
                    + Unidades5 * bill5.Valor + Unidades2 * mon2e.Valor + Unidades1 * mon1e.Valor +
            Unidades05 * mon50cen.Valor + Unidades02 * mon20cen.Valor
                    + Unidades01 * mon10cen.Valor + Unidades005 * mon5cen.Valor +
                    Unidades002 * mon2cen.Valor + Unidades001 * mon1cen.Valor;
        }
        public decimal getDineroDevuelveCajero()
        {
            _dinero1 = getBilletes500() * bill500.Valor + getBilletes200() * bill200.Valor
                    + getBilletes100() * bill100.Valor + getBilletes50() * bill50.Valor +
                    getBilletes20() * bill20.Valor + getBilletes10() * bill10.Valor
                    + getBilletes5() * bill5.Valor + getMonedas2() * mon2e.Valor + getMonedas1() * mon1e.Valor +
                    getCen50() * mon50cen.Valor + getCen20() * mon20cen.Valor
                    + getCen10() * mon10cen.Valor + getCen5() * mon5cen.Valor +
                    getCen2() * mon2cen.Valor + getCen1() * mon1cen.Valor;

            return _dinero1;
        }

        public int getCen1()
        {
            int cen1 = (int)(getRestoMonedas2cen() / mon1cen.Valor);
            if (cen1 <= Unidades001)
            {
                return cen1;
            }
            else
            {
                return Unidades001;
            }
        }

        public decimal getRestoMonedas2cen()
        {
            decimal restoMonedas2cen = (getRestomonedas5cen() % mon2cen.Valor);

            int cen2 = (int)(getRestomonedas5cen() / mon2cen.Valor);
            if (cen2 <= Unidades002)
            {
                return restoMonedas2cen;
            }
            else
            {
                return restoMonedas2cen + (cen2 - Unidades002) * mon2cen.Valor;

            }
        }

        public int getCen2()
        {
            int cen2 = (int)(getRestomonedas5cen() / mon2cen.Valor);
            if (cen2 <= Unidades002)
            {
                return cen2;
            }
            else
            {
                return Unidades002;
            }
        }

        public decimal getRestomonedas5cen()
        {
            decimal restoMonedas5cen = (getRestoMonedas10cen() % mon5cen.Valor);

            int cen5 = (int)(getRestoMonedas10cen() / mon5cen.Valor);
            if (cen5 <= Unidades005)
            {
                return restoMonedas5cen;
            }
            else
            {
                return restoMonedas5cen + (cen5 - Unidades005) * mon5cen.Valor;

            }
        }

        public int getCen5()
        {
            int cen5 = (int)(getRestoMonedas10cen() / mon5cen.Valor);
            if (cen5 <= Unidades005)
            {
                return cen5;
            }
            else
            {
                return Unidades005;
            }
        }

        public decimal getRestoMonedas10cen()
        {
            decimal restomonedas10cen = (getRestoMonedas20cen() % mon10cen.Valor);

            int cen10 = (int)(getRestoMonedas20cen() / mon10cen.Valor);
            if (cen10 <= Unidades01)
            {
                return restomonedas10cen;
            }
            else
            {
                return restomonedas10cen + (cen10 - Unidades01) * mon10cen.Valor;

            }
        }

        public int getCen10()
        {
            int cen10 = (int)(getRestoMonedas20cen() / mon10cen.Valor);
            if (cen10 <= Unidades01)
            {
                return cen10;
            }
            else
            {
                return Unidades01;
            }
        }

        public decimal getRestoMonedas20cen()
        {
            decimal restomonedas20cen = (getRestoMonedas50cen() % mon20cen.Valor);

            int cen20 = (int)(getRestoMonedas50cen() / mon20cen.Valor);
            if (cen20 <= Unidades02)
            {
                return restomonedas20cen;
            }
            else
            {
                return restomonedas20cen + (cen20 - Unidades02) * mon20cen.Valor;

            }
        }

        public int getCen20()
        {
            int cen20 = (int)(getRestoMonedas50cen() / mon20cen.Valor);
            if (cen20 <= Unidades02)
            {
                return cen20;
            }
            else
            {
                return Unidades02;
            }
        }

        public decimal getRestoMonedas50cen()
        {
            decimal restoMonedas50cen = getRestomonedas1e() % mon50cen.Valor;

            int cen50 = (int)(getRestomonedas1e() / mon50cen.Valor);
            if (cen50 <= Unidades05)
            {
                return restoMonedas50cen;
            }
            else
            {
                return restoMonedas50cen + (cen50 - Unidades05) * mon50cen.Valor;

            }
        }

        public int getCen50()
        {
            int cen50 = (int)(getRestomonedas1e() / mon50cen.Valor);
            if (cen50 <= Unidades05)
            {
                return cen50;
            }
            else
            {
                return Unidades05;
            }
        }
        public decimal getRestomonedas1e()
        {
            decimal restoMonedas1e = getRestoMonedas2e() % mon1e.Valor;
            int monedas1 = (int)getRestoMonedas2e();
            if (monedas1 <= Unidades1)
            {
                return restoMonedas1e;
            }
            else
            {
                return restoMonedas1e + (monedas1 - Unidades1) * mon1e.Valor;
            }
        }

        public int getMonedas1()
        {
            int monedas1 = (int)getRestoMonedas2e();
            if (monedas1 <= Unidades1)
            {
                return monedas1;
            }
            else
            {
                return Unidades1;
            }
        }

        public decimal getRestoMonedas2e()
        {
            decimal restoMonedas2e = getRestoBilletes5() % mon2e.Valor;
            int monedas2 = (int)(getRestoBilletes5() / mon2e.Valor);
            if (monedas2 <= Unidades2)
            {
                return restoMonedas2e;
            }
            else
            {
                return restoMonedas2e + (monedas2 - Unidades2) * mon2e.Valor;
            }
        }

        public int getMonedas2()
        {
            int monedas2 = (int)(getRestoBilletes5() / mon2e.Valor);
            if (monedas2 <= Unidades2)
            {
                return monedas2;
            }
            else
            {
                return Unidades2;
            }
        }

        public decimal getRestoBilletes5()
        {
            decimal restoBilletes5 = getRestobilletes10() % bill5.Valor;
            int billetes5 = (int)(getRestobilletes10() / bill5.Valor);
            if (billetes5 <= Unidades5)
            {
                return restoBilletes5;
            }
            else
            {
                return restoBilletes5 + (billetes5 - Unidades5) * bill5.Valor;
            }
        }

        public int getBilletes5()
        {
            int billetes5 = (int)(getRestobilletes10() / bill5.Valor);
            if (billetes5 <= Unidades5)
            {
                return billetes5;
            }
            else
            {
                return Unidades5;
            }
        }

        public decimal getRestobilletes10()
        {
            decimal restoBilletes10 = getRestoBilletes20() % bill10.Valor;
            int billetes10 = (int)(getRestoBilletes20() / bill10.Valor);
            if (billetes10 <= Unidades10)
            {
                return restoBilletes10;
            }
            else
            {
                return restoBilletes10 + (billetes10 - Unidades10) * bill10.Valor;
            }
        }

        public int getBilletes10()
        {
            int billetes10 = (int)(getRestoBilletes20() / bill10.Valor);
            if (billetes10 <= Unidades10)
            {
                return billetes10;
            }
            else
            {
                return Unidades10;
            }
        }

        public decimal getRestoBilletes20()
        {
            decimal restoBillete20 = getRestoBilletes50() % bill20.Valor;
            int billetes20 = (int)(getRestoBilletes50() / bill20.Valor);
            if (billetes20 <= Unidades20)
            {
                return restoBillete20;
            }
            else
            {
                return restoBillete20 + (billetes20 - Unidades20) * bill20.Valor;
            }
        }

        public int getBilletes20()
        {
            int billetes20 = (int)(getRestoBilletes50() / bill20.Valor);
            if (billetes20 <= Unidades20)
            {
                return billetes20;
            }
            else
            {
                return Unidades20;
            }
        }

        public decimal getRestoBilletes50()
        {
            decimal restobilletes50 = getRestoBilletes100() % bill50.Valor;
            int billetes50 = (int)(getRestoBilletes100() / bill50.Valor);
            if (billetes50 <= Unidades50)
            {
                return restobilletes50;
            }
            else
            {
                return restobilletes50 + (billetes50 - Unidades50) * bill50.Valor;
            }
        }

        public int getBilletes50()
        {
            int billetes50 = (int)(getRestoBilletes100() / bill50.Valor);
            if (billetes50 <= Unidades50)
            {
                return billetes50;
            }
            else
            {
                return Unidades50;
            }
        }

        public decimal getRestoBilletes100()
        {
            decimal restoBilletes100 = getRestoBilletes200() % bill100.Valor;
            int billetes100 = (int)(getRestoBilletes200() / bill100.Valor);
            if (billetes100 <= Unidades100)
            {
                return restoBilletes100;
            }
            else
            {
                return restoBilletes100 + (billetes100 - Unidades100) * bill100.Valor;
            }
        }

        public int getBilletes100()
        {
            int billetes100 = (int)(getRestoBilletes200() / bill100.Valor);
            if (billetes100 <= Unidades100)
            {
                return billetes100;
            }
            else
            {
                return Unidades100;
            }

        }

        public decimal getRestoBilletes200()
        {
            decimal restoBilletes200 = getRestoBilletes500() % bill200.Valor;
            int billetes200 = (int)(getRestoBilletes500() / bill200.Valor);
            if (billetes200 <= Unidades200)
            {
                return restoBilletes200;
            }
            else
            {
                return restoBilletes200 + (billetes200 - Unidades200) * bill200.Valor;
            }

        }

        public int getBilletes200()
        {

            int billetes200 = (int)(getRestoBilletes500() / bill200.Valor);
            if (billetes200 <= Unidades200)
            {
                return billetes200;
            }
            else
            {
                return Unidades200;
            }
        }

        public decimal getRestoBilletes500()
        {

            decimal restoBilletes500 = _dineroasacar.getDinero() % bill500.Valor;
            int billetes500 = (int)(_dineroasacar.getDinero() / bill500.Valor);
            if (billetes500 <= Unidades500)
            {
                return restoBilletes500;
            }
            else
            {
                return restoBilletes500 + (billetes500 - Unidades500) * bill500.Valor;
            }

        }

        public int getBilletes500()
        {

            int billetes500 = (int)(_dineroasacar.getDinero() / bill500.Valor);
            if (billetes500 <= Unidades500)
            {
                return billetes500;
            }
            else
            {
                return Unidades500;
            }

        }
        public void actualizarDinero()
        {
            Unidades500 = Unidades500 - getBilletes500();
            Unidades200 = Unidades200 - getBilletes200();
            Unidades100 = Unidades100 - getBilletes100();
            Unidades50 = Unidades50 - getBilletes50();
            Unidades20 = Unidades20 - getBilletes20();
            Unidades10 = Unidades10 - getBilletes10();
            Unidades5 = Unidades5 - getBilletes5();
            Unidades2 = Unidades2 - getMonedas2();
            Unidades1 = Unidades1 - getMonedas1();
            Unidades05 = Unidades05 - getCen50();
            Unidades02 = Unidades02 - getCen20();
            Unidades01 = Unidades01 - getCen10();
            Unidades005 = Unidades005 - getCen5();
            Unidades002 = Unidades002 - getCen2();
            Unidades001 = Unidades001 - getCen1();
        }

        public Ticket devolverDinero()
        {

            Ticket t1 = new Ticket(getBilletes500(), getBilletes200(), getBilletes100()
            , getBilletes50(), getBilletes20(), getBilletes10(), getBilletes5(), getMonedas2()
            , getMonedas1(), getCen50(), getCen20()
            , getCen10(), getCen5(), getCen2(), getCen1());
            Ticket t2 = new Ticket(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            if (_dineroasacar.getDinero() > _dinero)
            {
                Console.WriteLine("El cajero automático no dispone de más dinero, por favor acuda al más cercano\n");
                return t2;
            }
            else if (_dineroasacar.getDinero() != _dinero1)
            {
                Console.WriteLine("El cajero no dispone de los cambios disponibles para retirar su dinero, por favor acuda al más cercano\n");
                return t2;
            }
            else
            {

                Console.WriteLine(t1.toString());
                actualizarDinero();
                return t1;
            }
        }
    }
}
