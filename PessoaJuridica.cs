using Banco;

namespace Banco{
    public class PessoaJuridica:Cliente{
        private string CNPJ;

        public PessoaJuridica():base(){

        }
        public PessoaJuridica(string nome, string dataNascimento, string cep, string telefone, string cnpj, Conta conta):this()
        {
            NomeCompleto = nome;
            DataNascimento = dataNascimento;
            Cep = cep;
            Telefone = telefone;
            CNPJ = cnpj;
            contaCliente = conta;
        }
        public string get(){
            return CNPJ;
        }
        public override void imprimir(){
            Console.WriteLine("-----------Dados do cliente - Pessoa Juridica-------------");
            Console.WriteLine($"Cliente: {NomeCompleto}");
            Console.WriteLine($"Data de nascimento: {DataNascimento}");
            Console.WriteLine($"CEP: {Cep}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}