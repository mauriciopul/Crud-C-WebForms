<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crud 1</title>
    <style type="text/css">
        .auto-style2 {
            width: 257px;
        }
        .auto-style3 {
            width: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">Nombre:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>            
        </tr>
        <tr>
            <td class="auto-style3">Cedula:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
            </td>            
        </tr>
        <tr>
            <td class="auto-style3">Contraseña:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox>
            </td>            
        </tr>
        <tr>
            <td class="auto-style3">Fecha de nacimiento:</td>
            <td class="auto-style2">
                Dia:<asp:TextBox ID="txtDia" runat="server" Width="23px"></asp:TextBox>
                Mes:<asp:TextBox ID="txtMes" runat="server" Width="23px"></asp:TextBox>
                Año:<asp:TextBox ID="txtAño" runat="server" Width="39px"></asp:TextBox>
            </td>            
        </tr>
    </table>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="lblPrueba" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
