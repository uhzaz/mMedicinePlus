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


        //Irshad - Login to the application
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMobileNo.Text != "" && tbPassword.Text != "")
                {
                    string strResult = global.GETData(global.login + "mobile=" + tbMobileNo.Text + "&password=" + tbPassword.Text + "&devicetype=desktop&productid=1");
                    string[] result = global.parsePSV(strResult);
                    if (result.Count() > 0)
                    {
                        if (result[0] == "Yes")
                        {
                            mainPage form = new mainPage();
                            form.Show();
                            this.Hide();
                        }
                        else if (result[0] == "No")
                        {
                            MessageBox.Show(result[1]);
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                global.ErrorLog(ex.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new Register();
            form.Show();
            this.Hide();
        }
        
    }
}
