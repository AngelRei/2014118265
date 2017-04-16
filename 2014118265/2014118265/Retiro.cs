using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118265
{
    public class Retiro
    { 
        public int dinero { get; private set; }
        public int nticket { get; private set; }
        public ATM Atm { get; private set; }

        public Retiro()
        {

        }
        public Retiro (ATM atm)
        {
            Atm = atm;
        }

        public Retiro(int nticket)
        {
            nticket = nticket;
        }
   
        public void CalcularRetiro()
        {
            // nticket=Atm;
        }
    }
}
