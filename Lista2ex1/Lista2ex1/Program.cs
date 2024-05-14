using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        if (valor1 > valor2)
        {
            Console.Write("O maior valor é: " + valor1);
        }
        else if (valor2 > valor1)
        {
            Console.Write("O maior valor é: " + valor2);
        }
        else
        {
            Console.WriteLine("Os valores são iguais.");
        }
    }
}
