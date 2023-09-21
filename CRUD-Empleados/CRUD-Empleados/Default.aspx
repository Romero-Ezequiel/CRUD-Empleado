<%@ Page  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD_Empleados._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-12" style="margin-top: 30px;">
            <asp:Button runat="server" OnClick="Nuevo" Text="Nuevo" CssClass="btn btn-sm btn-success" 
                style="margin: 15px; margin-left: 4px; margin-top: -2px;"/>
        </div>
    </div>

    <div class="row" style="margin-right">
        <div class="col-12" style="position: absolute; left: 166px; top: 79px;">
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Buscar" OnClick="btnSearch_Click" />
        </div>
    </div>
    
    <div class="row">
        <div class="col-12">
            <asp:GridView ID="GridEmpleado" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" />
                    <asp:BoundField DataField="Salario" HeaderText="Salario" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" CommandArgument='<%# Eval("IdEmpleado") %>' Text="Editar" OnClick="Editar" CssClass="btn btn-sm btn-primary" />
                            <asp:LinkButton runat="server" CommandArgument='<%# Eval("IdEmpleado") %>' Text="Eliminar" OnClick="Eliminar" OnClientClick="return confirm('Desea eliminar?')" CssClass="btn btn-sm btn-danger" />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
        </div>
    </div>
    

</asp:Content>
