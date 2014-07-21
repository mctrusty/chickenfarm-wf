using ChickenFarmWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChickenFarmWF
{
    public class DisplayDataController
    {
        public IDisplayDataView View { get; set; }
        public DisplayDataController(IDisplayDataView view)
        {
            View = view;
            View.DataRequested += GetData;
        }
        
        public void GetData(object sender, EventArgs e)
        {

            View.Data = new List<string> { "String A", "String B", "String C", "String D" };
            View.Bind();
        }

        public IQueryable<Farmer> GetFarmers()
        {
            FarmContext db = new FarmContext();
            var q = db.Farmers;
            return q;
        }
    }
}