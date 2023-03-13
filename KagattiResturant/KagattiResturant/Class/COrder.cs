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
    class RestOrder
    {
        public Guid GUID { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Guid Item_Name { get; set; }
        public int Count { get; set; }
        public double Single_Price { get; set; }
        public double Total_Price { get; set; }
        public Guid Users { get; set; }
        public Guid Guid_RestBill { get; set; }
        public double Tax { get; set; }

        public static RestOrder Load(Guid G)
        {
            RestOrder Result = new RestOrder();
            SqlDataReader Dr;

            try
            {
                SqlCommand Comm = ProjBase.Conn.CreateCommand();
                Comm.CommandText = "Select * from RestOrder Where GUID ='" + G.ToString() + "'";
                Dr = Comm.ExecuteReader();
                Dr.Read();
                Result.GUID = ValuesFix.GetValueGUID(Dr["GUID"].ToString());
                Result.Date = ValuesFix.GetValueDateTime(Dr["Date"].ToString());
                Result.Item_Name = ValuesFix.GetValueGUID(Dr["Item_Name"].ToString());
                Result.Count = ValuesFix.GetValueInt(Dr["Count"].ToString());
                Result.Single_Price = ValuesFix.GetValueDouble(Dr["Single_Price"].ToString());
                Result.Tax = ValuesFix.GetValueDouble(Dr["Tax"].ToString());
                Result.Total_Price = ValuesFix.GetValueDouble(Dr["Total_Price"].ToString());
                Result.Users = ValuesFix.GetValueGUID(Dr["Users"].ToString());
                Result.Guid_RestBill = ValuesFix.GetValueGUID(Dr["Section_Name"].ToString());

                Dr.Close();
            }
            catch (Exception ex)
            {
                Result = new RestOrder();
                Result.GUID = G;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return Result;
        }

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestOrder_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Item_Name", Item_Name);
            cmd.Parameters.AddWithValue("@Count", Count);
            cmd.Parameters.AddWithValue("@Tax", Tax);
            cmd.Parameters.AddWithValue("@Single_Price", Single_Price);
            cmd.Parameters.AddWithValue("@Total_Price", Total_Price);
            cmd.Parameters.AddWithValue("@Users", Users);
            cmd.Parameters.AddWithValue("@Guid_RestBill", Guid_RestBill);
    
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestOrder", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestOrder_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Item_Name", Item_Name);
            cmd.Parameters.AddWithValue("@Count", Count);
            cmd.Parameters.AddWithValue("@Tax", Tax);
            cmd.Parameters.AddWithValue("@Single_Price", Single_Price);
            cmd.Parameters.AddWithValue("@Total_Price", Total_Price);
            cmd.Parameters.AddWithValue("@Users", Users);
            cmd.Parameters.AddWithValue("@Guid_RestBill", Guid_RestBill);

          
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
            SqlCommand cmd = new SqlCommand("Prc_RestOrder_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
       
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del RestOrder", ex);
                Result = false;
            }
            return Result;
        }


    }
}
