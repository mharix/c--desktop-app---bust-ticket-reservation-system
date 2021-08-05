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
    public partial class CustomerSearch : MetroFramework.Forms.MetroForm
    {
        public CustomerSearch()
        {
            InitializeComponent();
        }
        database dbcon = new database();
        DataTable table = new DataTable();
        private void CustomerSearch_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (TXT_NAME.Text != "" && CBOX_FROM.SelectedIndex != -1 && CBOX_TO.SelectedIndex != -1 && TXT_AGE.Text != "" && TXT_BUSNO.Text != "")
            {
                table = dbcon.select("emp_CUSTOMER_SEARCH'" + TXT_BUSNO.Text + "','" + CBOX_FROM.SelectedItem.ToString() + "','" + CBOX_TO.SelectedItem.ToString() + "','" + TXT_NAME.Text + "','" + TXT_AGE.Text + "','"+DATE_ARR.Text+"','"+DATE_DEP.Text+"'");
                grid_search.DataSource = table;
            }
            else
            {
                MessageBox.Show("fill all fields to search exact record!");
            }
        }

        private void TXT_NAME_TextChanged(object sender, EventArgs e)
        {
           
                table = dbcon.select(" EMP_CUSTOMER_SEARCH_NAME '"+TXT_NAME.Text+"'");
            grid_search.DataSource = table;
        }

        private void TXT_AGE_TextChanged(object sender, EventArgs e)
        {
            
                 table = dbcon.select(" EMP_CUSTOMER_SEARCH_AGE '" + TXT_AGE.Text + "'");
            grid_search.DataSource = table;
        }

        private void CBOX_TO_SelectedIndexChanged(object sender, EventArgs e)
        {
            table = dbcon.select(" EMP_CUSTOMER_SEARCH_TO '" + CBOX_TO.SelectedItem.ToString() + "'");
            grid_search.DataSource = table;
        }

        private void CBOX_FROM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                table = dbcon.select(" EMP_CUSTOMER_SEARCH_FROM '" + CBOX_FROM.SelectedItem.ToString() + "'");
            grid_search.DataSource = table;
        }

        private void DATE_ARR_ValueChanged(object sender, EventArgs e)
        {
            table = dbcon.select(" EMP_CUSTOMER_SEARCH_ARR'" + DATE_ARR.Text + "'");
            grid_search.DataSource = table;
        }

        private void DATE_DEP_ValueChanged(object sender, EventArgs e)
        {
            
                table = dbcon.select(" EMP_CUSTOMER_SEARCH_DEP'" + DATE_DEP.Text + "'");
            grid_search.DataSource = table;
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            table = dbcon.select(" EMP_CUSTOMER_SEARCH_BUS'" + TXT_BUSNO.Text + "'");
            grid_search.DataSource = table;
        }
    }
}
