<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConnectedObject.aspx.cs" Inherits="WebAppAssign13Aug.ConnectedObject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="EmpId"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="EmpName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="EmpSal"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmpSal" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnInsertP" runat="server" OnClick="btnInsertP_Click" Text="InsertWithP" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdateP" runat="server" OnClick="btnUpdateP_Click" Text="UpdateWithP" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btndeleteP" runat="server" OnClick="btndeleteP_Click" Text="DeleteWithP" />
        <br />
        <br />
        <asp:Button ID="btnWithQ" runat="server" OnClick="btnWithQ_Click" Text="inserWithQ" Width="102px" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" UpdateQ" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DeleteQ" />
        <br />
    </form>
</body>
</html>
