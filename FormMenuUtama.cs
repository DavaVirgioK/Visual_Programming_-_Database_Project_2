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
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        MenuStrip mnstrip;
        
        void MenuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtility.Enabled = false;
            menu = this;
        }
        
        FormLogin vformLogin;
        void vformLogin_formClosed(object sender, FormClosedEventArgs e)
        {
            vformLogin = null;
        }

        FormStokObat vformObat;
        void vformObat_formClosed(object sender, FormClosedEventArgs e)
        {
            vformObat = null;
        }

        FormEmployee vformEmployee;
        void vformEmployee_formClosed(object sender, FormClosedEventArgs e)
        {
            vformEmployee = null;
        }

        FormCustomer vformCustomer;
        void vformCustomer_formClosed(object sender, FormClosedEventArgs e)
        {
            vformCustomer = null;
        }

        FormSupplier vformSupplier;
        void vformSupplier_formClosed(object sender, FormClosedEventArgs e)
        {
            vformSupplier = null;
        }

        FormTransaksi vformTransaksi;
        void vformTransaksi_formClosed(object sender, FormClosedEventArgs e)
        {
            vformTransaksi = null;
        }

        FormAbout vformAbout;
        void vformAbout_formClosed(object sender, FormClosedEventArgs e)
        {
            vformAbout = null;
        }

        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vformLogin == null)
            {
                vformLogin = new FormLogin();
                vformLogin.FormClosed += new FormClosedEventHandler(vformLogin_formClosed);
                vformLogin.ShowDialog();
            }
            else
            {
                vformLogin.Activate();
            }
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vformObat == null)
            {
                vformObat = new FormStokObat();
                vformObat.FormClosed += new FormClosedEventHandler(vformObat_formClosed);
                vformObat.ShowDialog();
            }
            else
            {
                vformObat.Activate();
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vformEmployee == null)
            {
                vformEmployee = new FormEmployee();
                vformEmployee.FormClosed += new FormClosedEventHandler(vformEmployee_formClosed);
                vformEmployee.ShowDialog();
            }
            else
            {
                vformEmployee.Activate();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vformCustomer == null)
            {
                vformCustomer = new FormCustomer();
                vformCustomer.FormClosed += new FormClosedEventHandler(vformCustomer_formClosed);
                vformCustomer.ShowDialog();
            }
            else
            {
                vformCustomer.Activate();
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vformSupplier == null)
            {
                vformSupplier = new FormSupplier();
                vformSupplier.FormClosed += new FormClosedEventHandler(vformSupplier_formClosed);
                vformSupplier.ShowDialog();
            }
            else
            {
                vformSupplier.Activate();
            }
        }

        private void menuTransaksi_Click(object sender, EventArgs e)
        {
            if (vformTransaksi == null)
            {
                vformTransaksi = new FormTransaksi();
                vformTransaksi.FormClosed += new FormClosedEventHandler(vformTransaksi_formClosed);
                vformTransaksi.ShowDialog();
            }
            else
            {
                vformTransaksi.Activate();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vformAbout == null)
            {
                vformAbout = new FormAbout();
                vformAbout.FormClosed += new FormClosedEventHandler(vformAbout_formClosed);
                vformAbout.ShowDialog();
            }
            else
            {
                vformAbout.Activate();
            }
        }
    }
}
