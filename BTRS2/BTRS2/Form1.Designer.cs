namespace BTRS2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TXT_UNAME = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TXT_PASS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BTN_LOGIN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // TXT_UNAME
            // 
            this.TXT_UNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_UNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TXT_UNAME.ForeColor = System.Drawing.Color.Black;
            this.TXT_UNAME.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_UNAME.HintText = "ENTER USERNAME";
            this.TXT_UNAME.isPassword = false;
            this.TXT_UNAME.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_UNAME.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_UNAME.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_UNAME.LineThickness = 3;
            this.TXT_UNAME.Location = new System.Drawing.Point(62, 104);
            this.TXT_UNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_UNAME.Name = "TXT_UNAME";
            this.TXT_UNAME.Size = new System.Drawing.Size(211, 49);
            this.TXT_UNAME.TabIndex = 0;
            this.TXT_UNAME.Text = "HARIS";
            this.TXT_UNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TXT_PASS
            // 
            this.TXT_PASS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_PASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TXT_PASS.ForeColor = System.Drawing.Color.Black;
            this.TXT_PASS.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_PASS.HintText = "ENTER PASWORD";
            this.TXT_PASS.isPassword = true;
            this.TXT_PASS.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_PASS.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_PASS.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_PASS.LineThickness = 3;
            this.TXT_PASS.Location = new System.Drawing.Point(62, 185);
            this.TXT_PASS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PASS.Name = "TXT_PASS";
            this.TXT_PASS.Size = new System.Drawing.Size(211, 49);
            this.TXT_PASS.TabIndex = 1;
            this.TXT_PASS.Text = "123";
            this.TXT_PASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.ActiveBorderThickness = 1;
            this.BTN_LOGIN.ActiveCornerRadius = 20;
            this.BTN_LOGIN.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_LOGIN.ActiveForecolor = System.Drawing.Color.White;
            this.BTN_LOGIN.ActiveLineColor = System.Drawing.Color.Transparent;
            this.BTN_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_LOGIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_LOGIN.BackgroundImage")));
            this.BTN_LOGIN.ButtonText = "LOGIN";
            this.BTN_LOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOGIN.ForeColor = System.Drawing.Color.Black;
            this.BTN_LOGIN.IdleBorderThickness = 1;
            this.BTN_LOGIN.IdleCornerRadius = 20;
            this.BTN_LOGIN.IdleFillColor = System.Drawing.Color.White;
            this.BTN_LOGIN.IdleForecolor = System.Drawing.Color.Black;
            this.BTN_LOGIN.IdleLineColor = System.Drawing.Color.Black;
            this.BTN_LOGIN.Location = new System.Drawing.Point(62, 296);
            this.BTN_LOGIN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(201, 41);
            this.BTN_LOGIN.TabIndex = 2;
            this.BTN_LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 425);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.TXT_PASS);
            this.Controls.Add(this.TXT_UNAME);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TXT_UNAME;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TXT_PASS;
        private Bunifu.Framework.UI.BunifuThinButton2 BTN_LOGIN;
    }
}

