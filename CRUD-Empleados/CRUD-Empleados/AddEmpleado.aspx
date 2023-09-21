<%@ Page Title="AddEmpleado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEmpleado.aspx.cs" Inherits="CRUD_Empleados.AddEmpleado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <asp:Label ID="lblTitulo" runat="server" CssClass="fs-4 fw-bold"  style="margin-left: 15px;"></asp:Label>

    <div class="container">
        <div class="mb-3">
            <label class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>

        <div class="mb-3">
            <label class="form-label">Apellido</label>
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label class="form-label">Correo</label>
            <asp:TextBox ID="TextCorreo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    
        <div class="mb-3">
            <label class="form-label">Salario</label>
            <asp:TextBox ID="TextSalario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="container">
        <asp:Button ID="btnSubmit" runat="server" Text="Enviar" CssClass="btn btn-sm btn-primary" OnClick="btnSubmit_Click"/>
        <asp:LinkButton runat="server" PostBackUrl="~/Default.aspx" CssClass="btn btn-sm btn-warning">Volver</asp:LinkButton>
    </div>

</asp:Content>


