namespace CalcularSueldoNeto
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            Empleado empleado = new Empleado(50000,0.0287,3500,0);
            //empleado.mostrarDatos();
            empleado.CalcularSueldoNeto();

           // empleado.mostrarDatos();
        }
    }
}
