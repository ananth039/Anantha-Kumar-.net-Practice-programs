using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Registartion
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {

                Response.Redirect("Login.aspx");
            }
            else
            {
                Session["Username"] = Session["Username"];
                Response.Redirect("EditDetails.aspx");
            }
        }
        protected void UserInput(object sender, EventArgs e)
        {
            string value = (sender as Button).Text;
            if (TxtResult.Text == "0")
            {
                TxtResult.Text = value;
            }
            else
            {
                TxtResult.Text += value;
            }

        }


        private static string value1;
        private static string Operation;
        protected void Divide(object sender, EventArgs e)
        {
            value1 = TxtResult.Text;
            txtStatus.Text = value1;
            TxtResult.Text = "0";
            Operation = btndivide.Text;

        }

        protected void Subtarct(object sender, EventArgs e)
        {
            value1 = TxtResult.Text;
            txtStatus.Text = value1;
            TxtResult.Text = "0";
            Operation = btnSubtract.Text;
        }

        protected void Multiply(object sender, EventArgs e)
        {
            value1 = TxtResult.Text;
            txtStatus.Text = value1;
            TxtResult.Text = "0";
            Operation = btnMultiply.Text;
        }

        protected void Addition(object sender, EventArgs e)
        {
            value1 = TxtResult.Text;
            txtStatus.Text = value1;
            TxtResult.Text = "0";
            Operation = btnAddition.Text;
        }
        protected void Percentage(object sender, EventArgs e)
        {
            value1 = TxtResult.Text;
            txtStatus.Text = value1;
            TxtResult.Text = "0";
            Operation = btnPercentage.Text;
        }
        protected void btnEqualto_Click(object sender, EventArgs e)
        {
            string Result;
            switch (Operation)
            {
                case "+":
                    Result = (double.Parse(value1) + double.Parse(TxtResult.Text)).ToString();
                    txtStatus.Text = value1 + "+" + TxtResult.Text;
                    TxtResult.Text = Result;
                    break;
                case "-":
                    Result = (double.Parse(value1) - double.Parse(TxtResult.Text)).ToString();
                    txtStatus.Text = value1 + "-" + TxtResult.Text;
                    TxtResult.Text = Result;

                    break;
                case "*":
                    Result = (double.Parse(value1) * double.Parse(TxtResult.Text)).ToString();
                    txtStatus.Text = value1 + "*" + TxtResult.Text;
                    TxtResult.Text = Result;
                    break;
                case "/":
                    Result = (double.Parse(value1) / double.Parse(TxtResult.Text)).ToString();
                    txtStatus.Text = value1 + "/" + TxtResult.Text;
                    TxtResult.Text = Result;
                    break;
                case "%":
                    Result = (double.Parse(value1) % double.Parse(TxtResult.Text)).ToString();
                    txtStatus.Text = value1 + "%" + TxtResult.Text;
                    TxtResult.Text = Result;
                    break;

            }
        }

        protected void ClearResult(object sender, EventArgs e)
        {
            TxtResult.Text = "0";
            txtStatus.Text = "";

        }

    }
}