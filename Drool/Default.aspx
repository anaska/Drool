<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Drool.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
            <form runat="server">
            
                <p>FROM:</p>
                <asp:DropDownList ID="Currency1" runat="server" AutoPostBack="False">
            </asp:DropDownList>
                <p>TO:</p> <asp:DropDownList ID="Currency2" runat="server" AutoPostBack="False"></asp:DropDownList>
                
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Convert" runat="server" Text="Convert" OnClick="Convert_Click" />
                <asp:Label ID="Label1" runat="server" Text="" Font-Size="30"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <p>COMPARE TO:</p>
                <asp:DropDownList ID="Currency3" runat="server"></asp:DropDownList>
                <asp:ScriptManager ID="scripman1" runat="server" EnablePageMethods="True"></asp:ScriptManager>
                <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
                <asp:Label ID="Label2" runat="server" Font-Size="24"></asp:Label>
            </form>

</asp:Content>

