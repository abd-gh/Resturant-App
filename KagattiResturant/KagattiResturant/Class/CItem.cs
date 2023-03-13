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
    class RestItem
    {
        public Guid GUID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Guid Section_Name { get; set; }
        public int Quantity { get; set; }
        

        public static RestItem Load(Guid guid)
        {
            RestItem item = new RestItem();
            SqlDataReader Dr;

            try
            {
                SqlCommand Comm = ProjBase.Conn.CreateCommand();
                Comm.CommandText = "Select * from RestItem Where GUID ='" + guid.ToString() + "'";
                Dr = Comm.ExecuteReader();
                Dr.Read();
                item.GUID = ValuesFix.GetValueGUID(Dr["GUID"].ToString());
                item.Price = ValuesFix.GetValueDouble(Dr["Price"].ToString());
                item.Name = ValuesFix.GetValueString(Dr["Name"].ToString());
                item.Section_Name = ValuesFix.GetValueGUID(Dr["Section_Name"].ToString());
                item.Quantity = ValuesFix.GetValueInt(Dr["Quantity"].ToString());

                Dr.Close();
            }
            catch (Exception ex)
            {
                item = new RestItem();
                item.GUID = guid;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return item;
        }

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestItem_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Section_Name", Section_Name);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
    
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestItem", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestItem_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Section_Name", Section_Name);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
          
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
            SqlCommand cmd = new SqlCommand("Prc_RestItem_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
       
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del RestItem", ex);
                Result = false;
            }
            return Result;
        }


    }
}
