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
    class RestEmpSalInv
    {
        public Guid GUID { get; set; }
        public Guid GUID_EmpSal { get; set; }
        public Guid GUID_Emp { get; set; }
        public string Month { get; set; }
        public double Salary { get; set; }
        public double Salary_received { get; set; }
        public double Salary_Remaining { get; set; }
        public double Salary_Discount { get; set; }
        public double Salary_Plus { get; set; }
        public DateTime Date { get; set; }
        public Guid Users { get; set; }

        public static RestEmpSalInv Load(Guid G)
        {
            RestEmpSalInv Result = new RestEmpSalInv();
            SqlDataReader Dr;

            try
            {
                SqlCommand Comm = ProjBase.Conn.CreateCommand();
                Comm.CommandText = "Select * from RestEmpSalInv Where GUID ='" + G.ToString() + "'";
                Dr = Comm.ExecuteReader();
                Dr.Read();
                Result.GUID = ValuesFix.GetValueGUID(Dr["GUID"].ToString());
                Result.GUID_EmpSal = ValuesFix.GetValueGUID(Dr["GUID_EmpSal"].ToString());
                Result.GUID_Emp = ValuesFix.GetValueGUID(Dr["GUID_Emp"].ToString());
                Result.Month = ValuesFix.GetValueString(Dr["Month"].ToString());
                Result.Salary = ValuesFix.GetValueDouble(Dr["Salary"].ToString());
                Result.Salary_received = ValuesFix.GetValueDouble(Dr["Salary_received"].ToString());
                Result.Salary_Remaining = ValuesFix.GetValueDouble(Dr["Salary_Remaining"].ToString());
                Result.Salary_Discount = ValuesFix.GetValueDouble(Dr["Salary_Discount"].ToString());
                Result.Salary_Plus = ValuesFix.GetValueDouble(Dr["Salary_Plus"].ToString());
                Result.Date = ValuesFix.GetValueDateTime(Dr["Date"].ToString());
                Result.Users = ValuesFix.GetValueGUID(Dr["Users"].ToString());
                Dr.Close();
            }
            catch (Exception ex)
            {
                Result = new RestEmpSalInv();
                Result.GUID = G;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return Result;
        }

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmpSalInv_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@GUID_EmpSal", GUID_EmpSal);
            cmd.Parameters.AddWithValue("@GUID_Emp", GUID_Emp);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            cmd.Parameters.AddWithValue("@Salary_received", Salary_received);
            cmd.Parameters.AddWithValue("@Salary_Remaining", Salary_Remaining);
            cmd.Parameters.AddWithValue("@Salary_Discount", Salary_Discount);
            cmd.Parameters.AddWithValue("@Salary_Plus", Salary_Plus);
            cmd.Parameters.AddWithValue("@Month", Month);
            cmd.Parameters.AddWithValue("@Users", Users);
            cmd.Parameters.AddWithValue("@Date", Date);
            
   
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestEmpSalInv", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmpSalInv_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@GUID_EmpSal", GUID_EmpSal);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            cmd.Parameters.AddWithValue("@Salary_received", Salary_received);
            cmd.Parameters.AddWithValue("@Salary_Remaining", Salary_Remaining);
            cmd.Parameters.AddWithValue("@Salary_Discount", Salary_Discount);
            cmd.Parameters.AddWithValue("@Salary_Plus", Salary_Plus);
            cmd.Parameters.AddWithValue("@Month", Month);
            cmd.Parameters.AddWithValue("@Users", Users);
            cmd.Parameters.AddWithValue("@Date", Date);
      

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestEmpSalInv", ex);
                Result = false;
            }
            return Result;
        }

        public bool Del()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestEmpSalInv_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del RestEmpSalInv", ex);
                Result = false;
            }
            return Result;
        }


    }
}
