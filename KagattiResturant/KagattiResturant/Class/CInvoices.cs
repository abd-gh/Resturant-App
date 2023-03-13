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
    class RestInvoices
    {
        public Guid GUID { get; set; }
        public int Number { get; set; }      
        public string Title { get; set; }
        public double Price { get; set; }
        public string Notes { get; set; }
        public Guid Users { get; set; }
        public DateTime Date { get; set; }

        public static RestInvoices Load(Guid G)
        {
            RestInvoices Result = new RestInvoices();
            SqlDataReader Dr;

            try
            {
                SqlCommand Comm = ProjBase.Conn.CreateCommand();
                Comm.CommandText = "Select * from RestInvoices Where GUID ='" + G.ToString() + "'";
                Dr = Comm.ExecuteReader();
                Dr.Read();
                Result.GUID = ValuesFix.GetValueGUID(Dr["GUID"].ToString());
                Result.Title = ValuesFix.GetValueString(Dr["Title"].ToString());
                Result.Price = ValuesFix.GetValueDouble(Dr["Price"].ToString());
                Result.Notes = ValuesFix.GetValueString(Dr["Notes"].ToString());
                Result.Users = ValuesFix.GetValueGUID(Dr["Users"].ToString());
                Result.Date = ValuesFix.GetValueDateTime(Dr["Date"].ToString());

                Dr.Close();
            }
            catch (Exception ex)
            {
                Result = new RestInvoices();
                Result.GUID = G;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return Result;
        }

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestInvoices_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@Users", Users);
            cmd.Parameters.AddWithValue("@Date", Date);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestInvoices", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestInvoices_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@Users", Users);
            cmd.Parameters.AddWithValue("@Date", Date);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestInvoices", ex);
                Result = false;
            }
            return Result;
        }

        public bool Del()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestInvoices_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del RestInvoices", ex);
                Result = false;
            }
            return Result;
        }


    }
}
