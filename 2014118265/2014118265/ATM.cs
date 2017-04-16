using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118265
{
    public class ATM
    {
        private Teclado _teclado;
        private DispensadorEfectivo _dispensadorEfectivo;
        private RanuraDeposito _ranuraDeposito;
        private Pantalla _pantalla;
        private Retiro _retiro;
        BasedeDatos _baseDatos = null;

        public void comenzar()
        {

            // Console.Write("Empezar")

            _baseDatos = new BasedeDatos();

            _baseDatos.registrar();

            _baseDatos.AutenticarLogin(0123, 01234);

            _baseDatos.ObtenerSaldoDisponible(0123);

            _baseDatos.ObtenerSaldoTotal(0123);
            Console.ReadKey();

        }
    }
}
