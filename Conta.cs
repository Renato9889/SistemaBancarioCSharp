using Banco;

namespace Banco{
    public class Conta{
        public string NumeroConta;
        private DateTime DataCriacao;
        private string CodigoBanco;
        private float Saldo;
        private int Tipo;
        public Conta(string numero, string banco, float saldo, int tipo){
            NumeroConta = numero;
            DateTime data = DateTime.Today;
            DataCriacao = data;
            CodigoBanco = banco;
            Saldo = saldo;
            Tipo = tipo;
        }

        public void ContaCorrente(){
            Saldo = ((float)(Saldo - 0.001));
        }
        public void ContaPopança(){
            Saldo = ((float)(Saldo + 0.003));
        }
        public void depositar(float valor){
            Saldo = Saldo + valor;
        }
        public void sacar(float valor){
            Saldo = Saldo - valor;
        }
        public void extrato(){
            Console.WriteLine("--------------EXTRATO-------------");
            Console.WriteLine($"Conta: {NumeroConta}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine("----------------------------------");
        }
    }
}