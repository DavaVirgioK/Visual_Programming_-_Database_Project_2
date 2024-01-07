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
    public partial class ReportViewerEmployee2 : Form
    {
        public ReportViewerEmployee2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ReportViewerEmployee2_Load(object sender, EventArgs e)
        {
            ReportEmployee2 rm = new ReportEmployee2();
            crystalReportViewer1.ReportSource = rm;
        }
    }
}
