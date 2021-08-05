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
    public partial class EmployeePanel : MetroFramework.Forms.MetroForm
    {
        string username = "";
        database dbcon = new database();

        public EmployeePanel()
        {
            InitializeComponent();
        }
        public EmployeePanel(string uname)
        {
            InitializeComponent();
            username = uname;

        }

        private void EmployeePanel_Load(object sender, EventArgs e)
        {

        }

        private void BTN_LOGOUT_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
           
            f.Show();
            this.Hide();

        }

        private void BTN_RESETPASS_Click(object sender, EventArgs e)
        {
            rtxt_upasss.Text = null;
            panel_change_password.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbtn_changepass_Click(object sender, EventArgs e)
        {
           if(rtxt_upasss.Text!="" && username!="")
            {
                dbcon.insert("emp_chnagepasss '"+rtxt_upasss.Text+"','"+username+"'");
                panel_change_password.Visible = false;
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("Please enter your password!");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          
            panel_change_password.Visible = false;
        }

        private void BTN_BOOKING_Click(object sender, EventArgs e)
        {
            booking b = new booking(username);
            b.Show();
            

        }

        private void BTN_PRICELIST_Click(object sender, EventArgs e)
        {
            pricelist p = new pricelist();
            p.Show();
        }

        private void BTN_ENQUIRY_Click(object sender, EventArgs e)
        {
            enquiry E = new enquiry();
            E.Show();
            
        }

        private void e_btn_canclticket_Click(object sender, EventArgs e)
        {
            TicketCancle t = new TicketCancle();
            t.Show();
        }

        private void btn_search_customer_Click(object sender, EventArgs e)
        {
            CustomerSearch cs = new CustomerSearch();
                cs.Show();

        }
    }
}
