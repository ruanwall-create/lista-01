using System.Globalization;

Console.Write("Informe o valor total da compra: ");
decimal valorCompra = decimal.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

decimal desconto = 0;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.10m;
}

decimal valorFinal = valorCompra - desconto;

Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
Console.WriteLine($"Desconto aplicado: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");