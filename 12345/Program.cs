using System;

namespace _12345
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uma escola te contratou para desenvolver um aplicativo que realize a média das notas de alunos de uma sala,
            // lembrando que atualmente a sala tem apenas 5 alunos e a nota vai de 0 a 10. 

            Console.WriteLine("Media de alunos");

            float soma = 0;
            float media = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a b nota do aluno " + i + ";");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota);
                soma += nota;

            }

            media = soma / 5;
            Console.WriteLine("Média é igual a: " + media);

        }
    }
}
