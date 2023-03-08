using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public class Moneda
    {
        private decimal valor;

        public Moneda(decimal valor)
        {
            this.valor = valor;
        }
        public decimal Valor
        {
            get
            {
                return valor;
            }
            set
            {
                this.valor = valor;
            }
        }

    }
}
