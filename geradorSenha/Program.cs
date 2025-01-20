
Console.WriteLine("Criador de senha ");

Console.WriteLine("Insira a quantidade de caracteres que deseja em sua senha: (Ps: Máximo 10 e minimo 4)");
if (int.TryParse(Console.ReadLine(), out int caracteres)) ;
{
    Console.WriteLine("Você deseja adicionar números na sua senha?");
    string numeros = Console.ReadLine();

    Console.WriteLine("Você deseja inserir letras na senha?");
    string letras = Console.ReadLine();

    Console.WriteLine("Você deseja adicionar caracteres especiais?(Ex: @, !, # ou -)");
    string especiais = Console.ReadLine();

    Random random = new Random();

    if (caracteres <= 4)
    {
        Console.WriteLine("Não é possivel criar a sua senha (ERRO).");
    }
    if (caracteres >= 10)
    {
        Console.WriteLine("Não é possivel criar a sua senha (ERRO).");
    }
}
