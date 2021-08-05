using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;


namespace BTRS2
{
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        database dbcon = new database();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (TXT_UNAME.Text!="" && TXT_PASS.Text!="")
            { table = dbcon.select("LOGIN_CHECK '" + TXT_UNAME.Text + "','" + TXT_PASS.Text + "'");
                if (table.Rows.Count >0)
                {
                    if (table.Rows[0][0].ToString() == "ADMIN")
                    {
                        AdminPanel ad = new AdminPanel();
                        ad.Text = "ADMIN-" + table.Rows[0][1].ToString();
                        ad.Show();
                        this.Hide();
                    }
                    else if (table.Rows[0][0].ToString() == "EMPLOYEE")
                    {
                        EmployeePanel emp = new EmployeePanel(table.Rows[0][2].ToString());
                        emp.Text = "EMPLOYEE-" + table.Rows[0][1].ToString();
                        emp.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("INVALID CREDNTIALS ! \n Contact Admin for more information!");
                }
            }
            else
            {
                MessageBox.Show("ENTER YOUR USERNAME OR PASSWORD!");
            }

        }
    }
}
