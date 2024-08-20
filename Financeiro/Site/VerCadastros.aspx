<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="VerCadastros.aspx.cs" Inherits="Financeiro.Site.VerCadastros" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Cadastro de Controle Financeiro</h4>
                    <br />
                    <h6 class="card-subtitle">Cadastre um controle financeiro para acompanhar todas as suas compras. </h6>

                    <asp:GridView ID="gvControlesFinanceiros" runat="server" AutoGenerateColumns="False" OnRowCommand="gvControlesFinanceiros_RowCommand" CssClass="table table-striped">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id"  Visible="false"/>
                            <asp:BoundField DataField="Produto" HeaderText="Produto" />
                            <asp:BoundField DataField="Preco" HeaderText="Preço Total" />
                            <asp:BoundField DataField="PrecoParcela" HeaderText="Preço Parcela" />
                            <asp:BoundField DataField="Parcelas" HeaderText="Parcelas" />
                            <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
                            <asp:BoundField DataField="DataCompra" HeaderText="Data da Compra" />
                            <asp:BoundField DataField="DataFinal" HeaderText="Data Final Compra" />
                            <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" />
                            <asp:TemplateField HeaderText="Ações">
                                <ItemTemplate>
                                    <asp:Button ID="btnEditar" runat="server" CommandName="Editar" CommandArgument='<%# Eval("Id") %>' Text="Editar" OnClientClick="return confirm('Você tem certeza que deseja editar este item?');" class="btn btn-success btn-sm"/>
                                    <asp:Button ID="btnExcluir" runat="server" CommandName="Excluir" CommandArgument='<%# Eval("Id") %>' Text="Excluir" OnClientClick="return confirm('Você tem certeza que deseja excluir este item?');" class="btn btn-danger btn-sm"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
