class Program
{
    static void Main()
    {
        Conta conta = new Conta(123, "Liandra");

        conta.Depositar(200);
        Console.WriteLine(conta);

        conta.Sacar(300); 
        Console.WriteLine(conta);

        Console.WriteLine($"Saldo Total: {conta.SaldoTotal}");
        Console.WriteLine($"Status: {conta.StatusConta}");

        conta.Titular = "Liandra Prado"; 
        Console.WriteLine(conta);
    }
}