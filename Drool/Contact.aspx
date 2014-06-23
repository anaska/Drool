<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Drool.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br />
    <br />
    <br />
    <br />
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>

    <section class="contact">
        <header>
            <h3>E-mail:</h3>
        </header>
        <p>
            <span>Andrei Anusca:</span>
            <span>07xxxxxxxx</span>
        </p>
        <p>
            <span>Tudor Catz:</span>
            <span>07xxxxxxxx</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span>Andrei Anusca:</span>
            <span><a href="mailto:andrei.anusca@info.uaic.ro">andrei.anusca@info.uaic.ro</a></span>
        </p>
        <p>
            <span>Tudor Catz:</span>
            <span><a href="mailto:tudor.catz@info.uaic.ro">tudor.catz@info.uaic.ro</a></span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Address:</h3>
        </header>
        <p>
            One Microsoft Way<br />
            Redmond, WA 98052-6399
        </p>
    </section>
</asp:Content>