using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criador de senha");

        Console.WriteLine("Insira a quantidade de caracteres que deseja em sua senha: (Máximo 10 e mínimo 4)");
        if (int.TryParse(Console.ReadLine(), out int caracteres))
        {
            if (caracteres < 4 || caracteres > 10)
            {
                Console.WriteLine("Erro: O número de caracteres deve ser entre 4 e 10.");
                return;
            }

            Console.WriteLine("Você deseja adicionar números na sua senha? (sim/não)");
            string numeros = Console.ReadLine();

            Console.WriteLine("Você deseja adicionar letras na senha? (sim/não)");
            string letras = Console.ReadLine();

            Console.WriteLine("Você deseja adicionar caracteres especiais? (sim/não)");
            string especiais = Console.ReadLine();

            if (numeros != "sim" && letras != "sim" && especiais != "sim")
            {
                Console.WriteLine("Erro: Você deve escolher pelo menos uma opção.");
                return;
            }

            string senha = "";
            Random random = new Random();
        }
    }
}            