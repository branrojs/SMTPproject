<%@ Page Title="lobby" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="veraplicantes.aspx.cs" Inherits="WebApplication1.Account.WebForm1" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-horizontal">
        <h4>Aplicantes al puesto</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cedu" CssClass="col-md-2 control-label">Cedula</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cedu" readonly = 'true' CssClass="form-control" />
            </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="nombre" CssClass="col-md-2 control-label">Nombre</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="nombre" readonly = 'true' CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="apellidos" CssClass="col-md-2 control-label">apellidos</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="apellidos"  readonly = 'true' CssClass="form-control" />
            </div>
        </div>
         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label" >Requerimientos cumplidos por el aplicante</asp:Label>
             <div class="col-md-10">
                 <asp:TextBox ID="requiobt" runat="server" readonly = 'true' Height="159px" Width="558px" TextMode="MultiLine" Rows="6" ></asp:TextBox>
              </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server"  AssociatedControlID="correo" CssClass="col-md-2 control-label">e-mail</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="correo" readonly = 'true' CssClass="form-control" />
                
            </div>
        </div>
        <div class="col-md-offset-2 col-md-10">
            
            <asp:Label ID="nomas" runat="server" Text=""></asp:Label>
            
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"  Text="Primer participante" Visible="true" CssClass="btn btn-default" ID="pp" Width="193px" OnClick="pp_Click" />
               <asp:Button runat="server"  Text="Siguiente" Visible="false" CssClass="btn btn-default" ID="next" OnClick="next_Click" />
                <asp:Button runat="server"  Text="Enviar solicitud de entrevista" Visible="false" CssClass="btn btn-default" ID="enviarm" BorderStyle="Solid" OnClick="enviarm_Click" />
            </div>
            
        </div>
        
    </div>

</div>
</asp:Content>

