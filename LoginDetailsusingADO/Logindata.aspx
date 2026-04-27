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
         <asp:GridView ID="gvdata" runat="server" AutoGenerateColumns="false"
             AllowPaging="true" PageSize="5"  OnPageIndexChanging="gvdata_PageIndexChanging" DataKeyNames="uid"  OnRowCancelingEdit="gvdata_RowCancelingEdit" OnRowEditing="gvdata_RowEditing" OnRowUpdating="gvdata_RowUpdating1" OnRowDeleting="gvdata_RowDeleting" >
             <Columns>
                 <asp:TemplateField HeaderText="Username">
                   <ItemTemplate>
                       <asp:Label ID="lblu1name" runat="server" Text='<%#Bind("Username") %>'></asp:Label>
                   </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtu1name" runat="server" Text='<%#Bind("Username") %>'></asp:TextBox>
                     </EditItemTemplate>
                  </asp:TemplateField>
                 <asp:TemplateField HeaderText="Password">
                     <ItemTemplate>
                         <asp:Label ID="lblpwd" runat="server" Text='<%#Bind("Password") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtpwd" runat="server" Text='<%#Bind("Password") %>'></asp:TextBox> 
                     </EditItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Actions">
                     <ItemTemplate>
                         <asp:Button ID="btnedit" runat="server" Text="Edit" CommandName="Edit" />
                         <asp:Button ID="btndelete1" runat="server" Text="Delete" CommandName="Delete"/>
                      </ItemTemplate>
                     <EditItemTemplate>
                         <asp:Button ID="btnupdate1" runat="server" Text="Update" CommandName="Update" />
                         <asp:Button ID="btncancel" runat="server" Text="Cancle" CommandName="Cancel" />
                     </EditItemTemplate>
                 </asp:TemplateField>
             </Columns>
         </asp:GridView>
     </td>
 </tr>
            </table>
        </div>
    </form>
</body>
</html>
