﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class Users_FourmReply : System.Web.UI.Page
{

    DaFourms fourms = new DaFourms();
    protected void Page_Load(object sender, EventArgs e)
    {
        

        fourms.ReplyId=fourms.AutoGenerateReplyId();
    }
}