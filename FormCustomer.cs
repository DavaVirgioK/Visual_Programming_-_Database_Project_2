using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Project_Apotek_Kimia_Farma
{
    public partial class FormCustomer : Form
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

        public FormCustomer()
        {
            InitializeComponent();
        }

        void NoOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT CustID FROM Customer WHERE CustID IN(SELECT MAX (CustID) FROM Customer) ORDER BY CustID DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["CustID"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan = "CST" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan = "CST001";
            }
            rd.Close();
            txtCustID.Text = urutan;
            conn.Close();
        }
        public void showData()
        {
            adpt = new SqlDataAdapter("select * from Customer", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Customer cs = new Customer
            {
                CustID = txtCustID.Text,
                CustName = txtCustName.Text,
                CustAddress = txtCustAddress.Text,
                CustPhone = txtCustPhone.Text,
        
            };
            db.Customers.InsertOnSubmit(cs);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Input data berhasil");

                txtCustID.Clear();
                txtCustName.Clear();
                txtCustAddress.Clear();
                txtCustPhone.Clear();
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var ubah = (from a in db.Customers
                        where a.CustID == txtCustID.Text
                        select a).Single();
            ubah.CustName = txtCustName.Text;
            ubah.CustAddress = txtCustName.Text;
            ubah.CustPhone = txtCustPhone.Text;
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Update Data Berhasil");



                txtCustID.Clear();
                txtCustName.Clear();
                txtCustAddress.Clear();
                txtCustPhone.Clear();
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
            var delete = (from a in db.Customers
                          where a.CustID == txtCustID.Text
                          select a).Single();
            db.Customers.DeleteOnSubmit(delete);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Delete Data Berhasil");

                txtCustID.Clear();
                txtCustName.Clear();
                txtCustAddress.Clear();
                txtCustPhone.Clear();
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            showData();
            NoOtomatis();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportViewerCustomer rvc = new ReportViewerCustomer();
            rvc.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select * from Customer WHERE CustomerName = '" + txtSearch.Text + "'", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCustID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCustName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCustAddress.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCustPhone.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
