using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Financeiro.Models
{
    public class ControleFinanceiro
    {
        public int Id { get; set; }
        [Required]
        public string Produto { get; set; }
        [Required]
        public int QtdParcelas { get; set; }
        [Required]
        public decimal Precototal { get; set; }
        public decimal? PrecoPorParcela { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime DataCompra { get; set; }
        public DateTime UltimoDiaParcela { get; set; }
        [Required]
        public int QuantidadeDeProdutos { get; set; }
    }
}