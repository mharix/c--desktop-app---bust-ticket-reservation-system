using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BTRS2
{
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        public void backtoUpadte()//use this function  to close search fomr and show updation form or panel
        {


        }
        database dbcon = new database();

        string location;

        string jobtype;
        string education;

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
        public bool check_user()
        {
            DataTable tb = new DataTable();

            tb = dbcon.select("select EUSERNAME from emp where EUSERNAME='" + TXT_USERNAME.Text + "'");
            if(tb.Rows.Count >0)
            {
                MessageBox.Show("username exist!");
                return false;
                
            }
            else
            {
                MessageBox.Show("username not exist!");
                return true;
            }
        }

        private void BTN_ADD_USER_Click(object sender, EventArgs e)
        {
            string jobtype;
            string education;
            //HERE WE USING REGEX TO GET VALID DATA FROM USER
            if (!Regex.IsMatch(TXT_NAME.Text, @"^[\p{L} \.\-]+$"))
            {
                TXT_NAME.BackColor = Color.Red;//REGEX IN NAME
                TXT_NAME.Focus();
            }
            else
            {
                TXT_NAME.BackColor = Color.White;
                if (!Regex.IsMatch(TXT_PHONE.Text, @"^[0-9]{11,12}$"))
                {
                    TXT_PHONE.BackColor = Color.Red;//REGEX ON PHONE NO
                    TXT_PHONE.Focus();

                }
                else
                {
                    TXT_PHONE.BackColor = Color.White;
                    ;
                    if (TXT_ADDRESS.Text == "")
                    {

                        TXT_ADDRESS.BackColor = Color.Red;
                        TXT_ADDRESS.Focus();
                    }
                    else
                    {

                        TXT_ADDRESS.BackColor = Color.White;

                        if (CBOX_LOCATION.SelectedIndex == -1)
                        {
                            CBOX_LOCATION.BackColor = Color.Red;
                            lbl_location.ForeColor = Color.Red;//CHEKING USER NOT LEFT ANY FIELD NULL
                            CBOX_LOCATION.Focus();


                        }
                        else
                        {

                            CBOX_LOCATION.BackColor = Color.White;
                            lbl_location.ForeColor = Color.White;
                            if (!Regex.IsMatch(TXT_EMAIL.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                            {
                                TXT_EMAIL.BackColor = Color.Red;
                                TXT_EMAIL.Focus();
                            }
                            else
                            {
                                TXT_EMAIL.BackColor = Color.White;
                                if (TXT_USERNAME.Text == "" && check_user())
                                {
                                    MessageBox.Show("Enter Username or username already exist!");
                                    TXT_USERNAME.BackColor = Color.Red;
                                    TXT_USERNAME.Focus();
                                }
                                else
                                {
                                    TXT_USERNAME.BackColor = Color.White;
                                    if (TXT_PASSWORD.Text == "" )
                                    {
                                       
                                        TXT_PASSWORD.BackColor = Color.Red;
                                        TXT_PASSWORD.Focus();

                                    }
                                    else
                                    {
                                        TXT_PASSWORD.BackColor = Color.White;
                                        if (RD_ADMIN.Checked)//CHECKING THE EDUCATION OF EMPLOYEEE USING CHECKED RADIO BUTTOS
                                        {
                                            jobtype = "ADMIN";
                                        }
                                        else
                                        {
                                            jobtype = "EMPLOYEE";
                                        }

                                        if (RD_BS.Checked)
                                        {
                                            education = "BS";
                                        }
                                        else if (RD_MATRIC.Checked)
                                        {
                                            education = "MATRIC";
                                        }
                                        else if (RD_INTER.Checked)
                                        {
                                            education = "INTERMEDIATE";
                                        }
                                        else if (RD_MASTER.Checked)
                                        {
                                            education = "MASTER";
                                        }
                                        else if (RD_PHD.Checked)
                                        {
                                            education = "PHD";
                                        }
                                        else
                                        {
                                            education = "DIPLOMA";
                                        }
                                        //HERE WE ARE CALLING DATABASE CLASS INSERT FUNCTION  AND PASSING INSERTION QUERY TO IT
                                        //TO INSERT EMPLOYE REGESTRARTION INFO INTO DATABASE TABLE EMP
                                        dbcon.insert(" INSERT_EMP'" + TXT_NAME.Text + "'," + TXT_PHONE.Text + ",'" + TXT_ADDRESS.Text + "','" + education + "'," + TXT_AGE.Value.ToString() + ",'" + TXT_EMAIL.Text + "','" + TXT_USERNAME.Text + "','" + TXT_PASSWORD.Text + "','" + CBOX_LOCATION.SelectedItem.ToString() + "','" + jobtype + "';");
                                        TXT_AGE.ResetText();
                                        TXT_NAME.Text = null;
                                        TXT_PHONE.Text = null;//here we reset our text boxes values for further regstrations.
                                        TXT_ADDRESS.Text = null;
                                        TXT_EMAIL.Text = null;
                                        TXT_USERNAME.Text = null;
                                        TXT_PASSWORD.Text = null;
                                        CBOX_LOCATION.SelectedItem = null;
                                    }

                                }

                            }

                        }
                    }
                }

            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            panel_update_user.Visible = true;
            panel_user_search.Visible = false;
            PANEL_USER_ADD.Visible = false;


        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            panel_update_user.Visible = false;//visi user add panel  and hide others
            PANEL_USER_ADD.Visible = true;
            PANEL_USER_ADD.BringToFront();
        }

        private void BTN_FINDE_EMP_Click(object sender, EventArgs e)
        {
            panel_user_search.Visible = true;

        }



        private void grid_forsearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = grid_forsearch.Rows[i];

            TXT_UNAME.Text = row.Cells[1].Value.ToString();
            TXT_UPHONE.Text = row.Cells[2].Value.ToString();
            TXT_UADDRESS.Text = row.Cells[3].Value.ToString();

            education = row.Cells[4].Value.ToString();
            jobtype = row.Cells[10].Value.ToString();
            TXT_UAGE.Value = Convert.ToDecimal(row.Cells[5].Value);

            location = row.Cells[9].Value.ToString();
            switch (location)
            {
                case ("KARACHI"): CBOX_ULOCATION.SelectedIndex = 1; break;
                case ("LAHORE"): CBOX_ULOCATION.SelectedIndex = 2; break;
                case ("ISLAMABAD"): CBOX_ULOCATION.SelectedIndex = 0; break;
            }
            TXT_UEMAIL.Text = row.Cells[6].Value.ToString();
            TXT_UPASSWORD.Text = row.Cells[8].Value.ToString();
            TXT_UUSERNAME.Text = row.Cells[7].Value.ToString();

            if (jobtype == "ADMIN")
            {
                RD_ADMN.Checked = true;
            }
            else
            {
                RD_MPLOYEE.Checked = true;

            }
            switch (education)
            {
                case ("MATRIC"): rdu_matric.Checked = true; break;
                case ("INTERMEDIATE"): rdu_inter.Checked = true; break;
                case ("MASTER"): rdu_master.Checked = true; break;
                case ("BS"): rdu_bs.Checked = true; break;
                case ("DIPLOMA"): radioButton1.Checked = true; break;
                case ("PHD"): rdu_phd.Checked = true; break;

            }




            panel_user_search.Visible = false;

        }

        private void txt_forsearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = dbcon.select("admin_find_emp '" + txt_forsearch.text + "'");
            grid_forsearch.DataSource = table;
        }

        private void BTN_UPDATE_EMPLOYEE_Click(object sender, EventArgs e)
        {
            //here we update employe record
            if (TXT_UUSERNAME.Text != "")
            {
                if (RD_ADMIN.Checked)//CHECKING THE EDUCATION OF EMPLOYEEE USING CHECKED RADIO BUTTOS
                {
                    jobtype = "ADMIN";
                }
                else
                {
                    jobtype = "EMPLOYEE";
                }

                if (rdu_bs.Checked)
                {
                    education = "BS";
                }
                else if (rdu_matric.Checked)
                {
                    education = "MATRIC";
                }
                else if (rdu_inter.Checked)
                {
                    education = "INTERMEDIATE";
                }
                else if (rdu_master.Checked)
                {
                    education = "MASTER";
                }
                else if (rdu_phd.Checked)
                {
                    education = "PHD";
                }
                else
                {
                    education = "DIPLOMA";
                }
                dbcon.insert("admin_update_emp'" + TXT_UNAME.Text + "','" + TXT_UPHONE.Text + "','" + TXT_UADDRESS.Text + "','" + education + "','" + TXT_UAGE.Value.ToString() + "','" + TXT_UEMAIL.Text + "','" + TXT_UUSERNAME.Text + "','" + TXT_UPASSWORD.Text + "','" + CBOX_ULOCATION.SelectedItem + "','" + jobtype + "'");
                TXT_UAGE.ResetText();
                TXT_UNAME.Text = null;
                TXT_UPHONE.Text = null;//here we reset our text boxes values for further regstrations.
                TXT_UADDRESS.Text = null;
                TXT_UEMAIL.Text = null;
                TXT_UPASSWORD.Text = null;
                TXT_UUSERNAME.Text = null;
                CBOX_ULOCATION.SelectedItem = null;

            }//IFCLOSE HERE
            else
            {
                MessageBox.Show("Find an employee first then Update it!");
            }
        }


        private void btn_delete_employee_Click(object sender, EventArgs e)
        {///here we delete employee record
            if (TXT_UUSERNAME.Text != "")
            {
                dbcon.insert("admin_delete_emp '" + TXT_UUSERNAME.Text + "'");
            }
            else
            {
                MessageBox.Show("Find an employee first then remove it!");
            }
            //now we reset fields
            TXT_UAGE.ResetText();
            TXT_UNAME.Text = null;
            TXT_UPHONE.Text = null;//here we reset our text boxes values for further regstrations.
            TXT_UADDRESS.Text = null;
            TXT_UEMAIL.Text = null;
            TXT_UPASSWORD.Text = null;
            TXT_UUSERNAME.Text = null;
            CBOX_ULOCATION.SelectedItem = null;
        }

        private void BTN_BUS_Click(object sender, EventArgs e)
        {
            //this butt willl visible the buss managment of admin
            panel_bus.Visible = true;
            panel_bus.BringToFront();
            BTN_BUS_CHAGES.Visible = true;

            DataTable table = new DataTable();
            table = dbcon.select("admin_bus_view");
            GRID_BUSES.DataSource = table;


        }

        private void BTN_USER_Click(object sender, EventArgs e)
        {
            panel_bus.Visible = false;
            panel_user.Visible = true;

        }

        private void PANEL_BUS_ADD_Paint(object sender, PaintEventArgs e)
        {

        }
        public void nullAndRefresh()
        {
            TXT_BUS_NO.Text = ""; CBOX_BUS_STATION.SelectedItem = null; CBOX_BUS_TYPE.SelectedItem = null;
            DataTable table = new DataTable();
            table = dbcon.select("admin_bus_view");
            GRID_BUSES.DataSource = table;
        }
        private void BTN_ADD_BUS_Click(object sender, EventArgs e)//this event first check data ins not null then add data to database in bus table using respective procedure
        {//code by mharis1071544
            if (TXT_BUS_NO.Text != "")
            {
                TXT_BUS_NO.BackColor = Color.White;
                if (CBOX_BUS_TYPE.SelectedIndex != -1)
                {
                    CBOX_BUS_TYPE.BackColor = Color.White;
                    lbl_bustyp.ForeColor = Color.Black;
                    if (CBOX_BUS_STATION.SelectedIndex != -1)
                    {

                        CBOX_BUS_STATION.BackColor = Color.White;
                        DataTable table = new DataTable();
                        table = dbcon.select("admin_bus_check '" + TXT_BUS_NO.Text + "'");
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Bus already exsit!");
                            TXT_BUS_NO.BackColor = Color.Red;
                            TXT_BUS_NO.Focus();
                        }
                        else
                        {
                            dbcon.insert("admin_bus_add '" + TXT_BUS_NO.Text + "','" + CBOX_BUS_TYPE.SelectedItem.ToString() + "','" + CBOX_BUS_STATION.Text + "'");
                            nullAndRefresh();//this function called to reset fields of add us pnel and refresh the grid to vew fressh records

                        }
                    }
                    else//code by mharis1071544
                    {
                        CBOX_BUS_STATION.BackColor = Color.Red;
                        lbl_station.ForeColor = Color.Red;
                        CBOX_BUS_STATION.Focus();
                    }
                }
                else
                {
                    CBOX_BUS_TYPE.BackColor = Color.Red;
                    lbl_bustyp.ForeColor = Color.Red;
                    CBOX_BUS_TYPE.Focus();
                }
            }
            else
            {
                TXT_BUS_NO.BackColor = Color.Red;
                TXT_BUS_NO.Focus();
            }
        }

        private void BTN_REMOVE_BUS_Click(object sender, EventArgs e)
        {
            if (TXT_BUS_NO.Text != "")
            {
                dbcon.insert("admin_bus_remove '" + TXT_BUS_NO.Text + "'");
                nullAndRefresh();

            }//code by mharis1071544
            else
            {
                MessageBox.Show("enter bus no to remove bus! \n OR \n chooe it from side table!");
            }
        }

        private void GRID_BUSES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            DataGridViewRow row = GRID_BUSES.Rows[i];

            TXT_BUS_NO.Text = row.Cells[0].Value.ToString();

            string STATON = row.Cells[1].Value.ToString();
            switch (STATON)
            {
                case ("EXPRESS"): CBOX_BUS_TYPE.SelectedIndex = 0; break;
                case ("LUXARY"): CBOX_BUS_TYPE.SelectedIndex = 1; break;
                case ("VOLVO(AC)"): CBOX_BUS_TYPE.SelectedIndex = 2; break;
                case ("VOLVO(NON-AC)"): CBOX_BUS_TYPE.SelectedIndex = 3; break;
            }

            //code by mharis1071544
            string type = row.Cells[2].Value.ToString();
            switch (type)
            {
                case ("KARACHI"): CBOX_BUS_STATION.SelectedIndex = 0; break;
                case ("LAHORE"): CBOX_BUS_STATION.SelectedIndex = 1; break;
                case ("ISLAMABAD"): CBOX_BUS_STATION.SelectedIndex = 2; break;
            }

        }

        private void BTN_BUS_ADD_Click(object sender, EventArgs e)
        {
            PANEL_BUS_ADD.Visible = true;
            PANEL_BUS_SCHEDULE.Visible = false;
            PANEL_BUS_CHARGES.Visible = false;


        }

        private void BTN_BUS_SCHEDULE_Click(object sender, EventArgs e)
        {
            PANEL_BUS_SCHEDULE.Visible = true;
            PANEL_BUS_CHARGES.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {//here we veriy fields are  filled or have data
            if (s_cbox_bustype.SelectedIndex != -1)
            {
                s_cbox_bustype.BackColor = Color.White;
                s_lbl_bustype.ForeColor = Color.Black;
                if (s_txt_busno.SelectedIndex != -1)
                {
                    s_txt_busno.BackColor = Color.White;
                    s_lbl_busno.ForeColor = Color.Black;
                    if (s_txt_from.SelectedIndex != -1)
                    {
                        s_txt_from.BackColor = Color.White;
                        s_lbl_from.ForeColor = Color.Black;
                        if (s_txt_to.SelectedIndex != -1)
                        {
                            s_txt_to.BackColor = Color.White;
                            s_lbl_to.ForeColor = Color.Black;

                            if (true)
                            {
                                

                                //code by mharis1071544

                                if (s_dep_date.Text != s_arr_date.Text && s_dep_date.Value < s_arr_date.Value)
                                { //after validy we enter data to schedule table 

                                    if (!Regex.IsMatch(s_txt_price.Text, @"^[0-9]{1,6}$"))
                                    {
                                        s_txt_price.BackColor = Color.Red;//REGEX ON PHONE NO
                                        s_txt_price.Focus();

                                    }
                                    else
                                    {
                                        s_txt_price.BackColor = Color.White;
                                        dbcon.insert("admin_bus_schedule_insert '" + s_txt_busno.SelectedItem.ToString() + "', '" + s_dep_date.Text + "', '" + s_arr_date.Text + "', '" + s_txt_to.SelectedItem.ToString() + "', '" + s_txt_from.SelectedItem.ToString() + "', '"+ num_seats.Value + "','" + s_txt_price.Text + "'");
                                        s_txt_busno.Items.Clear();
                                        s_cbox_bustype.Items.Clear();
                                        s_txt_to.Items.Clear();
                                        s_txt_from.Items.Clear();
                                        s_dep_date.ResetText();
                                        s_arr_date.ResetText();
                                    }



                                }
                                else
                                {
                                    MessageBox.Show("Departure and arrival time must be different!");
                                }



                            }
                            else
                            {
                                
                            }
                        }
                        else
                        {
                            s_txt_to.BackColor = Color.Red;
                            s_lbl_to.ForeColor = Color.Red;
                            s_txt_to.Focus();
                        }

                    }
                    else
                    {
                        s_txt_from.BackColor = Color.Red;
                        s_lbl_from.ForeColor = Color.Red;
                        s_txt_from.Focus();
                    }
                }
                else
                {
                    s_txt_busno.BackColor = Color.Red;
                    s_lbl_busno.ForeColor = Color.Red;
                    s_txt_busno.Focus();
                }

            }//code by mharis1071544
            else
            {
                s_cbox_bustype.BackColor = Color.Red;
                s_lbl_bustype.ForeColor = Color.Red;
                s_cbox_bustype.Focus();
            }
        }






        private void s_cbox_bustype_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = dbcon.select("admin_bus_schedule_busno '" + s_cbox_bustype.SelectedItem.ToString() + "' ");
            grid_busschedule.DataSource = table;
            s_txt_busno.Items.Clear();
            DataGridViewRow row;
            for (int i = 0; i < grid_busschedule.Rows.Count - 1; i++)
            {
                row = grid_busschedule.Rows[i];

                s_txt_busno.Items.Add(row.Cells[0].Value.ToString());

            }
        }

        private void s_txt_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HERE WE ADD  DESTINATION PLACE TO  TO FIELD AS PER THEIR  FROM FILED SELECTION SO KARACHI KARACHI OR SAME PLACE TRAVEL IS NOT POSSIBLE
            s_txt_to.Items.Clear();

            if (s_txt_from.SelectedItem.ToString() == "KARACHI")
            {
                s_txt_to.Items.Add("LAHORE");
                s_txt_to.Items.Add("ISLAMABAD");

            }//code by mharis1071544
            else if (s_txt_from.SelectedItem.ToString() == "LAHORE")
            {

                s_txt_to.Items.Add("KARACHI");
                s_txt_to.Items.Add("ISLAMABAD");
            }
            else if (s_txt_from.SelectedItem.ToString() == "ISLAMABAD")
            {

                s_txt_to.Items.Add("KARACHI");
                s_txt_to.Items.Add("LAHORE");
            }

        }

        private void s_dep_date_ValueChanged(object sender, EventArgs e)
        {
            s_dep_date.Value = DateTime.Today.AddDays(+1);
        }
        //code by mharis1071544
        private void C_BTN_ADDCHARGES_Click(object sender, EventArgs e)
        {// here we checking validity or not nulll of dataor fields
            if (!Regex.IsMatch(C_TXT_INFANT.Text, @"^[0-9]{1,3}$"))
            {
                C_TXT_INFANT.BackColor = Color.Red;
                C_TXT_INFANT.Focus();
            }
            else
            {
                C_TXT_INFANT.BackColor = Color.White;

                if (!Regex.IsMatch(C_TXT_CHILD.Text, @"^[0-9]{1,3}$"))
                {
                    C_TXT_CHILD.BackColor = Color.Red;
                    C_TXT_CHILD.Focus();
                }
                else
                {
                    C_TXT_CHILD.BackColor = Color.White;
                    if (!Regex.IsMatch(C_TXT_ADULT.Text, @"^[0-9]{1,3}$"))
                    {
                        C_TXT_ADULT.BackColor = Color.Red;
                        C_TXT_ADULT.Focus();
                    }
                    else
                    {
                        C_TXT_ADULT.BackColor = Color.White;
                        if (!Regex.IsMatch(C_TXT_OLD.Text, @"^[0-9]{1,3}$"))
                        {
                            C_TXT_OLD.BackColor = Color.Red;
                            C_TXT_OLD.Focus();
                        }
                        else
                        {
                            C_TXT_OLD.BackColor = Color.White;
                            if (!Regex.IsMatch(C_TXT_2DAY.Text, @"^[0-9]{1,3}$"))
                            {
                                C_TXT_2DAY.BackColor = Color.Red;
                                C_TXT_2DAY.Focus();
                            }
                            else
                            {
                                C_TXT_2DAY.BackColor = Color.White;
                                if (!Regex.IsMatch(C_TXT_1DAY.Text, @"^[0-9]{1,3}$"))
                                {
                                    C_TXT_1DAY.BackColor = Color.Red;
                                    C_TXT_1DAY.Focus();
                                }
                                else
                                {
                                    C_TXT_1DAY.BackColor = Color.White;
                                    if (!Regex.IsMatch(C_TXT_0DAY.Text, @"^[0-9]{1,3}$"))
                                    {
                                        C_TXT_0DAY.BackColor = Color.Red;
                                        C_TXT_0DAY.Focus();
                                    }
                                    else
                                    {
                                        C_TXT_0DAY.BackColor = Color.White;
                                        dbcon.insert("admin_bus_CHARGES_DELETE");
                                        dbcon.insert("insert into charges values('"+C_TXT_INFANT.Text+"'  ,'"+C_TXT_CHILD.Text+"' ,'"+C_TXT_ADULT.Text+"' ,'"+C_TXT_OLD.Text+"','"+C_TXT_2DAY.Text+"','"+C_TXT_1DAY.Text+"' ,'"+C_TXT_0DAY.Text+"' );");
                                        C_TXT_INFANT.Text = null; C_TXT_CHILD.Text = null; C_TXT_ADULT.Text = null; C_TXT_OLD.Text = null; C_TXT_2DAY.Text = null; C_TXT_1DAY.Text = null; C_TXT_0DAY.Text = null;
                                        //finaly charges are added here

                                    }


                                }

                            }

                        }
                    }

                }
            }//main else end
        }//charges btn click event end

        private void btn_bu_chargess_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_BUS_CHAGES_Click(object sender, EventArgs e)
        {
            PANEL_BUS_CHARGES.Visible = true;
        }

        private void BTN_LOGOUT_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void C_BTN_ADDCHARGES_Click_1(object sender, EventArgs e)
        {
            if (C_TXT_INFANT.Text != "" && C_TXT_INFANT.Text != "" && C_TXT_CHILD.Text != "" && C_TXT_ADULT.Text != "" && C_TXT_OLD.Text != "" && C_TXT_2DAY.Text != "" && C_TXT_1DAY.Text != "" && C_TXT_0DAY.Text != "")
            {
                dbcon.insert("admin_bus_CHARGES_DELETE");
                dbcon.insert("admin_TICKET_charges '" + C_TXT_INFANT.Text + "','" + C_TXT_CHILD.Text + "','" + C_TXT_ADULT.Text + "','" + C_TXT_OLD.Text + "','" + C_TXT_2DAY.Text + "','" + C_TXT_1DAY.Text + "','" + C_TXT_0DAY.Text + "'");
            }
            else
            {
                MessageBox.Show("Enter all above charges!");
            }
        }
    }//class end
}//namespace end





    
    