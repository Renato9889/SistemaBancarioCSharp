using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;

namespace Banco{
    public class Cliente{
        public string NomeCompleto;
        public string DataNascimento;
        public string Cep;
        public string Telefone;

        public Conta contaCliente;

        public Cliente(){
            
        }
        public Cliente(string nome, string dataNascimento, string cep, string telefone, Conta conta){
            NomeCompleto = nome;
            DataNascimento = dataNascimento;
            Cep = cep;
            Telefone = telefone;
            contaCliente = conta;
        }
        public virtual void imprimir(){
            Console.WriteLine("-----------Dados do cliente-------------");
            Console.WriteLine($"Cliente: {NomeCompleto}!");
            Console.WriteLine($"Data de nascimento: {DataNascimento}");
            Console.WriteLine($"CEP: {Cep}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}