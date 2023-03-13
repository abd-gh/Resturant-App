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
    class RestBill
    {
        public Guid GUID { get; set; }
        public int Number { get; set; }
        public int  Num { get; set; }
        public DateTime Date { get; set; } 
        public double Total_Price { get; set; }
        public Guid Users { get; set; }
        public bool Type { get; set; }
        public bool Checks { get; set; }
        public string Notes { get; set; }

        public static RestBill Load(Guid G)
        {
            RestBill Result = new RestBill();
            SqlDataReader Dr;

            try
            {
                SqlCommand Comm = ProjBase.Conn.CreateCommand();
                Comm.CommandText = "Select * from RestBill Where GUID ='" + G.ToString() + "'";
                Dr = Comm.ExecuteReader();
                Dr.Read();
                Result.GUID = ValuesFix.GetValueGUID(Dr["GUID"].ToString());
                Result.Num = ValuesFix.GetValueInt(Dr["Num"].ToString());
                Result.Date = ValuesFix.GetValueDateTime(Dr["Date"].ToString());
                Result.Total_Price = ValuesFix.GetValueDouble(Dr["Total_Price"].ToString());
                Result.Users = ValuesFix.GetValueGUID(Dr["Users"].ToString());
                Result.Type = ValuesFix.GetValuebool(Dr["Type"].ToString());
                Result.Checks = ValuesFix.GetValuebool(Dr["Checks"].ToString());
                Result.Notes = ValuesFix.GetValueString(Dr["Notes"].ToString());
                Dr.Close();
            }
            catch (Exception ex)
            {
                Result = new RestBill();
                Result.GUID = G;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return Result;
        }

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestBill_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Num", Num);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Total_Price", Total_Price);
            cmd.Parameters.AddWithValue("@Users", Users);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Checks", Checks);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestBill", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestBill_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Num", Num);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Total_Price", Total_Price);
            cmd.Parameters.AddWithValue("@Users", Users);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Checks", Checks);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add HotelFloors", ex);
                Result = false;
            }
            return Result;
        }

        public bool Del()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestBill_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
       
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del RestBill", ex);
                Result = false;
            }
            return Result;
        }


    }
}
