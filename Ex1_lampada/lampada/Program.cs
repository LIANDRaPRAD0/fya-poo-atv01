class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada("Philips", "LED");

        Console.WriteLine(lampada);

        lampada.Alternar(); // liga
        lampada.AjustarBrilho(70);

        Console.WriteLine(lampada);

        lampada.Alternar(); // desliga
        Console.WriteLine(lampada);

        lampada.Alternar(); // liga de novo (mantém brilho)
        Console.WriteLine(lampada);
    }
}
