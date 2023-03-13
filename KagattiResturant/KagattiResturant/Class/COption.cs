using GProjects.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KagattiResturant.Class
{
    public static class Options
    {
        //Type 0 for all 1 for User
        public static bool SetOptions(string Name, string Value, string UserGUID, string ComputerName)
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_SetOPtions", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Value", Value);
            cmd.Parameters.AddWithValue("@UserGUID", UserGUID);
            cmd.Parameters.AddWithValue("@CpmputerName", ComputerName);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add SetOPtions", ex);
                Result = false;
            }


            return Result;
        }

        public static bool SetOptionsForAll(string Name, string Value)
        {
            return SetOptions(Name, Value.ToString(), Guid.Empty.ToString(), "0");
        }
        public static bool SetOptionsForAll(string Name, int Value)
        {
            return SetOptionsForAll(Name, Value.ToString());
        }
        public static bool SetOptionsForAll(string Name, double Value)
        {
            return SetOptionsForAll(Name, Value.ToString());
        }
        public static bool SetOptionsForAll(string Name, float Value)
        {
            return SetOptionsForAll(Name, Value.ToString());
        }
        public static bool SetOptionsForAll(string Name, DateTime Value)
        {
            return SetOptionsForAll(Name, Value.ToString());
        }
        public static bool SetOptionsForAll(string Name, Decimal Value)
        {
            return SetOptionsForAll(Name, Value.ToString());
        }
        public static bool SetOptionsForAll(string Name, bool Value)
        {
            return SetOptions(Name, Value.ToString(), Guid.Empty.ToString(), "0");
        }


        public static string GetOptionsForAll(string Name, string Def = "")
        {
            if (!ProjBase.IsRunning)
                return Def;
            string Result = "";
            string Sql = "select Value from GOptions where Name = '" + Name + "'";
            Result = DBSqlServer.ExecuteScalar(Sql).ToString();
            if (Result == "" || Result == null)
                Result = Def;
            return Result;
        }
        public static int GetOptionsForAll(string Name, int Def = 0)
        {
            return int.Parse(GetOptionsForAll(Name, Def.ToString()));
        }
        public static bool GetOptionsForAll(string Name, bool Def = false)
        {
            return bool.Parse(GetOptionsForAll(Name, Def.ToString()));
        }



        public static bool SetOptionsForUser(string Name, string Value)
        {
            return SetOptions(Name, Value.ToString(), CSamaHotel.CurrUser.guid.ToString(), "0");
        }
        public static bool SetOptionsForUser(string Name, int Value)
        {
            return SetOptionsForUser(Name, Value.ToString());
        }
        public static bool SetOptionsForUser(string Name, double Value)
        {
            return SetOptionsForUser(Name, Value.ToString());
        }
        public static bool SetOptionsForUser(string Name, float Value)
        {
            return SetOptionsForUser(Name, Value.ToString());
        }
        public static bool SetOptionsForUser(string Name, DateTime Value)
        {
            return SetOptionsForUser(Name, Value.ToString());
        }
        public static bool SetOptionsForUser(string Name, Decimal Value)
        {
            return SetOptionsForUser(Name, Value.ToString());
        }
        public static bool SetOptionsForUser(string Name, bool Value)
        {
            return SetOptionsForUser(Name, Value.ToString());
        }


        public static string GetOptionsForUser(string Name, string Def = "")
        {
            if (!ProjBase.IsRunning)
                return Def;
            string Result = "";
            string Sql = "select Value from GOptions where UserGUID='" + CSamaHotel.CurrUser.guid.ToString() + "' and Name = '" + Name + "'";
            Result = DBSqlServer.ExecuteScalar(Sql).ToString();
            if (Result == "" || Result == null)
                Result = Def;
            return Result;
        }
        public static int GetOptionsForUser(string Name, int Def = 0)
        {
            return int.Parse(GetOptionsForUser(Name, Def.ToString()));
        }
        public static bool GetOptionsForUser(string Name, bool Def = false)
        {
            return bool.Parse(GetOptionsForUser(Name, Def.ToString()));
        }


        public static object GetOptionRegistry(string Folder, string Name, object Def)
        {
            object Result;
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey(ProjBase.CompanyName).CreateSubKey(ProjBase.ProgramName);
                key.CreateSubKey(Folder);
                Result = key.GetValue(Name);
                if (Result == null)
                    Result = Def;
            }
            catch (Exception)
            {
                Result = Def;
            }

            return Result;
        }
        public static void SetOptionRegistry(string Folder, string Name, object Value)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey(ProjBase.CompanyName).CreateSubKey(ProjBase.ProgramName);
            key.CreateSubKey(Folder);
            key.SetValue(Name, Value);

        }
    }
}
