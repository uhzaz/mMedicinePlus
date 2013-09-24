using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace mMedicine_Plus
{
    class global
    {
        #region statics
        public static int screenWidth;
        public static int screenHeight;
        public static Font boxMessage =new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font boxContent= new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        #endregion

        #region apis
        public static string baseUrl = "http://mmedicine.mobi/mmedicine";
        public static string plusBaseUrl = "http://rest.mmedicine.mobi:8080";
        public static string login = baseUrl +"/userlogin.aspx?"; // mobile, password, devicetype, product 
        public static string registration = baseUrl+"/new_temporarylogin.aspx?"; // templogin, password, productid=1, mobileno, city , name, 
        public static string changePassword = baseUrl+"/changedpassword.aspx?"; // newpwsd, userid, pharmaid, productid=1
        public static string profileUpdate = plusBaseUrl + "/doctors/profile/update?"; // post docMysqlId, docData (json)
               #region Articles
        public static string articles = baseUrl+"/new_datafrommexpert.aspx?"; // specality_id, license=3420111, status=live , userid 
        public static string articleDetails = baseUrl+"/mexpertdataaccess.aspx?"; // article_id , pageNo, 
        public static string articleSaved = baseUrl+"/doctor_saved_mexpert.aspx?"; //userid, artcile_id, 
#endregion         
               #region news & events
        public static string eventlist =baseUrl+ "/new_eventlisting.aspx?"; //  license_number= , specality_id , user_id
        public static string eventdetail = baseUrl+"/new_event_data.aspx?"; // event_id, user_id 

#endregion
               #region feature products 
        public static string promotionList = baseUrl+"/new_mobilelistingscreen.aspx?"; // speciality_id , license, pharmaid, user_id
        public static string promotionDetail = baseUrl+"/new_retrievedata.aspx?"; // mrid, user_id

        #endregion 
               #region interacton 
        public static string interactionResults =baseUrl+ "/mb_medicaleffect.aspx?"; // molecule_1 , molecule_2, viewing

        #endregion 
               #region speciality
               public static string specialityList =baseUrl+ "/list_of_specality.aspx"; 
               public static string specialityUpdate = baseUrl+"/update_doctor__specality.aspx?"; //u_id, spl_id
               
               #endregion
               #region dictionary  , drug 
               public static string dictionaryList = plusBaseUrl + "/dictionary/0" ; // change 0 for specific id 
               public static string drugList = plusBaseUrl + "/list/drugs?"; //pattern 
               public static string drugMonograph = plusBaseUrl + "/genric/0"; // change 0 to specific id 
                
               #endregion 
               #region Events
                    public static string eventList = plusBaseUrl + "/calendar/event/l"; //post docMysqId, skip , seek  
                    public static string eventCreate = plusBaseUrl + "/calendar/event/c"; //post eventData
                    
                #endregion 
               #region directory 
                    public static string directoryListing = plusBaseUrl + "/directory/refresh"; // post docMysqlId 
                    
                    #endregion 

        #endregion
                    #region layouts
                    public static void screenLayout()
        {
            screenWidth = (Screen.PrimaryScreen.Bounds.Width > 400) ? 400 : Screen.PrimaryScreen.Bounds.Width;
            screenHeight = (Screen.PrimaryScreen.Bounds.Height > 600) ? 600 : Screen.PrimaryScreen.Bounds.Height;

        }

#endregion
    }
}
