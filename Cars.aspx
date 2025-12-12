<%@ Page Title="Cars" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RentACarApp.Cars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <h2>Available Cars</h2>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvCars" runat="server" CssClass="table table-striped" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Make" HeaderText="Make" />
        <asp:BoundField DataField="Model" HeaderText="Model" />
        <asp:BoundField DataField="Year" HeaderText="Year" />
        <asp:BoundField DataField="LicensePlate" HeaderText="License Plate" />
        <asp:BoundField DataField="DailyRate" HeaderText="Daily Rate" />
        <asp:TemplateField HeaderText="Available">
            <ItemTemplate>
                <asp:Label ID="lblAvailable" runat="server" Text='<%# Convert.ToBoolean(Eval("Available")) ? "Yes" : "No" %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
