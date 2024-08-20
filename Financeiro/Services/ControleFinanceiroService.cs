using Financeiro.DataBase;
using Financeiro.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Financeiro.Services
{
    public class ControleFinanceiroService
    {
        private readonly FinanceiroContext _context;

        public ControleFinanceiroService(FinanceiroContext context)
        {
            _context = context;
        }

        public void AdicionarControleFinanceiro(ControleFinanceiro controleFinanceiro)
        {
            DateTime date = controleFinanceiro.DataCompra;
            controleFinanceiro.UltimoDiaParcela = date.AddMonths(controleFinanceiro.QtdParcelas);
            _context.ControlesFinanceiros.Add(controleFinanceiro);

            _context.SaveChanges();
        }

        public ControleFinanceiro BuscarControleFinanceiro(int controleId)
        {
            var controle = _context.ControlesFinanceiros.FirstOrDefault(x => x.Id == controleId);

            if (controle is null) return null;

            return controle;

        }

        public DataTable BuscarTodosOsControleFinanceiros()
        {
            var controles = _context.ControlesFinanceiros.ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Parcelas", typeof(int));
            dt.Columns.Add("PrecoParcela", typeof(int));
            dt.Columns.Add("Preco", typeof(decimal));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("DataCompra", typeof(DateTime));
            dt.Columns.Add("DataFinal", typeof(DateTime));
            dt.Columns.Add("Quantidade", typeof(int));

            foreach (var controle in controles)
            {
                DataRow row = dt.NewRow();
                row["Id"] = controle.Id;
                row["Produto"] = controle.Produto;
                row["Parcelas"] = controle.QtdParcelas;
                row["PrecoParcela"] = controle.PrecoPorParcela;
                row["Preco"] = controle.Precototal;
                row["Descricao"] = controle.Descricao;
                row["DataCompra"] = controle.DataCompra;
                row["DataFinal"] = controle.UltimoDiaParcela;
                row["Quantidade"] = controle.QuantidadeDeProdutos;

                dt.Rows.Add(row);
            }

            return dt;
        }

        public void DeletarControleFinanceiro(int id)
        {
            var controle = BuscarControleFinanceiro(id);

            if (controle != null)
            {
                _context.ControlesFinanceiros.Remove(controle);
                _context.SaveChanges();
            }
        }

        public void EditarControleFinanceiro(int controleId, ControleFinanceiro controleFinanceiro)
        {
            var controle = BuscarControleFinanceiro(controleId);

            if (controle != null)
            {
                controle.Id = controleId;
                controle.Produto = controleFinanceiro.Produto;
                var parcela = controle.QtdParcelas = controleFinanceiro.QtdParcelas;
                var total = controle.Precototal = controleFinanceiro.Precototal;
                controle.Descricao = controleFinanceiro.Descricao;
                controle.PrecoPorParcela = total/parcela;
                DateTime date = controle.DataCompra = controleFinanceiro.DataCompra;
                controle.QuantidadeDeProdutos = controleFinanceiro.QuantidadeDeProdutos;
                controle.UltimoDiaParcela = date.AddMonths(controleFinanceiro.QtdParcelas);

                _context.ControlesFinanceiros.AddOrUpdate(controle);

                _context.SaveChanges();
            }
        }

    }
}