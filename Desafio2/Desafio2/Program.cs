using System;

class Desafio2
{
    static void Main()
    {
        Console.Write("Digite o texto: ");
        string texto = Console.ReadLine();


        int cont = 0;

        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                cont++;
            }
        }

        if (cont > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {cont} vez(es) no texto inserido.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece no texto inserido.");
        }
    }

}