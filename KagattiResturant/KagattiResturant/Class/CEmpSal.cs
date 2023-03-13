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
    class RestEmpSal
    {
        public Guid GUID { get; set; }
        public Guid GUID_Emp { get; set; }
        public string Month { get; set; }
        public double Salary { get; set; }
        public double Salary_received { get; set; }
        public double Salary_Remaining { get; set; }
        public double Salary_Discount { get; set; }
        public double Salary_Plus { get; set; }

        //public static RestEmpSal Load(Guid G)
        //{
        //    RestEmpSal Result = new RestEmpSal();
        //    SqlDataReader Dr;

        //    try
        //    {
        //        SqlCommand Comm = ProjBase.Conn.CreateCommand();
        //        Comm.CommandText = "Select * from RestEmpSal Where GUID ='" + G.ToString() + "'";
        //        Dr = Comm.ExecuteReader();
        //        Dr.Read();
        //        Result.GUID = ValuesFix.GetValueGUID(Dr["GUID"].ToString());
        //        // Result.Number = ValuesFix.GetValueInt(Dr["Number"].ToString());
              
        //        Result.Name = ValuesFix.GetValueString(Dr["Name"].ToString());
       

        //        Dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Result = new RestEmpSal();
        //        Result.GUID = G;
        //        GControls.Message.MSBox.Show("Error", ex);
        //    }

        //    return Result;
        //}

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmpSal_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@GUID_Emp", GUID_Emp);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            cmd.Parameters.AddWithValue("@Salary_received", Salary_received);
            cmd.Parameters.AddWithValue("@Salary_Remaining", Salary_Remaining);
            cmd.Parameters.AddWithValue("@Salary_Discount", Salary_Discount);
            cmd.Parameters.AddWithValue("@Salary_Plus", Salary_Plus);
            cmd.Parameters.AddWithValue("@Month", Month);
            
   
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestEmpSal", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmpSal_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@GUID_Emp", GUID_Emp);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            cmd.Parameters.AddWithValue("@Salary_received", Salary_received);
            cmd.Parameters.AddWithValue("@Salary_Remaining", Salary_Remaining);
            cmd.Parameters.AddWithValue("@Salary_Discount", Salary_Discount);
            cmd.Parameters.AddWithValue("@Salary_Plus", Salary_Plus);
            cmd.Parameters.AddWithValue("@Month", Month);
      

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestEmpSal", ex);
                Result = false;
            }
            return Result;
        }

        public bool Del()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmpSal_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del RestEmpSal", ex);
                Result = false;
            }
            return Result;
        }


    }
}
