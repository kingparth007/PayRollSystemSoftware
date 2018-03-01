using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollSystem
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            ContentPnl.Controls.Clear();
            Employee emp = new Employee();
            ContentPnl.Controls.Add(emp);

        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            ContentPnl.Controls.Clear();
            EmpClockPay clock = new EmpClockPay();
            ContentPnl.Controls.Add(clock);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }
    }
}
