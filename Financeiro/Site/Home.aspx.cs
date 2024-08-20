using Financeiro.DataBase;
using Financeiro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Financeiro.Site
{
    public partial class Home : System.Web.UI.Page
    {
        private UsuarioService _usuarioService;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Btn_Entrar(object sender, EventArgs e)
        {
            _usuarioService = new UsuarioService(new FinanceiroContext());

            Models.Login login = new Models.Login();
            login.Email = email.Text;
            login.Senha = password.Text;

            _usuarioService.Logar(login);
        }
    }
}