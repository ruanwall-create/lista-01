Console.Write("Informe o saldo inicial: ");
decimal saldo = decimal.Parse(Console.ReadLine()!);

int opcao;

do
{
    Console.WriteLine("Escolha a operação:");
    opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 1)
    {
        Console.Write("Informe o valor da movimentação: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);

        saldo += valor;
        Console.WriteLine($"Entrada registrada. Saldo atual: R$ {saldo}");
    }
    else if (opcao == 2)
    {
        Console.Write("Informe o valor da movimentação: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);

        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saída registrada. Saldo atual: R$ {saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

} while (opcao != 3);

Console.WriteLine($"Saldo final: R$ {saldo}");