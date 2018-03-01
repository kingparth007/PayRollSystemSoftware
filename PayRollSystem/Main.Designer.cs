namespace PayRollSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.btnSystemName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClockInPnl = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPictureClock = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.drpClockInOut = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblSignIN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.signUserName = new System.Windows.Forms.TextBox();
            this.lblUName = new System.Windows.Forms.Label();
            this.HeaderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.btnClockInPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureClock)).BeginInit();
            this.btnLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.HeaderPnl.Controls.Add(this.btnSystemName);
            this.HeaderPnl.Controls.Add(this.pictureBox2);
            this.HeaderPnl.Controls.Add(this.btnMinimise);
            this.HeaderPnl.Controls.Add(this.btnClose);
            this.HeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPnl.ForeColor = System.Drawing.Color.White;
            this.HeaderPnl.Location = new System.Drawing.Point(0, 0);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(800, 37);
            this.HeaderPnl.TabIndex = 0;
            // 
            // btnSystemName
            // 
            this.btnSystemName.AutoSize = true;
            this.btnSystemName.BackColor = System.Drawing.Color.Transparent;
            this.btnSystemName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemName.Location = new System.Drawing.Point(35, 9);
            this.btnSystemName.Name = "btnSystemName";
            this.btnSystemName.Size = new System.Drawing.Size(81, 21);
            this.btnSystemName.TabIndex = 12;
            this.btnSystemName.Text = "PayRoll";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimise.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimise.Image")));
            this.btnMinimise.ImageActive = null;
            this.btnMinimise.Location = new System.Drawing.Point(726, 0);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(37, 37);
            this.btnMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimise.TabIndex = 12;
            this.btnMinimise.TabStop = false;
            this.btnMinimise.Zoom = 10;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(763, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClockInPnl
            // 
            this.btnClockInPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClockInPnl.BackgroundImage")));
            this.btnClockInPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClockInPnl.Controls.Add(this.btnPictureClock);
            this.btnClockInPnl.Controls.Add(this.btnSubmit);
            this.btnClockInPnl.Controls.Add(this.txtUserName);
            this.btnClockInPnl.Controls.Add(this.drpClockInOut);
            this.btnClockInPnl.Controls.Add(this.label1);
            this.btnClockInPnl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClockInPnl.ForeColor = System.Drawing.Color.White;
            this.btnClockInPnl.GradientBottomLeft = System.Drawing.Color.Black;
            this.btnClockInPnl.GradientBottomRight = System.Drawing.Color.Black;
            this.btnClockInPnl.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClockInPnl.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClockInPnl.Location = new System.Drawing.Point(39, 37);
            this.btnClockInPnl.Name = "btnClockInPnl";
            this.btnClockInPnl.Quality = 10;
            this.btnClockInPnl.Size = new System.Drawing.Size(348, 480);
            this.btnClockInPnl.TabIndex = 1;
            this.btnClockInPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // btnPictureClock
            // 
            this.btnPictureClock.BackColor = System.Drawing.Color.Transparent;
            this.btnPictureClock.Image = ((System.Drawing.Image)(resources.GetObject("btnPictureClock.Image")));
            this.btnPictureClock.Location = new System.Drawing.Point(124, 71);
            this.btnPictureClock.Name = "btnPictureClock";
            this.btnPictureClock.Size = new System.Drawing.Size(110, 95);
            this.btnPictureClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPictureClock.TabIndex = 5;
            this.btnPictureClock.TabStop = false;
            this.btnPictureClock.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.BorderRadius = 10;
            this.btnSubmit.ButtonText = "     Submit";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Iconimage")));
            this.btnSubmit.Iconimage_right = null;
            this.btnSubmit.Iconimage_right_Selected = null;
            this.btnSubmit.Iconimage_Selected = null;
            this.btnSubmit.IconZoom = 100D;
            this.btnSubmit.IsTab = false;
            this.btnSubmit.Location = new System.Drawing.Point(38, 292);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmit.selected = false;
            this.btnSubmit.Size = new System.Drawing.Size(266, 48);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Textcolor = System.Drawing.Color.White;
            this.btnSubmit.TextFont = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(124, 231);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 33);
            this.txtUserName.TabIndex = 2;
            // 
            // drpClockInOut
            // 
            this.drpClockInOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.drpClockInOut.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.drpClockInOut.FormattingEnabled = true;
            this.drpClockInOut.ItemHeight = 23;
            this.drpClockInOut.Items.AddRange(new object[] {
            "Clock In",
            "Clock Out"});
            this.drpClockInOut.Location = new System.Drawing.Point(36, 188);
            this.drpClockInOut.Name = "drpClockInOut";
            this.drpClockInOut.Size = new System.Drawing.Size(268, 29);
            this.drpClockInOut.Sorted = true;
            this.drpClockInOut.TabIndex = 1;
            this.drpClockInOut.UseSelectable = true;
            this.drpClockInOut.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // btnLoginPanel
            // 
            this.btnLoginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginPanel.BackgroundImage")));
            this.btnLoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginPanel.Controls.Add(this.lblSignIN);
            this.btnLoginPanel.Controls.Add(this.pictureBox1);
            this.btnLoginPanel.Controls.Add(this.txtPass);
            this.btnLoginPanel.Controls.Add(this.lblPass);
            this.btnLoginPanel.Controls.Add(this.bunifuFlatButton1);
            this.btnLoginPanel.Controls.Add(this.signUserName);
            this.btnLoginPanel.Controls.Add(this.lblUName);
            this.btnLoginPanel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPanel.ForeColor = System.Drawing.Color.White;
            this.btnLoginPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoginPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoginPanel.GradientTopLeft = System.Drawing.Color.Black;
            this.btnLoginPanel.GradientTopRight = System.Drawing.Color.Black;
            this.btnLoginPanel.Location = new System.Drawing.Point(393, 37);
            this.btnLoginPanel.Name = "btnLoginPanel";
            this.btnLoginPanel.Quality = 10;
            this.btnLoginPanel.Size = new System.Drawing.Size(364, 480);
            this.btnLoginPanel.TabIndex = 2;
            this.btnLoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);
            // 
            // lblSignIN
            // 
            this.lblSignIN.AutoSize = true;
            this.lblSignIN.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIN.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIN.Location = new System.Drawing.Point(139, 118);
            this.lblSignIN.Name = "lblSignIN";
            this.lblSignIN.Size = new System.Drawing.Size(112, 34);
            this.lblSignIN.TabIndex = 11;
            this.lblSignIN.Text = "Sign In";
            this.lblSignIN.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(135, 241);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(169, 33);
            this.txtPass.TabIndex = 10;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(14, 241);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 21);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 10;
            this.bunifuFlatButton1.ButtonText = " Login";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(135, 292);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(169, 48);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // signUserName
            // 
            this.signUserName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUserName.Location = new System.Drawing.Point(135, 185);
            this.signUserName.Name = "signUserName";
            this.signUserName.Size = new System.Drawing.Size(169, 33);
            this.signUserName.TabIndex = 7;
            this.signUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.BackColor = System.Drawing.Color.Transparent;
            this.lblUName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUName.Location = new System.Drawing.Point(14, 185);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(86, 21);
            this.lblUName.TabIndex = 6;
            this.lblUName.Text = "Username";
            this.lblUName.Click += new System.EventHandler(this.label2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnLoginPanel);
            this.Controls.Add(this.btnClockInPnl);
            this.Controls.Add(this.HeaderPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayRoll";
            this.Load += new System.EventHandler(this.Main_Load);
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.btnClockInPnl.ResumeLayout(false);
            this.btnClockInPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureClock)).EndInit();
            this.btnLoginPanel.ResumeLayout(false);
            this.btnLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPnl;
        private Bunifu.Framework.UI.BunifuGradientPanel btnClockInPnl;
        private Bunifu.Framework.UI.BunifuGradientPanel btnLoginPanel;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox drpClockInOut;
        private System.Windows.Forms.TextBox txtUserName;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmit;
        private System.Windows.Forms.PictureBox btnPictureClock;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox signUserName;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSignIN;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimise;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label btnSystemName;
    }
}

