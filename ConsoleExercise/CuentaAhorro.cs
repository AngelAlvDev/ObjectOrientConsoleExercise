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

        public CuentaAhorro(double cuotaMantenimiento)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }
        public void setCuotaMantenimiento(double cuotaMantenimiento)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }

        public
    }
}
