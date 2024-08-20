<%@ Page Language="C#" EnableEventValidation="true" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EditarCadastro.aspx.cs" Inherits="Financeiro.Site.EditarCadastro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Cadastro de Controle Financeiro</h4>
                    <br />
                    <h6 class="card-subtitle">Cadastre um controle financeiro para acompanhar todas as suas compras. </h6>

                    <div class="form-group">
                        <label for="inputProduto" class="form-label">Produto</label>
                        <asp:TextBox runat="server" ID="produto" class="form-control" aria-describedby="produtoNome" placeholder="Nome do produto"></asp:TextBox>
                        <small id="produtoNome" class="form-text text-muted">Digite o nome do produto que você comprou.</small>
                    </div>
                    <div class="form-group">
                        <label for="inputParcelas" class="form-label">Parcelas</label>
                        <asp:TextBox runat="server" ID="parcelas" class="form-control" aria-describedby="parcelaQuantidade" placeholder="Quantidade de parcelas"></asp:TextBox>
                        <small id="parcelaQuantidade" class="form-text text-muted">Digite em quantas parcelas foi sua compra.</small>
                    </div>
                    <div class="form-group">
                        <label for="inputPreco" class="form-label">Preço Total</label>
                        <asp:TextBox runat="server" ID="preco" class="form-control" aria-describedby="precoTotal" placeholder="Preço Total"></asp:TextBox>
                        <small id="precoTotal" class="form-text text-muted">Digite o preço total do produto comprado.</small>
                    </div>
                    <div class="form-group">
                        <label for="inputDescricao" class="form-label">Descrição</label>
                        <asp:TextBox runat="server" ID="descricao" class="form-control" aria-describedby="descricaoProduto" placeholder="Descrição"></asp:TextBox>
                        <small id="descricaoProduto" class="form-text text-muted">Digite uma pequena descrição do produto comprado.</small>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1" class="form-label">Data da compra</label>
                        <asp:TextBox runat="server" ID="dataCompra" class="form-control" aria-describedby="dataFinalCompra" placeholder="Data de aquisição"></asp:TextBox>
                        <small id="dataFinalCompra" class="form-text text-muted">Digite a data da aquisição do produto.</small>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1" class="form-label">Quantidade</label>
                        <asp:TextBox runat="server" ID="quantidade" class="form-control" aria-describedby="produtoNome" placeholder="Quantidade comprada de produto"></asp:TextBox>
                        <small id="emailHelp" class="form-text text-muted">Digite um número de quantos produtos comprou .</small>
                    </div>
                    <div class="form-check mr-sm-2 mb-3">
                        <input type="checkbox" class="form-check-input" id="checkbox0" value="check">
                        <label class="form-check-label" for="checkbox0">Check Me Out !</label>
                    </div>
                    <asp:Button runat="server" Id="botao" OnClick="EnviarEditar" Text="Enviar Atualização" CssClass="btn btn-primary m-1" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
