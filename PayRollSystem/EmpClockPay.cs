using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace PayRollSystem
{
    public partial class EmpClockPay : UserControl
    {
        PayRollDataEntities payroll = new PayRollDataEntities();
        DateTime rt;

        public EmpClockPay()
        {

            InitializeComponent();
            FillGrid();
            FillComboName();
            EmpPayGrid.Visible = false;
        }

        private void FillComboName()
        {
            //EmpNameCombo.DataSource = payroll.EmployeeTbls.ToList();
            //EmpNameCombo.DisplayMember = "EmpName";
            //EmpNameCombo.ValueMember = "EmpId";
        }

        private void FillGrid()
        {
          ClockGrid.DataSource = (from ec in payroll.EmpClockTbls
                                                           join e in payroll.EmployeeTbls on ec.EmpId equals e.EmpId
                                                           where ec.EmpWokDate.Equals(System.DateTime.Today.Date)
                                                           select new
                                                           {
                                                               Name = e.EmpName,
                                                               Start_Time = ec.EmpWorkStartTime,
                                                               Fnish_Time = ec.EmpWorkFinishTime,
                                                               Total_Hours = ec.EmpWorkHours,

                                                           }).ToList();

            //FillGrid2.DataSource = (from ec in payroll.EmpClockTbls
            //                        join e in payroll.EmployeeTbls on ec.EmpId equals e.EmpId
            //                        where ec.EmpWokDate.Equals(System.DateTime.Today.Date)
            //                        select new
            //                        {
            //                            Name = e.EmpName,
            //                            Start_Time = ec.EmpWorkStartTime,
            //                            Fnish_Time = ec.EmpWorkFinishTime,
            //                            Total_Hours = ec.EmpWorkHours,

            //                        }).ToList();
            // ClockGrid.DataSource = payroll.EmpClockTbls.Where(e => e.EmpWokDate.Equals(System.DateTime.Today.Date)).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPaySalary_Click(object sender, EventArgs e)
        {
            DateTime endweekdate = System.DateTime.Today.Date.AddDays(-2);
            DateTime startweekdate = System.DateTime.Today.Date.AddDays(-9);
            // MessageBox.Show(endweekdate + " Today-" + System.DateTime.Now.ToShortDateString() + "End Week :" + startweekdate);
            var paylast = payroll.EmpPayTbls.OrderByDescending(pl => pl.EmpPayID).ToList().FirstOrDefault();
            //if (paylast != null)
            //{
            DateTime chc = System.DateTime.Now.Date.AddDays(-7);
            if (paylast == null || paylast.EmpSalaryDate.AddDays(-7) == chc)
            {
                var empid = payroll.EmployeeTbls.Where(es => es.EmpStatus.Equals("Active Employee")).ToList();
                foreach (var i in empid)
                {
                    Decimal thw = 0;
                    var empweekclock = (from ec in payroll.EmpClockTbls
                                        where ec.EmpId.Equals(i.EmpId) &&
                                       (ec.EmpWokDate >= startweekdate && ec.EmpWokDate <= endweekdate)
                                        select new
                                        {
                                            TotalHours = ec.EmpWorkHours
                                        }).ToList();
                    foreach (var c in empweekclock)
                    {
                        Decimal ct = Convert.ToDecimal(c.TotalHours.ToString());
                        thw = thw + ct;
                        //         MessageBox.Show(thw.ToString());
                    }

                    Decimal totalpayofweek = thw * i.EmpPayRate;
                    Decimal totaltaxofweek = (totalpayofweek * 114) / 1000;
                    Decimal totalcreditamout = totalpayofweek - totaltaxofweek;
                    MessageBox.Show("TotalPay:" + totalpayofweek + "___TotalTax:" + totaltaxofweek +
                        "___TotalCredit:" + totalcreditamout);

                    EmpPayTbl PayToEmp = new EmpPayTbl()
                    {
                        EmpSalaryDate = System.DateTime.Now.Date,
                        EmpTotalHours = thw,
                        EmpTotalPay = totalpayofweek,
                        EmpTaxPay = totaltaxofweek,
                        EmpCreditPay = totalcreditamout,
                        EmpId = i.EmpId
                    };
                    payroll.EmpPayTbls.Add(PayToEmp);
                    payroll.SaveChanges();
                }
                Fillpay();
            }
            else
            {
                MessageBox.Show("Its not time for Pay");
            }

        }

        private void Fillpay()
        {

            EmpPayGrid.Visible = true;
            EmpPayGrid.DataSource = payroll.EmpPayTbls.Where(ps => ps.EmpSalaryDate.Equals(System.DateTime.Today.Date)).ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSendPaySlip_Click(object sender, EventArgs e)
        {
            var paylist = payroll.EmpPayTbls.Where(ps => ps.EmpSalaryDate.Equals(System.DateTime.Today.Date)).ToList();

            foreach (var i in paylist)
            {

                var ud = payroll.EmployeeTbls.Where(g => g.EmpId.Equals(i.EmpId)).First();

                string payslip = @"<table border='2'><tr><td><b>" + ud.EmpName + " " + ud.EmpSurname + "</b></td></tr>" +
                                        "<tr><td><b>Date:-</b></td> " +
                                        "<td>" + i.EmpSalaryDate.ToShortDateString() + "</td></tr>" +
                                        "<tr><b><td>Hours</td>" +
                                        "<td>PayRate</td></b>" +
                                        "<tr><td>" + i.EmpTotalHours + "</td>" +
                                        "<td>" + ud.EmpPayRate + "</td></tr>" +
                                        "<tr><td><b>TOTALPAY--</b></td>" +
                                        "<td>" + i.EmpTotalPay + "</td></tr>" +
                                        "<tr></b><td>TOTAL TAX--</b></td>" +
                                        "<td>" + i.EmpTaxPay + "</td></tr>" +
                                        "<tr><td><b>Total Credited Amount--</b></td>" +
                                        "<td>" + i.EmpCreditPay + "</td></tr></table>";

                MessageBox.Show(payslip);

                PayMail(ud.EmpEmail, payslip);
            }

        }

        private void PayMail(string empEmail, string payslip)
        {
            // Function Use: Send Email with name  & Password
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential("ranjitvicky19@gmail.com", "19ranjit"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true
            };
            MailMessage mail = new MailMessage()
            {

                //Setting From , To and CC
                From = new MailAddress("ranjitvicky19@gmail.com")
            };
            mail.To.Add(new MailAddress(empEmail));
            mail.Subject = "Weekly PaySlip";
            mail.IsBodyHtml = true;
            mail.Body = "<b>Your Last Week PaySlip<b>" +
                " <br> PayRoll Co.<br><br>" +
                "<br>" + payslip;
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail Does Not Sent...." + ex.Message.ToString());
            }

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WorkingEmp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
