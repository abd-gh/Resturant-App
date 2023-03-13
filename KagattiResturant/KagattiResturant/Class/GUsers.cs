using EnCryptDecrypt;
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
    class GUsers
    {
        public static Guid X { get; set; }
        public Guid guid { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool UpdatePrice { get; set; }
        public Guid ParentUser { get; set; }

        public GUsers()
        {
            LoginName = Password = "";
            IsAdmin = false;
            UpdatePrice = false;
            guid = ParentUser = Guid.Empty;
        }

        public static GUsers Load(Guid guid)
        {
            GUsers Result = new GUsers();
            SqlDataReader Dr;
            SqlCommand Comm = ProjBase.Conn.CreateCommand();
            Comm.CommandText = "Select * from GUsers Where GUID ='" + guid.ToString() + "'";
            Dr = Comm.ExecuteReader();
            Dr.Read();
            try
            {
                
                Result.guid = guid;
                Result.LoginName = Dr["LoginName"].ToString();
                Result.Password = CryptorEngine.Decrypt(Dr["Password"].ToString(), true);
                Result.IsAdmin = bool.Parse(Dr["IsAdmin"].ToString());
                Result.ParentUser = ValuesFix.GetValueGUID(Dr["ParentUser"].ToString());
                
                Dr.Close();
            }
            catch (Exception ex)
            {
                Result = new GUsers();
                Result.guid = guid;
            }
            Dr.Close();
         
            return Result;
        }

        public static bool Login(string Username, string password)
        {
            bool Result = false;
            try
            {
                Guid guid = Guid.Empty;
                string SQL = "select top 1 GUID from GUsers where  LoginName='" + Username + "' and Password='" + CryptorEngine.Encrypt(password,true) + "'";
                guid = Guid.Parse(DBSqlServer.ExecuteScalar(SQL).ToString());
                X = guid;
                if (guid == Guid.Empty)
                {
                    throw new Exception();
                }
                CSamaHotel.CurrUser = GUsers.Load(guid);
                Result = true;
            }
            catch (Exception)
            {
                GControls.Message.MSBox.Show("The UserName Or Password Not Found.", "User Not Fount.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                Result = false;
            }
            return Result;
        }

        public static int GetCountUser()
        {
            int Result = 0;
            Result=int.Parse(DBSqlServer.ExecuteScalar("select Count(*) from GUsers").ToString());

            return Result;
        }

        public bool Add()
        {
            guid = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_GUser_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", guid);
            cmd.Parameters.AddWithValue("@LoginName", LoginName);
            cmd.Parameters.AddWithValue("@Password", CryptorEngine.Encrypt(Password, true));
            cmd.Parameters.AddWithValue("@isAdmin", IsAdmin);
            cmd.Parameters.AddWithValue("@ParentUser", ParentUser);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add Users", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_GUser_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", guid);
            cmd.Parameters.AddWithValue("@LoginName", LoginName);
            cmd.Parameters.AddWithValue("@isAdmin", IsAdmin);
            cmd.Parameters.AddWithValue("@Password", CSamaHotel.CreateMD5(Password));
            cmd.Parameters.AddWithValue("@ParentUser", ParentUser);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add Users", ex);
                Result = false;
            }
            return Result;
        }

        public bool Del()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_GUser_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", guid);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del Users", ex);
                Result = false;
            }
            return Result;
        }

        
    }



    public class GSecurity
    {
        public Guid GUID { get; set; }
        public Guid UserGUID { get; set; }
        public SecurityType SecurityType { get; set; }
        public string Name { get; set; }
        public string Command { get; set; }
        public bool Permission { get; set; }

        public static List<GSecurity> GetGSecurity(Guid UserGUID)
        {
            List<GSecurity> Result = new List<GSecurity>();
            string Sql = "select * from GSecurity where UserGUID='" + UserGUID.ToString() + "' order by SecurityType,Name ";
            SqlDataReader Dr = DBSqlServer.ExecuteReader(Sql);
            while (Dr.Read())
            {
                GSecurity Temp = new GSecurity();
                Temp.UserGUID = UserGUID;
                Temp.SecurityType = (SecurityType)Enum.Parse(typeof(SecurityType), Dr["SecurityType"].ToString());
                Temp.Name = Dr["Name"].ToString();
                Temp.Command = Dr["Command"].ToString();
                Temp.Permission = bool.Parse(Dr["Permission"].ToString());
                Result.Add(Temp);
            }
            Dr.Close();
            return Result;
        }

        public static bool GetGSecurityByAdmin(SecurityType securitytype, string name, string command, string Password)
        {
            bool Result = false;
            try
            {
                string Sql = "select Top 1 Permission from VwGSecurity where password = '" + Password + "' and securityType='" + securitytype.ToString() + "' and name='" + name + "' and command='" + command + "'";
                Result = ValuesFix.GetValuebool(DBSqlServer.ExecuteScalar(Sql));
            }
            catch (Exception ex)
            { Result = false; }


            return Result;
        }
        public static bool GetGSecurity(SecurityType securitytype, string name, string command)
        {
            bool Result = false;
            if (CSamaHotel.ListGSecurity == null)
                CSamaHotel.IntGSecurity();
            if (CSamaHotel.CurrUser == null)
                return false;
            GSecurity Temp = CSamaHotel.ListGSecurity.Find(x => (x.SecurityType == securitytype) && (x.Name == name) && (x.Command == command));
            if (Temp != null)
                Result = Temp.Permission;
            else
            {
                Temp = new GSecurity();
                Temp.UserGUID = CSamaHotel.CurrUser.guid;
                Temp.SecurityType = securitytype;
                Temp.Name = name;
                Temp.Command = command;
                Temp.Permission = Result;
                Temp.Add();
                CSamaHotel.ListGSecurity.Add(Temp);
            }
            if (CSamaHotel.CurrUser.IsAdmin)
                Result = true;
            return Result;
        }
        public bool Add()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("AddGSecurity", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", Guid.NewGuid());
            cmd.Parameters.AddWithValue("@UserGUID", UserGUID);
            cmd.Parameters.AddWithValue("@SecurityType", SecurityType.ToString());
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Command", Command);
            cmd.Parameters.AddWithValue("@Permission", Permission);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add  GSecurity", ex);
                Result = false;
            }
            return Result;
        }

        internal static bool GetGSecurity(SecurityType card, object name, string v)
        {
            throw new NotImplementedException();
        }

        public static bool DeleteGSecurityByUser(Guid UserGUID)
        {
            bool Result = false;
            SqlCommand cmd = new SqlCommand("DeleteGSecurityByUser", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserGUID", UserGUID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del Delete  Security By Users", ex);
                Result = false;
            }

            return Result;
        }
    }




    public enum SecurityType
    {
        Rep = 1,
        Card = 2,
        Command = 3
    }
}
