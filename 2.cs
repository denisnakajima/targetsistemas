using System;

class Program
{
    static bool PertenceFibonacci(int numero)
    {
        int a = 0, b = 1, temp;

        while (a < numero)
        {
            temp = a;
            a = b;
            b = temp + b;
        }

        return a == numero;
    }

    static void Main()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
    }
}