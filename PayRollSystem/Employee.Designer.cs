namespace PayRollSystem
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtpayrate = new System.Windows.Forms.TextBox();
            this.empstatus = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emptype = new MetroFramework.Controls.MetroComboBox();
            this.DropGender = new MetroFramework.Controls.MetroComboBox();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DrpBank = new MetroFramework.Controls.MetroComboBox();
            this.txtempaccno = new System.Windows.Forms.TextBox();
            this.TxtIRD1 = new System.Windows.Forms.TextBox();
            this.BtnAddress = new System.Windows.Forms.TextBox();
            this.lblEmpBnk = new System.Windows.Forms.Label();
            this.lblBANo = new System.Windows.Forms.Label();
            this.lblIRD = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label1LblEmail = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.btnsname = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GridView1 = new MetroFramework.Controls.MetroGrid();
            this.employeeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtsid = new System.Windows.Forms.TextBox();
            this.btnsid = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textsid = new System.Windows.Forms.TextBox();
            this.btnempsid = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnempupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textpayrate = new System.Windows.Forms.TextBox();
            this.cbempstatus = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbemptype = new MetroFramework.Controls.MetroComboBox();
            this.cbgender = new MetroFramework.Controls.MetroComboBox();
            this.cbbankname = new MetroFramework.Controls.MetroComboBox();
            this.textbankac = new System.Windows.Forms.TextBox();
            this.textird1 = new System.Windows.Forms.TextBox();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textnumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 647);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.txtpayrate);
            this.tabPage1.Controls.Add(this.empstatus);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.emptype);
            this.tabPage1.Controls.Add(this.DropGender);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.DrpBank);
            this.tabPage1.Controls.Add(this.txtempaccno);
            this.tabPage1.Controls.Add(this.TxtIRD1);
            this.tabPage1.Controls.Add(this.BtnAddress);
            this.tabPage1.Controls.Add(this.lblEmpBnk);
            this.tabPage1.Controls.Add(this.lblBANo);
            this.tabPage1.Controls.Add(this.lblIRD);
            this.tabPage1.Controls.Add(this.lblGender);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.TxtEmail);
            this.tabPage1.Controls.Add(this.label1LblEmail);
            this.tabPage1.Controls.Add(this.TxtNumber);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtSurname);
            this.tabPage1.Controls.Add(this.LblSurname);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Employee";
            // 
            // txtpayrate
            // 
            this.txtpayrate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpayrate.Location = new System.Drawing.Point(662, 294);
            this.txtpayrate.MaxLength = 6;
            this.txtpayrate.Name = "txtpayrate";
            this.txtpayrate.Size = new System.Drawing.Size(169, 33);
            this.txtpayrate.TabIndex = 143;
            this.txtpayrate.TextChanged += new System.EventHandler(this.txtpayrate_TextChanged);
            // 
            // empstatus
            // 
            this.empstatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Active Employee",
            "In-Active Employee"});
            this.empstatus.FormattingEnabled = true;
            this.empstatus.ItemHeight = 23;
            this.empstatus.Items.AddRange(new object[] {
            "Active Employee ",
            "In-Active Employee"});
            this.empstatus.Location = new System.Drawing.Point(661, 200);
            this.empstatus.Name = "empstatus";
            this.empstatus.Size = new System.Drawing.Size(169, 29);
            this.empstatus.TabIndex = 141;
            this.empstatus.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(507, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 140;
            this.label4.Text = "Pay Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(507, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 139;
            this.label3.Text = "Employee Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(507, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 138;
            this.label1.Text = "Employee Type";
            // 
            // emptype
            // 
            this.emptype.FormattingEnabled = true;
            this.emptype.ItemHeight = 23;
            this.emptype.Location = new System.Drawing.Point(661, 253);
            this.emptype.Name = "emptype";
            this.emptype.Size = new System.Drawing.Size(169, 29);
            this.emptype.TabIndex = 142;
            this.emptype.UseSelectable = true;
            // 
            // DropGender
            // 
            this.DropGender.FormattingEnabled = true;
            this.DropGender.ItemHeight = 23;
            this.DropGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DropGender.Location = new System.Drawing.Point(300, 329);
            this.DropGender.Name = "DropGender";
            this.DropGender.Size = new System.Drawing.Size(169, 29);
            this.DropGender.TabIndex = 137;
            this.DropGender.UseSelectable = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
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
            this.btnSubmit.Location = new System.Drawing.Point(389, 377);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmit.selected = false;
            this.btnSubmit.Size = new System.Drawing.Size(266, 48);
            this.btnSubmit.TabIndex = 136;
            this.btnSubmit.Textcolor = System.Drawing.Color.White;
            this.btnSubmit.TextFont = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DrpBank
            // 
            this.DrpBank.FormattingEnabled = true;
            this.DrpBank.ItemHeight = 23;
            this.DrpBank.Items.AddRange(new object[] {
            "ANZ Bank",
            "ASB Bank",
            "Westpac Bank",
            "Kiwi Bank"});
            this.DrpBank.Location = new System.Drawing.Point(661, 94);
            this.DrpBank.Name = "DrpBank";
            this.DrpBank.Size = new System.Drawing.Size(169, 29);
            this.DrpBank.TabIndex = 135;
            this.DrpBank.UseSelectable = true;
            // 
            // txtempaccno
            // 
            this.txtempaccno.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempaccno.Location = new System.Drawing.Point(661, 140);
            this.txtempaccno.Name = "txtempaccno";
            this.txtempaccno.Size = new System.Drawing.Size(169, 33);
            this.txtempaccno.TabIndex = 134;
            this.txtempaccno.TextChanged += new System.EventHandler(this.txtempaccno_TextChanged);
            // 
            // TxtIRD1
            // 
            this.TxtIRD1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIRD1.Location = new System.Drawing.Point(661, 41);
            this.TxtIRD1.Name = "TxtIRD1";
            this.TxtIRD1.Size = new System.Drawing.Size(169, 33);
            this.TxtIRD1.TabIndex = 133;
            this.TxtIRD1.TextChanged += new System.EventHandler(this.TxtIRD1_TextChanged);
            // 
            // BtnAddress
            // 
            this.BtnAddress.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddress.Location = new System.Drawing.Point(300, 244);
            this.BtnAddress.Multiline = true;
            this.BtnAddress.Name = "BtnAddress";
            this.BtnAddress.Size = new System.Drawing.Size(169, 67);
            this.BtnAddress.TabIndex = 132;
            // 
            // lblEmpBnk
            // 
            this.lblEmpBnk.AutoSize = true;
            this.lblEmpBnk.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpBnk.ForeColor = System.Drawing.Color.White;
            this.lblEmpBnk.Location = new System.Drawing.Point(507, 95);
            this.lblEmpBnk.Name = "lblEmpBnk";
            this.lblEmpBnk.Size = new System.Drawing.Size(102, 21);
            this.lblEmpBnk.TabIndex = 131;
            this.lblEmpBnk.Text = "Bank Name";
            // 
            // lblBANo
            // 
            this.lblBANo.AutoSize = true;
            this.lblBANo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBANo.ForeColor = System.Drawing.Color.White;
            this.lblBANo.Location = new System.Drawing.Point(506, 146);
            this.lblBANo.Name = "lblBANo";
            this.lblBANo.Size = new System.Drawing.Size(149, 21);
            this.lblBANo.TabIndex = 130;
            this.lblBANo.Text = "Bank Account No";
            // 
            // lblIRD
            // 
            this.lblIRD.AutoSize = true;
            this.lblIRD.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRD.ForeColor = System.Drawing.Color.White;
            this.lblIRD.Location = new System.Drawing.Point(506, 47);
            this.lblIRD.Name = "lblIRD";
            this.lblIRD.Size = new System.Drawing.Size(111, 21);
            this.lblIRD.TabIndex = 129;
            this.lblIRD.Text = "IRD Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(153, 326);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 21);
            this.lblGender.TabIndex = 128;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(153, 249);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 21);
            this.lblAddress.TabIndex = 127;
            this.lblAddress.Text = "Address";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(300, 191);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(169, 33);
            this.TxtEmail.TabIndex = 126;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // label1LblEmail
            // 
            this.label1LblEmail.AutoSize = true;
            this.label1LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.label1LblEmail.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1LblEmail.ForeColor = System.Drawing.Color.White;
            this.label1LblEmail.Location = new System.Drawing.Point(152, 194);
            this.label1LblEmail.Name = "label1LblEmail";
            this.label1LblEmail.Size = new System.Drawing.Size(58, 21);
            this.label1LblEmail.TabIndex = 125;
            this.label1LblEmail.Text = "Email";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumber.Location = new System.Drawing.Point(300, 143);
            this.TxtNumber.MaxLength = 11;
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(169, 33);
            this.TxtNumber.TabIndex = 124;
            this.TxtNumber.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 123;
            this.label2.Text = "Number";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurname.Location = new System.Drawing.Point(300, 92);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(169, 33);
            this.TxtSurname.TabIndex = 122;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.BackColor = System.Drawing.Color.Transparent;
            this.LblSurname.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurname.ForeColor = System.Drawing.Color.White;
            this.LblSurname.Location = new System.Drawing.Point(152, 95);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(78, 21);
            this.LblSurname.TabIndex = 121;
            this.LblSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(300, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 33);
            this.txtName.TabIndex = 120;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(152, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 21);
            this.lblName.TabIndex = 119;
            this.lblName.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.EmpGrid);
            this.tabPage2.Controls.Add(this.btnsname);
            this.tabPage2.Controls.Add(this.GridView1);
            this.tabPage2.Controls.Add(this.txtsid);
            this.tabPage2.Controls.Add(this.btnsid);
            this.tabPage2.Controls.Add(this.txtsname);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Employee Details";
            // 
            // EmpGrid
            // 
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGrid.Location = new System.Drawing.Point(0, 46);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.Size = new System.Drawing.Size(980, 416);
            this.EmpGrid.TabIndex = 143;
            // 
            // btnsname
            // 
            this.btnsname.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnsname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnsname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsname.BorderRadius = 10;
            this.btnsname.ButtonText = "";
            this.btnsname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsname.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsname.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsname.Iconimage")));
            this.btnsname.Iconimage_right = null;
            this.btnsname.Iconimage_right_Selected = null;
            this.btnsname.Iconimage_Selected = null;
            this.btnsname.IconZoom = 100D;
            this.btnsname.IsTab = false;
            this.btnsname.Location = new System.Drawing.Point(945, 6);
            this.btnsname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnsname.Name = "btnsname";
            this.btnsname.Normalcolor = System.Drawing.Color.Transparent;
            this.btnsname.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnsname.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsname.selected = true;
            this.btnsname.Size = new System.Drawing.Size(35, 33);
            this.btnsname.TabIndex = 142;
            this.btnsname.Textcolor = System.Drawing.Color.White;
            this.btnsname.TextFont = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToResizeRows = false;
            this.GridView1.AutoGenerateColumns = false;
            this.GridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.DataSource = this.employeeTblBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.GridView1.EnableHeadersVisualStyles = false;
            this.GridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView1.Location = new System.Drawing.Point(0, 46);
            this.GridView1.Name = "GridView1";
            this.GridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView1.Size = new System.Drawing.Size(986, 575);
            this.GridView1.TabIndex = 140;
            // 
            // employeeTblBindingSource
            // 
            this.employeeTblBindingSource.DataMember = "EmployeeTbl";
            // 
            // txtsid
            // 
            this.txtsid.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsid.Location = new System.Drawing.Point(631, 6);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(134, 33);
            this.txtsid.TabIndex = 139;
            this.txtsid.Text = "By ID";
            // 
            // btnsid
            // 
            this.btnsid.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnsid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnsid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsid.BorderRadius = 10;
            this.btnsid.ButtonText = "";
            this.btnsid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsid.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsid.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsid.Iconimage")));
            this.btnsid.Iconimage_right = null;
            this.btnsid.Iconimage_right_Selected = null;
            this.btnsid.Iconimage_Selected = null;
            this.btnsid.IconZoom = 100D;
            this.btnsid.IsTab = false;
            this.btnsid.Location = new System.Drawing.Point(761, 6);
            this.btnsid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnsid.Name = "btnsid";
            this.btnsid.Normalcolor = System.Drawing.Color.Transparent;
            this.btnsid.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnsid.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsid.selected = true;
            this.btnsid.Size = new System.Drawing.Size(35, 33);
            this.btnsid.TabIndex = 138;
            this.btnsid.Textcolor = System.Drawing.Color.White;
            this.btnsid.TextFont = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtsname
            // 
            this.txtsname.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsname.Location = new System.Drawing.Point(814, 6);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(136, 33);
            this.txtsname.TabIndex = 121;
            this.txtsname.Text = "By Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Controls.Add(this.textsid);
            this.tabPage3.Controls.Add(this.btnempsid);
            this.tabPage3.Controls.Add(this.btnempupdate);
            this.tabPage3.Controls.Add(this.textpayrate);
            this.tabPage3.Controls.Add(this.cbempstatus);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cbemptype);
            this.tabPage3.Controls.Add(this.cbgender);
            this.tabPage3.Controls.Add(this.cbbankname);
            this.tabPage3.Controls.Add(this.textbankac);
            this.tabPage3.Controls.Add(this.textird1);
            this.tabPage3.Controls.Add(this.textaddress);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textemail);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textnumber);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textsurname);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.textname);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(982, 621);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Employee Details";
            // 
            // textsid
            // 
            this.textsid.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsid.Location = new System.Drawing.Point(803, 17);
            this.textsid.Name = "textsid";
            this.textsid.Size = new System.Drawing.Size(134, 33);
            this.textsid.TabIndex = 173;
            this.textsid.Text = "By ID";
            // 
            // btnempsid
            // 
            this.btnempsid.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnempsid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnempsid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnempsid.BorderRadius = 10;
            this.btnempsid.ButtonText = "";
            this.btnempsid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnempsid.Iconcolor = System.Drawing.Color.Transparent;
            this.btnempsid.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnempsid.Iconimage")));
            this.btnempsid.Iconimage_right = null;
            this.btnempsid.Iconimage_right_Selected = null;
            this.btnempsid.Iconimage_Selected = null;
            this.btnempsid.IconZoom = 100D;
            this.btnempsid.IsTab = false;
            this.btnempsid.Location = new System.Drawing.Point(933, 17);
            this.btnempsid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnempsid.Name = "btnempsid";
            this.btnempsid.Normalcolor = System.Drawing.Color.Transparent;
            this.btnempsid.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnempsid.OnHoverTextColor = System.Drawing.Color.White;
            this.btnempsid.selected = true;
            this.btnempsid.Size = new System.Drawing.Size(35, 33);
            this.btnempsid.TabIndex = 172;
            this.btnempsid.Textcolor = System.Drawing.Color.White;
            this.btnempsid.TextFont = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempsid.Click += new System.EventHandler(this.btnempsid_Click);
            // 
            // btnempupdate
            // 
            this.btnempupdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnempupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnempupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnempupdate.BorderRadius = 10;
            this.btnempupdate.ButtonText = "Update";
            this.btnempupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnempupdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnempupdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnempupdate.Iconimage")));
            this.btnempupdate.Iconimage_right = null;
            this.btnempupdate.Iconimage_right_Selected = null;
            this.btnempupdate.Iconimage_Selected = null;
            this.btnempupdate.IconZoom = 100D;
            this.btnempupdate.IsTab = false;
            this.btnempupdate.Location = new System.Drawing.Point(426, 489);
            this.btnempupdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Normalcolor = System.Drawing.Color.Transparent;
            this.btnempupdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(234)))));
            this.btnempupdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnempupdate.selected = true;
            this.btnempupdate.Size = new System.Drawing.Size(162, 33);
            this.btnempupdate.TabIndex = 169;
            this.btnempupdate.Textcolor = System.Drawing.Color.White;
            this.btnempupdate.TextFont = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // textpayrate
            // 
            this.textpayrate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpayrate.Location = new System.Drawing.Point(662, 371);
            this.textpayrate.Name = "textpayrate";
            this.textpayrate.Size = new System.Drawing.Size(169, 33);
            this.textpayrate.TabIndex = 168;
            // 
            // cbempstatus
            // 
            this.cbempstatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Active Employee",
            "In-Active Employee"});
            this.cbempstatus.FormattingEnabled = true;
            this.cbempstatus.ItemHeight = 23;
            this.cbempstatus.Items.AddRange(new object[] {
            "Active Employee ",
            "In-Active Employee"});
            this.cbempstatus.Location = new System.Drawing.Point(661, 277);
            this.cbempstatus.Name = "cbempstatus";
            this.cbempstatus.Size = new System.Drawing.Size(169, 29);
            this.cbempstatus.TabIndex = 166;
            this.cbempstatus.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(507, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 165;
            this.label5.Text = "Pay Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(507, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 21);
            this.label6.TabIndex = 164;
            this.label6.Text = "Employee Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(507, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 163;
            this.label7.Text = "Employee Type";
            // 
            // cbemptype
            // 
            this.cbemptype.FormattingEnabled = true;
            this.cbemptype.ItemHeight = 23;
            this.cbemptype.Location = new System.Drawing.Point(661, 330);
            this.cbemptype.Name = "cbemptype";
            this.cbemptype.Size = new System.Drawing.Size(169, 29);
            this.cbemptype.TabIndex = 167;
            this.cbemptype.UseSelectable = true;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.ItemHeight = 23;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(300, 406);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(169, 29);
            this.cbgender.TabIndex = 162;
            this.cbgender.UseSelectable = true;
            // 
            // cbbankname
            // 
            this.cbbankname.FormattingEnabled = true;
            this.cbbankname.ItemHeight = 23;
            this.cbbankname.Items.AddRange(new object[] {
            "ANZ Bank",
            "ASB Bank",
            "Westpac Bank",
            "Kiwi Bank"});
            this.cbbankname.Location = new System.Drawing.Point(661, 171);
            this.cbbankname.Name = "cbbankname";
            this.cbbankname.Size = new System.Drawing.Size(169, 29);
            this.cbbankname.TabIndex = 160;
            this.cbbankname.UseSelectable = true;
            // 
            // textbankac
            // 
            this.textbankac.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbankac.Location = new System.Drawing.Point(661, 217);
            this.textbankac.Name = "textbankac";
            this.textbankac.Size = new System.Drawing.Size(169, 33);
            this.textbankac.TabIndex = 159;
            // 
            // textird1
            // 
            this.textird1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textird1.Location = new System.Drawing.Point(661, 118);
            this.textird1.Name = "textird1";
            this.textird1.Size = new System.Drawing.Size(169, 33);
            this.textird1.TabIndex = 158;
            // 
            // textaddress
            // 
            this.textaddress.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textaddress.Location = new System.Drawing.Point(300, 321);
            this.textaddress.Multiline = true;
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(169, 67);
            this.textaddress.TabIndex = 157;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(507, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 156;
            this.label8.Text = "Bank Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(506, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 21);
            this.label9.TabIndex = 155;
            this.label9.Text = "Bank Account No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(506, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 21);
            this.label10.TabIndex = 154;
            this.label10.Text = "IRD Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(153, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 21);
            this.label11.TabIndex = 153;
            this.label11.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(153, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 21);
            this.label12.TabIndex = 152;
            this.label12.Text = "Address";
            // 
            // textemail
            // 
            this.textemail.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemail.Location = new System.Drawing.Point(300, 268);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(169, 33);
            this.textemail.TabIndex = 151;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(152, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 21);
            this.label13.TabIndex = 150;
            this.label13.Text = "Email";
            // 
            // textnumber
            // 
            this.textnumber.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnumber.Location = new System.Drawing.Point(300, 220);
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(169, 33);
            this.textnumber.TabIndex = 149;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(152, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 21);
            this.label14.TabIndex = 148;
            this.label14.Text = "Number";
            // 
            // textsurname
            // 
            this.textsurname.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsurname.Location = new System.Drawing.Point(300, 169);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(169, 33);
            this.textsurname.TabIndex = 147;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(152, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 21);
            this.label15.TabIndex = 146;
            this.label15.Text = "Surname";
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(300, 121);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(169, 33);
            this.textname.TabIndex = 145;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(152, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 21);
            this.label16.TabIndex = 144;
            this.label16.Text = "Name";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.tabControl1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(993, 650);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtpayrate;
        private MetroFramework.Controls.MetroComboBox empstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox emptype;
        private MetroFramework.Controls.MetroComboBox DropGender;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmit;
        private MetroFramework.Controls.MetroComboBox DrpBank;
        private System.Windows.Forms.TextBox txtempaccno;
        private System.Windows.Forms.TextBox TxtIRD1;
        private System.Windows.Forms.TextBox BtnAddress;
        private System.Windows.Forms.Label lblEmpBnk;
        private System.Windows.Forms.Label lblBANo;
        private System.Windows.Forms.Label lblIRD;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1LblEmail;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtsname;
        private Bunifu.Framework.UI.BunifuFlatButton btnsid;
        private MetroFramework.Controls.MetroGrid GridView1;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.BindingSource employeeTblBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empMNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empBankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empBankAccountNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPayRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIdDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnsname;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuFlatButton btnempupdate;
        private System.Windows.Forms.TextBox textpayrate;
        private MetroFramework.Controls.MetroComboBox cbempstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cbemptype;
        private MetroFramework.Controls.MetroComboBox cbgender;
        private MetroFramework.Controls.MetroComboBox cbbankname;
        private System.Windows.Forms.TextBox textbankac;
        private System.Windows.Forms.TextBox textird1;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textnumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textsid;
        private Bunifu.Framework.UI.BunifuFlatButton btnempsid;
        private System.Windows.Forms.DataGridView EmpGrid;
    }
}
