<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegestrationform.aspx.cs" Inherits="LoginDetailsusingADO.StudentRegestrationform" %>

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
                        <asp:Label ID="lblfname" runat="server" Text="FirstName: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvfname" runat="server" ControlToValidate="txtfname" ErrorMessage="Please enter Firstname" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                       <asp:Label ID="lbllname" runat="server" Text="LastName: "></asp:Label>   
                    </td>
                    <td>
                           <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="rfvlname" runat="server" ControlToValidate="txtlname" ErrorMessage="Please enter Lastname" ForeColor="Red"></asp:RequiredFieldValidator>

                    </td>
                     </tr>
                <tr>
                    <td>
                      <asp:Label ID="lblgender" runat="server" Text="Gender: "></asp:Label>   
                    </td>
                    <td>
                        <asp:RadioButton ID="rbfemale" runat="server" Text="Female" GroupName="gender"  />
                        <asp:RadioButton ID="rbmale" runat="server" Text="Male" GroupName="gender" />
                        <asp:RadioButton ID="rbothers" runat="server" Text="Others" GroupName="gender"  />
                        <asp:CustomValidator ID="cvgender" runat="server"   Display="Dynamic"  ValidateEmptyText="true" ErrorMessage="Please Select Your Gender" ForeColor="Red" OnServerValidate="cvgender_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                       <asp:Label ID="lblCourse" runat="server" Text="Course: "></asp:Label>   
                    </td>
                    <td>
                        <asp:CheckBox ID="chkcshorp" runat="server" Text="CShorp" AutoPostBack="true"/>
                        <asp:CheckBox ID="chkADO" runat="server" Text="ADO.Net" AutoPostBack="true" />
                        <asp:CheckBox ID="chkmvc" runat="server" Text="MVC" AutoPostBack="true"/>
                        <asp:CheckBox ID="chkcore" runat="server" Text="DotNetCore" AutoPostBack="true"/>
                        <asp:CheckBox ID="chkangular" runat="server" Text="Angular" AutoPostBack="true"/>
                        <asp:CustomValidator ID="cvcourse" runat="server" ValidateEmptyText="true" ErrorMessage="Please Select Your Courses" ForeColor="Red" OnServerValidate="cvcourse_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbldob" runat="server" Text="Date Of Birth: "></asp:Label>
                    </td>
                    <td>
                    <asp:DropDownList ID="ddldob" runat="server" AutoPostback="true">
                        <asp:ListItem>--select--</asp:ListItem>
                        <asp:ListItem>2003-5-19</asp:ListItem>
                            <asp:ListItem>2002-12-14</asp:ListItem>
                            <asp:ListItem>2001-8-11</asp:ListItem>
                            <asp:ListItem>1998-1-24</asp:ListItem>
                            <asp:ListItem>1999-6-22</asp:ListItem>
                    </asp:DropDownList>  
                        <asp:RequiredFieldValidator ID="rfvdob" runat="server" ErrorMessage="Please select your Date of Birth" ControlToValidate="ddldob" ForeColor="Red" InitialValue="--select--"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                     <asp:Label ID="lblemail" runat="server" Text="Email ID: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server" ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rvfemail" runat="server" ControlToValidate="txtemail" ErrorMessage="Please enter email" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revemail" runat="server" ControlToValidate="txtemail" ErrorMessage="Email should be follow email expression" ForeColor="Red" ValidationExpression="^[A-Za-z0-9]+@[A-Za-z0-9]+\.[a-z]{2,}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblpw" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpw" runat="server" TextMode="Password"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvpw" runat="server" ControlToValidate="txtpw" ErrorMessage="Please enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcpw" runat="server" Text="Confirm Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtcpw" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvcpw" runat="server" ControlToValidate="txtcpw" ErrorMessage="Please enter Confirm Password" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvcpw" runat="server" ControlToValidate="txtcpw" ControlToCompare="txtpw" ErrorMessage="Confirm password should match with password" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblpno" runat="server" Text="Ph no:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox Id="txtpno" runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfvpno" runat="server" ControlToValidate="txtpno" ErrorMessage="Please enter Ph no" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="revpno" runat="server" ControlToValidate="txtpno" ErrorMessage="Ph no should contain 10 digits" ForeColor="Red" ValidationExpression="^\d{10}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" CausesValidation="true" />
                    </td>
                    <td>
                        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblsearch" runat="server" Text="Search"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
                    </td>
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
