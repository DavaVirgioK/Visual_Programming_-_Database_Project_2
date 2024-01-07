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
    public partial class ReportViewerCustomer : Form
    {
        public ReportViewerCustomer()
        {
            InitializeComponent();
        }

        private void ReportViewerCustomer_Load(object sender, EventArgs e)
        {
            ReportCustomer rm = new ReportCustomer();
            crystalReportViewer1.ReportSource = rm;
        }
    }
}
