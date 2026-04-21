using System;

public class Cofre
{
    // encapsulamento
    private string dono;
    private string senha;
    private bool estaAberto;
    private int tentativasErradas;

    public string Dono
    {
        get { return dono; }
    }

    public bool EstaAberto
    {
        get { return estaAberto; } // somente leitura
    }

    public int TentativasErradas
    {
        get { return tentativasErradas; }
    }

    // Construtor
    public Cofre(string dono, string senhaInicial)
    {
        this.dono = dono;
        this.senha = senhaInicial;
        this.estaAberto = false;
        this.tentativasErradas = 0;
    }

    // Método abrir
    public string Abrir(string senhaInformada)
    {
        if (tentativasErradas >= 3)
        {
            return "Cofre Bloqueado!";
        }

        if (senhaInformada == senha)
        {
            estaAberto = true;
            tentativasErradas = 0;
            return "Cofre aberto com sucesso!";
        }
        else
        {
            tentativasErradas++;
            return $"Senha incorreta! Tentativas: {tentativasErradas}";
        }
    }

    // Método fechar
    public void Fechar()
    {
        estaAberto = false;
    }

    // Alterar senha
    public string AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (!estaAberto)
        {
            return "O cofre precisa estar aberto para alterar a senha.";
        }

        if (senhaAntiga != senha)
        {
            return "Senha antiga incorreta.";
        }

        senha = novaSenha;
        return "Senha alterada com sucesso!";
    }

    // Método opcional 
    public void ResetarCofre()
    {
        tentativasErradas = 0;
    }

    public override string ToString()
    {
        return $"Dono: {dono} | Estado: {(estaAberto ? "Aberto" : "Fechado")} | Tentativas erradas: {tentativasErradas}";
    }
}