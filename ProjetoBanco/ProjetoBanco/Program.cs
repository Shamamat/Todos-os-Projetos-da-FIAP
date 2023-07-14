namespace ProjetoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCC = new ContaCorrente();
            contaCC.depositar(1000);
            contaCC.Sacar(500);
            Console.WriteLine("Saldo Conta Corrente: " + contaCC.exibeSaldo());

            ContaPoupança cp = new ContaPoupança();
            cp.depositar(1000);
            cp.sacar(500);

            ControladorDeExtratos ce = new ControladorDeExtratos();
            ce.GeradorExtratos(cc);
            ce.GeradorExtratos(cp);

        }
    }
}