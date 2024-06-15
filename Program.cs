// See https://aka.ms/new-console-template for more information
using exercicio_formasGeometricas;
using System;
using System.Diagnostics;

Retangulo retangulo1 = new Retangulo( 0, 0, 0);
Circulo circulo1 = new Circulo(0, 0);
Triangulo triangulo1 = new Triangulo(0, 0, 0);

int opcao;
Console.WriteLine("O que você deseja calcular? (Retângulo = 1, Círculo = 2, Triângulo = 3)");
opcao = Convert.ToInt32(Console.ReadLine());

switch(opcao)
{
    case 1:
        Console.WriteLine("Vamos calcular a área de um retângulo: ");
        retangulo1.CalcularArea();
        break;
    case 2:
        Console.WriteLine("Vamos calcular a área de um círculo: ");
        circulo1.CalcularArea();
        break;
    case 3:
        Console.WriteLine("Vamos calcular a área de um triângulo: ");
        triangulo1.CalcularArea();
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
