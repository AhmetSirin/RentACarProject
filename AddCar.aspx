<%@ Page Title="Add Car" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCar.aspx.cs" Inherits="RentACarApp.AddCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <h2>Add New Car</h2>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                <div class="mb-3">
                    <asp:TextBox ID="txtMake" runat="server" CssClass="form-control" Placeholder="Make"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtModel" runat="server" CssClass="form-control" Placeholder="Model"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtYear" runat="server" CssClass="form-control" Placeholder="Year"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtLicensePlate" runat="server" CssClass="form-control" Placeholder="License Plate"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtDailyRate" runat="server" CssClass="form-control" Placeholder="Daily Rate"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
                </div>
                <asp:Button ID="btnAddCar" runat="server" Text="Add Car" CssClass="btn btn-primary" OnClick="btnAddCar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
