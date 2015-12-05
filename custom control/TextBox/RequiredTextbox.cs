using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;


namespace RequiredFieldvalidator
{
    public class RequiredTextbox:CompositeControl
    {
        TextBox input;
        RequiredFieldValidator validator;
        public string Text
        {
            get
            {
                EnsureChildControls();
                return input.Text;
            }
            set
            {
                EnsureChildControls();
                input.Text=value;
            }
        }
        protected override void CreateChildControls()
        {
            input = new TextBox();
            input.ID="input";
            this.Controls.Add(input);
            validator=new RequiredFieldValidator();
            validator.ID="Valinput";
            validator.ControlToValidate=input.ID;

        }
    }
}
