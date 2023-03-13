using GProjects.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KagattiResturant.Class
{
    class CSamaHotel
    {
        public static GUsers CurrUser { get; set; }
       // public static bool IsAdmin { get; set; }
        public static Stimulsoft.Controls.Win.DotNetBar.StyleManager styleManager { get; set; }

        public static List<GSecurity> ListGSecurity;

        public static void IntGSecurity()
        {
            ListGSecurity = new List<GSecurity>();
            if (CurrUser != null)
            {
                ListGSecurity = GSecurity.GetGSecurity(CurrUser.guid);
           
            }
        }
        public static void ChangeLanguge()
        {

        }

        public static string CreateMD5(string S)
        {
            string Result = "";
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(S));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            Result = strBuilder.ToString();
            return Result;
        }
    }
}
