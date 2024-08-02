using System;

namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularVolumenEsfera(double radio)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        }

        public double CalcularLongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public double CalcularAreaCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public double CalcularVolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public void Imprimir(double areaCirculo, double volumenEsfera, double longitudCircunferencia, double areaCuadrado, double volumenCubo)
        {
            Console.WriteLine($"Área del círculo: {areaCirculo}");
            Console.WriteLine($"Volumen de la esfera: {volumenEsfera}");
            Console.WriteLine($"Longitud de la circunferencia: {longitudCircunferencia}");
            Console.WriteLine($"Área del cuadrado: {areaCuadrado}");
            Console.WriteLine($"Volumen del cubo: {volumenCubo}");
        }
    }
}