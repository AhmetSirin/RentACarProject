using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RentACarApp
{
    public partial class AddCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCar_Click(object sender, EventArgs e)
        {
            Vt db = new Vt();
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = int.Parse(txtYear.Text);
            string licensePlate = txtLicensePlate.Text;
            decimal dailyRate = decimal.Parse(txtDailyRate.Text);
            bool available = chkAvailable.Checked;

            if (db.AddCar(make, model, year, licensePlate, dailyRate, available))
            {
                lblMessage.Text = "Car added successfully!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Error adding car.";
            }
        }
    }
}
