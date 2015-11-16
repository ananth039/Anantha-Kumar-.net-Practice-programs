using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace asp.net_page_life_cycle_events
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        void page_PreInit()
        {
            Response.Write("page_Preinit " + "<br/>");
        }
        void page_Init()
        {
            Response.Write("page_init " + "<br/>");
        }
        void page_InitComplete()
        {
            Response.Write("page_initComplete " + "<br/>");
        }
        void page_preload()
        {
            Response.Write("page_preload " + "<br/>");
        }
        void page_load()
        {
            Response.Write("page_load " + "<br/>");
        }
    
        void page_loadComplete()
        {
            Response.Write("page_loadComplete " + "<br/>");
        }
        void page_preRender()
        {
            Response.Write("page_preRender " + "<br/>");
        }
        void page_preRenderComplete()
        {
            Response.Write("page_preRenderComplete " + "<br/>");
        }
        void page_Unload()
        {
            Response.Write("unload ");
        }
        
        
    }
}