using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTRS2
{
    class database
    {
        static string path = ConfigurationManager.ConnectionStrings["path"].ConnectionString;
        SqlConnection con = new SqlConnection(path);
        SqlCommand cmd;
        SqlDataAdapter adt;
        
        public DataTable select(string query)//this function get records from database as per query
        {
            DataTable table = new DataTable();
            try
            {//try bloc to handle exception when db not open
                con.Open();
               
                adt = new SqlDataAdapter(query, path);
                adt.Fill(table);
                con.Close();

                
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Database Connection is not active" + e.ToString());
                con.Close();
            }
            return table;
        }


        public void insert(string query)//this function insert records into database as per query
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Record Updated !");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Record not Updated !");
                }

                con.Close();

            }//try block end here
            catch (Exception e)
            {
                con.Close();
                System.Windows.Forms.MessageBox.Show("Database Connection is not active" + e.ToString());
            }

        }

    }
}
