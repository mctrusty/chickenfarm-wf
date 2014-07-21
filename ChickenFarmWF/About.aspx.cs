using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChickenFarmWF.Models;
using System.Data.Entity;

namespace ChickenFarmWF
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Farmer> farmersGrid_getData()
        {
            FarmContext db = new FarmContext();
            var q = db.Farmers;
            return q;
        }
    }
}