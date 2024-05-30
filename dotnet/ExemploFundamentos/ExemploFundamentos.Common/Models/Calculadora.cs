namespace ExemploFundamentos.Common.Models;

public class Calculadora
{
    public void Somar(int x, int y)
    {
        Console.WriteLine($"A soma de {x} + {y} = {x + y}");
    }
    public void Subtrair(int x, int y)
    {
        Console.WriteLine($"A Subtração de {x} por {y} = {x - y}");
    }
    public void Multiplicar(int x, int y)
    {
        Console.WriteLine($"A Multiplicação de {x} por {y} = {x * y}");
    }
    public void Dividir(int x, int y)
    {
        Console.WriteLine($"A Divisão de {x} por {y} = {x / y}");
    }
    public void Modulo(int x, int y)
    {
        Console.WriteLine($"O Resto da divisão de {x} por {y} = {x % y}");
    }
    public void Potencia(int x, int y)
    {
        double pot = Math.Pow(x, y);
        Console.WriteLine($"A potencia de {x} por {y} = {pot}");
    }
    public void Seno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double seno = Math.Round(Math.Sin(radiano), 4);
        Console.WriteLine($"Seno de {angulo} = {seno}");
    }
    public void Coseno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double coseno = Math.Round(Math.Cos(radiano), 4);
        Console.WriteLine($"Coseno de {angulo} = {coseno}");
    }
    public void Tangente(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double tangente = Math.Round(Math.Tan(radiano), 4);
        Console.WriteLine($"Tangente de {angulo} = {tangente}");
    }

    public void RaizQuadrada(double x)
    {
        double raiz = Math.Sqrt(x);
        Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
    }
}