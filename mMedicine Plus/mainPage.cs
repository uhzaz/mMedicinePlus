using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace mMedicine_Plus
{
    
        

    
    
    
    
    public partial class mainPage : Form
    {
        string[] settings;
        public mainPage(string[] parameters)
        {
            InitializeComponent();
            settings = parameters;
            
        }

        private void pbFeature_Click(object sender, EventArgs e)
        {

        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            // open the settings file 
            bool settingState = false;
            try
            {
                StreamReader sr = new StreamReader("settings");
                sr.ReadToEnd();
                settingState = true;

            }
            catch (Exception ex)
            {
                if (ex.Message.Substring(0, 14) == "Could not find")
                {
                    StreamWriter sw = new StreamWriter("settings");
                    sw.Flush();
                    sw.WriteLine(settings);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //bkwDrugDatabase.RunWorkerAsync();

        }
        private void updateDrugDatabase()
        {
            string[] patterns = new string[26];
            string[] drugJson = new string[26];
            for (var i = 0; i < 26; i++)
            {
                patterns[i] = Convert.ToChar(i + 65).ToString();
                string drugListUrl = global.drugList + patterns[i];
                drugJson[i] = global.GETData(drugListUrl);
                updateLocalDrugLocalStore(drugJson[i]);
            }
        }
        private void updateLocalDrugLocalStore(string drugJsonStr)
        {
            drugJsonStr = drugJsonStr.Substring(1,drugJsonStr.Length -1) ;
            File.AppendAllText("drugDatabase", JsonConvert.SerializeObject(drugJsonStr, Formatting.None)); 
        }

       
        private void bkwDrugDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                updateDrugDatabase();
                
            }
            catch (Exception ex) 
            {
                global.ErrorLog("Error in Background worker :" + ex.Message);
            }
        }
    }
}
