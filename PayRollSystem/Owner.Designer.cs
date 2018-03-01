namespace PayRollSystem
{
    partial class Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.btnSystemName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lftPnl = new System.Windows.Forms.Panel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnRoster = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnPay = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnEmployee = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuTileButton();
            this.ContentPnl = new System.Windows.Forms.Panel();
            this.HeaderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.lftPnl.SuspendLayout();
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
            this.HeaderPnl.Size = new System.Drawing.Size(1000, 39);
            this.HeaderPnl.TabIndex = 2;
            // 
            // btnSystemName
            // 
            this.btnSystemName.AutoSize = true;
            this.btnSystemName.BackColor = System.Drawing.Color.Transparent;
            this.btnSystemName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemName.Location = new System.Drawing.Point(51, 9);
            this.btnSystemName.Name = "btnSystemName";
            this.btnSystemName.Size = new System.Drawing.Size(101, 25);
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
            this.pictureBox2.Size = new System.Drawing.Size(51, 39);
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
            this.btnMinimise.Location = new System.Drawing.Point(935, 0);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(33, 39);
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
            this.btnClose.Location = new System.Drawing.Point(968, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lftPnl
            // 
            this.lftPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(86)))), ((int)(((byte)(128)))));
            this.lftPnl.Controls.Add(this.btnLogout);
            this.lftPnl.Controls.Add(this.BtnRoster);
            this.lftPnl.Controls.Add(this.BtnPay);
            this.lftPnl.Controls.Add(this.BtnEmployee);
            this.lftPnl.Controls.Add(this.btnDashboard);
            this.lftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lftPnl.Location = new System.Drawing.Point(0, 39);
            this.lftPnl.Name = "lftPnl";
            this.lftPnl.Size = new System.Drawing.Size(152, 661);
            this.lftPnl.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLogout.color = System.Drawing.Color.Transparent;
            this.btnLogout.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImagePosition = 4;
            this.btnLogout.ImageZoom = 40;
            this.btnLogout.LabelPosition = 34;
            this.btnLogout.LabelText = "Exit";
            this.btnLogout.Location = new System.Drawing.Point(23, 360);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 82);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BtnRoster
            // 
            this.BtnRoster.BackColor = System.Drawing.Color.Transparent;
            this.BtnRoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnRoster.color = System.Drawing.Color.Transparent;
            this.BtnRoster.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.BtnRoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRoster.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoster.ForeColor = System.Drawing.Color.White;
            this.BtnRoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnRoster.Image")));
            this.BtnRoster.ImagePosition = 4;
            this.BtnRoster.ImageZoom = 40;
            this.BtnRoster.LabelPosition = 34;
            this.BtnRoster.LabelText = "Roster";
            this.BtnRoster.Location = new System.Drawing.Point(23, 270);
            this.BtnRoster.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnRoster.Name = "BtnRoster";
            this.BtnRoster.Size = new System.Drawing.Size(111, 82);
            this.BtnRoster.TabIndex = 7;
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnPay.color = System.Drawing.Color.Transparent;
            this.BtnPay.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.BtnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPay.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.ForeColor = System.Drawing.Color.White;
            this.BtnPay.Image = ((System.Drawing.Image)(resources.GetObject("BtnPay.Image")));
            this.BtnPay.ImagePosition = 4;
            this.BtnPay.ImageZoom = 30;
            this.BtnPay.LabelPosition = 34;
            this.BtnPay.LabelText = "Pay";
            this.BtnPay.Location = new System.Drawing.Point(23, 180);
            this.BtnPay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(111, 82);
            this.BtnPay.TabIndex = 6;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.BtnEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnEmployee.color = System.Drawing.Color.Transparent;
            this.BtnEmployee.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.BtnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmployee.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployee.ForeColor = System.Drawing.Color.White;
            this.BtnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmployee.Image")));
            this.BtnEmployee.ImagePosition = 4;
            this.BtnEmployee.ImageZoom = 30;
            this.BtnEmployee.LabelPosition = 34;
            this.BtnEmployee.LabelText = "Employee";
            this.BtnEmployee.Location = new System.Drawing.Point(23, 90);
            this.BtnEmployee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(111, 82);
            this.BtnEmployee.TabIndex = 5;
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDashboard.color = System.Drawing.Color.Transparent;
            this.btnDashboard.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImagePosition = 4;
            this.btnDashboard.ImageZoom = 30;
            this.btnDashboard.LabelPosition = 34;
            this.btnDashboard.LabelText = "Dashboard";
            this.btnDashboard.Location = new System.Drawing.Point(23, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(111, 82);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // ContentPnl
            // 
            this.ContentPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(86)))), ((int)(((byte)(128)))));
            this.ContentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPnl.Location = new System.Drawing.Point(152, 39);
            this.ContentPnl.Name = "ContentPnl";
            this.ContentPnl.Size = new System.Drawing.Size(848, 661);
            this.ContentPnl.TabIndex = 4;
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.ContentPnl);
            this.Controls.Add(this.lftPnl);
            this.Controls.Add(this.HeaderPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.lftPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Label btnSystemName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimise;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel lftPnl;
        private Bunifu.Framework.UI.BunifuTileButton btnDashboard;
        private Bunifu.Framework.UI.BunifuTileButton BtnEmployee;
        private Bunifu.Framework.UI.BunifuTileButton BtnPay;
        private Bunifu.Framework.UI.BunifuTileButton BtnRoster;
        private Bunifu.Framework.UI.BunifuTileButton btnLogout;
        private System.Windows.Forms.Panel ContentPnl;
    }
}