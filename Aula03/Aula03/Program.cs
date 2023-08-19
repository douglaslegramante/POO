﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente cliente = new Cliente();

            //CartaoDeCredito cartao = new CartaoDeCredito();
            //cartao.numero = 123;
            //cartao.dataDeValidade = "21/11/2021";
            //cartao.cliente = cliente;
            //cartao.cliente.nome = "Ana Paula";

            //Console.WriteLine(cliente.nome);
            //Console.WriteLine(cartao.cliente.nome);


            // Criando um objeto de cada classe
            Cliente c = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito();
            Conta ct = new Conta();
            Agencia ag = new Agencia();
            Endereco end = new Endereco();

            // Acessando os atributos
            c.nome = "Rafael Duarte";
            c.codigo = 123;
            cdc.numero = 111111;
            cdc.dataDeValidade = "12/12/18";
            ct.numero = 45678;
            ct.saldo = 500;
            ct.limite = 100;
            ag.numero = 1825;
            end.logradouro = "Avenida Paraná";
            end.numero = 2345;
            end.bairro = "Centro";

            Console.WriteLine("Dados do cliente");
            Console.WriteLine("Nome: " + c.nome);
            Console.WriteLine("Código: " + c.codigo);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados do cartão");
            Console.WriteLine("Número: " + cdc.numero);
            Console.WriteLine("Data de validade: " + cdc.dataDeValidade);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados da conta");
            Console.WriteLine("Número: " + ct.numero);
            Console.WriteLine("Saldo: " + ct.saldo);
            Console.WriteLine("Limite: " + ct.limite);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados da agencia");
            Console.WriteLine("Número: " + ag.numero);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados do endereço");
            Console.WriteLine("Logradouro: " + end.logradouro);
            Console.WriteLine("Número: " + end.numero);
            Console.WriteLine("Bairro: " + end.bairro);

            Console.WriteLine(" ----------------------------------------");

            // Ligando os objetos
            cdc.cliente = c;
            ct.agencia = ag;
            end.cliente = c;

            Console.WriteLine("Dados do cliente obtidos através do cartão");
            Console.WriteLine("Nome do cliente: " + cdc.cliente.nome);
            Console.WriteLine("Código do cliente: " + cdc.cliente.codigo);
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("Dados da agencia obtidos através da conta");
            Console.WriteLine("Número da agencia: " + ct.agencia.numero);
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("Dados do cliente obtidos através do endereço");
            Console.WriteLine("Código do cliente: " + end.cliente.codigo);
            Console.WriteLine("Nome do cliente: " + end.cliente.nome);

            Console.WriteLine(" ----------------------------------------\n");
            // Referência de um objeto
            Conta contaMaria = new Conta();
            contaMaria.numero = 23456;
            contaMaria.saldo = 500;
            contaMaria.limite = 1000;


            // Chamando o método Depositar ()
            contaMaria.Depositar(250);
            contaMaria.Sacar(300);
            

            // Armazenando a resposta de um método em uma variável
            decimal saldoDisponivel = contaMaria.ConsultarSaldo();
            contaMaria.ImprimeExtrato();
            Console.WriteLine("Saldo Disponível: " + saldoDisponivel.ToString("c2"));

            Console.ReadKey();
        }
    }
}
