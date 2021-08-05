using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace BTRS2
{
    
    public partial class booking : MetroFramework.Forms.MetroForm
    {
        ArrayList al_seats = new ArrayList();
        database dbcon = new database();
        int total_price_in_checkBoxLoop = 0;
        int ticketCounter=1;

        //int count = 0;
        string username;
        int seats;
        int ageDiscount;
        
        int price;
        int SCHEDULE_NO;
        
        DataTable tableForSeats;
        public booking()
        {
            InitializeComponent();
        }
        public booking(string uname)
        {
            InitializeComponent();
            username = uname;
        }

        private void booking_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            t_cbox_to.Items.Clear();

            if (t_cbox_from.SelectedItem.ToString() == "KARACHI")
            {
                t_cbox_to.Items.Add("LAHORE");
                t_cbox_to.Items.Add("ISLAMABAD");

            }//code by mharis1071544
            else if (t_cbox_from.SelectedItem.ToString() == "LAHORE")
            {

                t_cbox_to.Items.Add("KARACHI");
                t_cbox_to.Items.Add("ISLAMABAD");
            }
            else if (t_cbox_from.SelectedItem.ToString() == "ISLAMABAD")
            {

                t_cbox_to.Items.Add("KARACHI");
                t_cbox_to.Items.Add("LAHORE");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t_cbox_from.SelectedIndex != -1 && t_cbox_to.SelectedIndex != -1)
            {
                t_lbl_seats.Text = null;
                DataTable table = new DataTable();
                table = dbcon.select(" emp_book_ticket_busess '" + t_cbox_bustype.SelectedItem.ToString() + "' ,'" + t_cbox_to.SelectedItem.ToString() + "' ,'" + t_cbox_from.SelectedItem.ToString() + "' ,'" + t_date_depart.Text + "' ,'" + t_date_arrival.Text + "'  ");
                tempgrid.DataSource = table;
                tableForSeats = table;
                t_cbox_busno.Items.Clear();
                DataGridViewRow row;
                for (int i = 0; i < tempgrid.Rows.Count - 1; i++)
                {
                    row = tempgrid.Rows[i];

                    t_cbox_busno.Items.Add(row.Cells[0].Value.ToString());

                }
            }
            else
            {
                MessageBox.Show("Select To and From Places Above!");
            }
        }

        private void t_txt_name_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(t_txt_name.Text, @"^[\p{L} \.\-]+$"))
            {
                t_txt_name.BackColor = Color.Red;//REGEX IN NAME
                t_txt_name.Focus();
            }
            else
            {
                t_txt_name.BackColor = Color.White;

            }

        }

        private void t_txt_name_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(t_txt_name.Text, @"^[\p{L} \.\-]+$"))
            {
                t_txt_name.BackColor = Color.Red;//REGEX IN NAME
                t_txt_name.Focus();
            }
            else
            {
                t_txt_name.BackColor = Color.White;

            }
        }

       

       

        private void t_txt_cnic_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(t_txt_cnic.Text, @"^[0-9]{13,13}$"))
            {//validate age text on text changed event
                t_txt_cnic.BackColor = Color.Red;//REGEX IN NAME
                t_txt_cnic.Focus();
            }
            else
            {
                t_txt_cnic.BackColor = Color.White;

            }
        }

        private void t_txt_cnic_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(t_txt_cnic.Text, @"^[0-9]{13,13}$"))
            {//validate age text on text changed event
                t_txt_cnic.BackColor = Color.Red;//REGEX IN NAME
                t_txt_cnic.Focus();
            }
            else
            {
                t_txt_cnic.BackColor = Color.White;

            }
        }

        private void bunifuCustomTextbox7_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(t_txt_phone.Text, @"^[0-9]{11,11}$"))
            {//validate age text on text changed event
                t_txt_phone.BackColor = Color.Red;//REGEX IN NAME
                t_txt_phone.Focus();
            }
            else
            {
                t_txt_phone.BackColor = Color.White;

            }
        }

        private void t_txt_phone_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(t_txt_phone.Text, @"^[0-9]{11,11}$"))
            {//validate age text on text changed event
                t_txt_phone.BackColor = Color.Red;//REGEX IN NAME
                t_txt_phone.Focus();
            }
            else
            {
                t_txt_phone.BackColor = Color.White;

            }
        }

        private void t_date_depart_Leave(object sender, EventArgs e)
        {
            //increase arrival date  by to departure date after selecting departure date
            if (t_date_depart.Value >= TODAY_DATE.Value)
            {
                DateTime t = new DateTime();

                t = t_date_depart.Value;
                t_date_arrival.Value = t.AddDays(1);
            }
            else
            {
                MessageBox.Show("donot Pick past dates!");
                t_date_depart.Focus();
            }
            
        }

        private void t_cbox_busno_SelectedIndexChanged(object sender, EventArgs e)
        {

            //here we calculate ticket price after selecting bus and bu type

            tempgrid.DataSource = tableForSeats;
            DataGridViewRow row;
            string busno = t_cbox_busno.SelectedItem.ToString();

            for (int i = 0; i < tempgrid.Rows.Count - 1; i++)
            {
                row = tempgrid.Rows[i];
                //geting no of seats of selecxt bus no;
                if (row.Cells[0].Value.ToString() == busno)
                {
                    t_lbl_seats.Text = row.Cells[1].Value.ToString();
                    seats = Convert.ToInt32(row.Cells[1].Value);
                    showSeats(seats);
                    price = Convert.ToInt32(row.Cells[2].Value);

                    SCHEDULE_NO = Convert.ToInt32(row.Cells[3].Value);

                    lbl_top_price.Text = price.ToString();
                    if (seats >= 0)
                    {
                        //btn_bookticket.Visible = true;
                        //btn_print.Visible = false;
                        //check selected or avilable seats here
                        fillSeats();
                    }
                    else
                    {
                        //btn_bookticket.Visible = false;
                        //btn_print.Visible = false;
                    }
                    break;
                }
                else
                {
                    continue;
                }


            }//end for loop
            


        }

        private void BTN_REET_Click(object sender, EventArgs e)
        {
            PANEL_AGEOFSEATS.Visible = false;
            checkbox_panel.Controls.Clear();
            t_txt_name.Text = "";
            t_txt_phone.Text = null;
            t_txt_cnic.Text = null;
            global_i = 0;
            
            total_price_in_checkBoxLoop = 0;
            al_seats.Clear();



            t_date_arrival.ResetText();
            t_date_depart.ResetText();
        }
        PdfDocument doc;
        PdfPageBase page;
        System.Drawing.Image backgroundImage = System.Drawing.Image.FromFile("back.png");
       
        private void btn_bookticket_Click(object sender, EventArgs e)
        {//here we insert our final ticket information to database
            PANEL_AGEOFSEATS.Visible = false;
            
            btn_nextAge.Visible = true;
            getseatsFromcheckboxes();
            //ticket printing file is created here
            doc = new PdfDocument();
            page = doc.Pages.Add();
            //declare or add pages to file as per no of tickets


            if (al_seats.Count >0)
            {
                P_NUM_AGE.Visible = true;
                lbl_agepanle.Visible = true;
                lbl_seat_no_Ofage.Visible = true;
                PANEL_AGEOFSEATS.Visible = true;
                lbl_seat_no_Ofage.Text = al_seats[global_i].ToString();
            }
            else
            {
                MessageBox.Show("Choose Seats !");
                PANEL_AGEOFSEATS.Visible = false;
            }
            
          
            /// dbcon.insert("emp_insert_customer '"+t_txt_name.Text+"',"+t_txt_age.Text+",'"+t_txt_cnic.Text+"','"+t_txt_phone.Text+"',"+SCHEDULE_NO+","+total+"");
           
            
            //btn_print.Visible = true;


        }

        


        private void btn_small_pricelist_Click(object sender, EventArgs e)
        {
            pricelist p = new pricelist();
            p.Show();
        }
        public void fillSeats()
        {

        }
        public void showSeats(int s)
        {//here size panel of seats according to no of seats

            checkbox_panel.Controls.Clear();
            if (s > 0 && s <= 30)
            {
                checkbox_panel.Size = new Size(370, 100);
                fillseatpanel();
            }
            else if (s > 30 && s <= 50)
            {
                checkbox_panel.Size = new Size(470, 120);
                fillseatpanel();
            }
            else if (s > 50 && s <= 60)
            {
                checkbox_panel.Size = new Size(470, 140);
                fillseatpanel();
            }
            seatAlreadyBooked();
        }
        public void fillseatpanel()
        {//this function is used to show chexkboxes as seats in bus on form
            int pr = 0;
            for (int i = 1; i <= seats; i++)
            {

                CheckBox c = new CheckBox();
                c.Size = new Size(40, 17);
                c.Text = i.ToString();
                c.Name = "s" + i.ToString();
                c.Location = new Point(pr, 30);
                pr = pr + 40;
                checkbox_panel.Controls.Add(c);
            }


        }
        public void getseatsFromcheckboxes()
        {//here we get checked seats nos
            int count = 0;
            foreach (Control c in checkbox_panel.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    al_seats.Add(c.Text);
                    count++;

                }
            }



        }



       

       

       

        public int calcTicketPrice(int age)
        {
           int prise=0;

            DataTable table = new DataTable();
            table = dbcon.select("emp_age_charges_return");
            tempgrid.DataSource = table;
            DataGridViewRow row;
            row = tempgrid.Rows[0];


            if (age >= 0 && age <= 4)
            {
                ageDiscount = Convert.ToInt32(row.Cells[1].Value);
            }
            else if (age >= 5 && age <= 12)
            {
                ageDiscount = Convert.ToInt32(row.Cells[2].Value);
            }
            else if (age > 12 && age <= 50)
            {
                ageDiscount = Convert.ToInt32(row.Cells[3].Value);
            }
            else if (age > 50)
            {
                ageDiscount = Convert.ToInt32(row.Cells[4].Value);
            }
            else { ageDiscount = 0; }

            prise = ((price / 100) * ageDiscount);
            

            return prise;
        }
       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            EmployeePanel p = new EmployeePanel();
            p.Show();
            this.Hide();
        }
        int global_i = 0;
        int col = 0;
        //here we declare 11 pages of tickets
        
        private void btn_nextAge_Click(object sender, EventArgs e)
        {

            if (global_i < al_seats.Count)
            {

                int tage;
            int tprice;
            lbl_seat_no_Ofage.Text = al_seats[global_i].ToString();
            tage = Convert.ToInt32(P_NUM_AGE.Value);
            tprice = calcTicketPrice(tage);
                //design print pattern here
                dbcon.insert("emp_insert_customer '" + t_txt_name.Text + "'," + tage.ToString() + ",'" + t_txt_cnic.Text + "','" + t_txt_phone.Text + "'," + SCHEDULE_NO + "," + tprice.ToString() + ",'"+ lbl_seat_no_Ofage.Text + "'");
                //data inserted in databse 
                if (ticketCounter > 5)
                {
                    page = doc.Pages.Add();
                    col = 0;
                    ticketCounter = 1;
                }
                


                
                    
                    col += 20;
                    page.Canvas.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", new PdfFont(PdfFontFamily.Helvetica, 12f), new PdfSolidBrush(Color.Black), 10, col);
                    col += 20;
                    page.Canvas.DrawString("NAME:" + t_txt_name.Text + "\t\t\t\t\t CNIC: " + t_txt_cnic.Text + "\t\t\t\t\t AGE: " + tage.ToString(), new PdfFont(PdfFontFamily.Helvetica, 12f), new PdfSolidBrush(Color.Black), 10, col);
                    col += 20;
                    page.Canvas.DrawString("FROM:" + t_cbox_from.SelectedItem.ToString() + "\t\t\t\t\t DATE: " + t_date_depart.Text, new PdfFont(PdfFontFamily.Helvetica, 12f), new PdfSolidBrush(Color.Black), 10, col);
                    col += 20;
                    page.Canvas.DrawString("TO:" + t_cbox_to.SelectedItem.ToString() + "\t\t\t\t\t DATE: " + t_date_arrival.Text, new PdfFont(PdfFontFamily.Helvetica, 12f), new PdfSolidBrush(Color.Black), 10, col);
                    col += 20;
                    page.Canvas.DrawString("BusType:" + t_cbox_bustype.SelectedItem.ToString() + "\t\t\t\t\t BusNo: " + t_cbox_busno.SelectedItem.ToString() + "\t\t\t\t\t Seat#: " + lbl_seat_no_Ofage.Text + Environment.NewLine, new PdfFont(PdfFontFamily.Helvetica, 12f), new PdfSolidBrush(Color.Black), 10, col);
                    col += 20;
                    page.Canvas.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", new PdfFont(PdfFontFamily.Helvetica, 12f), new PdfSolidBrush(Color.Black), 10, col);
                    col += 20;
                
                ticketCounter++;


                //Thread.Sleep((int)TimeSpan.FromSeconds(2).TotalMilliseconds);
                total_price_in_checkBoxLoop += tprice;

            
             
           
                if (global_i >= al_seats.Count-1)
                {
                    btn_print.Visible = true;
                    btn_nextAge.Visible = false;
                    global_i = 0;
                }
                else
                {
                   
                    global_i++;
                    lbl_seat_no_Ofage.Text = al_seats[global_i].ToString();
                }
               
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            EmployeePanel p = new EmployeePanel();
            p.Show();
            this.Hide();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //Action on print button click done here
            page.Canvas.DrawString("TOTAL PRICE::"+ total_price_in_checkBoxLoop + Environment.NewLine, new PdfFont(PdfFontFamily.Helvetica, 16f), new PdfSolidBrush(Color.Black), 10, col);
            try
            {
                doc.SaveToFile("ticket.pdf");

                doc.Close();
                MessageBox.Show("Ticket Printed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ticket not printed \n"+ex.ToString());
            }

            btn_print.Visible = false;

            
            
           

            total_price_in_checkBoxLoop = 0;
            al_seats.Clear();
            checkbox_panel.Controls.Clear();
            

            PANEL_AGEOFSEATS.Visible = false;
            checkbox_panel.Controls.Clear();
            t_txt_name.Text = "";
            t_txt_phone.Text = null;
            t_txt_cnic.Text = null;
            global_i = 0;
            



            t_date_arrival.ResetText();
            t_date_depart.ResetText();

        }

        //in this we disable those seats or chekboxes which are already booked.
        public void seatAlreadyBooked()
        {
            DataTable table = new DataTable();
            table = dbcon.select("getLeftSeats '" + t_date_depart.Text + "','" + t_date_arrival.Text + "'");
             grid_checkseats.DataSource = table;
            DataGridViewRow row;
            

            for (int i = 0; i <= grid_checkseats.Rows.Count - 2; i++)
            {
                row = grid_checkseats.Rows[i];
                string s = row.Cells[0].Value.ToString();
                
                   
                    foreach (Control c in checkbox_panel.Controls)
                    {
                    if(c.Text==s)
                    {
                        c.Enabled = false;
                    }





                    }
                
            }

            
        }
    }
}
