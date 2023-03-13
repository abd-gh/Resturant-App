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
    class RestSection
    {
        public Guid GUID { get; set; }
        public int Number { get; set; }      
        public string Name { get; set; }
        public string Printer { get; set; }
        public bool IsProduct { get; set; }

        public static RestSection Load(Guid guid)
        {
            RestSection section = new RestSection();
            SqlDataReader dr;

            try
            {
                SqlCommand Comm = ProjBase.Conn.CreateCommand();
                Comm.CommandText = "Select * from RestSection Where GUID ='" + guid.ToString() + "'";
                dr = Comm.ExecuteReader();
                dr.Read();
                section.GUID = ValuesFix.GetValueGUID(dr["GUID"].ToString());
                section.Printer = ValuesFix.GetValueString(dr["Printer"].ToString());
                section.Name = ValuesFix.GetValueString(dr["Name"].ToString());
                section.IsProduct = ValuesFix.GetValuebool(dr["IsProduct"].ToString());
                dr.Close();
            }
            catch (Exception ex)
            {
                section = new RestSection();
                section.GUID = guid;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return section;
        }

        public bool Add()
        {
            GUID = Guid.NewGuid();
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestSection_Add", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Printer", Printer);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@IsProduct", IsProduct);
   
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestSection", ex);
                Result = false;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestSection_Update", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            cmd.Parameters.AddWithValue("@Printer", Printer);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@IsProduct", IsProduct);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Add RestSection", ex);
                Result = false;
            }
            return Result;
        }

        public bool Del()
        {
            bool Result = true;
            SqlCommand cmd = new SqlCommand("Prc_RestSection_Del", ProjBase.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GUID", GUID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error Del RestSection", ex);
                Result = false;
            }
            return Result;
        }
    }
}
