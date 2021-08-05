namespace BTRS2
{
    partial class pricelist
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
            this.grig_price_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.curr_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grig_price_list)).BeginInit();
            this.SuspendLayout();
            // 
            // grig_price_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grig_price_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grig_price_list.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grig_price_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grig_price_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grig_price_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grig_price_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grig_price_list.DoubleBuffered = true;
            this.grig_price_list.EnableHeadersVisualStyles = false;
            this.grig_price_list.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grig_price_list.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.grig_price_list.Location = new System.Drawing.Point(23, 63);
            this.grig_price_list.Name = "grig_price_list";
            this.grig_price_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grig_price_list.Size = new System.Drawing.Size(519, 462);
            this.grig_price_list.TabIndex = 1;
            // 
            // curr_date
            // 
            this.curr_date.Location = new System.Drawing.Point(325, 37);
            this.curr_date.Name = "curr_date";
            this.curr_date.Size = new System.Drawing.Size(200, 20);
            this.curr_date.TabIndex = 0;
            this.curr_date.ValueChanged += new System.EventHandler(this.curr_date_ValueChanged);
            // 
            // pricelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 562);
            this.Controls.Add(this.curr_date);
            this.Controls.Add(this.grig_price_list);
            this.Name = "pricelist";
            this.Resizable = false;
            this.Text = "PRICE LIST";
            this.Load += new System.EventHandler(this.pricelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grig_price_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid grig_price_list;
        private System.Windows.Forms.DateTimePicker curr_date;
    }
}