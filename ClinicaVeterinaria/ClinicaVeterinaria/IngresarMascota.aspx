<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IngresarMascota.aspx.cs" Inherits="ClinicaVeterinaria.IngresarMascota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <table style="width:100%;">
        <tr>
            <td>
                Id</td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Nombre Mascota</td>
            <td>
                <asp:TextBox ID="txtNombreMascota" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Nombre Dueño</td>
            <td>
                <asp:TextBox ID="txtNombreDueno" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Tipo de Mascota</td>
            <td>
                <asp:TextBox ID="txtTipoMascota" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Raza de Mascota</td>
            <td>
                <asp:TextBox ID="txtRazaMascota" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" onclick="btnGuardar_Click" 
                    Text="Guardar Mascota" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
   
</asp:Content>
