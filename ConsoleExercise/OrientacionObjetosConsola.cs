using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleExercise
{
    class OrientacionObjetosConsola
    {
        static void Main(string[] args)
        {
            String numeroCuenta;
            String nombreTitular;
            Double saldo;
            Double tipoInteres;
            Double cuota;
            Console.WriteLine("Programa de prueba de herencia.");
            Console.WriteLine("Introduzca Información relativa a la cuenta bancaria:");
            Console.Write("Número de cuenta: ");
            numeroCuenta = Console.ReadLine();
            Console.Write("Nombre del titular de la cuenta: ");
            nombreTitular = Console.ReadLine();
            Console.Write("Introduzca saldo de la cuenta: ");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca tipo de interés de la cuenta: ");
            tipoInteres = Convert.ToDouble(Console.ReadLine());
            Cuenta cuenta = new Cuenta(numeroCuenta, saldo, tipoInteres, nombreTitular);
            cuenta.Estado();
            Console.WriteLine("\n\nIntroduzca Información relativa a la cuenta bancaria:");
            Console.Write("Número de cuenta: ");
            numeroCuenta = Console.ReadLine();
            Console.Write("Nombre del titular de la cuenta: ");
            nombreTitular = Console.ReadLine();
            Console.Write("Introduzca saldo de la cuenta: ");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca tipo de interés de la cuenta: ");
            tipoInteres = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca cuota de mantenimiento: ");
            cuota = Convert.ToDouble(Console.ReadLine());
            cuenta = new CuentaAhorro(numeroCuenta, saldo, tipoInteres, nombreTitular,cuota);
            cuenta.Estado();
            Console.ReadKey();

        }
    }
}
