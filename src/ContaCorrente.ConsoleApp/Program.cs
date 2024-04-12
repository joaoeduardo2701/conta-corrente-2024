namespace ContaCorrente.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        ContaCorrente Chay = new ContaCorrente("Chay", "Chata", "666.666.666-66", 50.00, 10.00, "3891", "Física");
        ContaCorrente DuduLindo = new ContaCorrente("Dudu", "Lindo", "123.456.789-00", 2000.00, 500.00, "3789", "Física");

        Console.WriteLine("-- Dados Chay --");
        Console.WriteLine(Chay);

        // Operação de saque Chay
        double valorChaySaque = 20;

        if (Chay.Sacar(valorChaySaque))
        {
            Chay.Sacar(valorChaySaque);
            Console.WriteLine(Chay);
        }

        Console.WriteLine("-- Dados Dudu Lindo --");
        Console.WriteLine(DuduLindo);

        // Operação de saque Dudu
        double valorDuduSaque = 500.00;

        if (Chay.Sacar(valorDuduSaque))
        {
            Chay.Sacar(valorDuduSaque);
            Console.WriteLine(DuduLindo);
        }

        // Mostrar saldo da Chay
        double saldo = Chay.VerSaldo();
        Console.WriteLine(saldo.ToString("F2"));

        // Transferência Chay -> Dudu Lindo
        double valorTransferencia = 10.00;

        if (Chay.Transferir(valorTransferencia))
        {

        }
        Chay.Transferir(500.00);
    }
}