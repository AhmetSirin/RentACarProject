<%@ Page Title="Rent a Car" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rental.aspx.cs" Inherits="RentACarApp.Rental" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <h2>Rent a Car</h2>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                <div class="mb-3">
                    <asp:DropDownList ID="ddlAvailableCars" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtRentDuration" runat="server" CssClass="form-control" Placeholder="Rent Duration (in days)"></asp:TextBox>
                </div>
                <asp:Button ID="btnRent" runat="server" Text="Rent Car" CssClass="btn btn-primary" OnClick="btnRent_Click" />
            </div>
            <div class="col-md-6">
                <h4>Available Cars</h4>
                <asp:GridView ID="gvRentedCars" runat="server" CssClass="table table-striped">
                    <Columns>
                        <asp:BoundField DataField="Make" HeaderText="Make" />
                        <asp:BoundField DataField="Model" HeaderText="Model" />
                        <asp:BoundField DataField="Year" HeaderText="Year" />
                        <asp:BoundField DataField="LicensePlate" HeaderText="License Plate" />
                        <asp:BoundField DataField="DailyRate" HeaderText="Daily Rate" />
                        <asp:BoundField DataField="Available" HeaderText="Available" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

        <!-- Yeni eklenen tablo -->
        <div class="row mt-5">
            <div class="col-md-12">
                <h4>Rented Cars</h4>
                <asp:GridView ID="gvUnavailableCars" runat="server" CssClass="table table-striped">
                    <Columns>
                        <asp:BoundField DataField="Make" HeaderText="Make" />
                        <asp:BoundField DataField="Model" HeaderText="Model" />
                        <asp:BoundField DataField="Year" HeaderText="Year" />
                        <asp:BoundField DataField="LicensePlate" HeaderText="License Plate" />
                        <asp:BoundField DataField="DailyRate" HeaderText="Daily Rate" />
                        <asp:BoundField DataField="Available" HeaderText="Available" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <!-- Yeni eklenen tablo sonu -->

    </div>
</asp:Content>
