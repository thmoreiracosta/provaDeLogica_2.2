using System;
using System.Globalization;

namespace provaDeLogica_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 2.2:
            // Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (ax² + bx + c = 0)
            // Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja 
            // abaixo). Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser 
            // negativo), mostrar uma mensagem "Impossivel calcular". 
            
            // Fórmula Baskara: x = -b+ou-raizdelta / 2*a, onde delta é: b² - 4*a*c.

            double a, b, c, x1, x2, delta;

            
            Console.WriteLine("Entre com os coeficientes da equação (a, b, c) respectivamente: ");
            
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (delta < 0.0 || a == 0.0) {
                Console.WriteLine("Impossível Calcular");
            } else if (delta == 0.0) {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 e X2 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
            } else {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }     
        }
    }
}