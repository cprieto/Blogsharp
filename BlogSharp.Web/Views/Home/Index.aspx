<%@ Page Language="C#" MasterPageFile="../Shared/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BlogSharp.Web.Areas.Admin.Views.Home.Index" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
</asp:Content>
