<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SOLTUM.Satelites.ControlDeCasas.Default" %>

<%@ Register Assembly="DevExpress.Web.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <dx:aspxgridview runat="server" Width="100%" AutoGenerateColumns="true" 
            DataSourceId="CasasObjectDataSource"
            ></dx:aspxgridview>
    </div>
    <asp:ObjectDataSource ID="CasasObjectDataSource" runat="server" 
        DataObjectTypeName="SOLTUM.Satelites.ControlDeCasas.Entity.CasaInfo" 
        SelectMethod="GetCasas" 
        TypeName="SOLTUM.Satelites.ControlDeCasas.Business.CasaBAL">
    </asp:ObjectDataSource>

</asp:Content>
