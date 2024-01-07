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
    public partial class ReportViewerMedicine2 : Form
    {
        public ReportViewerMedicine2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportMedicine2 rm = new ReportMedicine2();
            rm.SetParameterValue("T_Medicine", this.dateTimePicker1.Text);
            crystalReportViewer1.ReportSource = rm;
        }

        private void ReportViewerMedicine2_Load(object sender, EventArgs e)
        {
 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
