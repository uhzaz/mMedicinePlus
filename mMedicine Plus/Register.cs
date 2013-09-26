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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            global.screenLayout();
            this.Width = global.screenWidth;
            this.Height = global.screenHeight * 80 / 100;
        }


        //Irshad - To register to the application
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCity.Text != "" && txtMobile.Text != "" && txtName.Text != "" && txtPassword.Text != "" && txtTempLogin.Text != "")
                {
                    string strResult = global.GETData(global.registration + "TempLogin=" + txtTempLogin.Text + "&PASSWORD=" + txtPassword.Text + "&ProductID=1&MobileNo=" + txtMobile.Text + "&City=" + txtCity.Text + "&Name=" + txtName.Text);
                    string[] result = global.parsePSV(strResult);
                    if (result.Count() > 0)
                    {
                        if (result[0] == "Yes")
                        {

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
                else
                {
                    MessageBox.Show("Please fill the missing details to register.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                global.ErrorLog(ex.ToString());
            }
        }
    }
}
