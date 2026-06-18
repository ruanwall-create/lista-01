Console.Write("Informe a quantidade de clientes atendidos: ");
int quantidade = int.Parse(Console.ReadLine()!);

int tempoTotal = 0;

for (int i = 1; i <= quantidade; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    int tempo = int.Parse(Console.ReadLine()!);

    tempoTotal += tempo;
}

int media = tempoTotal / quantidade;

Console.WriteLine($"Tempo total de atendimento: {tempoTotal} minutos");
Console.WriteLine($"Tempo médio por cliente: {media} minutos");