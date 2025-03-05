using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalcularSueldoNeto
{
    public class Empleado
    {
        // Formula:
        // Salario Neto = Salario Bruto - (AFP + ISR)
        public int SalarioBruto;
        public double Afp;
        public int Isr;
        public double SalarioNeto;

        public Empleado ( int SalarioBruto, double Afp, int Isr, double SalarioNeto ) 
        {

            this.SalarioBruto = SalarioBruto;
            this.Afp = Afp;
            this.Isr = Isr;
            this.SalarioNeto = SalarioNeto;


        }

        public void mostrarDatos () {

            Console.WriteLine( "------Datos------" );
            Console.WriteLine( $"Salario Bruto:{SalarioBruto}\nAfp: {Afp}\nIsr: {Isr}\nSalario Neto: { Math.Round(SalarioNeto)}" );


        }

        public void CalcularSueldoNeto (){

            SalarioNeto = SalarioBruto - (Afp + Isr);

            Console.WriteLine( $"El salario neto es de {Math.Round(SalarioNeto)}");
            

        }


    }
}
