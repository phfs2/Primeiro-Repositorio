// See https://aka.ms/new-console-template for more information
using System;
using Banco.Entities;

namespace Banco{

    class program{

        static void Main(){
            
            Conta c = new Conta("Pablo Henrique", "1.234.567", "nova");

            Conta n = new Conta("Letíca Miranda", "9.876.543", "antiga");

            c.Depositar(1000);
            n.Depositar(2000);

            c.Sacar(3000);
            c.Sacar(250);

            n.Transferencia(750, c);

            c.ConsultarCliente();
            n.ConsultarCliente();

        }

    }
}


