using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mMedicine_Plus
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            global.screenLayout();
            this.Width = global.screenWidth;
            this.Height = global.screenHeight *80/100;
            tbReset("boxMessage");

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
           
        }

        private void tbReset(string format)
        {
            switch(format)
            {
                case "boxMessage":
                    tbMobileNo.Text = "Enter Mobile No";
                    tbMobileNo.Font = global.boxMessage;
                    tbMobileNo.ForeColor = Color.LightGray;
                    tbPassword.ForeColor = Color.LightGray;
                    tbPassword.Font = global.boxMessage;
                    tbPassword.Text = "Your Password";
                    break;
                default:
                    
                    tbMobileNo.Font = global.boxContent;
                    tbMobileNo.ForeColor = Color.Gray;
                    tbPassword.ForeColor = Color.Gray;
                    tbPassword.Font = global.boxContent;
                    
                    break;
        }
        
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.Font = global.boxContent;
            tbPassword.ForeColor = Color.Gray;
            tbPassword.Text = "";
            tbPassword.PasswordChar = '*';
        }

        private void tbMobileNo_Enter(object sender, EventArgs e)
        {
            tbMobileNo.ForeColor = Color.Gray;
            tbMobileNo.Text = "";

            tbMobileNo.Font = global.boxContent;
        }

        private void tbMobileNo_Leave(object sender, EventArgs e)
        {
            if (tbMobileNo.Text == "")
            {
               
                tbMobileNo.ForeColor = Color.LightGray;
                tbMobileNo.Font = global.boxMessage;
                tbMobileNo.Text = "Enter Mobile No";
            }
            else
            {

            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.PasswordChar='\0';
                tbPassword.ForeColor = Color.LightGray;
                tbPassword.Font = global.boxMessage;
                tbPassword.Text = "Your Password";
            }
            else
            { 

            }
        }
        
    }
}
