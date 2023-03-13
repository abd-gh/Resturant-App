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
    class RestEmployee
    {
        public Guid GUID { get; set; }
        public int Number { get; set; }      
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
       
       

        public static RestEmployee Load(Guid G)
        {
            RestEmployee Result = new RestEmployee();
            SqlDataReader Dr;

            try
            {
                SqlCommand Comm = ProjBase.Conn.CreateCommand();
                Comm.CommandText = "Select * from RestEmployee Where GUID ='" + G.ToString() + "'";
                Dr = Comm.ExecuteReader();
                Dr.Read();
                Result.GUID = ValuesFix.GetValueGUID(Dr["GUID"].ToString());             
                Result.Name = ValuesFix.GetValueString(Dr["Name"].ToString());
                Result.Notes = ValuesFix.GetValueString(Dr["Notes"].ToString());
                Result.Phone = ValuesFix.GetValueString(Dr["Phone"].ToString());
                Result.Salary = ValuesFix.GetValueDouble(Dr["Salary"].ToString());
                Dr.Close();
            }
            catch (Exception ex)
            {
                Result = new RestEmployee();
                Result.GUID = G;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return Result;
        }

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmployee_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);       
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Salary", Salary);
   
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestEmployee", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmployee_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Salary", Salary);
      

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestEmployee", ex);
                Result = false;
            }
            return Result;
        }

        public bool Del()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmployee_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del RestEmployee", ex);
                Result = false;
            }
            return Result;
        }


    }
}
