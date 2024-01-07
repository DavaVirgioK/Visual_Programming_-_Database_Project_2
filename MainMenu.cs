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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FormStokObat fso = new FormStokObat();
            fso.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTransaksi f5 = new FormTransaksi();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEmployee fe = new FormEmployee();
            fe.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCustomer fc = new FormCustomer();
            fc.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
