using GProjects.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamaHotel.Class
{
    class HotelRooms
    {
        public Guid GUID { get; set; }
        public int Number { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int BadsNumber { get; set; }
        public int Status { get; set; }
        public string  Notes { get; set; }
        public Guid FloorGUID { get; set; }
        public string Price { get;  set; }

        public static HotelRooms Load(Guid G)
        {
            HotelRooms Result = new HotelRooms();
            SqlDataReader Dr;

            try
            {
                SqlCommand Comm = ProjBase.Conn.CreateCommand();
                Comm.CommandText = "Select * from HotelRooms Where GUID ='" + G.ToString() + "'";
                Dr = Comm.ExecuteReader();
                Dr.Read();
                Result.GUID =ValuesFix.GetValueGUID(Dr["GUID"].ToString());
                Result.Number = ValuesFix.GetValueInt(Dr["Number"].ToString());
                Result.Code = ValuesFix.GetValueString(Dr["Code"].ToString());
                Result.Name = ValuesFix.GetValueString(Dr["Name"].ToString());
                Result.BadsNumber = ValuesFix.GetValueInt(Dr["BadsNumber"].ToString());
                Result.Status = ValuesFix.GetValueInt(Dr["Status"].ToString());
                Result.Notes = ValuesFix.GetValueString(Dr["Notes"].ToString());
                Result.FloorGUID = ValuesFix.GetValueGUID(Dr["FloorGUID"].ToString());

                Dr.Close();
            }
            catch (Exception ex)
            {
                Result = new HotelRooms();
                Result.GUID = G;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return Result;
        }

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_HotelRooms_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@BadsNumber", BadsNumber);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@FloorGUID", FloorGUID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add HotelRooms", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_HotelRooms_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@BadsNumber", BadsNumber);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@FloorGUID", FloorGUID);
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
            SqlCommand cmd = new SqlCommand("Prc_HotelRooms_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del HotelRooms", ex);
                Result = false;
            }
            return Result;
        }


    }
}
