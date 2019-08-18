using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public partial class TextBoxUsername : System.Windows.Forms.TextBox
    {
        public TextBoxUsername()
        {
            InitializeComponent();

            Text = "Username";
        }

        public TextBoxUsername(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (!DesignMode)
            {
                if (Text == "Username")
                {
                    Text = "";
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
                    Text = "Username";
                }
            }
            base.OnLostFocus(e);
        }
    }
}
