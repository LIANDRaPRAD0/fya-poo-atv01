using System;

public class Personagem
{
    private string nome;
    private readonly string classe;
    private int nivel;
    private double vidaAtual;
    private double vidaMaxima;

    // Propriedades
    public string Nome
    {
        get { return nome; }
    }

    public string Classe
    {
        get { return classe; }
    }

    public int Nivel
    {
        get { return nivel; }
    }

    public double VidaAtual
    {
        get { return vidaAtual; }
    }

    public double VidaMaxima
    {
        get { return vidaMaxima; }
    }

    public bool EstaVivo
    {
        get { return vidaAtual > 0; }
    }

    // Construtor
    public Personagem(string nome, string classe)
    {
        this.nome = nome;
        this.classe = classe;
        this.nivel = 1;

        if (classe.ToLower() == "guerreiro")
        {
            vidaMaxima = 150;
        }
        else if (classe.ToLower() == "mago")
        {
            vidaMaxima = 80;
        }
        else
        {
            throw new Exception("Classe inválida!");
        }

        vidaAtual = vidaMaxima;
    }

    // Receber dano
    public void ReceberDano(double pontos)
    {
        if (!EstaVivo) return;

        vidaAtual -= pontos;

        if (vidaAtual < 0)
        {
            vidaAtual = 0;
        }
    }

    // Curar
    public void Curar(double pontos)
    {
        if (!EstaVivo) return;

        vidaAtual += pontos;

        if (vidaAtual > vidaMaxima)
        {
            vidaAtual = vidaMaxima;
        }
    }

    // Subir nível
    public void SubirNivel()
    {
        if (!EstaVivo) return;

        if (nivel < 99)
        {
            nivel++;

            vidaMaxima += vidaMaxima * 0.10; // +10%
            vidaAtual = vidaMaxima; 
        }
    }

    // Método de ressuscitar
    public void Ressuscitar()
    {
        if (EstaVivo) return;

        vidaAtual = vidaMaxima;
    }

    public override string ToString()
    {
        return $"{nome} ({classe}) - Lvl {nivel} - HP: {vidaAtual:F0}/{vidaMaxima:F0}";
    }
}