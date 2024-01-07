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
    public partial class Form1 : Form
    {
        string koneksi = "Data Source=FERROX\\SQLEXPRESS;Initial Catalog=UAS_Visprog;Integrated Security=True";
        DataSet ds = new DataSet();
        string vquery = "";
        public Form1()
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
                MessageBox.Show("Login Data Berhasil");
                MainMenu f3 = new MainMenu();
                f3.Show();
                
            }
            else
            {
                MessageBox.Show("Login Data Gagal");

            }

        }
    }
 }

