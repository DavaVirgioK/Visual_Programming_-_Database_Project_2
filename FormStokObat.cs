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
    public partial class FormStokObat : Form
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
  
        public FormStokObat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) { 


            DataClasses1DataContext db = new DataClasses1DataContext();
            Medicine mdc = new Medicine
            {
                MedicineID = txtMedId.Text,
                MedicineName = txtMedNama.Text,
                MedicinePrice = (Convert.ToInt32(txtMedPrice.Text)),
                MedicineQty = (Convert.ToInt32(txtMedQuantity.Text)),
                MedicineDate = this.dateTimePicker1.Text,
            };
            db.Medicines.InsertOnSubmit(mdc);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Input data berhasil");

                txtMedId.Clear();
                txtMedNama.Clear();
                txtMedPrice.Clear();
                txtMedQuantity.Clear();
                dateTimePicker1.CustomFormat="";
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        public void showData() {
            adpt = new SqlDataAdapter("select * from Medicine", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMedId_Leave(object sender, EventArgs e)
        {

        }

        private void FormStokObat_Load(object sender, EventArgs e)
        {
            showData();
            NoOtomatis();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void NoOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT MedicineID FROM Medicine WHERE MedicineID IN(SELECT MAX (MedicineID) FROM Medicine) ORDER BY MedicineID DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["MedicineID"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan = "MDI" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan = "MDI001";
            }
            rd.Close();
            txtMedId.Text = urutan;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var ubah = (from a in db.Medicines
                        where a.MedicineID == txtMedId.Text
                        select a).Single();
            ubah.MedicineName = txtMedNama.Text;
            ubah.MedicinePrice = (Convert.ToInt32(txtMedPrice.Text));
            ubah.MedicineQty = (Convert.ToInt32(txtMedQuantity.Text));
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Update Data Berhasil");

                txtMedId.Clear();
                txtMedNama.Clear();
                txtMedPrice.Clear();
                txtMedQuantity.Clear();
                dateTimePicker1.CustomFormat = "";
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
            var delete = (from a in db.Medicines
                          where a.MedicineID == txtMedId.Text
                          select a).Single();
            db.Medicines.DeleteOnSubmit(delete);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Delete Data Berhasil");

                txtMedId.Clear();
                txtMedNama.Clear();
                txtMedPrice.Clear();
                txtMedQuantity.Clear();
                dateTimePicker1.CustomFormat = "";
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportViewerMedicine rvm = new ReportViewerMedicine();
            rvm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            txtMedId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMedNama.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMedPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMedQuantity.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMedId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportViewerMedicine2 rvm2 = new ReportViewerMedicine2();
            rvm2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select * from Medicine WHERE MedicineID = '" + txtSearch.Text + "'", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
