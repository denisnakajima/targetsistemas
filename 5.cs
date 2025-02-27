using System;

class Program
{
    static string InverterString(string input)
    {
        char[] invertida = new char[input.Length];

        for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
        {
            invertida[i] = input[j];
        }

        return new string(invertida);
    }

    static void Main()
    {
        Console.Write("Digite uma string para inverter: ");
        string entrada = Console.ReadLine();

        Console.WriteLine("String invertida: " + InverterString(entrada));
    }
}