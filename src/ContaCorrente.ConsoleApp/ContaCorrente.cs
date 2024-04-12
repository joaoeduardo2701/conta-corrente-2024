namespace ContaCorrente.ConsoleApp;

internal class ContaCorrente
{
    public string NomePessoa;
    public string SobrenomePessoa;
    public string Cpf;
    /*
    public Cliente Nome;
    public Cliente Sobrenome;
    public Cliente Cpf;
    */
    public double Saldo;
    public double Limite;
    public string NumeroAgencia;
    public string TipoPessoa;
    //public double[] HistoricoMovimentacao = new double[20];

    public ContaCorrente(string nome, string sobrenome, string cpf, double saldo, double limite, string numeroAgencia, string tipoPessoa)
    {
        NomePessoa = nome;
        SobrenomePessoa = sobrenome;
        Cpf = cpf;
        Saldo = saldo;
        Limite = limite;
        NumeroAgencia = numeroAgencia;
        TipoPessoa = tipoPessoa;
    }

    public void Depositar(double valorDeposito)
    {
        Saldo += valorDeposito;
    }

    public bool Sacar(double valorSaque)
    {
        if (valorSaque < Limite + Saldo)
        {
            Saldo -= valorSaque;
            return true;
        }
        else
        {
            return false;
        }
    }

    public double VerSaldo()
    {
        return Saldo;
    }

    public bool Transferir(double valorTransferir)
    {
        if (valorTransferir < Limite + Saldo)
        {
            Saldo -= valorTransferir;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Extrato()
    {

    }

    public override string ToString()
    {
        return "Nome: " + NomePessoa + " " + SobrenomePessoa + "\n" +
            "CPF: " + Cpf + "\n" +
            "Saldo: " + "R$" + Saldo.ToString("F2") + "\n" +
            "Limite: " + "R$" + Limite.ToString("F2") + "\n" +
            "Número da Agência: " + NumeroAgencia + "\n" +
            "Tipo Pessoa: " + TipoPessoa + "\n";
    }


}