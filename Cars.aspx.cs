using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RentACarApp
{
    public partial class Cars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCars();
            }
        }

        private void LoadCars()
        {
            Vt db = new Vt();
            DataTable dt = db.GetCars();
            gvCars.DataSource = dt; // GridView kontrolünün ID'si gvCars olarak değiştirildi
            gvCars.DataBind();
        }

    }
}
