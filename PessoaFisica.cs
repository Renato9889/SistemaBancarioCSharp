using Banco;

namespace Banco{
    public class PessoaFisica:Cliente{
        private string CPF;

        public PessoaFisica():base(){

        }
        public PessoaFisica(string nome, string dataNascimento, string cep, string telefone,Conta conta, string cpf):this()
        {
            NomeCompleto = nome;
            DataNascimento = dataNascimento;
            Cep = cep;
            Telefone = telefone;
            CPF = cpf;
            contaCliente = conta;
        }
        public string get(){
            return CPF;
        }
        public override void imprimir(){
            Console.WriteLine("-----------Dados do cliente - Pessoa Fisica-------------");
            Console.WriteLine($"Cliente: {NomeCompleto}");
            Console.WriteLine($"Data de nascimento: {DataNascimento}");
            Console.WriteLine($"CEP: {Cep}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Numero da Conta: {contaCliente.NumeroConta}");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}