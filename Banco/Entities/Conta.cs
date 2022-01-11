using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Conta
    {
        public Conta(string nome, string numero, string senha) 
        {   
            this.NomeTitular = nome;
            this.Numero = numero;
            this.Saldo = 0;
            this.Senha = senha;
        }

        public string NomeTitular { get; set; }
        public string Numero { get; private set; }
        public double Saldo { get; private set; }
        private string Senha { get; set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
            System.Console.WriteLine("Valor depositado com sucesso");

        }

        public bool Sacar(double valor)
        {
            if(this.Saldo >= valor){
                this.Saldo -= valor; 

                return true;    
            }
            
            return false;
        }

        public void Transferencia(double valor, Conta destino)
        {
            if(Sacar(valor)){    
                destino.Depositar(valor);
                System.Console.WriteLine("Transferencia efetuada com sucesso!");
            }
            else{
                System.Console.WriteLine("Saldo insuficiente para realizar a transferencia");
            }
        }

        public void ConsultarCliente()
        {
            System.Console.WriteLine("Nome:" + this.NomeTitular);
            System.Console.WriteLine("Numero da conta:" + this.Numero);
            System.Console.WriteLine("Saldo:" + this.Saldo);
        }

        
    }
}