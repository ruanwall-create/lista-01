Console.Write("Informe a primeira pontuação: ");
int pontuacao1 = int.Parse(Console.ReadLine()!);

Console.Write("Informe a segunda pontuação: ");
int pontuacao2 = int.Parse(Console.ReadLine()!);

Console.Write("Informe a terceira pontuação: ");
int pontuacao3 = int.Parse(Console.ReadLine()!);

if (pontuacao1 == pontuacao2 && pontuacao2 == pontuacao3)
{
    Console.WriteLine("As três pontuações são iguais.");
}
else
{}
    int maiorPontuacao = pontuacao1;

    if (pontuacao2 > maiorPontuacao)
    {
        maiorPontuacao = pontuacao2;
    }

    if (pontuacao3 > maiorPontuacao)
    {
        maiorPontuacao = pontuacao3;
    }

    Console.WriteLine($"Maior pontuação: {maiorPontuacao}");