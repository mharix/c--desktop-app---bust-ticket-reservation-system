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
    public partial class TicketCancle : MetroFramework.Forms.MetroForm
    {
        public TicketCancle()
        {
            InitializeComponent();
        }
        database dbcon = new database();
        private void TicketCancle_Load(object sender, EventArgs e)
        {
            
        }
        DataTable table = new DataTable();
       
        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            getDataForCancle();
        }
        public void getDataForCancle()
        {
            DataTable table = new DataTable();
           table= dbcon.select("getdatafordelete '"+TXT_BUSNO.Text+"','"+DDATE.Text+"','"+ADATE.Text+"','"+TXT_SEAT.Text+"'");
            GRID_DELETE.DataSource = table;

        }

        private void BTN_DELETE_Click_1(object sender, EventArgs e)
        {
            
                try
                {
                    DataGridViewRow row;
                    row = GRID_DELETE.Rows[0];
                    DateTime startDT = Convert.ToDateTime(row.Cells[6].Value);
                    int price = Convert.ToInt32(row.Cells[2].Value);
                    DateTime endDT = CURR_DATE.Value;
                    // row.Cells[1].Value;

                    int daysDiff = ((TimeSpan)(endDT - startDT)).Days;
                    int rem = 0;
                    table = dbcon.select("emp_age_charges_return");
                    grddays.DataSource = table;
                    DataGridViewRow row1;
                    row1 = grddays.Rows[0];

                    if (daysDiff == 0)
                    {
                        rem = Convert.ToInt32(row1.Cells[7].Value);
                    
                }
                    else if (daysDiff == 1)
                    {
                        rem = Convert.ToInt32(row1.Cells[6].Value);
                 
                }
                    else if (daysDiff == 2)
                    {
                        rem = Convert.ToInt32(row1.Cells[5].Value);
                    
                }

                    lbl_rem_price.Text = ((price / 100) * rem).ToString();
                MessageBox.Show("return amount"+ ((price / 100) * rem).ToString());

                dbcon.insert("delete_tickets '" + row.Cells[5].Value.ToString() + "'");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("FIrst find reocrds !\n"+ex.ToString());
                }
            

        }
    }
}
