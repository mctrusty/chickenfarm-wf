using ChickenFarmWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChickenFarmWF
{
    public partial class Contact : Page, IDisplayDataView
    {
        private DisplayDataController controller;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // pass a reference to this to the controller (presenter)
            // "this" is the view, still partially involving the code-behind
            controller = new DisplayDataController(this);
        }

        public IEnumerable<Farmer> farmersGrid_getData()
        {
            return controller.GetFarmers();
        }

        #region DataView members
        public event EventHandler DataRequested;

        public List<string> Data { get; set; }

        public void Bind()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}