class Program
{
    static void Main()
    {
        Cofre cofre = new Cofre("Liandra", "1234");

        Console.WriteLine(cofre.Abrir("1111"));
        Console.WriteLine(cofre.Abrir("2222"));
        Console.WriteLine(cofre.Abrir("3333"));
        Console.WriteLine(cofre.Abrir("1234")); // bloqueado

        Console.WriteLine(cofre);

        cofre.ResetarCofre(); // opcional
        Console.WriteLine(cofre.Abrir("1234")); // agora abre

        Console.WriteLine(cofre.AlterarSenha("1234", "9999"));
        Console.WriteLine(cofre);
    }
}