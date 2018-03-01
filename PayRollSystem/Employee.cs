using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace PayRollSystem
{
    public partial class Employee : UserControl
    {
        public string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PayRollData.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        static int count;

        PayRollDataEntities payroll = new PayRollDataEntities();
        DateTime rt;

        public Employee()
        {
            InitializeComponent();
            FillCombo();

            gridfill();

        }

        private void gridfill()
        {
            cmd = new SqlCommand("Select * from EmployeeTbl", con);
            System.Data.DataTable dt = new System.Data.DataTable();

            con.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                EmpGrid.DataSource = dt;
            }
            else
            {
                dt.Load(rdr);
                EmpGrid.DataSource = dt;
            }
            con.Close();
        }


        private void FillCombo()
        {
            SqlCommand sqlCmd = new SqlCommand();
            try
            {
                con = new SqlConnection(str);

                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * from  DepartmentTbl;";
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                cbemptype.DataSource = emptype.DataSource = dtRecord;
                cbemptype.DisplayMember = emptype.DisplayMember = "DeptName";
                cbemptype.ValueMember = emptype.ValueMember = "DeptId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a name of employee !");
                return;
            }
            else if (TxtSurname.Text == string.Empty)
            {
                MessageBox.Show("Please enter the surname of employee !");
                return;
            }
            else if (TxtNumber.Text == string.Empty)
            {
                MessageBox.Show("Please enter the mobile number of employee !");
                return;
            }
            else if (TxtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please enter the email of employee !");
                return;
            }
            else if (BtnAddress.Text == string.Empty)
            {
                MessageBox.Show("Please enter the address of employee !");
                return;
            }
            else if (TxtIRD1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the IRD number of employee !");
                return;
            }
            else if (txtempaccno.Text == string.Empty)
            {
                MessageBox.Show("Please enter the bank account number of employee !");
                return;
            }
            else if (txtpayrate.Text == string.Empty)
            {
                MessageBox.Show("Please enter the pay rate of employee !");
                return;
            }
            else if (DropGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Gender !");
                return;
            }
            else if (emptype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a position of employee !");
                return;
            }
            else if (empstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the cureent status of employee !");
                return;
            }
            else if (DrpBank.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a bank Name for Employee !");
                return;
            }
            con = new SqlConnection(str);
            con.Open();
            string tick = DateTime.Now.Ticks.ToString().Substring(8, 10);
            string uname = txtName.Text.Substring(0, 3).ToString() + tick;
            string pass = tick;

            //if (con.State == System.Data.ConnectionState.Open)


            cmd = new SqlCommand("insert into EmployeeTbl(EmpName,EmpSurname,EmpUsername,EmpPassword,EmpMNumber,EmpEmail,EmpAddress,EmpIRD,EmpGender," +
                "EmpBankName,EmpBankAccountNO,EmpPayRate,EmpStatus,EmpType,DeptId) values (@empname,@empsurname,@empusername,@emppass," +
                "@empmnumber,@empmail,@empaddress,@empird,@empgender,@empbankname,@empbankaccountno,@emppayrate,@empstatus,@emptype,@deptid)", con);


            cmd.Parameters.AddWithValue("@empname", txtName.Text);
            cmd.Parameters.AddWithValue("@empsurname", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@empmnumber", TxtNumber.Text);
            cmd.Parameters.AddWithValue("@empmail", TxtEmail.Text);
            cmd.Parameters.AddWithValue("@empaddress", BtnAddress.Text);
            cmd.Parameters.AddWithValue("@empird", TxtIRD1.Text);
            cmd.Parameters.AddWithValue("@empgender", DropGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@empbankname", DrpBank.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@empbankaccountno", txtempaccno.Text);
            cmd.Parameters.AddWithValue("@emppayrate", txtpayrate.Text);
            cmd.Parameters.AddWithValue("@empstatus", empstatus.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@emptype", emptype.SelectedValue);
            cmd.Parameters.AddWithValue("@empusername", uname);
            cmd.Parameters.AddWithValue("@emppass", pass);
            cmd.Parameters.AddWithValue("@deptid", Convert.ToInt32(emptype.SelectedValue.ToString()));

            cmd.ExecuteNonQuery();

            MessageBox.Show("New Employee Added Successfully");
            if (TxtEmail.Text.ToString().Trim().Equals(""))
            {
                // Show relevant message to user
                MessageBox.Show("Please Check Email Id");
            }
            else
            {
                // con = new SqlConnection(str);
                // Query to Check for id and password for specific email id
                cmd = new SqlCommand("Select EmpUsername,EmpPassword from EmployeeTbl where EmpEmail=@Email", con);
                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.ToString());

                //        con.Open();

                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    // Reading the data
                    rdr.Read();
                    SendMail(TxtEmail.Text.ToString(), rdr["EmpUsername"].ToString(), rdr["EmpPassword"].ToString());
                    MessageBox.Show("Email has been sent");
                }
                else
                {
                    // Show relevant message to user
                    MessageBox.Show("Email is not sent");

                }
                txtName.Text = "";
                TxtSurname.Text = "";
                TxtNumber.Text = "";
                BtnAddress.Text = "";
                TxtEmail.Text = "";
                TxtIRD1.Text = "";
                DrpBank.Text = "";
                txtempaccno.Text = "";
                empstatus.Text = "";
                emptype.Text = "";
                txtpayrate.Text = "";
                DropGender.Text = "";

            }
        }

        private void SendMail(string EmpEmail, string name, string Password)
        {
            // Function Use: Send Email with name  & Password
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("ranjitvicky19@gmail.com", "19ranjit");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            MailMessage mail = new MailMessage();

            //Setting From , To and CC
            mail.From = new MailAddress("ranjitvicky19@gmail.com");
            mail.To.Add(new MailAddress(EmpEmail));
            mail.Subject = "Payroll Employee Registration";
            mail.IsBodyHtml = true;
            mail.Body = "You profile has been recently uploaded by employer in Payroll System<br>Please check your Login Credential<br>"
                        + "UserName : " + name + "<br>"
                        + "Password : " + Password;
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail Does Not Sent...." + ex.Message.ToString());
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumber.Text.Remove(TxtNumber.Text.Length - 1);
                count = 1;
            }
            else
            {

                count = 0;
            }
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(TxtEmail.Text, (@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$")))
            //{
            //    MessageBox.Show("E-mail address format is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtNumber.Text.Remove(TxtEmail.Text.Length - 1);
            //    count = 1;
            //}
            //else
            //{
            //    count = 0;
            //}

        }

        private void txtempaccno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtempaccno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers and alphabet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumber.Text.Remove(txtempaccno.Text.Length - 1);
                count = 1;
            }
            else
            {
                count = 0;
            }
        }

        private void TxtIRD1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtIRD1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumber.Text.Remove(TxtIRD1.Text.Length - 1);
                count = 1;
            }
            else
            {

                count = 0;
            }
        }

        private void txtpayrate_TextChanged(object sender, EventArgs e)
        {

            //if (System.Text.RegularExpressions.Regex.IsMatch(TxtIRD1.Text, @"^[+-]?([0 - 9]*[.])?[0-9]+$"))
            //{
            //    MessageBox.Show("Please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtNumber.Text.Remove(TxtIRD1.Text.Length - 1);
            //    count = 1;
            //}
            //else
            //{

            //    count = 0;
            //}
        }

        private void btnempsid_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();

            cmd = new SqlCommand("Select * from EmployeeTbl WHERE EmpUsername LIKE '%'+@unames+'%' ", con);
            cmd.Parameters.AddWithValue("@unames", textsid.Text.ToString());
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows && rdr.Read())
            {
                // rdr.Read();
                textname.Text = rdr["EmpName"].ToString();
                textsurname.Text = rdr["EmpSurname"].ToString();
                textnumber.Text = rdr["EmpMNumber"].ToString();
                textpayrate.Text = rdr["EmpPayRate"].ToString();
                textbankac.Text = rdr["EmpBankAccountNO"].ToString();
                textaddress.Text = rdr["EmpAddress"].ToString();
                textemail.Text = rdr["EmpEmail"].ToString();
                textird1.Text = rdr["EmpIRD"].ToString();
                string gender = rdr["EmpGender"].ToString();
                cbgender.Text = gender;
                string bankname = rdr["EmpBankName"].ToString();
                cbbankname.Text = bankname;
                string status = rdr["EmpStatus"].ToString();
                cbempstatus.Text = status;
                string type = rdr["EmpType"].ToString();
                cbemptype.Text = type;



                //this.cbgender.DisplayMember = "EmpGender";//column that you want to show on combo Box
                // this.cbgender.ValueMember = "EmpGender";//same ColumnName Here



                //    cbemptype.Text = rdr.GetValue(2).ToString();
                //    cbempstatus.Text = rdr.GetValue(9).ToString();
                //    cbbankname.Text = rdr.GetValue(9).ToString();
            }
            else
            {
                rdr.Read();
                textird1.Text = "";
                textname.Text = "";
                textsurname.Text = "";
                textpayrate.Text = "";
                textbankac.Text = "";
                textnumber.Text = "";
                textaddress.Text = "";
                textemail.Text = "";
                cbbankname.Text = "";
                cbempstatus.Text = "";
                cbemptype.Text = "";
                cbgender.Text = "";

                MessageBox.Show("Employee ID not found");
            }
            con.Close();

        }

        private void btnempupdate_Click(object sender, EventArgs e)
        {
            if (textname.Text == string.Empty)
            {
                MessageBox.Show("Please enter a name of employee !");
                return;
            }
            else if (textsurname.Text == string.Empty)
            {
                MessageBox.Show("Please enter the surname of employee !");
                return;
            }
            else if (textnumber.Text == string.Empty)
            {
                MessageBox.Show("Please enter the mobile number of employee !");
                return;
            }
            else if (textemail.Text == string.Empty)
            {
                MessageBox.Show("Please enter the email of employee !");
                return;
            }
            else if (textaddress.Text == string.Empty)
            {
                MessageBox.Show("Please enter the address of employee !");
                return;
            }
            else if (textird1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the IRD number of employee !");
                return;
            }
            else if (textbankac.Text == string.Empty)
            {
                MessageBox.Show("Please enter the bank account number of employee !");
                return;
            }
            else if (textpayrate.Text == string.Empty)
            {
                MessageBox.Show("Please enter the pay rate of employee !");
                return;
            }
            else if (cbgender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Gender !");
                return;
            }
            else if (cbemptype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a position of employee !");
                return;
            }
            else if (cbempstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the current status of employee !");
                return;
            }
            else if (cbbankname.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a bank Name for Employee !");
                return;
            }
            //opeining connection and updating employee details
            con = new SqlConnection(str);
            con.Open();
            cmd = new SqlCommand("Update EmployeeTbl set EmpType=@emptype,EmpName=@empname,EmpSurname=@empsurname,EmpMNumber=@empmnumber," +
                "EmpEmail=@empemail,EmpAddress=@empaddress,EmpIRD=@empird,EmpGender=@empgender,EmpStatus=@empstatus,EmpBankName=@empbankname," +
                "EmpBankAccountNO=@empbankac,EmpPayRate=@emppayrate where EmpId=@empid", con);
            cmd.Parameters.AddWithValue("@empid", textsid.Text);
            cmd.Parameters.AddWithValue("@empname", textname.Text);
            cmd.Parameters.AddWithValue("@emptype", cbemptype.Text);
            cmd.Parameters.AddWithValue("@empsurname", textsurname.Text);
            cmd.Parameters.AddWithValue("@empmnumber", textnumber.Text);
            cmd.Parameters.AddWithValue("@empaddress", textaddress.Text);
            cmd.Parameters.AddWithValue("@empird", textird1.Text);
            cmd.Parameters.AddWithValue("@empemail", textemail.Text);
            cmd.Parameters.AddWithValue("@empgender", cbgender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@empstatus", cbempstatus.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@empbankname", cbbankname.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@empbankac", textbankac.Text);
            cmd.Parameters.AddWithValue("@emppayrate", textpayrate.Text);
            //  cmd.Parameters.AddWithValue("@deptid", Convert.ToInt32(cbemptype.SelectedValue.ToString()));


            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Employee Details UPDATED Successfully.");
                textird1.Text = "";
                textname.Text = "";
                textsurname.Text = "";
                textpayrate.Text = "";
                textbankac.Text = "";
                textnumber.Text = "";
                textaddress.Text = "";
                textemail.Text = "";
                cbbankname.Text = "";
                cbempstatus.Text = "";
                cbemptype.Text = "";
                cbgender.Text = "";

            }
            else
            {
                MessageBox.Show("Employee Details not UPDATED !");
            }

            con.Close();
        }
    }
}
