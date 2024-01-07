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
    public partial class ReportViewerSupplier : Form
    {
        public ReportViewerSupplier()
        {
            
            InitializeComponent();

            SupplierReport sr = new SupplierReport();
            crystalReportViewer1.ReportSource = sr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
