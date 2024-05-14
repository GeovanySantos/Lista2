using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro valor: ");
        string input1 = Console.ReadLine();
        double valor1;
        while (!double.TryParse(input1, out valor1))
        {
            Console.Write("Entrada inválida. Por favor, digite um número válido: ");
            input1 = Console.ReadLine();
        }

        Console.Write("Digite o segundo valor: ");
        string input2 = Console.ReadLine();
        double valor2;
        while (!double.TryParse(input2, out valor2))
        {
            Console.Write("Entrada inválida. Por favor, digite um número válido: ");
            input2 = Console.ReadLine();
        }

        if (valor1 > valor2)
        {
            Console.Write("O maior valor é: " + valor1);
        }
        else if (valor2 > valor1)
        {
            Console.WriteLine("O maior valor é: " + valor2);
        }
        else
        {
            Console.WriteLine("Os valores são idênticos.");
        }
    }
}
