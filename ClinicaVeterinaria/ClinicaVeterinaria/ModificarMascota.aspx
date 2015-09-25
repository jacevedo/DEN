<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarMascota.aspx.cs" Inherits="ClinicaVeterinaria.ModificarMascota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                Ingrese el Id de la mascota a modificar</td>
            <td>
                <asp:TextBox ID="txtIdMascota" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnBuscarMascota" runat="server" 
                    onclick="btnBuscarMascota_Click" Text="Buscar Mascota" />
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
                <asp:TextBox ID="txtNombreMascota" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Nombre Dueño Mascota</td>
            <td>
                <asp:TextBox ID="txtDuenoMascota" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Tipo Mascota</td>
            <td>
                <asp:TextBox ID="txtTipoMascota" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Raza Mascota</td>
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
                    Text="Guardar Modifcaciones" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
