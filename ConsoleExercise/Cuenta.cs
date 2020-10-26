using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercise
{
    class Cuenta
    {
        private String numCuenta, nombre;
        private Double saldo, tipoInteres;

        public Cuenta(string numCuenta, double saldo, double tipoInteres, string nomCliente)
        {
            this.setNumCuenta(numCuenta);
            this.setSaldo(saldo);
            this.setTipoInteres(tipoInteres);
            this.setNombre(nomCliente);
        }

        public Cuenta()
        {
        }

        public String GetNumCuenta() {
            return this.numCuenta;
        }
        public Double GetSaldo() {
            return this.saldo;
        }
        public Double GetTipoInteres() { 
            return this.tipoInteres;
        }
        public String GetNombre() {
            return this.nombre;
        }

        public void SetNumCuenta(String numCuenta)
        {
            this.numCuenta = numCuenta;
        }
        public void SetSaldo(Double saldo)
        {
            this.saldo = saldo;
        }
        public void SetTipoInteres(Double tipoInteres)
        {
            this.tipoInteres = tipoInteres;
        }
        public void SetNombre(String nomCliente)
        {
            this.nombre = nomCliente;
        }

        public virtual void Estado()
        {
            Console.WriteLine("Numero de cuenta: " + this.GetNumCuenta() + "\tTitular de la cuenta: " + this.GetNombre() + "\tSaldo de la cuenta: " + this.GetSaldo() + "\tTipo de interés de la cuenta: " + this.GetTipoInteres());
        }

    }
}
