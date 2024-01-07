using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Project_Apotek_Kimia_Farma
{
    public partial class FormLogin : Form
    {
        string koneksi = "Data Source=FERROX\\SQLEXPRESS;Initial Catalog=UAS_Visprog;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        string vquery = "";


        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStokObat fso = new FormStokObat();
            fso.Show();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
       

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var login = (from a in db.Employees
                        where a.UserName == txtUsername.Text
                       && a.Pasword == txtPassword.Text
                        select a);

            if (login.Any())
            {

                FormMenuUtama.menu.menuLogin.Enabled = false;
                FormMenuUtama.menu.menuLogout.Enabled = true;
                FormMenuUtama.menu.menuMaster.Enabled = true;
                FormMenuUtama.menu.menuTransaksi.Enabled = true;
                FormMenuUtama.menu.menuUtility.Enabled = true;

                MessageBox.Show("Login Data Berhasil");
               this.Close();
      
            }
            else
            {
                MessageBox.Show("Login Data Gagal");

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "MNG001";
            txtPassword.Text = "admin123";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
 }

