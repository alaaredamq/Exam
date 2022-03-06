using Soap;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ForSoap {
    public partial class Index: System.Web.UI.Page {
        EcfCrudRef.Service1Client obj = new EcfCrudRef.Service1Client();
        protected void Page_Load(object sender, EventArgs e) {
            Users user = new Users();
            DataSet dataSet = new DataSet();
            dataSet = obj.UsersWithNoAccounts();
            GridView1.DataSource = dataSet;
            GridView1.DataBind();
        }
    }
}