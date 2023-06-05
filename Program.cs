// See https://aka.ms/new-console-template for more information
using System;
using Banco;
Conta um = new Conta("001", "007", 7000, 1);
Cliente primeiro = new PessoaFisica("Renato","21/12/1998","1111-11","(44)4444-4444",um,"66666666-66");
Conta dois = new Conta("001", "007", 10000, 1);
Cliente segundo= new PessoaFisica("Paulo","12/09/1999","1111-11","(44)4444-4444",um,"66666666-66");
Console.WriteLine("~~~~~~~~~~ Bem vindes ao Sitema do Banco RP ~~~~~~~~~~");
int log = 1;
int id = 0;
while(log!=0){
    List<Cliente> contas = new List<Cliente>(){primeiro,segundo};
    Console.WriteLine("Selecione uma opção: ");
    Console.WriteLine("[1] Criar uma Conta");
    Console.WriteLine("[2] Consultar uma Conta");
    Console.WriteLine("[3] Sair");
    string opcao = Console.ReadLine();

    switch(opcao){
        case "1":
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("[1] Pessoa Fisica");
            Console.WriteLine("[2] Pessoa Juridica");
            string opcao2 = Console.ReadLine();
            switch(opcao2){
                case "1":
                    Console.WriteLine("Digite o nome completo: ");
                    string nomeCliente = Console.ReadLine();
                    Console.WriteLine("Digite sua data de Nascimento: ");
                    string nasc = Console.ReadLine();
                    Console.WriteLine("Digite seu CEP: ");
                    string cepp = Console.ReadLine();
                    Console.WriteLine("Digite seu Telefone: ");
                    string tel = Console.ReadLine();
                    Console.WriteLine("Digite seu CPF: ");
                    string cpff = Console.ReadLine();
                    Console.WriteLine("Digite o valor que quer depositar para criar a conta: ");
                    string valorstring = Console.ReadLine();
                    float valor = global::System.Single.Parse(valorstring);
                    Console.WriteLine("Escolha o tipo de conta: ");
                    Console.WriteLine("[1] Conta Corrente");
                    Console.WriteLine("[2] Conta Poupança");
                    string opcaoconta = Console.ReadLine();
                    if(opcaoconta == "1"){
                        string contacod = "00" + id;
                        Conta contaaux = new Conta(contacod, "007", valor, 1);
                        Cliente clienteaux = new PessoaFisica(nomeCliente,nasc,cepp,tel,contaaux,cpff);
                        contas.Add(clienteaux);
                    }else{
                        if(opcaoconta == "2"){
                            string contacod = "00" + id;
                            Conta contaaux = new Conta(contacod, "007", valor, 2);
                            Cliente clienteaux = new PessoaFisica(nomeCliente,nasc,cepp,tel,contaaux,cpff);
                            contas.Add(clienteaux);
                        }else{
                            string contacod = "00" + id;
                            Conta contaaux = new Conta(contacod, "007", valor, 1);
                            Cliente clienteaux = new PessoaFisica(nomeCliente,nasc,cepp,tel,contaaux,cpff);
                            contas.Add(clienteaux);
                        }
                    }
                    Console.WriteLine("CONTA CRIADA COM SUCESSO");
                    id = id + 1;
                    break;
                case "2":
                    Console.WriteLine("Digite o nome completo: ");
                    string nomeCliente2 = Console.ReadLine();
                    Console.WriteLine("Digite sua data de Nascimento: ");
                    string nasc2 = Console.ReadLine();
                    Console.WriteLine("Digite seu CEP: ");
                    string cepp2 = Console.ReadLine();
                    Console.WriteLine("Digite seu Telefone: ");
                    string tel2 = Console.ReadLine();
                    Console.WriteLine("Digite seu CNPJ: ");
                    string cnpjj = Console.ReadLine();
                    Console.WriteLine("Digite o valor que quer depositar para criar a conta: ");
                    string valorstring2 = Console.ReadLine();
                    float valor2 = global::System.Single.Parse(valorstring2);
                    Console.WriteLine("Escolha o tipo de conta: ");
                    Console.WriteLine("[1] Conta Corrente");
                    Console.WriteLine("[2] Conta Poupança");
                    string opcaoconta2 = Console.ReadLine();
                    if(opcaoconta2 == "1"){
                        string contacod2 = "00" + id;
                        Conta contaaux2 = new Conta(contacod2, "007", valor2, 1);
                        Cliente clienteaux2 = new PessoaFisica(nomeCliente2,nasc2,cepp2,tel2,contaaux2,cnpjj);
                        contas.Add(clienteaux2);
                    }else{
                        if(opcaoconta2 == "2"){
                            string contacod2 = "00" + id;
                            Conta contaaux2 = new Conta(contacod2, "007", valor2, 2);
                            Cliente clienteaux2 = new PessoaFisica(nomeCliente2,nasc2,cepp2,tel2,contaaux2,cnpjj);
                            contas.Add(clienteaux2);
                        }else{
                            string contacod2 = "00" + id;
                            Conta contaaux2 = new Conta(contacod2, "007", valor2, 1);
                            Cliente clienteaux2= new PessoaFisica(nomeCliente2,nasc2,cepp2,tel2,contaaux2,cnpjj);
                            contas.Add(clienteaux2);
                        }
                    }
                    Console.WriteLine("CONTA CRIADA COM SUCESSO");
                    id = id + 1;
                    break;
            }
            break;
        case "2":
            Console.WriteLine("Digite o numero da conta para fazer a consulta: ");
            string numerodaconta = Console.ReadLine();
            int x = Int32.Parse(numerodaconta);
            Console.WriteLine(x);
            Cliente aux = contas[x+1];
            aux.imprimir();
            int status = 1;
            while(status != 0){
                Console.WriteLine("Deseja fazer uma operação?");
                Console.WriteLine("[1] SIM");
                Console.WriteLine("[2] NÃO");
                string opcao3 = Console.ReadLine();
                if(opcao3 == "1"){
                    Console.WriteLine("Qual Operação você quer fazer?");
                    Console.WriteLine("[1] DEPOSITO");
                    Console.WriteLine("[2] SAQUE");
                    Console.WriteLine("[3] EXTRATO");
                    string opcao5 = Console.ReadLine();
                    switch(opcao5){
                        case "1":
                            Console.WriteLine("Digite o Valor para ser depositado:");
                            string valordeposito = Console.ReadLine();
                            float valor = global::System.Single.Parse(valordeposito);
                            aux.contaCliente.depositar(valor);
                            break;
                        case "2":
                            Console.WriteLine("Digite o Valor para ser sacado:");
                            string valorsaque = Console.ReadLine();
                            float valors = global::System.Single.Parse(valorsaque);
                            aux.contaCliente.sacar(valors);
                            break;
                        case "3":
                            aux.contaCliente.extrato();
                            break;
                        default:
                            Console.WriteLine("VAlor invalido!!!");
                            break;
                    }
                }else{
                    Console.WriteLine("DESEJA SAIR?");
                    Console.WriteLine("[1] SIM");
                    Console.WriteLine("[2] NÃO");
                    string opcao4 = Console.ReadLine();
                    if(opcao4 == "1"){
                        status = 0;
                    }
                }
            }
            break;
        case "3":
            log = 0;
            break;    
        default:
            Console.WriteLine("VAlor invalido!!!");
            break;
    }

}
