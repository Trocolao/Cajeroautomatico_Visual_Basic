using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public class Billete
    {
       public Billete(int valor)
        {
            Valor = valor;
        }
        public int Valor { get; set; }
    }
}


