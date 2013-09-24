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
    public partial class mMedicinePlus : Form
    {
        public mMedicinePlus()
        {
            InitializeComponent();
            global.screenLayout();
            this.Width = global.screenWidth;
            this.Height = global.screenHeight * 80 / 100;

        }

        private void mMedicinePlus_Load(object sender, EventArgs e)
        {

        }
    }
}
