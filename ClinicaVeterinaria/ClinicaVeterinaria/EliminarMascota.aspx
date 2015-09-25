<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EliminarMascota.aspx.cs" Inherits="ClinicaVeterinaria.EliminarMascota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                Ingrese Id a Eliminar</td>
            <td>
                <asp:TextBox ID="txtIdEliminar" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnBuscarEliminar" runat="server" 
                    onclick="btnBuscarEliminar_Click" Text="Buscar Mascota" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td>
                Id Mascota</td>
            <td>
                <asp:Label ID="lblIdMascota" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Nombre Mascota</td>
            <td>
                <asp:Label ID="lblNombreMascota" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Nombre Dueño</td>
            <td>
                <asp:Label ID="lblNombreDueno" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Tipo Mascota</td>
            <td>
                <asp:Label ID="lblTipoMascota" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Raza Mascota</td>
            <td>
                <asp:Label ID="lblRazaMascota" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" onclick="btnEliminar_Click" 
                    Text="Eliminar Mascota" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
