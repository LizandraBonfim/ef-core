using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Estudos.EFCore.ValueObjects;

namespace Estudos.EFCore.Domain
{
    public class PedidoItem
    {
        [Key]
        public int Id { get; set; }
        // [ForeignKey("ProdutoId")]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
    }
}