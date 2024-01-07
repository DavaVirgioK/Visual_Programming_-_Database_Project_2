using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Data.SqlClient;
namespace Aplikasi_Project_Apotek_Kimia_Farma
{
    public partial class FormTransaksi : Form
    {
        string koneksi = "Data Source=FERROX\\SQLEXPRESS;Initial Catalog=UAS_Visprog;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        Koneksi konn = new Koneksi();
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public FormTransaksi()
        {
            InitializeComponent();
        }

        int total = 0;
        int qty = 0;
        int price = 0;
        int diskon = 0;

        void showData() {
            adpt = new SqlDataAdapter("select * from Transaksi", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void NoOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT TransactionID FROM Transaksi WHERE TransactionID IN(SELECT MAX (TransactionID) FROM Transaksi) ORDER BY TransactionID DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["TransactionID"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan = "TRB" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan = "TRB001";
            }
            rd.Close();
            txtTransID.Text = urutan;
            conn.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            showData();
            NoOtomatis();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        static string Diskon() {
            FileStream fs = new FileStream("D:\\Diskon.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            return (sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }

        static void Penjualan(string data, int total ) {
            FileStream fs = new FileStream("D:\\Penjualan.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sv = new StreamWriter(fs);
            sv.WriteLine(data, total);
            sv.Close();
            fs.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtDisc.Text = Diskon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Penjualan(txtTransID.Text, total);

            DataClasses1DataContext db = new DataClasses1DataContext();
            Transaksi cs = new Transaksi
            {
                TransactionID = txtTransID.Text,
                MedicineName = txtMedicineName.Text,
                MedicinePrice = (Convert.ToInt32(txtPrice.Text)),
                MedicineQuantity = (Convert.ToInt32(txtQty.Text)),
                Totalharga = total,

            };
            db.Transaksis.InsertOnSubmit(cs);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Input data berhasil");

                showData();
                txtTransID.Clear();
                txtMedicineName.Clear();
                txtPrice.Clear();
                txtQty.Clear();
                txtTotal.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisc.Text == "")
            {
                diskon = 0;
            }
            else {
                diskon = Convert.ToInt32(txtDisc.Text);
            }

            price = Convert.ToInt32(txtPrice.Text);

            if(txtQty.Text == "")
                System.Windows.Forms.MessageBox.Show("Harap Isi Jumlah");

            qty = Convert.ToInt32(txtQty.Text);
            
            total = (price * qty) - diskon;
            txtTotal.Text = total.ToString();

            button1.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DaftarObat daftar = new DaftarObat();
            daftar.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            TransactionDetail cs = new TransactionDetail
            {
                TransactionID = txtTransID.Text,
                MedicineID = txtMedID.Text,
                Quantity = txtQty.Text,


            };
            db.TransactionDetails.InsertOnSubmit(cs);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Input data berhasil");

                showData();
                txtMedicineName.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTransID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMedicineName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtQty.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTotal.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
