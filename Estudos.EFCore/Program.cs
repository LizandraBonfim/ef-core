using System;
using System.Linq;
using Estudos.EFCore.Data;
using Estudos.EFCore.Domain;
using Estudos.EFCore.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Estudos.EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Data.ApplicationContext();
            // db.Database.Migrate();

            //verificar se existe migracoes pendentes.
            // var existe = db.Database.GetPendingMigrations().Any();
            //
            // if(existe){}
            Console.WriteLine("Hello World!");

            InserirDadosEmMassa();
        }

        private static void InserirDados()
        {
            var produto = new Produto
            {
                Descricao = "Produto teste",
                CodigoDeBarras = "14526941",
                Valor = 10m,
                TipoProduto = TipoProduto.Embalagem,
                Ativo = true
            };
            
            using var db = new Data.ApplicationContext();
            //varias formas de add prodto ao BD.
            
            // db.Produtos.Add(produto);
            db.Set<Produto>().Add(produto);
            // db.Entry(produto).State = EntityState.Added;
            // db.Add(produto);

            var registros = db.SaveChanges();

            Console.WriteLine("Total de registros afetados: " + registros);
        }
        
        private static void InserirDadosEmMassa()
        {
            var produto = new Produto
            {
                Descricao = "Produto teste",
                CodigoDeBarras = "14526941",
                Valor = 10m,
                TipoProduto = TipoProduto.Embalagem,
                Ativo = true
            };


            var cliente = new Cliente
            {
                Nome = "Cliente teste",
                CEP = "08081570",
                Cidade = "Sao paulo",
                Estado = "SP",
                Telefone = "2516-5246"
            };
            using var db = new ApplicationContext();
            db.AddRange(produto,cliente);
            var registro = db.SaveChanges();
            Console.WriteLine("Dados: " + registro);
            
        }
    }
}