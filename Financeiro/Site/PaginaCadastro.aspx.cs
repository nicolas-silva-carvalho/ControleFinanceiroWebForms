using Financeiro.DataBase;
using Financeiro.Migrations;
using Financeiro.Models;
using Financeiro.Services;
using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Financeiro.Site
{
    public partial class PaginaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Focus();
        }

        public void Enviar(object sender, EventArgs e)
        {
            FinanceiroContext context = new FinanceiroContext();
            ControleFinanceiroService _financeiroService = new ControleFinanceiroService(context);
            ControleFinanceiro controle = new ControleFinanceiro();

            if (string.IsNullOrEmpty(produto.Text) || string.IsNullOrEmpty(parcelas.Text) || string.IsNullOrEmpty(preco.Text) || string.IsNullOrEmpty(descricao.Text) || string.IsNullOrEmpty(dataCompra.Text) || string.IsNullOrEmpty(quantidade.Text))
            {
                Response.Write("<script>alert('Todos os campos devem ser preenchidos!');</script>");
                return;
            }

            controle.Produto = produto.Text;
            var qtd = controle.QtdParcelas = int.Parse(parcelas.Text);
            var total = controle.Precototal = decimal.Parse(preco.Text);
            controle.Descricao = descricao.Text;
            var data = controle.DataCompra = Convert.ToDateTime(dataCompra.Text);
            controle.QuantidadeDeProdutos = int.Parse(quantidade.Text);
            var dataFim = controle.UltimoDiaParcela = data;
            dataFim = DateTime.UtcNow.AddMonths(qtd);
            controle.PrecoPorParcela = total / qtd;
            _financeiroService.AdicionarControleFinanceiro(controle);
        }
    }
}