

    Console.Write("Informe a nota final: ");
    if (double.TryParse(Console.ReadLine(), out double notaFinal))
{

        if (notaFinal >= 7)
        {
            Console.WriteLine("Estudante aprovado.");
        }
        else if (notaFinal >= 5)
        {
            Console.WriteLine("Estudante em recuperação.");
        }
        else
        {
            Console.WriteLine("Estudante reprovado.");
        }
       
}
