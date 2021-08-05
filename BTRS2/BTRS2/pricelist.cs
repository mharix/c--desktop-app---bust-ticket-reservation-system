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
    public partial class pricelist : MetroFramework.Forms.MetroForm
    {
        database dbcon = new database();
        public pricelist()
        {
            InitializeComponent();
            
        }

        private void pricelist_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            
            table = dbcon.select("emp_price_list '"+curr_date.Text+"'");
             
            grig_price_list.DataSource = table;
        }

        private void curr_date_ValueChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = dbcon.select("emp_price_list '" + curr_date.Text + "'");
            
            grig_price_list.DataSource = table;
        }
    }
}
