using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace image_control
{
    public partial class Image_control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //imgdispaly.Width = 200;
            //imgdispaly.Height = 200;
            
        }

        protected void btndisplayimage_Click(object sender, EventArgs e)
        {
            imgdispaly.ImageUrl = "animated-cook-and-chef-image-0011.gif";
        }
    }
}