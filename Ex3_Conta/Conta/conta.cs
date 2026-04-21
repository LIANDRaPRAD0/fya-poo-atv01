using System;

public class Conta
{
    // Atributos privados
    private readonly int numeroConta; // nunca muda
    private string titular;
    private double saldo;
    private double limite;

    // Propriedades
    public int NumeroConta
    {
        get { return numeroConta; }
    }

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public double Saldo
    {
        get { return saldo; }
    }

    public double Limite
    {
        get { return limite; }
    }

    public double SaldoTotal
    {
        get { return saldo + limite; }
    }
 
    public string StatusConta
    {
        get { return saldo < 0 ? "Negativo" : "Positivo"; }
    }

    // Construtor
    public Conta(int numeroConta, string titular)
    {
        this.numeroConta = numeroConta;
        this.titular = titular;
        this.saldo = 0;
        this.limite = 500;
    }

    // Depositar
    public bool Depositar(double valor)
    {
        if (valor <= 0)
        {
            return false;
        }

        saldo += valor;
        return true;
    }

    // Sacar
    public bool Sacar(double valor)
    {
        if (valor <= 0)
        {
            return false;
        }

        if (valor <= SaldoTotal)
        {
            saldo -= valor;
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"Conta: {numeroConta} | Titular: {titular} | Saldo: {saldo:F2} | Limite: {limite:F2}";
    }
}