using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
    public class FacultyDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FacultyConnectionString"].ConnectionString;

        
        public List<Faculty> GetAllFaculties()
        {
            List<Faculty> facultyList = new List<Faculty>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Faculty", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Faculty fac = new Faculty();
                    fac.Id = Convert.ToInt32(sdr[0]);
                    fac.Name = sdr["Name"].ToString();
                    fac.Desg = sdr["Desg"].ToString();
                    fac.Dept = sdr["Dept"].ToString();
                    facultyList.Add(fac);
                }
            }

            return facultyList;
        }

        public void InsertFaculty(Faculty fac)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Faculty (Id, Name, Desg, Dept) VALUES (@Id, @Name, @Desg, @Dept)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", fac.Id);
                cmd.Parameters.AddWithValue("@Name", fac.Name);
                cmd.Parameters.AddWithValue("@Desg", fac.Desg);
                cmd.Parameters.AddWithValue("@Dept", fac.Dept);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateFaculty(Faculty fac)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Faculty SET Name = @Name, Desg = @Desg, Dept = @Dept WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", fac.Id);
                cmd.Parameters.AddWithValue("@Name", fac.Name);
                cmd.Parameters.AddWithValue("@Desg", fac.Desg);
                cmd.Parameters.AddWithValue("@Dept", fac.Dept);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteFaculty(int Id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Faculty WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
}
}