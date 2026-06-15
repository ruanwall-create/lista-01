Console.Write("Informe o primeiro número: ");
int primeiroNumero = int.Parse(Console.ReadLine()!);

Console.Write("Informe o segundo número: ");
int segundoNumero = int.Parse(Console.ReadLine()!);

if (primeiroNumero > segundoNumero)
{
    Console.WriteLine("O primeiro número é maior.");
}
else if (segundoNumero > primeiroNumero)
{
    Console.WriteLine("O segundo número é maior.");
}
else

    Console.WriteLine("Os números são iguais.");