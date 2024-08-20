using Financeiro.DataBase;
using Financeiro.Services;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Financeiro.Site
{
    public partial class VerCadastros : System.Web.UI.Page
    {
        private ControleFinanceiroService _controleFinanceiroService;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UsuarioService usuarioService = new UsuarioService(new FinanceiroContext());
                if (!usuarioService.IsLoggedIn())
                {
                    Response.Redirect("~/Site/Home.aspx");
                }
                CarregarDados();
            }
            
        }

        private void CarregarDados()
        {
            _controleFinanceiroService = new ControleFinanceiroService(new FinanceiroContext());
            DataTable dt = _controleFinanceiroService.BuscarTodosOsControleFinanceiros();
            gvControlesFinanceiros.DataSource = dt;
            gvControlesFinanceiros.DataBind();
        }

        protected void gvControlesFinanceiros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int controleId = int.Parse(e.CommandArgument.ToString());
            _controleFinanceiroService = new ControleFinanceiroService(new FinanceiroContext());

            if (e.CommandName == "Editar")
            {
                Response.Redirect("EditarCadastro.aspx?id=" + controleId);
            }
            else if (e.CommandName == "Excluir")
            {
                _controleFinanceiroService.DeletarControleFinanceiro(controleId);
                CarregarDados();
            }
        }
    }
}
