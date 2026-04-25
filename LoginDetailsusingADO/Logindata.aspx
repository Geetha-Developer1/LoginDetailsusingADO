<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logindata.aspx.cs" Inherits="LoginDetailsusingADO.Logindata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="lbluname" runat="server" Text="Username: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvuname" runat="server" ControlToValidate="txtuname" ErrorMessage="Please enter Username" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblpw" runat="server" Text="Password: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpw" runat="server" ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvpw" runat="server" ControlToValidate="txtpw" ErrorMessage="Please enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" /></td>
                    <td>
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
                    </td>
                </tr>
               
            </table>
            <table align="center">
                <tr>
                    <td>
                       <asp:Label ID="lblsearch" runat="server" Text="Search"></asp:Label> 
                    </td>
                    <td>
                        <asp:TextBox ID="txtsearch" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" /></td>
                </tr>
                 <tr>
     <td></td>
     <td>
         <asp:GridView ID="gvdata" runat="server"></asp:GridView>
     </td>
 </tr>
            </table>
        </div>
    </form>
</body>
</html>
