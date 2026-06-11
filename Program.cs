Console.WriteLine("idade do visitante!");
int idade = int.Parse(Console.ReadLine());

if (idade < 16)
{
    Console.WriteLine("entrada permitida somente com respónsavel");
}
else
{
    Console.WriteLine("entrada liberada");
}