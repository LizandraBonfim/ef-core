using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Estudos.EFCore.ValueObjects;

namespace Estudos.EFCore.Domain
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public int  ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public StatusPedido Status { get; set; }
        public string Observacao { get; set; }
        public ICollection<PedidoItem> Itens { get; set; }
    }
}