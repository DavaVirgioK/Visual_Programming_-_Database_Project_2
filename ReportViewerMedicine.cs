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
    public partial class ReportViewerMedicine : Form
    {
        public ReportViewerMedicine()
        {
            InitializeComponent();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportMedicine rm = new ReportMedicine();
            rm.SetParameterValue("CariObat", textBox1.Text);
            crystalReportViewer1.ReportSource = rm;
        }

        private void ReportViewerMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
