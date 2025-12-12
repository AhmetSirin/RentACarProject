using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACarApp
{
    public partial class Rental : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAvailableCars();
                LoadRentedCars();
                LoadUnavailableCars(); // Yeni eklenen metodu çağır
            }
        }
        private void LoadUnavailableCars()
        {
            Vt db = new Vt();
            DataTable dtAllCars = db.GetCars(); // Tüm arabaları al
            DataTable dtAvailableCars = db.GetAvailableCars(); // Kullanılabilir arabaları al

            // Kullanılabilir olmayan arabaları belirlemek için tüm arabalar listesinden kullanılabilir arabaları çıkar
            DataTable dtUnavailableCars = dtAllCars.Clone(); // Kullanılabilir arabaların aynı yapısına sahip yeni bir DataTable oluştur
            foreach (DataRow row in dtAllCars.Rows)
            {
                bool isAvailable = false;
                foreach (DataRow availableRow in dtAvailableCars.Rows)
                {
                    if ((int)row["CarID"] == (int)availableRow["CarID"])
                    {
                        isAvailable = true; // Araba kullanılabilirse true
                        break;
                    }
                }

                // Araba kullanılabilir değilse (Available durumu false ise) dtUnavailableCars'e ekleyelim
                if (!isAvailable)
                {
                    dtUnavailableCars.ImportRow(row);
                }
            }

            gvUnavailableCars.DataSource = dtUnavailableCars;
            gvUnavailableCars.DataBind();
        }


        private void LoadRentedCars()
        {
            // RentedCars tablosundan veri almak yerine GetAvailableCars() metodunu kullanarak veri alınacak
            Vt db = new Vt();
            DataTable dt = db.GetAvailableCars();

            gvRentedCars.DataSource = dt;
            gvRentedCars.DataBind();
        }







        private void LoadAvailableCars()
        {
            Vt db = new Vt();
            DataTable dt = db.GetAvailableCars();

            ddlAvailableCars.DataSource = dt;
            ddlAvailableCars.DataTextField = "Make"; // Araba markasını göstermek için
            ddlAvailableCars.DataValueField = "CarId"; // Araba ID'sini seçmek için
            ddlAvailableCars.DataBind();

            // Seçenek ekleme
            ddlAvailableCars.Items.Insert(0, new ListItem("-- Select Car --", "0"));
        }





        protected void btnRent_Click(object sender, EventArgs e)
        {
            int carId = Convert.ToInt32(ddlAvailableCars.SelectedValue);
            DateTime rentStartDate = DateTime.Today;
            DateTime rentEndDate = rentStartDate.AddDays(Convert.ToInt32(txtRentDuration.Text));

            // Arabanın durumunu kiralık olarak işaretle
            UpdateCarAvailability(carId, false);

            // Kiralama işlemi başarılı mesajı göster
            lblMessage.Text = "Car rented successfully.";

            // Kiralama işlemi başarılı olduğunda aracın durumunu güncelle
            UpdateCarAvailability(carId, false);

            // Kiralanan araçların ve mevcut araçların listesini yeniden yükle
            LoadAvailableCars();
            LoadRentedCars();
        }






        private void UpdateCarAvailability(int carId, bool available)
        {
            Vt db = new Vt();
            bool success = db.UpdateCarAvailability(carId, available);
            if (!success)
            {
                // Hata durumunda kullanıcıya bilgi verilebilir
            }
        }


        private void SaveRentalInformation(int carId, DateTime rentStartDate, DateTime rentEndDate)
        {
            // Kiralama bilgilerini veritabanına kaydetme işlemi burada gerçekleştirilebilir
        }

    }
}
