namespace BTRS2
{
    partial class booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.s = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grid_checkseats = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.PANEL_AGEOFSEATS = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_seat_no_Ofage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_nextAge = new Bunifu.Framework.UI.BunifuFlatButton();
            this.P_NUM_AGE = new System.Windows.Forms.NumericUpDown();
            this.lbl_agepanle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkbox_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_small_pricelist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_REET = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_bookticket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tempgrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lbl_top_price = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddf = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_ticket_booking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_lbl_seats = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_date_arrival = new System.Windows.Forms.DateTimePicker();
            this.t_date_depart = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_txt_cnic = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.t_txt_phone = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.t_txt_name = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_cbox_from = new System.Windows.Forms.ComboBox();
            this.t_cbox_to = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_cbox_busno = new System.Windows.Forms.ComboBox();
            this.t_cbox_bustype = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TODAY_DATE = new System.Windows.Forms.DateTimePicker();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_checkseats)).BeginInit();
            this.PANEL_AGEOFSEATS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_NUM_AGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("s.BackgroundImage")));
            this.s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.s.Controls.Add(this.PANEL_AGEOFSEATS);
            this.s.Controls.Add(this.grid_checkseats);
            this.s.Controls.Add(this.checkbox_panel);
            this.s.Controls.Add(this.btn_small_pricelist);
            this.s.Controls.Add(this.BTN_REET);
            this.s.Controls.Add(this.btn_bookticket);
            this.s.Controls.Add(this.tempgrid);
            this.s.Controls.Add(this.lbl_top_price);
            this.s.Controls.Add(this.ddf);
            this.s.Controls.Add(this.btn_ticket_booking);
            this.s.Controls.Add(this.groupBox1);
            this.s.GradientBottomLeft = System.Drawing.Color.Gainsboro;
            this.s.GradientBottomRight = System.Drawing.Color.White;
            this.s.GradientTopLeft = System.Drawing.Color.White;
            this.s.GradientTopRight = System.Drawing.Color.White;
            this.s.Location = new System.Drawing.Point(13, 84);
            this.s.Name = "s";
            this.s.Quality = 10;
            this.s.Size = new System.Drawing.Size(930, 464);
            this.s.TabIndex = 0;
            // 
            // grid_checkseats
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_checkseats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_checkseats.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid_checkseats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_checkseats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_checkseats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_checkseats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_checkseats.DoubleBuffered = true;
            this.grid_checkseats.EnableHeadersVisualStyles = false;
            this.grid_checkseats.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grid_checkseats.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.grid_checkseats.Location = new System.Drawing.Point(904, 447);
            this.grid_checkseats.Name = "grid_checkseats";
            this.grid_checkseats.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_checkseats.Size = new System.Drawing.Size(11, 15);
            this.grid_checkseats.TabIndex = 33;
            this.grid_checkseats.Visible = false;
            // 
            // PANEL_AGEOFSEATS
            // 
            this.PANEL_AGEOFSEATS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PANEL_AGEOFSEATS.BackgroundImage")));
            this.PANEL_AGEOFSEATS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PANEL_AGEOFSEATS.Controls.Add(this.lbl_seat_no_Ofage);
            this.PANEL_AGEOFSEATS.Controls.Add(this.btn_nextAge);
            this.PANEL_AGEOFSEATS.Controls.Add(this.P_NUM_AGE);
            this.PANEL_AGEOFSEATS.Controls.Add(this.lbl_agepanle);
            this.PANEL_AGEOFSEATS.Controls.Add(this.btn_print);
            this.PANEL_AGEOFSEATS.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PANEL_AGEOFSEATS.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PANEL_AGEOFSEATS.GradientTopLeft = System.Drawing.Color.White;
            this.PANEL_AGEOFSEATS.GradientTopRight = System.Drawing.Color.White;
            this.PANEL_AGEOFSEATS.Location = new System.Drawing.Point(386, 8);
            this.PANEL_AGEOFSEATS.Name = "PANEL_AGEOFSEATS";
            this.PANEL_AGEOFSEATS.Quality = 10;
            this.PANEL_AGEOFSEATS.Size = new System.Drawing.Size(541, 221);
            this.PANEL_AGEOFSEATS.TabIndex = 13;
            this.PANEL_AGEOFSEATS.Visible = false;
            // 
            // lbl_seat_no_Ofage
            // 
            this.lbl_seat_no_Ofage.AutoSize = true;
            this.lbl_seat_no_Ofage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seat_no_Ofage.Location = new System.Drawing.Point(483, 12);
            this.lbl_seat_no_Ofage.Name = "lbl_seat_no_Ofage";
            this.lbl_seat_no_Ofage.Size = new System.Drawing.Size(37, 33);
            this.lbl_seat_no_Ofage.TabIndex = 13;
            this.lbl_seat_no_Ofage.Text = "--";
            // 
            // btn_nextAge
            // 
            this.btn_nextAge.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_nextAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_nextAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nextAge.BorderRadius = 0;
            this.btn_nextAge.ButtonText = "Save/Next";
            this.btn_nextAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextAge.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nextAge.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nextAge.Iconimage = null;
            this.btn_nextAge.Iconimage_right = null;
            this.btn_nextAge.Iconimage_right_Selected = null;
            this.btn_nextAge.Iconimage_Selected = null;
            this.btn_nextAge.IconMarginLeft = 0;
            this.btn_nextAge.IconMarginRight = 0;
            this.btn_nextAge.IconRightVisible = true;
            this.btn_nextAge.IconRightZoom = 0D;
            this.btn_nextAge.IconVisible = true;
            this.btn_nextAge.IconZoom = 90D;
            this.btn_nextAge.IsTab = false;
            this.btn_nextAge.Location = new System.Drawing.Point(169, 139);
            this.btn_nextAge.Name = "btn_nextAge";
            this.btn_nextAge.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_nextAge.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nextAge.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_nextAge.selected = false;
            this.btn_nextAge.Size = new System.Drawing.Size(209, 71);
            this.btn_nextAge.TabIndex = 12;
            this.btn_nextAge.Text = "Save/Next";
            this.btn_nextAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nextAge.Textcolor = System.Drawing.Color.White;
            this.btn_nextAge.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextAge.Click += new System.EventHandler(this.btn_nextAge_Click);
            // 
            // P_NUM_AGE
            // 
            this.P_NUM_AGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_NUM_AGE.Location = new System.Drawing.Point(209, 57);
            this.P_NUM_AGE.Name = "P_NUM_AGE";
            this.P_NUM_AGE.Size = new System.Drawing.Size(87, 31);
            this.P_NUM_AGE.TabIndex = 11;
            this.P_NUM_AGE.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.P_NUM_AGE.Visible = false;
            // 
            // lbl_agepanle
            // 
            this.lbl_agepanle.AutoSize = true;
            this.lbl_agepanle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agepanle.Location = new System.Drawing.Point(4, 12);
            this.lbl_agepanle.Name = "lbl_agepanle";
            this.lbl_agepanle.Size = new System.Drawing.Size(473, 34);
            this.lbl_agepanle.TabIndex = 9;
            this.lbl_agepanle.Text = "Enter Age of Passesnger At seat#";
            // 
            // btn_print
            // 
            this.btn_print.Activecolor = System.Drawing.Color.Teal;
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print.BorderRadius = 0;
            this.btn_print.ButtonText = "PRINT TICKET";
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.DisabledColor = System.Drawing.Color.Gray;
            this.btn_print.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_print.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_print.Iconimage")));
            this.btn_print.Iconimage_right = null;
            this.btn_print.Iconimage_right_Selected = null;
            this.btn_print.Iconimage_Selected = null;
            this.btn_print.IconMarginLeft = 0;
            this.btn_print.IconMarginRight = 0;
            this.btn_print.IconRightVisible = true;
            this.btn_print.IconRightZoom = 0D;
            this.btn_print.IconVisible = true;
            this.btn_print.IconZoom = 90D;
            this.btn_print.IsTab = false;
            this.btn_print.Location = new System.Drawing.Point(169, 139);
            this.btn_print.Name = "btn_print";
            this.btn_print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_print.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_print.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_print.selected = false;
            this.btn_print.Size = new System.Drawing.Size(209, 71);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "PRINT TICKET";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print.Textcolor = System.Drawing.Color.White;
            this.btn_print.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Visible = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // checkbox_panel
            // 
            this.checkbox_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkbox_panel.Location = new System.Drawing.Point(430, 23);
            this.checkbox_panel.Name = "checkbox_panel";
            this.checkbox_panel.Size = new System.Drawing.Size(474, 140);
            this.checkbox_panel.TabIndex = 9;
            // 
            // btn_small_pricelist
            // 
            this.btn_small_pricelist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_small_pricelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_small_pricelist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_small_pricelist.BorderRadius = 0;
            this.btn_small_pricelist.ButtonText = "price list";
            this.btn_small_pricelist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_small_pricelist.DisabledColor = System.Drawing.Color.Gray;
            this.btn_small_pricelist.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_small_pricelist.Iconimage = null;
            this.btn_small_pricelist.Iconimage_right = null;
            this.btn_small_pricelist.Iconimage_right_Selected = null;
            this.btn_small_pricelist.Iconimage_Selected = null;
            this.btn_small_pricelist.IconMarginLeft = 0;
            this.btn_small_pricelist.IconMarginRight = 0;
            this.btn_small_pricelist.IconRightVisible = true;
            this.btn_small_pricelist.IconRightZoom = 0D;
            this.btn_small_pricelist.IconVisible = true;
            this.btn_small_pricelist.IconZoom = 90D;
            this.btn_small_pricelist.IsTab = false;
            this.btn_small_pricelist.Location = new System.Drawing.Point(243, 398);
            this.btn_small_pricelist.Name = "btn_small_pricelist";
            this.btn_small_pricelist.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_small_pricelist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_small_pricelist.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_small_pricelist.selected = false;
            this.btn_small_pricelist.Size = new System.Drawing.Size(137, 48);
            this.btn_small_pricelist.TabIndex = 9;
            this.btn_small_pricelist.Text = "price list";
            this.btn_small_pricelist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_small_pricelist.Textcolor = System.Drawing.Color.White;
            this.btn_small_pricelist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_small_pricelist.Click += new System.EventHandler(this.btn_small_pricelist_Click);
            // 
            // BTN_REET
            // 
            this.BTN_REET.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_REET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_REET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_REET.BorderRadius = 0;
            this.BTN_REET.ButtonText = "New Ticket";
            this.BTN_REET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_REET.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_REET.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_REET.Iconimage = null;
            this.BTN_REET.Iconimage_right = null;
            this.BTN_REET.Iconimage_right_Selected = null;
            this.BTN_REET.Iconimage_Selected = null;
            this.BTN_REET.IconMarginLeft = 0;
            this.BTN_REET.IconMarginRight = 0;
            this.BTN_REET.IconRightVisible = true;
            this.BTN_REET.IconRightZoom = 0D;
            this.BTN_REET.IconVisible = true;
            this.BTN_REET.IconZoom = 90D;
            this.BTN_REET.IsTab = false;
            this.BTN_REET.Location = new System.Drawing.Point(24, 398);
            this.BTN_REET.Name = "BTN_REET";
            this.BTN_REET.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_REET.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_REET.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_REET.selected = false;
            this.BTN_REET.Size = new System.Drawing.Size(143, 48);
            this.BTN_REET.TabIndex = 8;
            this.BTN_REET.Text = "New Ticket";
            this.BTN_REET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_REET.Textcolor = System.Drawing.Color.White;
            this.BTN_REET.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_REET.Click += new System.EventHandler(this.BTN_REET_Click);
            // 
            // btn_bookticket
            // 
            this.btn_bookticket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_bookticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_bookticket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bookticket.BorderRadius = 0;
            this.btn_bookticket.ButtonText = "Book Seats";
            this.btn_bookticket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bookticket.DisabledColor = System.Drawing.Color.Gray;
            this.btn_bookticket.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_bookticket.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_bookticket.Iconimage")));
            this.btn_bookticket.Iconimage_right = null;
            this.btn_bookticket.Iconimage_right_Selected = null;
            this.btn_bookticket.Iconimage_Selected = null;
            this.btn_bookticket.IconMarginLeft = 0;
            this.btn_bookticket.IconMarginRight = 0;
            this.btn_bookticket.IconRightVisible = true;
            this.btn_bookticket.IconRightZoom = 0D;
            this.btn_bookticket.IconVisible = true;
            this.btn_bookticket.IconZoom = 90D;
            this.btn_bookticket.IsTab = false;
            this.btn_bookticket.Location = new System.Drawing.Point(430, 339);
            this.btn_bookticket.Name = "btn_bookticket";
            this.btn_bookticket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_bookticket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bookticket.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_bookticket.selected = false;
            this.btn_bookticket.Size = new System.Drawing.Size(209, 93);
            this.btn_bookticket.TabIndex = 10;
            this.btn_bookticket.Text = "Book Seats";
            this.btn_bookticket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bookticket.Textcolor = System.Drawing.Color.White;
            this.btn_bookticket.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookticket.Click += new System.EventHandler(this.btn_bookticket_Click);
            // 
            // tempgrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tempgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tempgrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tempgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tempgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tempgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tempgrid.DoubleBuffered = true;
            this.tempgrid.EnableHeadersVisualStyles = false;
            this.tempgrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.tempgrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.tempgrid.Location = new System.Drawing.Point(916, 448);
            this.tempgrid.Name = "tempgrid";
            this.tempgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tempgrid.Size = new System.Drawing.Size(11, 13);
            this.tempgrid.TabIndex = 6;
            this.tempgrid.Visible = false;
            // 
            // lbl_top_price
            // 
            this.lbl_top_price.AutoSize = true;
            this.lbl_top_price.BackColor = System.Drawing.Color.Black;
            this.lbl_top_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_top_price.Location = new System.Drawing.Point(583, 263);
            this.lbl_top_price.Name = "lbl_top_price";
            this.lbl_top_price.Size = new System.Drawing.Size(64, 25);
            this.lbl_top_price.TabIndex = 5;
            this.lbl_top_price.Text = "____";
            // 
            // ddf
            // 
            this.ddf.AutoSize = true;
            this.ddf.BackColor = System.Drawing.Color.Black;
            this.ddf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ddf.Location = new System.Drawing.Point(425, 263);
            this.ddf.Name = "ddf";
            this.ddf.Size = new System.Drawing.Size(144, 25);
            this.ddf.TabIndex = 2;
            this.ddf.Text = "Ticket Price:";
            // 
            // btn_ticket_booking
            // 
            this.btn_ticket_booking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ticket_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ticket_booking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ticket_booking.BorderRadius = 0;
            this.btn_ticket_booking.ButtonText = "BOOK TICKET";
            this.btn_ticket_booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ticket_booking.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ticket_booking.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ticket_booking.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ticket_booking.Iconimage")));
            this.btn_ticket_booking.Iconimage_right = null;
            this.btn_ticket_booking.Iconimage_right_Selected = null;
            this.btn_ticket_booking.Iconimage_Selected = null;
            this.btn_ticket_booking.IconMarginLeft = 0;
            this.btn_ticket_booking.IconMarginRight = 0;
            this.btn_ticket_booking.IconRightVisible = true;
            this.btn_ticket_booking.IconRightZoom = 0D;
            this.btn_ticket_booking.IconVisible = true;
            this.btn_ticket_booking.IconZoom = 90D;
            this.btn_ticket_booking.IsTab = false;
            this.btn_ticket_booking.Location = new System.Drawing.Point(564, 620);
            this.btn_ticket_booking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ticket_booking.Name = "btn_ticket_booking";
            this.btn_ticket_booking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ticket_booking.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_ticket_booking.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ticket_booking.selected = false;
            this.btn_ticket_booking.Size = new System.Drawing.Size(362, 74);
            this.btn_ticket_booking.TabIndex = 1;
            this.btn_ticket_booking.Text = "BOOK TICKET";
            this.btn_ticket_booking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ticket_booking.Textcolor = System.Drawing.Color.White;
            this.btn_ticket_booking.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_lbl_seats);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel17);
            this.groupBox1.Controls.Add(this.t_date_arrival);
            this.groupBox1.Controls.Add(this.t_date_depart);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.t_txt_cnic);
            this.groupBox1.Controls.Add(this.t_txt_phone);
            this.groupBox1.Controls.Add(this.t_txt_name);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.t_cbox_from);
            this.groupBox1.Controls.Add(this.t_cbox_to);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.t_cbox_busno);
            this.groupBox1.Controls.Add(this.t_cbox_bustype);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel10);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 364);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Booking";
            // 
            // t_lbl_seats
            // 
            this.t_lbl_seats.AutoSize = true;
            this.t_lbl_seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_lbl_seats.Location = new System.Drawing.Point(255, 316);
            this.t_lbl_seats.Name = "t_lbl_seats";
            this.t_lbl_seats.Size = new System.Drawing.Size(29, 20);
            this.t_lbl_seats.TabIndex = 22;
            this.t_lbl_seats.Text = "00";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(130, 318);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(92, 16);
            this.bunifuCustomLabel17.TabIndex = 21;
            this.bunifuCustomLabel17.Text = "Total Seats:";
            // 
            // t_date_arrival
            // 
            this.t_date_arrival.Location = new System.Drawing.Point(66, 214);
            this.t_date_arrival.Name = "t_date_arrival";
            this.t_date_arrival.Size = new System.Drawing.Size(200, 20);
            this.t_date_arrival.TabIndex = 6;
            // 
            // t_date_depart
            // 
            this.t_date_depart.Location = new System.Drawing.Point(67, 188);
            this.t_date_depart.Name = "t_date_depart";
            this.t_date_depart.Size = new System.Drawing.Size(200, 20);
            this.t_date_depart.TabIndex = 5;
            this.t_date_depart.Leave += new System.EventHandler(this.t_date_depart_Leave);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(24, 214);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(36, 13);
            this.bunifuCustomLabel5.TabIndex = 16;
            this.bunifuCustomLabel5.Text = "Arrival";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(6, 188);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(54, 13);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "Departure";
            // 
            // t_txt_cnic
            // 
            this.t_txt_cnic.BorderColor = System.Drawing.Color.SeaGreen;
            this.t_txt_cnic.Location = new System.Drawing.Point(67, 71);
            this.t_txt_cnic.MaxLength = 13;
            this.t_txt_cnic.Name = "t_txt_cnic";
            this.t_txt_cnic.Size = new System.Drawing.Size(155, 20);
            this.t_txt_cnic.TabIndex = 1;
            this.t_txt_cnic.TextChanged += new System.EventHandler(this.t_txt_cnic_TextChanged);
            this.t_txt_cnic.Leave += new System.EventHandler(this.t_txt_cnic_Leave);
            // 
            // t_txt_phone
            // 
            this.t_txt_phone.BorderColor = System.Drawing.Color.SeaGreen;
            this.t_txt_phone.Location = new System.Drawing.Point(68, 97);
            this.t_txt_phone.MaxLength = 11;
            this.t_txt_phone.Name = "t_txt_phone";
            this.t_txt_phone.Size = new System.Drawing.Size(155, 20);
            this.t_txt_phone.TabIndex = 2;
            this.t_txt_phone.TextChanged += new System.EventHandler(this.bunifuCustomTextbox7_TextChanged);
            this.t_txt_phone.Leave += new System.EventHandler(this.t_txt_phone_Leave);
            // 
            // t_txt_name
            // 
            this.t_txt_name.BorderColor = System.Drawing.Color.SeaGreen;
            this.t_txt_name.Location = new System.Drawing.Point(67, 37);
            this.t_txt_name.MaxLength = 50;
            this.t_txt_name.Name = "t_txt_name";
            this.t_txt_name.Size = new System.Drawing.Size(155, 20);
            this.t_txt_name.TabIndex = 0;
            this.t_txt_name.TextChanged += new System.EventHandler(this.t_txt_name_TextChanged);
            this.t_txt_name.Leave += new System.EventHandler(this.t_txt_name_Leave);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(24, 100);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel8.TabIndex = 8;
            this.bunifuCustomLabel8.Text = "Phone";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(29, 74);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(32, 13);
            this.bunifuCustomLabel7.TabIndex = 10;
            this.bunifuCustomLabel7.Text = "CNIC";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(24, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Name";
            // 
            // t_cbox_from
            // 
            this.t_cbox_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cbox_from.FormattingEnabled = true;
            this.t_cbox_from.Items.AddRange(new object[] {
            "KARACHI",
            "LAHORE",
            "ISLAMABAD"});
            this.t_cbox_from.Location = new System.Drawing.Point(67, 125);
            this.t_cbox_from.Name = "t_cbox_from";
            this.t_cbox_from.Size = new System.Drawing.Size(155, 21);
            this.t_cbox_from.TabIndex = 3;
            this.t_cbox_from.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // t_cbox_to
            // 
            this.t_cbox_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cbox_to.FormattingEnabled = true;
            this.t_cbox_to.Location = new System.Drawing.Point(67, 152);
            this.t_cbox_to.Name = "t_cbox_to";
            this.t_cbox_to.Size = new System.Drawing.Size(155, 21);
            this.t_cbox_to.TabIndex = 4;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(41, 155);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(20, 13);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "To";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 128);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(30, 13);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "From";
            // 
            // t_cbox_busno
            // 
            this.t_cbox_busno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cbox_busno.FormattingEnabled = true;
            this.t_cbox_busno.Location = new System.Drawing.Point(67, 277);
            this.t_cbox_busno.Name = "t_cbox_busno";
            this.t_cbox_busno.Size = new System.Drawing.Size(155, 21);
            this.t_cbox_busno.TabIndex = 8;
            this.t_cbox_busno.SelectedIndexChanged += new System.EventHandler(this.t_cbox_busno_SelectedIndexChanged);
            // 
            // t_cbox_bustype
            // 
            this.t_cbox_bustype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cbox_bustype.FormattingEnabled = true;
            this.t_cbox_bustype.Items.AddRange(new object[] {
            "EXPRESS",
            "LUXARY",
            "VOLVO(AC)",
            "VOLVO(NON-AC)"});
            this.t_cbox_bustype.Location = new System.Drawing.Point(68, 244);
            this.t_cbox_bustype.Name = "t_cbox_bustype";
            this.t_cbox_bustype.Size = new System.Drawing.Size(155, 21);
            this.t_cbox_bustype.TabIndex = 7;
            this.t_cbox_bustype.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(18, 280);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel10.TabIndex = 0;
            this.bunifuCustomLabel10.Text = "Bus No";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(10, 247);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel9.TabIndex = 0;
            this.bunifuCustomLabel9.Text = "Bus Type";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "<-Home";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(860, 30);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(68, 48);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "<-Home";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // TODAY_DATE
            // 
            this.TODAY_DATE.Enabled = false;
            this.TODAY_DATE.Location = new System.Drawing.Point(549, 58);
            this.TODAY_DATE.Name = "TODAY_DATE";
            this.TODAY_DATE.Size = new System.Drawing.Size(200, 20);
            this.TODAY_DATE.TabIndex = 15;
            // 
            // booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 558);
            this.Controls.Add(this.TODAY_DATE);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.s);
            this.Name = "booking";
            this.Resizable = false;
            this.Text = "Ticket Booking";
            this.Load += new System.EventHandler(this.booking_Load);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_checkseats)).EndInit();
            this.PANEL_AGEOFSEATS.ResumeLayout(false);
            this.PANEL_AGEOFSEATS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_NUM_AGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel s;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ticket_booking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox t_cbox_bustype;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox t_cbox_busno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.ComboBox t_cbox_from;
        private System.Windows.Forms.ComboBox t_cbox_to;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox t_txt_cnic;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox t_txt_phone;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox t_txt_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker t_date_arrival;
        private System.Windows.Forms.DateTimePicker t_date_depart;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tempgrid;
        private Bunifu.Framework.UI.BunifuCustomLabel t_lbl_seats;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuFlatButton btn_bookticket;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_REET;
        private Bunifu.Framework.UI.BunifuFlatButton btn_small_pricelist;
        private System.Windows.Forms.FlowLayoutPanel checkbox_panel;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_agepanle;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_top_price;
        private Bunifu.Framework.UI.BunifuCustomLabel ddf;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel PANEL_AGEOFSEATS;
        private Bunifu.Framework.UI.BunifuFlatButton btn_print;
        private System.Windows.Forms.NumericUpDown P_NUM_AGE;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nextAge;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_seat_no_Ofage;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grid_checkseats;
        private System.Windows.Forms.DateTimePicker TODAY_DATE;
    }
}