using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118265
{
    public class BasedeDatos
    {
        public Cuenta _cuenta;
        public List<Cuenta> _cuent;

        public BasedeDatos()
        {
            _cuenta = new Cuenta();
            _cuent = new List<Cuenta>();
        }
        public void registrar()
        {
            // numeroCuenta=0123;
            Console.WriteLine("Conexio de la Base de Datos");

            try
            {
                _cuenta.numeroCuenta = 0123;
                _cuenta.pin = 123;
                _cuenta.salDisponible = 123;
                _cuenta.salTotal = 123;
                _cuent.Add(_cuenta);

                _cuenta.numeroCuenta = 01234;
                _cuenta.pin = 1234;
                _cuenta.salDisponible = 1234;
                _cuenta.salTotal = 1234;

                _cuent.Add(_cuenta);

                Console.WriteLine("Base de Datos Completa");

            }catch(Exception ex)
            {

            }

        }

        public bool AutenticarLogin(int numeroCuenta , int pin)
        {
            if (_cuent == null)
            {
                Console.WriteLine("Entro");
                return false;

            }else
            {
                for(int i = 0; i < _cuent.Count; i++)
                {
                    if(numeroCuenta==_cuent[i].numeroCuenta && pin== _cuent[i].pin)
                    {
                        Console.WriteLine("Login Correcto");

                        return true;

                    }
                }
                return false;
            }

        }

        public double ObtenerSaldoDisponible(int numeroCuenta)
        {
            int variable = 0;

            for(int k=0; k < _cuent.Count; k++)
            {
                if (numeroCuenta == _cuent[k].numeroCuenta)
                {
                    variable = k;
                    Console.WriteLine("Saldo Disponible :" + variable);

                }
            }

            Console.WriteLine("Saldo Disponible:" + _cuent[variable].salDisponible);

            return _cuent[variable].salDisponible;

        }

        public double ObtenerSaldoTotal(int numeroCuenta)
        {
            int variable = 0;

            for (int j = 0; j < _cuent.Count; j++)
            {
                if (numeroCuenta == _cuent[j].numeroCuenta)
                {

                    variable= j;
                }

            }

            Console.WriteLine("tu saldo disponible es :" + _cuent[variable].salTotal);

            return _cuent[variable].salTotal;
        }



    }
}
