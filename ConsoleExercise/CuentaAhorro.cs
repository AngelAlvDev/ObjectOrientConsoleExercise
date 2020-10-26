﻿using System;
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

        public CuentaAhorro(double cuotaMantenimiento)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
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
            Console.WriteLine("Numero de cuenta: " + this.GetNumCuenta() + "\tTitular de la cuenta: " + this.GetNombre() + "\tSaldo de la cuenta: " + this.GetSaldo() + "\tTipo de interés de la cuenta: " + this.GetTipoInteres() + "\tCuota de mantenimiento; " + this.GetCuotaMantenimiento());
        }
    }
}
