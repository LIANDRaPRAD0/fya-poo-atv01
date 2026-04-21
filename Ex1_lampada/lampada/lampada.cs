using System;

public class Lampada
{
    
    private string marca;
    private readonly string tecnologia; 
        private bool ligada;
    private int brilho;

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Tecnologia
    {
        get { return tecnologia; } 
    }

    public bool Ligada
    {
        get { return ligada; }
    }

    public int Brilho
    {
        get { return brilho; }
    }

    // Construtor
    public Lampada(string marca, string tecnologia)
    {
        this.marca = marca;
        this.tecnologia = tecnologia;
        this.ligada = false; // inicia desligada
        this.brilho = 100;   // brilho padrão
    }

    // (liga/desliga)
    public void Alternar()
    {
        ligada = !ligada;
    }

    // Ajustar brilho
    public void AjustarBrilho(int novoBrilho)
    {
        if (!ligada)
        {
            Console.WriteLine("A lâmpada precisa estar ligada para ajustar o brilho.");
            return;
        }

        if (novoBrilho >= 0 && novoBrilho <= 100)
        {
            brilho = novoBrilho;
        }
        else
        {
            Console.WriteLine("Brilho deve estar entre 0 e 100.");
        }
    }

    public override string ToString()
    {
        return $"Marca: {marca} | Tecnologia: {tecnologia} | Estado: {(ligada ? "Ligada" : "Desligada")} | Brilho: {brilho}";
    }
}