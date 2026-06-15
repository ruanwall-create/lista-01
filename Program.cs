Console.Write("Informe a quantidade de tarefas concluídas: ");
int tarefasConcluidas = int.Parse(Console.ReadLine());

if (tarefasConcluidas >= 50)
{
    Console.WriteLine("Meta atingida.");
    Console.WriteLine($"Tarefas concluídas: {tarefasConcluidas}");
}
else
{
    int faltaram = 50 - tarefasConcluidas;

    Console.WriteLine("Meta não atingida.");
    Console.WriteLine($"Faltaram {faltaram} tarefas.");
}