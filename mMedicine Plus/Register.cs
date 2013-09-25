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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(global.GETData(global.login + "mobile=" + tbMobileNo.Text + "&password=" + tbPassword.Text + "&devicetype=desktop&productid=1"));
            }
            catch (Exception ex)
            {
                global.ErrorLog(ex.ToString());
            }
        }
    }
}
