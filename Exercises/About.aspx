<%@ Page Title="Exercise 6" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="Exercises.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>

        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Exercise 6</h1>
            <p class="lead">Please implement a function that checks whether a positive number is a palindrome or not. For
                example, 121 is a palindrome, but 123 is not.</p>
        </section>

            <asp:Label ID="lb_info" runat="server" Text="Enter a positive integer number: "></asp:Label>
        <section>
            <asp:TextBox ID="txt_input" runat="server" Height="30px" Width="120px"></asp:TextBox>
            <asp:Button ID="btn_check" runat="server" Text="Check Palindrome" Width="218px" />
        </section>
        <br />
        <asp:Label ID="lb_error" runat="server" ForeColor="#FF0066"></asp:Label>
        <section>
            <asp:Label ID="lb_textResponse" runat="server" Text="Result: "></asp:Label>
            <asp:Label ID="lb_response" runat="server"></asp:Label>
        </section>
    </main>
</asp:Content>
