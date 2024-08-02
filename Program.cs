using System;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();

            Console.WriteLine("Ingrese el radio del círculo/esfera:");
            double radio = Convert.ToDouble(Console.ReadLine());
            double areaCirculo = operaciones.CalcularAreaCirculo(radio);
            double volumenEsfera = operaciones.CalcularVolumenEsfera(radio);
            double longitudCircunferencia = operaciones.CalcularLongitudCircunferencia(radio);

            Console.WriteLine("Ingrese el lado del cuadrado/cubo:");
            double lado = Convert.ToDouble(Console.ReadLine());
            double areaCuadrado = operaciones.CalcularAreaCuadrado(lado);
            double volumenCubo = operaciones.CalcularVolumenCubo(lado);

            operaciones.Imprimir(areaCirculo, volumenEsfera, longitudCircunferencia, areaCuadrado, volumenCubo);
        }
    }
}
