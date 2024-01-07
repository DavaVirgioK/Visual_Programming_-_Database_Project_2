using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Project_Apotek_Kimia_Farma
{
    public partial class ReportViewEmployee : Form
    {
        public ReportViewEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportEmployee rm = new ReportEmployee();
            rm.SetParameterValue("tglMasuk", this.dateTimePicker1.Text);
            crystalReportViewer1.ReportSource = rm;
        }

        private void ReportViewEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
