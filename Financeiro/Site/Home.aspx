<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Financeiro.Site.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">General Form</h4>
                    <br />
                    <h6 class="card-subtitle">All with bootstrap element classies </h6>
                    <div class="form-group">
                        <label for="exampleInputEmail1" class="form-label">Email address</label>
                        <asp:TextBox runat="server" ID="email" type="email" class="form-control" aria-describedby="emailHelp" placeholder="Enter email"></asp:TextBox>
                        <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1" class="form-label">Password</label>
                        <asp:TextBox runat="server" type="password" class="form-control" ID="password" placeholder="Password"></asp:TextBox>
                    </div>
                    <div class="form-check mr-sm-2 mb-3">
                        <input type="checkbox" class="form-check-input" id="checkbox0" value="check">
                        <label class="form-check-label" for="checkbox0">Check Me Out !</label>
                    </div>
                    <asp:Button runat="server" Id="botaoLogin" OnClick="Btn_Entrar" Text="Entrar" CssClass="btn btn-primary m-1" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
