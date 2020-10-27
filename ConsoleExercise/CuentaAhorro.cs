using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercise
{
    class CuentaAhorro : Cuenta
    {
        private Double cuotaMantenimiento;

        public CuentaAhorro()
        {
        }

        public CuentaAhorro(string numCuenta, double saldo, double tipoInteres, string nombre, double cuotaMantenimiento)
        {
            this.SetNumCuenta(numCuenta);
            this.SetSaldo(saldo);
            this.SetTipoInteres(tipoInteres);
            this.SetNombre(nombre);
            this.SetCuotaMantenimiento(cuotaMantenimiento);
        }
        public void SetCuotaMantenimiento(double cuotaMantenimiento)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }
        public Double GetCuotaMantenimiento()
        {
            return this.cuotaMantenimiento;
        }

        public override void Estado()
        {
            Console.WriteLine("Numero de cuenta: " + this.GetNumCuenta() + 
                "\nTitular de la cuenta: " + this.GetNombre() + "\nSaldo de la cuenta: " 
                + this.GetSaldo() + "\nTipo de interés de la cuenta: " + this.GetTipoInteres() + 
                "\nCuota de mantenimiento: " + this.GetCuotaMantenimiento());
        }
    }
}
