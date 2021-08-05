using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTRS2
{
    public partial class enquiry : MetroFramework.Forms.MetroForm
    {
        public enquiry()
        {
            InitializeComponent();
        }
        database dbcon = new database();
        private void enquiry_Load(object sender, EventArgs e)
        {
            
        }

        private void e_btn_search_Click(object sender, EventArgs e)
        {
            if (e_from.SelectedIndex != -1 && e_to.SelectedIndex != -1)
            {
                DataTable table = new DataTable();
                table = dbcon.select("enquiry '" + e_date_depart.Text + "','" + e_date_arrival.Text + "','" + e_to.SelectedItem.ToString() + "','" + e_from.SelectedItem.ToString() + "'");
                grid_enquiry.DataSource = table;
            }
            else
            {
                MessageBox.Show("Select To and From Locations!");
            }
        }
    }
}
