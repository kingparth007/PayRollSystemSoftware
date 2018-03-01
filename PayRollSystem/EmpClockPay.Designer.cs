namespace PayRollSystem
{
    partial class EmpClockPay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpClockPay));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmplst = new System.Windows.Forms.Label();
            this.ClockGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendPaySlip = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EmpPayGrid = new System.Windows.Forms.DataGridView();
            this.EmpPayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSalaryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpTotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpTotalPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpTaxPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpCreditPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPaySalary = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblEmplst);
            this.panel1.Controls.Add(this.ClockGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 285);
            this.panel1.TabIndex = 3;
            // 
            // lblEmplst
            // 
            this.lblEmplst.AutoSize = true;
            this.lblEmplst.BackColor = System.Drawing.Color.Transparent;
            this.lblEmplst.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplst.ForeColor = System.Drawing.Color.White;
            this.lblEmplst.Location = new System.Drawing.Point(101, 24);
            this.lblEmplst.Name = "lblEmplst";
            this.lblEmplst.Size = new System.Drawing.Size(214, 21);
            this.lblEmplst.TabIndex = 123;
            this.lblEmplst.Text = "Current Employee for Day";
            // 
            // ClockGrid
            // 
            this.ClockGrid.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.ClockGrid.ColumnHeadersHeight = 50;
            this.ClockGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClockGrid.Location = new System.Drawing.Point(105, 68);
            this.ClockGrid.MultiSelect = false;
            this.ClockGrid.Name = "ClockGrid";
            this.ClockGrid.ReadOnly = true;
            this.ClockGrid.RowHeadersWidth = 50;
            this.ClockGrid.RowTemplate.Height = 40;
            this.ClockGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClockGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ClockGrid.Size = new System.Drawing.Size(450, 214);
            this.ClockGrid.TabIndex = 122;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSendPaySlip);
            this.panel2.Controls.Add(this.EmpPayGrid);
            this.panel2.Controls.Add(this.BtnPaySalary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 318);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 132;
            this.label1.Text = "Pay Info";
            // 
            // btnSendPaySlip
            // 
            this.btnSendPaySlip.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSendPaySlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSendPaySlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendPaySlip.BorderRadius = 10;
            this.btnSendPaySlip.ButtonText = "Send Pay Slip";
            this.btnSendPaySlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendPaySlip.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPaySlip.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSendPaySlip.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSendPaySlip.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSendPaySlip.Iconimage")));
            this.btnSendPaySlip.Iconimage_right = null;
            this.btnSendPaySlip.Iconimage_right_Selected = null;
            this.btnSendPaySlip.Iconimage_Selected = null;
            this.btnSendPaySlip.IconZoom = 80D;
            this.btnSendPaySlip.IsTab = false;
            this.btnSendPaySlip.Location = new System.Drawing.Point(691, 64);
            this.btnSendPaySlip.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSendPaySlip.Name = "btnSendPaySlip";
            this.btnSendPaySlip.Normalcolor = System.Drawing.Color.Maroon;
            this.btnSendPaySlip.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSendPaySlip.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSendPaySlip.selected = true;
            this.btnSendPaySlip.Size = new System.Drawing.Size(169, 48);
            this.btnSendPaySlip.TabIndex = 131;
            this.btnSendPaySlip.Textcolor = System.Drawing.Color.White;
            this.btnSendPaySlip.TextFont = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // EmpPayGrid
            // 
            this.EmpPayGrid.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.EmpPayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpPayGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpPayID,
            this.EmpSalaryDate,
            this.EmpTotalHours,
            this.EmpTotalPay,
            this.EmpTaxPay,
            this.EmpCreditPay,
            this.EmpId});
            this.EmpPayGrid.Location = new System.Drawing.Point(116, 117);
            this.EmpPayGrid.Name = "EmpPayGrid";
            this.EmpPayGrid.Size = new System.Drawing.Size(743, 198);
            this.EmpPayGrid.TabIndex = 130;
            // 
            // EmpPayID
            // 
            this.EmpPayID.HeaderText = "PayID";
            this.EmpPayID.Name = "EmpPayID";
            // 
            // EmpSalaryDate
            // 
            this.EmpSalaryDate.HeaderText = "SalaryDate";
            this.EmpSalaryDate.Name = "EmpSalaryDate";
            this.EmpSalaryDate.ReadOnly = true;
            // 
            // EmpTotalHours
            // 
            this.EmpTotalHours.HeaderText = "TotalHoursOfWeek";
            this.EmpTotalHours.Name = "EmpTotalHours";
            this.EmpTotalHours.ReadOnly = true;
            // 
            // EmpTotalPay
            // 
            this.EmpTotalPay.HeaderText = "TotalPay";
            this.EmpTotalPay.Name = "EmpTotalPay";
            this.EmpTotalPay.ReadOnly = true;
            // 
            // EmpTaxPay
            // 
            this.EmpTaxPay.HeaderText = "Tax";
            this.EmpTaxPay.Name = "EmpTaxPay";
            this.EmpTaxPay.ReadOnly = true;
            // 
            // EmpCreditPay
            // 
            this.EmpCreditPay.HeaderText = "Credited Amount";
            this.EmpCreditPay.Name = "EmpCreditPay";
            this.EmpCreditPay.ReadOnly = true;
            // 
            // EmpId
            // 
            this.EmpId.HeaderText = "EmployeId";
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // BtnPaySalary
            // 
            this.BtnPaySalary.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnPaySalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnPaySalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPaySalary.BorderRadius = 10;
            this.BtnPaySalary.ButtonText = "Pay Salary";
            this.BtnPaySalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPaySalary.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaySalary.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPaySalary.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnPaySalary.Iconimage")));
            this.BtnPaySalary.Iconimage_right = null;
            this.BtnPaySalary.Iconimage_right_Selected = null;
            this.BtnPaySalary.Iconimage_Selected = null;
            this.BtnPaySalary.IconZoom = 80D;
            this.BtnPaySalary.IsTab = false;
            this.BtnPaySalary.Location = new System.Drawing.Point(119, 64);
            this.BtnPaySalary.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnPaySalary.Name = "BtnPaySalary";
            this.BtnPaySalary.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPaySalary.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnPaySalary.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPaySalary.selected = true;
            this.BtnPaySalary.Size = new System.Drawing.Size(169, 48);
            this.BtnPaySalary.TabIndex = 129;
            this.BtnPaySalary.Textcolor = System.Drawing.Color.White;
            this.BtnPaySalary.TextFont = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaySalary.Click += new System.EventHandler(this.BtnPaySalary_Click);
            // 
            // EmpClockPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmpClockPay";
            this.Size = new System.Drawing.Size(1115, 609);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPayGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmplst;
        private System.Windows.Forms.DataGridView ClockGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSendPaySlip;
        private System.Windows.Forms.DataGridView EmpPayGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSalaryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpTotalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpTotalPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpTaxPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpCreditPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPaySalary;
    }
}
