<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regestration.aspx.cs" Inherits="LoginDetailsusingADO.Regestration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lbluname" runat="server" Text="Username: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvuname" runat="server" ControlToValidate="txtuname" ErrorMessage="Please Enter Username" ForeColor="Red"></asp:RequiredFieldValidator>         

                    </td>
                </tr>
                <tr>
                   <td>
     <asp:Label ID="lblage" runat="server" Text="Age: "></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="rfvage" runat="server" ControlToValidate="txtage" ErrorMessage="Please Enter Age" ForeColor="Red"></asp:RequiredFieldValidator>         
     <asp:RangeValidator ID="rvage" runat="server" MinimumValue="18" MaximumValue="35" ErrorMessage="Please enter age between 18-35" ControlToValidate="txtage" ForeColor="Red"></asp:RangeValidator>
 </td>
                </tr>
                <tr>
                     <td>
     <asp:Label ID="lblemail" runat="server" Text="Email ID: "></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="rfvemail" runat="server" ControlToValidate="txtemail" ErrorMessage="Please Enter Email" ForeColor="Red"></asp:RequiredFieldValidator>         
     <asp:RegularExpressionValidator ID="revemail" runat="server" ControlToValidate="txtemail" ErrorMessage="Mail should be in mailformate" ForeColor="Red" ValidationExpression="^[A-Za-z0-9]+@[A-Za-z0-9]+\.[A-Za-z]{2,}$"></asp:RegularExpressionValidator>
 </td>
                </tr>
                <tr>
                     <td>
     <asp:Label ID="lblpw" runat="server" Text="Password: "></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="txtpw" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="rfvpw" runat="server" ControlToValidate="txtpw" ErrorMessage="Please Enter password" ForeColor="Red"></asp:RequiredFieldValidator>         

 </td>
                </tr>
                <tr>
                     <td>
     <asp:Label ID="lblcpw" runat="server" Text="Confirm Password: "></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="txtcpw" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="rfvcpw" runat="server" ControlToValidate="txtcpw" ErrorMessage="Please Enter Confirm password" ForeColor="Red"></asp:RequiredFieldValidator>         
     <asp:CompareValidator ID="cvcpw" runat="server" ControlToValidate="txtcpw" ControlToCompare="txtpw" ErrorMessage="Password and Confirm Password should match" ForeColor="Red"></asp:CompareValidator>
 </td>
                </tr>
                <tr>
                     <td>
     <asp:Label ID="lblmno" runat="server" Text="Mobile No: "></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="txtmno" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="rfvmno" runat="server" ControlToValidate="txtmno" ErrorMessage="Please Enter MobileNo" ForeColor="Red"></asp:RequiredFieldValidator>         
     <asp:RegularExpressionValidator ID="revmno" runat="server" ControlTovalidate="txtmno" ValidationExpression="^\d{10}$" ErrorMessage="Please enter valid mobileno" ForeColor="Red"></asp:RegularExpressionValidator>
 </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
