namespace ContaCorrente.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        ContaCorrente p1 = new ContaCorrente("Chay", "Chata", "666.666.666-66", 50.00, 10.00, "3891", "Física");
        ContaCorrente p2 = new ContaCorrente("Dudu", "Lindo", "123.456.789-00", 2000.00, 500.00, "3789", "Física");
        
        Console.WriteLine("-- Dados Pessoa 1 --");
        Console.WriteLine(p1);

        // Operação de saque p1
        double valorChaySaque = 20;

        if (p1.Sacar(valorChaySaque))
        {
            p1.Sacar(valorChaySaque);
            Console.WriteLine(p1);
        }

        Console.WriteLine("-- Dados Pessoa 2 --");
        Console.WriteLine(p2);

        // Operação de saque Pessoa 1
        double valorDuduSaque = 500.00;

        if (p1.Sacar(valorDuduSaque))
        {
            p1.Sacar(valorDuduSaque);
            Console.WriteLine(p2);
        }

        // Mostrar saldo da Pessoa 1
        // double saldo = p1.VerSaldo();
        // Console.WriteLine(saldo.ToString("F2"));

        // Transferência Pessoa 1 -> Pessoa 2
        double valorTransferencia = 10.00;

        p1.Transferir(valorTransferencia, p2);

        // Mostrar Extrato

        p1.Depositar(200);

        Movimentacao[] movimentacoes = p1.Extrato();

        for (int i = 0; i < movimentacoes.Length; i++)
        {
            Movimentacao movimentacao = movimentacoes[i];

            if (movimentacao == null)
            {
                break;
            }
            
            Console.WriteLine($"{i + 1}ª Transação: {movimentacao.TipoTransferencia} R${movimentacao.Valor.ToString("F2")}");
        }

        Console.ReadKey();
    }
}
