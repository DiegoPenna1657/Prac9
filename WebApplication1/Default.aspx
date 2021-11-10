<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" >
            </asp:GridView>
            <br />
            Total Peliculas:
            <asp:TextBox ID="TotalMovies" runat="server" Width="374px"></asp:TextBox>
            <br />
            Maximo RunTime: <asp:TextBox ID="LongestRunTime" runat="server" Width="374px"></asp:TextBox>
            <br />
            Minimo RunTime:
            <asp:TextBox ID="ShortestRunTime" runat="server" Width="374px"></asp:TextBox>
            <br />
            Promedio RunTime:
            <asp:TextBox ID="AverageRunTime" runat="server" Width="374px"></asp:TextBox>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
