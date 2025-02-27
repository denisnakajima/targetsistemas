using System;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    class Faturamento
    {
        public double[] valores { get; set; }
    }

    static void Main()
    {
        string json = File.ReadAllText("faturamento.json");
        var faturamento = JsonSerializer.Deserialize<Faturamento>(json);

        var valoresValidos = faturamento.valores.Where(v => v > 0).ToArray();
        double media = valoresValidos.Average();

        Console.WriteLine($"Menor faturamento: {valoresValidos.Min():C2}");
        Console.WriteLine($"Maior faturamento: {valoresValidos.Max():C2}");
        Console.WriteLine($"Dias acima da média: {valoresValidos.Count(v => v > media)}");
    }
}