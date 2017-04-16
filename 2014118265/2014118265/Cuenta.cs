using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118265
{
    public class Cuenta
    {
        public int numeroCuenta { get; set; }
        public int pin { get; set; }
        public double salTotal { get; set; }
        public double salDisponible { get; set; }

        public Cuenta()
        {
        }
        
        public Cuenta(int numeroCuenta, int pin, double salTotal, double salDisponible)
        {
            this.numeroCuenta = numeroCuenta;
            this.pin = pin;
            this.salTotal = salTotal;
            this.salDisponible = salDisponible;

        }
    }
}
