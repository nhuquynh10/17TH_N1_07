using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                int tong = tinhtong2so(1, 2);
            }

        }
        int tinhtong2so(int a, int b) {
            return a + b;
        }
    }
}