namespace BTRS2
{
    partial class enquiry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enquiry));
            this.grid_enquiry = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.e_btn_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.e_date_arrival = new System.Windows.Forms.DateTimePicker();
            this.e_date_depart = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.e_from = new System.Windows.Forms.ComboBox();
            this.e_to = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_enquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_enquiry
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_enquiry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_enquiry.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid_enquiry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_enquiry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_enquiry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_enquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_enquiry.DoubleBuffered = true;
            this.grid_enquiry.EnableHeadersVisualStyles = false;
            this.grid_enquiry.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grid_enquiry.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.grid_enquiry.Location = new System.Drawing.Point(33, 153);
            this.grid_enquiry.Name = "grid_enquiry";
            this.grid_enquiry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_enquiry.Size = new System.Drawing.Size(881, 382);
            this.grid_enquiry.TabIndex = 5;
            // 
            // e_btn_search
            // 
            this.e_btn_search.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.e_btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.e_btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e_btn_search.BorderRadius = 0;
            this.e_btn_search.ButtonText = "Search";
            this.e_btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.e_btn_search.DisabledColor = System.Drawing.Color.Gray;
            this.e_btn_search.Iconcolor = System.Drawing.Color.Transparent;
            this.e_btn_search.Iconimage = ((System.Drawing.Image)(resources.GetObject("e_btn_search.Iconimage")));
            this.e_btn_search.Iconimage_right = null;
            this.e_btn_search.Iconimage_right_Selected = null;
            this.e_btn_search.Iconimage_Selected = null;
            this.e_btn_search.IconMarginLeft = 0;
            this.e_btn_search.IconMarginRight = 0;
            this.e_btn_search.IconRightVisible = true;
            this.e_btn_search.IconRightZoom = 0D;
            this.e_btn_search.IconVisible = true;
            this.e_btn_search.IconZoom = 90D;
            this.e_btn_search.IsTab = false;
            this.e_btn_search.Location = new System.Drawing.Point(786, 99);
            this.e_btn_search.Name = "e_btn_search";
            this.e_btn_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.e_btn_search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.e_btn_search.OnHoverTextColor = System.Drawing.Color.White;
            this.e_btn_search.selected = false;
            this.e_btn_search.Size = new System.Drawing.Size(128, 48);
            this.e_btn_search.TabIndex = 4;
            this.e_btn_search.Text = "Search";
            this.e_btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.e_btn_search.Textcolor = System.Drawing.Color.White;
            this.e_btn_search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_btn_search.Click += new System.EventHandler(this.e_btn_search_Click);
            // 
            // e_date_arrival
            // 
            this.e_date_arrival.Location = new System.Drawing.Point(107, 114);
            this.e_date_arrival.Name = "e_date_arrival";
            this.e_date_arrival.Size = new System.Drawing.Size(200, 20);
            this.e_date_arrival.TabIndex = 2;
            // 
            // e_date_depart
            // 
            this.e_date_depart.Location = new System.Drawing.Point(108, 88);
            this.e_date_depart.Name = "e_date_depart";
            this.e_date_depart.Size = new System.Drawing.Size(200, 20);
            this.e_date_depart.TabIndex = 0;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(65, 114);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(36, 13);
            this.bunifuCustomLabel5.TabIndex = 20;
            this.bunifuCustomLabel5.Text = "Arrival";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(47, 88);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(54, 13);
            this.bunifuCustomLabel4.TabIndex = 21;
            this.bunifuCustomLabel4.Text = "Departure";
            // 
            // e_from
            // 
            this.e_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_from.FormattingEnabled = true;
            this.e_from.Items.AddRange(new object[] {
            "KARACHI",
            "LAHORE",
            "ISLAMABAD"});
            this.e_from.Location = new System.Drawing.Point(381, 88);
            this.e_from.Name = "e_from";
            this.e_from.Size = new System.Drawing.Size(155, 21);
            this.e_from.TabIndex = 1;
            // 
            // e_to
            // 
            this.e_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_to.FormattingEnabled = true;
            this.e_to.Items.AddRange(new object[] {
            "KARACHI",
            "LAHORE",
            "ISLAMABAD"});
            this.e_to.Location = new System.Drawing.Point(381, 115);
            this.e_to.Name = "e_to";
            this.e_to.Size = new System.Drawing.Size(155, 21);
            this.e_to.TabIndex = 3;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(355, 118);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(20, 13);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "To";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(345, 91);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(30, 13);
            this.bunifuCustomLabel2.TabIndex = 25;
            this.bunifuCustomLabel2.Text = "From";
            // 
            // enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 558);
            this.Controls.Add(this.e_from);
            this.Controls.Add(this.e_to);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.e_date_arrival);
            this.Controls.Add(this.e_date_depart);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.e_btn_search);
            this.Controls.Add(this.grid_enquiry);
            this.Name = "enquiry";
            this.Resizable = false;
            this.Text = "Seats Enquiry";
            this.Load += new System.EventHandler(this.enquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_enquiry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid grid_enquiry;
        private Bunifu.Framework.UI.BunifuFlatButton e_btn_search;
        private System.Windows.Forms.DateTimePicker e_date_arrival;
        private System.Windows.Forms.DateTimePicker e_date_depart;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox e_from;
        private System.Windows.Forms.ComboBox e_to;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}