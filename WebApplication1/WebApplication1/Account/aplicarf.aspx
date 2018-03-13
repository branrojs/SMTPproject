<%@ Page Title="Aplicacion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aplicarf.aspx.cs" Inherits="WebApplication1.Account.aplicarf" Async="true" %>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <asp:Label ID="testf" runat="server"></asp:Label>

    <div class="form-horizontal">
        <h4>Formulario para aplicar al puesto de freidor.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cedu" CssClass="col-md-2 control-label">Cedula</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cedu" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cedu"
                    CssClass="text-danger" ErrorMessage="El campo de cedula es obligatorio." />
            </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="nombre" CssClass="col-md-2 control-label">Nombre</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="nombre" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="nombre"
                    CssClass="text-danger" ErrorMessage="El campo de nombre es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="apellidos" CssClass="col-md-2 control-label">apellidos</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="apellidos"  CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="apellidos"
                    CssClass="text-danger" ErrorMessage="El campo de apellidos es obligatorio." />
            </div>
        </div>
         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Requerimientos</asp:Label>
             <div class="col-md-10">
             <asp:CheckBoxList ID="chkModuleList" runat="server" >
                <asp:ListItem Text="Bachillerato concluido" Value="1"></asp:ListItem>
                <asp:ListItem Text="Titulos en gastronomia" Value="2"></asp:ListItem>
                 <asp:ListItem Text="experiencia laboral" Value="3"></asp:ListItem>
                 <asp:ListItem Text="Manipulacion de alimentos" Value="4"></asp:ListItem>
                </asp:CheckBoxList>
                  <asp:CustomValidator ID="CustomValidator1" ErrorMessage="Porfavor seleccione al menos un requerimiento."
                    ForeColor="Red" ClientValidationFunction="ValidateCheckBoxList" runat="server" />
              </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="correo" CssClass="col-md-2 control-label">e-mail</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="correo" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="correo"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="El campo de e-mail es obligatorio." />
                
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"  Text="Aplicar" CssClass="btn btn-default" OnClick="Unnamed9_Click" />
                <script type="text/javascript">
                    function ValidateCheckBoxList(sender, args) {
                        var checkBoxList = document.getElementById("<%=chkModuleList.ClientID %>");
                            var checkboxes = checkBoxList.getElementsByTagName("input");
                            var isValid = false;
                            for (var i = 0; i < checkboxes.length; i++) {
                                if (checkboxes[i].checked) {
                                    isValid = true;
                                    break;
                                }
                            }
                            args.IsValid = isValid;
                        }
                    </script>
            </div>
        </div>
        
    </div>
</asp:Content>