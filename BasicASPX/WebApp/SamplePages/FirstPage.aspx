﻿<%@ Page Title="Hello World" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="WebApp.SamplePages.FirstPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter your Name"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="yourname" runat="server" Height="16px"></asp:TextBox>
    <br/>
    <asp:Button ID="PressMe" runat="server" Text="Press Me" OnClick="PressMe_Click" />
    <br/>
    <asp:Literal ID="OutputMessage" runat="server"></asp:Literal>
</asp:Content>
