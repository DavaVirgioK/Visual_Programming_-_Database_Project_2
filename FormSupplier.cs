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
using System.Data.OleDb;

namespace Aplikasi_Project_Apotek_Kimia_Farma
{
    public partial class FormSupplier : Form
    {
        string koneksi = "Data Source=FERROX\\SQLEXPRESS;Initial Catalog=UAS_Visprog;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        string vquery = "";

        Koneksi konn = new Koneksi();
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public FormSupplier()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            Suplier spp = new Suplier
            {
                SuplierID = txtSuppId.Text,
                SuplierName = txtSuppName.Text,
                SuplierAddress = txtSuppAdd.Text,
                SuplierPhone = txtSuppContact.Text,
            };
            db.Supliers.InsertOnSubmit(spp);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Input data berhasil");

                txtSuppId.Clear();
                txtSuppName.Clear();
                txtSuppAdd.Clear();
                txtSuppContact.Clear();
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void NoOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT SuplierID FROM Suplier WHERE SuplierID IN(SELECT MAX (SuplierID) FROM Suplier) ORDER BY SuplierID DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["SuplierID"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan = "SUP" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan = "SUP001";
            }
            rd.Close();
            txtSuppId.Text = urutan;
            conn.Close();
        }
        public void showData()
        {
            adpt = new SqlDataAdapter("select * from Suplier", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var ubah = (from a in db.Supliers
                        where a.SuplierID == txtSuppId.Text
                        select a).Single();
            ubah.SuplierName = txtSuppName.Text;
            ubah.SuplierAddress = txtSuppAdd.Text;
            ubah.SuplierPhone = txtSuppContact.Text;
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Update Data Berhasil");


                txtSuppId.Clear();
                txtSuppName.Clear();
                txtSuppAdd.Clear();
                txtSuppContact.Clear();
                showData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var delete = (from a in db.Supliers
                          where a.SuplierID == txtSuppId.Text
                          select a).Single();
            db.Supliers.DeleteOnSubmit(delete);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Delete Data Berhasil");

                txtSuppId.Clear();
                txtSuppName.Clear();
                txtSuppAdd.Clear();
                txtSuppContact.Clear();
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportViewerSupplier rvs = new ReportViewerSupplier();
            rvs.Show();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            showData();
            NoOtomatis();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSuppId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSuppName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSuppAdd.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSuppContact.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select * from Suplier WHERE SuplierName = '" + txtSearch.Text + "'", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
