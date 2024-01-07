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
    public partial class DaftarObat : Form
    {
        string koneksi = "Data Source=FERROX\\SQLEXPRESS;Initial Catalog=UAS_Visprog;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        string vquery = "";

        public DaftarObat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTransaksi ft = new FormTransaksi();
            ft.txtMedicineName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ft.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ft.txtMedID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ft.Show();
            Close();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select * from Medicine WHERE MedicineName = '"+ txtSearch.Text +"'", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DaftarObat_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select * from Medicine", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
