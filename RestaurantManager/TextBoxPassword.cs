using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public partial class TextBoxPassword : System.Windows.Forms.TextBox
    {
        public TextBoxPassword()
        {
            InitializeComponent();
            Text = "Password";
        }

        public TextBoxPassword(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnGotFocus(EventArgs e)
        {
            if (!DesignMode)
            {
                if (Text == "Password")
                {
                    Text = "";
                    //UseSystemPasswordChar = true;
                }
            }
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            if (!DesignMode)
            {
                if (Text == "")
                {
                    Text = "Password";
                }
            }
            base.OnLostFocus(e);
        }
    }
}
