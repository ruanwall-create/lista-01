Console.Write("Informe a quantidade inicial em estoque: ");
int estoque = int.Parse(Console.ReadLine()!);

int opcao;

do
{
    Console.WriteLine("Escolha a operação:");
    opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 1)
    {
        Console.Write("Informe a quantidade movimentada: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        estoque += quantidade;
        Console.WriteLine($"Entrada registrada. Estoque atual: {estoque}");
    }
    else if (opcao == 2)
    {
        Console.Write("Informe a quantidade movimentada: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        if (quantidade <= estoque)
        {
            estoque -= quantidade;
            Console.WriteLine($"Saída registrada. Estoque atual: {estoque}");
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
    }
    else if (opcao == 3)
    {
        Console.WriteLine($"Estoque atual: {estoque}");
    }

} while (opcao != 4);

Console.WriteLine($"Estoque final: {estoque}");