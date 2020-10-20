using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercise
{
    class CuentaBancaria
    {
        private String numCuenta, nombre;
        private Double saldo, tipoInteres;

        public CuentaBancaria(string numCuenta, double saldo, double tipoInteres, string nomCliente)
        {
            this.setNumCuenta(numCuenta);
            this.setSaldo(saldo);
            this.setTipoInteres(tipoInteres);
            this.setNombre(nomCliente);
        }

        public String getNumCuenta() {
            return this.numCuenta;
        }
        public Double getSaldo() {
            return this.saldo;
        }
        public Double getTipoInteres() { 
            return this.tipoInteres;
        }
        public String getNombre() {
            return this.nombre;
        }

        public void setNumCuenta(String numCuenta)
        {
            this.numCuenta = numCuenta;
        }
        public void setSaldo(Double saldo)
        {
            this.saldo = saldo;
        }
        public void setTipoInteres(Double tipoInteres)
        {
            this.tipoInteres = tipoInteres;
        }
        public void setNombre(String nomCliente)
        {
            this.nombre = nomCliente;
        }

        public void estado()
        {

        }

    }
}
