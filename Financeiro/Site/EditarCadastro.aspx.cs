using Financeiro.DataBase;
using Financeiro.Models;
using Financeiro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Financeiro.Site
{
    public partial class EditarCadastro : System.Web.UI.Page
    {
        private ControleFinanceiroService _controleFinanceiroService;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDados();
            }
        }

        private void CarregarDados()
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                return;
            }

            int id = int.Parse(Request.QueryString["id"]);
            _controleFinanceiroService = new ControleFinanceiroService(new FinanceiroContext());

            var controle = _controleFinanceiroService.BuscarControleFinanceiro(id);

            if (controle != null)
            {
                produto.Text = controle.Produto;
                parcelas.Text = controle.QtdParcelas.ToString();
                preco.Text = controle.Precototal.ToString();
                descricao.Text = controle.Descricao;
                dataCompra.Text = controle.DataCompra.ToString();
                quantidade.Text = controle.QuantidadeDeProdutos.ToString();
            }
        }

        public void EnviarEditar(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            _controleFinanceiroService = new ControleFinanceiroService(new FinanceiroContext());

            var controle = new ControleFinanceiro();
            controle.Id = id;
            controle.Produto = produto.Text;
            controle.QtdParcelas = int.Parse(parcelas.Text);
            controle.Precototal = decimal.Parse(preco.Text);
            controle.Descricao = descricao.Text;
            controle.DataCompra = Convert.ToDateTime(dataCompra.Text);
            controle.QuantidadeDeProdutos = int.Parse(quantidade.Text);

            _controleFinanceiroService.EditarControleFinanceiro(id, controle);

            CarregarDados();
        }
    }
}