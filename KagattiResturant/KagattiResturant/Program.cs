using GControls.Class;
using GProjects.Class; 
using KagattiResturant.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KagattiResturant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ProjBase.ApplicationNameKey = "Caption";
            ProjBase.CompanyName = "KagattiHotel";
            ProjBase.IsRunning = true;
            string lang = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            //MainF App = new MainF();
            FrmMain App = new FrmMain();


            ProjBase.MdiParent = App;
            ProjBase.CurrentLanguage = CLanguage.LoadXmlSerializer(CBaseClass.AppPath + "\\ResLng\\" + lang + ".RLXml");
            string Style = Options.GetOptionRegistry("Style", "CBStyle", Stimulsoft.Controls.Win.DotNetBar.eStyle.Office2007Blue.ToString()).ToString();
            //App.styleManager.ManagerStyle = (Stimulsoft.Controls.Win.DotNetBar.eStyle)Enum.Parse(typeof(Stimulsoft.Controls.Win.DotNetBar.eStyle), Style);
            CSamaHotel.styleManager = App.styleManager;
            GControls.Message.MSBox.Language = ProjBase.CurrentLanguage;



            Application.Run(App);
        }
    }
}
