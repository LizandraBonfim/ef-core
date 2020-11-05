using System.ComponentModel.DataAnnotations;
using Estudos.EFCore.ValueObjects;

namespace Estudos.EFCore.Domain
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public bool Ativo { get; set; }
    }
}