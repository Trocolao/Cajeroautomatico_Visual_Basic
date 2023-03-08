using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public class Dinero
    {
        decimal dinero;

        public Dinero(decimal dinero)
        {
            this.dinero = dinero;
        }

        public decimal getDinero()
        {
            return dinero;
        }

        public void setDinero(decimal dinero)
        {
            this.dinero = dinero;
        }

    }
}
