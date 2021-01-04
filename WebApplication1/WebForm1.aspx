<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 203px;
        }
        .auto-style3 {
            width: 208px;
        }
        .auto-style4 {
            width: 243px;
        }
        .auto-style5 {
            width: 202px;
        }
        .auto-style6 {
            direction: ltr;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Name:
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">Gender:
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">Total Marks:
                    <asp:TextBox ID="txtMarks" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" Width="59px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Name:
                    <asp:TextBox ID="txtName0" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">Gender:
                    <asp:TextBox ID="txtGender0" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">Total Marks:
                    <asp:TextBox ID="txtMarks0" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    Name:
                    <asp:TextBox ID="txtWhere" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    Name:
                    <asp:TextBox ID="txtWhereD" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" Width="61px" />
                </td>
            </tr>
        </table>
        <asp:Label ID="lblmessage" runat="server" ></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
