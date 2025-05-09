<%@ Page Title="Exercise 1" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Exercises._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Exercise 3</h1>
            <p class="lead">Write some code that accepts an integer and prints the integers
                from 0 to that input integer in a spiral format.
                For example, if I supplied 24 the output would be:</p>
                <p class="lead">20 21 22 23 24</p>
                <p class="lead">19 6 7 8 9</p>
                <p class="lead">18 5 0 1 10</p>
                <p class="lead">17 4 3 2 11</p>
                <p class="lead">16 15 14 13 12</p>
        </section>

            <asp:Label ID="lb_info" runat="server" Text="Enter a positive integer number: "></asp:Label>
        <section>
            <asp:TextBox ID="txt_input" runat="server" Height="30px" Width="80px"></asp:TextBox>
            <asp:Button ID="btn_generate" runat="server" Text="Generate Spiral" Width="218px" />
        </section>
        <br />
        <asp:Label ID="lb_error" runat="server" ForeColor="#FF0066"></asp:Label>
        <br />

        <section>
            <asp:TextBox ID="txt_result" runat="server" Height="350px" ReadOnly="True" TextMode="MultiLine" Width="800px" Font-Names="Consolas" Font-Overline="False" Font-Underline="False">The Spiral will be generated here.</asp:TextBox>
        </section>
    </main>

</asp:Content>
