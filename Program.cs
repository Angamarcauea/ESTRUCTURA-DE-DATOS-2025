using System;

namespace FigurasGeometricas
{
    // Clase Circulo representa un círculo con su radio
    class Circulo
    {
        private double radio; // Atributo privado que representa el radio del círculo

        // Constructor que recibe el valor del radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double,
        // se utiliza para calcular el área de un círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro devuelve el perímetro del círculo (longitud de la circunferencia)
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectangulo representa un rectángulo con ancho y alto
    class Rectangulo
    {
        private double ancho;  // Atributo privado para el ancho
        private double alto;   // Atributo privado para el alto

        // Constructor que recibe los valores de ancho y alto
        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        // CalcularArea devuelve el área del rectángulo
        public double CalcularArea()
        {
            return ancho * alto;
        }

        // CalcularPerimetro devuelve el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (ancho + alto);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Circulo con radio 5
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

            // Crear un objeto de tipo Rectangulo con ancho 4 y alto 6
            Rectangulo miRectangulo = new Rectangulo(4, 6);
            Console.WriteLine("Área del rectángulo: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.CalcularPerimetro());
        }
    }
}

