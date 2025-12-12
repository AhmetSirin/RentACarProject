<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RentACarApp.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6">
                <h1 class="display-4">Welcome to Rent A Car Istanbul</h1>
                <p class="lead">We offer a wide range of rental cars to suit your needs. Whether you need a small, fuel-efficient car for city driving or a spacious SUV for a family trip, we've got you covered.</p>
                <p>Explore our fleet of vehicles and book your rental today!</p>
                <a href="Rental.aspx" class="btn btn-primary btn-lg">View Available Cars</a>
            </div>
            <div class="col-md-6">
                <img src="Styles/araba.png" alt="Rental Car" class="img-fluid rounded shadow-lg">
            </div>
        </div>
        <hr class="my-5">
        <div class="row">
            <div class="col-md-4">
                <div class="card mb-4 shadow-sm">
                    <img src="Styles\sedan.jpg" class="card-img-top" alt="Sedan Car">
                    <div class="card-body">
                        <h5 class="card-title">Sedans</h5>
                        <p class="card-text">Comfortable and efficient, perfect for city driving.</p>
                        <a href="Rental.aspx" class="btn btn-outline-primary">View Sedans</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card mb-4 shadow-sm">
                    <img src="Styles\Suvs.png" class="card-img-top" alt="SUV Car">
                    <div class="card-body">
                        <h5 class="card-title">SUVs</h5>
                        <p class="card-text">Spacious and powerful, ideal for family trips.</p>
                        <a href="Rental.aspx" class="btn btn-outline-primary">View SUVs</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card mb-4 shadow-sm">
                    <img src="Styles\TESLA.png" class="card-img-top" alt="Electric Car">
                    <div class="card-body">
                        <h5 class="card-title">Electric Cars</h5>
                        <p class="card-text">Eco-friendly and innovative, drive the future today.</p>
                        <a href="Rental.aspx" class="btn btn-outline-primary">View Electric Cars</a>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
