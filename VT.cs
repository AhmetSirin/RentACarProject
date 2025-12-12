using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RentACarApp
{
    public class Vt
    {
        private string connectionString;

        public Vt()
        {
            connectionString = ConfigurationManager.ConnectionStrings["RentACarDB"].ConnectionString;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable GetCars()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cars", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetCustomers()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetRentals()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rentals", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public bool AddCar(string make, string model, int year, string licensePlate, decimal dailyRate, bool available)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Cars (Make, Model, Year, LicensePlate, DailyRate, Available) VALUES (@Make, @Model, @Year, @LicensePlate, @DailyRate, @Available)", conn);
                cmd.Parameters.AddWithValue("@Make", make);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@LicensePlate", licensePlate);
                cmd.Parameters.AddWithValue("@DailyRate", dailyRate);
                cmd.Parameters.AddWithValue("@Available", available);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool UpdateCar(int carID, string make, string model, int year, string licensePlate, decimal dailyRate, bool available)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Cars SET Make=@Make, Model=@Model, Year=@Year, LicensePlate=@LicensePlate, DailyRate=@DailyRate, Available=@Available WHERE CarID=@CarID", conn);
                cmd.Parameters.AddWithValue("@CarID", carID);
                cmd.Parameters.AddWithValue("@Make", make);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@LicensePlate", licensePlate);
                cmd.Parameters.AddWithValue("@DailyRate", dailyRate);
                cmd.Parameters.AddWithValue("@Available", available);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public DataTable GetCarByID(int carID)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cars WHERE CarID=@CarID", conn);
                cmd.Parameters.AddWithValue("@CarID", carID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public bool DeleteCar(int carID)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Cars WHERE CarID=@CarID", conn);
                cmd.Parameters.AddWithValue("@CarID", carID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public DataTable GetAvailableCars()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cars WHERE Available = 1", conn); // Available durumu false olan araçları seçiyoruz
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetRentedCars()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM RentedCars", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public bool UpdateCarAvailability(int carId, bool available)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Cars SET Available=@Available WHERE CarID=@CarID", conn);
                cmd.Parameters.AddWithValue("@CarID", carId);
                cmd.Parameters.AddWithValue("@Available", available);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }


    }
}