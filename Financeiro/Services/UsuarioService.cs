using Financeiro.DataBase;
using Financeiro.Migrations;
using Financeiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financeiro.Services
{
    public class UsuarioService
    {
        private readonly FinanceiroContext _context;

        public UsuarioService(FinanceiroContext context)
        {
            _context = context;
        }

        public bool Logar(Login login)
        {
            var user = _context.Usuarios.FirstOrDefault(x => x.Email.ToLower() == login.Email.ToLower() && x.Senha.ToLower() == login.Senha.ToLower());
            if (user != null)
            {
                HttpContext.Current.Session["UserId"] = user.Id;
                HttpContext.Current.Session["UserName"] = user.Nome;
                HttpContext.Current.Session.Timeout = 60;
                return true;
            }
            else
            {
                return false;
                throw new Exception("Usuário ou senha incorretos.");
            }
        }

        public void Logout()
        {
            HttpContext.Current.Session.Clear();
        }

        public bool IsLoggedIn()
        {
            return HttpContext.Current.Session["UserId"] != null;
        }

        public Models.CadastroUsuario GetLoggedInUser()
        {
            if (IsLoggedIn())
            {
                int userId = (int)HttpContext.Current.Session["UserId"];
                return _context.Usuarios.FirstOrDefault(u => u.Id == userId);
            }
            return null;
        }
    }
}