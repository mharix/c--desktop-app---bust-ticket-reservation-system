namespace BTRS2
{
    partial class CustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TXT_BUSNO = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.CBOX_TO = new System.Windows.Forms.ComboBox();
            this.CBOX_FROM = new System.Windows.Forms.ComboBox();
            this.DATE_DEP = new System.Windows.Forms.DateTimePicker();
            this.DATE_ARR = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TXT_AGE = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TXT_NAME = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BTN_SEARCH = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grid_search = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_search)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuGradientPanel1.Controls.Add(this.TXT_BUSNO);
            this.bunifuGradientPanel1.Controls.Add(this.CBOX_TO);
            this.bunifuGradientPanel1.Controls.Add(this.CBOX_FROM);
            this.bunifuGradientPanel1.Controls.Add(this.DATE_DEP);
            this.bunifuGradientPanel1.Controls.Add(this.DATE_ARR);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.TXT_AGE);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.TXT_NAME);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.BTN_SEARCH);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(23, 63);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(768, 104);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(462, 53);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(46, 13);
            this.bunifuCustomLabel8.TabIndex = 20;
            this.bunifuCustomLabel8.Text = "BUS N0";
            // 
            // TXT_BUSNO
            // 
            this.TXT_BUSNO.BorderColor = System.Drawing.Color.SeaGreen;
            this.TXT_BUSNO.Location = new System.Drawing.Point(465, 68);
            this.TXT_BUSNO.MaxLength = 6;
            this.TXT_BUSNO.Name = "TXT_BUSNO";
            this.TXT_BUSNO.Size = new System.Drawing.Size(100, 20);
            this.TXT_BUSNO.TabIndex = 6;
            this.TXT_BUSNO.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // CBOX_TO
            // 
            this.CBOX_TO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_TO.FormattingEnabled = true;
            this.CBOX_TO.Items.AddRange(new object[] {
            "KARACHI",
            "LAHORE",
            "ISLAMABAD"});
            this.CBOX_TO.Location = new System.Drawing.Point(211, 20);
            this.CBOX_TO.Name = "CBOX_TO";
            this.CBOX_TO.Size = new System.Drawing.Size(121, 21);
            this.CBOX_TO.TabIndex = 1;
            this.CBOX_TO.SelectedIndexChanged += new System.EventHandler(this.CBOX_TO_SelectedIndexChanged);
            // 
            // CBOX_FROM
            // 
            this.CBOX_FROM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_FROM.FormattingEnabled = true;
            this.CBOX_FROM.Items.AddRange(new object[] {
            "KARACHI",
            "LAHORE",
            "ISLAMABAD"});
            this.CBOX_FROM.Location = new System.Drawing.Point(338, 21);
            this.CBOX_FROM.Name = "CBOX_FROM";
            this.CBOX_FROM.Size = new System.Drawing.Size(121, 21);
            this.CBOX_FROM.TabIndex = 2;
            this.CBOX_FROM.SelectedIndexChanged += new System.EventHandler(this.CBOX_FROM_SelectedIndexChanged);
            // 
            // DATE_DEP
            // 
            this.DATE_DEP.Location = new System.Drawing.Point(272, 69);
            this.DATE_DEP.Name = "DATE_DEP";
            this.DATE_DEP.Size = new System.Drawing.Size(184, 20);
            this.DATE_DEP.TabIndex = 5;
            this.DATE_DEP.ValueChanged += new System.EventHandler(this.DATE_DEP_ValueChanged);
            // 
            // DATE_ARR
            // 
            this.DATE_ARR.Location = new System.Drawing.Point(82, 69);
            this.DATE_ARR.Name = "DATE_ARR";
            this.DATE_ARR.Size = new System.Drawing.Size(184, 20);
            this.DATE_ARR.TabIndex = 4;
            this.DATE_ARR.ValueChanged += new System.EventHandler(this.DATE_ARR_ValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(462, 5);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(29, 13);
            this.bunifuCustomLabel5.TabIndex = 14;
            this.bunifuCustomLabel5.Text = "AGE";
            // 
            // TXT_AGE
            // 
            this.TXT_AGE.BorderColor = System.Drawing.Color.SeaGreen;
            this.TXT_AGE.Location = new System.Drawing.Point(465, 21);
            this.TXT_AGE.MaxLength = 2;
            this.TXT_AGE.Name = "TXT_AGE";
            this.TXT_AGE.Size = new System.Drawing.Size(46, 20);
            this.TXT_AGE.TabIndex = 3;
            this.TXT_AGE.TextChanged += new System.EventHandler(this.TXT_AGE_TextChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(269, 53);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(74, 13);
            this.bunifuCustomLabel6.TabIndex = 9;
            this.bunifuCustomLabel6.Text = "DEPARTURE";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(79, 53);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel7.TabIndex = 10;
            this.bunifuCustomLabel7.Text = "ARRIVAL";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(79, 5);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "NAME";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.BorderColor = System.Drawing.Color.SeaGreen;
            this.TXT_NAME.Location = new System.Drawing.Point(82, 21);
            this.TXT_NAME.MaxLength = 50;
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(123, 20);
            this.TXT_NAME.TabIndex = 0;
            this.TXT_NAME.TextChanged += new System.EventHandler(this.TXT_NAME_TextChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(337, 5);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "FROM";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(208, 5);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(22, 13);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "TO";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 13);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "SEARCH BY ";
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_SEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_SEARCH.BorderRadius = 0;
            this.BTN_SEARCH.ButtonText = "SEARCH";
            this.BTN_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SEARCH.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_SEARCH.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_SEARCH.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_SEARCH.Iconimage")));
            this.BTN_SEARCH.Iconimage_right = null;
            this.BTN_SEARCH.Iconimage_right_Selected = null;
            this.BTN_SEARCH.Iconimage_Selected = null;
            this.BTN_SEARCH.IconMarginLeft = 0;
            this.BTN_SEARCH.IconMarginRight = 0;
            this.BTN_SEARCH.IconRightVisible = true;
            this.BTN_SEARCH.IconRightZoom = 0D;
            this.BTN_SEARCH.IconVisible = true;
            this.BTN_SEARCH.IconZoom = 90D;
            this.BTN_SEARCH.IsTab = false;
            this.BTN_SEARCH.Location = new System.Drawing.Point(625, 12);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_SEARCH.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_SEARCH.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_SEARCH.selected = false;
            this.BTN_SEARCH.Size = new System.Drawing.Size(140, 64);
            this.BTN_SEARCH.TabIndex = 7;
            this.BTN_SEARCH.Text = "SEARCH";
            this.BTN_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.Textcolor = System.Drawing.Color.White;
            this.BTN_SEARCH.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.grid_search);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(23, 173);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(946, 378);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // grid_search
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_search.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_search.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_search.DoubleBuffered = true;
            this.grid_search.EnableHeadersVisualStyles = false;
            this.grid_search.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grid_search.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.grid_search.Location = new System.Drawing.Point(3, 3);
            this.grid_search.Name = "grid_search";
            this.grid_search.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_search.Size = new System.Drawing.Size(940, 372);
            this.grid_search.TabIndex = 8;
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 558);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "CustomerSearch";
            this.Resizable = false;
            this.Text = "CustomerSearch";
            this.Load += new System.EventHandler(this.CustomerSearch_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grid_search;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_SEARCH;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TXT_NAME;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.DateTimePicker DATE_ARR;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TXT_AGE;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.DateTimePicker DATE_DEP;
        private System.Windows.Forms.ComboBox CBOX_TO;
        private System.Windows.Forms.ComboBox CBOX_FROM;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TXT_BUSNO;
    }
}