using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;        //Import namespaces
using System.Windows.Forms;
using System.Data;
using CRUD_LayeredApp.LogicLayer;

namespace CRUD_LayeredApp.DataLayer
{
    
    internal class DataHandler
    {
        //Set ADO.Net objects
        string connect = "Server=.; Initial Catalog= BelgiumCampusDB; Integrated Security= SSPI";
        SqlDataAdapter adapter;
        DataTable table;

        //Create a method getStudent() utilizing DataTable
        public DataTable getStudent()
        {
            string query = @"SELECT * FROM Student";

            adapter = new SqlDataAdapter(query, connect);

            table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public void register(Student student)
        {
            string query = $"INSERT INTO Student VALUES ('{student.StudentNumber}', '{student.Name}', " +
                $"'{student.Surname}', '{student.Course}', '{student.Age}', '{student.Phone}')";

            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void update(Student student) 
        {
            string query = $"UPDATE Student SET studentNumber = '{student.StudentNumber}', firstname = '{student.Name}', " +
                $"surname = '{student.Surname}', course = '{student.Course}', age = '{student.Age}', phone = '{student.Phone}' " +
                $"WHERE studentNumber = '{student.StudentNumber}'";
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable search(int stdNo)
        {
            string query = $"SELECT * FROM Student WHERE studentNumber = '{stdNo}'";
            adapter = new SqlDataAdapter(query, connect);

            table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public void delete(int stdNo)
        {
            string query = $"DELETE FROM Student WHERE studentNumber = '{stdNo}'";
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"Data for student {stdNo} deleted successfully");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
