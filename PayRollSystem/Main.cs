using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollSystem
{
    public partial class Main : Form
    {
        PayRollDataEntities payroll = new PayRollDataEntities();
        DateTime rt;

        public Main()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            drpClockInOut.Text = "Please Select";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (signUserName.Text == "Admin" && txtPass.Text == "Admin123")
            {
                this.Hide();
                Owner owner = new Owner();
                owner.Show();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            InsertData();
        }
        private void InsertData()
        {
            try
            {
                int id = 0;
                string usrnm = txtUserName.Text;
                string b = Convert.ToString(System.DateTime.Now.ToShortTimeString());

                if (drpClockInOut.Text != "" && usrnm != "")
                {


                    EmployeeTbl emplist = payroll.EmployeeTbls.First(u => u.EmpUsername.Equals(usrnm));
                    id = emplist.EmpId;

                    if (id != 0)
                    {
                        EmpClockTbl checkclock = payroll.EmpClockTbls.Where(e => e.EmpId == id && e.EmpWokDate.Equals(System.DateTime.Today.Date)).SingleOrDefault();
                        if (checkclock != null && drpClockInOut.Text.ToUpper().ToString() == "CLOCK OUT")
                        {

                            if (checkclock.EmpWorkFinishTime == null)
                            {
                                DateTime starttime = Convert.ToDateTime(checkclock.EmpWorkStartTime);
                                DateTime finishtime = roundmin(Convert.ToDateTime(System.DateTime.Now.ToShortTimeString()));
                                string totalhours = Convert.ToString(finishtime - starttime);
                                totalhours = Regex.Replace(totalhours, "[:]", ".");
                                totalhours = totalhours.Substring(0, 5);
                                checkclock.EmpWorkFinishTime = finishtime.ToShortTimeString();
                                checkclock.EmpWorkHours = totalhours;
                                payroll.SaveChanges();
                                MessageBox.Show("Good Bye. Have a Nice Day. Thank you for working today");
                            }
                            else
                            {
                                MessageBox.Show("Already Clock Out Bye Bye");
                            }

                        }
                        else
                        {
                            if (drpClockInOut.Text.ToUpper().ToString() == "CLOCK IN")
                            {

                                EmpClockTbl checkcIn = payroll.EmpClockTbls.Where(e => e.EmpId == id && e.EmpWokDate.Equals(System.DateTime.Today.Date)).SingleOrDefault();
                                if (checkcIn == null)
                                {
                                    roundmin(Convert.ToDateTime(b.ToString()));
                                    MessageBox.Show(rt.ToShortTimeString());
                                    EmpClockTbl clock = new EmpClockTbl();

                                    clock.EmpId = id;
                                    clock.EmpWokDay = System.DateTime.Today.DayOfWeek.ToString();
                                    clock.EmpWorkStartTime = rt.ToShortTimeString();
                                    clock.EmpWokDate = System.DateTime.Today.Date;
                                    payroll.EmpClockTbls.Add(clock);
                                    MessageBox.Show(payroll.GetValidationErrors().ToString());
                                    payroll.SaveChanges();

                                    MessageBox.Show("Welcome");
                                }
                                else
                                {
                                    MessageBox.Show("Already Clock IN");
                                }
                            }
                            else
                            {

                                MessageBox.Show("Please Clock in");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Insert Correct Username");

                    }


                }

                else
                {
                    MessageBox.Show("Please Insert Data");
                }
            }

            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

        }

        DateTime roundmin(DateTime dt)
        {
            int min = dt.Minute;

            DateTime Output;
            int Minute;


            if ((dt.Minute <= 8) || ((dt.Minute >= 16) && (dt.Minute <= 22)) || ((dt.Minute >= 31) && (dt.Minute <= 38)) || ((dt.Minute >= 46) && (dt.Minute <= 52)))
            {
                Minute = -1;
            }
            else
            {
                if (dt.Minute >= 52)
                {
                    dt.AddHours(1);
                    Minute = +1;
                }
                Minute = +1;
            }

            while ((dt.Minute != 0) && (dt.Minute != 15) && (dt.Minute != 30) && (dt.Minute != 45))
                dt = dt.AddMinutes(Minute);
            rt = dt;
            return rt;

        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
