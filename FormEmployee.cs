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
    public partial class FormEmployee : Form
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
        public FormEmployee()
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
            cmd = new SqlCommand("SELECT EmployeeID FROM Employee WHERE EmployeeID IN(SELECT MAX (EmployeeID) FROM Employee) ORDER BY EmployeeID DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["EmployeeID"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan = "EMP" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan = "EMP001";
            }
            rd.Close();
            txtEmpID.Text = urutan;
            conn.Close();
        }

        public void showData()
        {
            adpt = new SqlDataAdapter("select * from Employee", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Employee emp = new Employee
            {
                EmployeeID = txtEmpID.Text,
                EmployeeName = txtEmpName.Text,
                EmployeeAddress = txtEmpName.Text,
                EmployeePosition = txtEmpPos.Text,
                UserName = txtUsername.Text,
                Pasword = txtPassword.Text,
                Email = txtEmail.Text,
                Date = this.dateTimePicker1.Text,
            };
            db.Employees.InsertOnSubmit(emp);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Input data berhasil");

                txtEmpID.Clear();
                txtEmpName.Clear();
                txtEmpPos.Clear();
                txtEmpAdd.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtEmail.Clear();
                dateTimePicker1.CustomFormat = "";
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
            var ubah = (from a in db.Employees
                        where a.EmployeeID == txtEmpID.Text
                        select a).Single();
            ubah.EmployeeName = txtEmpID.Text;
            ubah.EmployeeAddress = txtEmpAdd.Text;
            ubah.EmployeePosition = txtEmpPos.Text;
            ubah.UserName = txtUsername.Text;
            ubah.Pasword = txtPassword.Text;
            ubah.Email = txtEmail.Text;
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Update Data Berhasil");

                txtEmpID.Clear();
                txtEmpName.Clear();
                txtEmpPos.Clear();
                txtEmpAdd.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtEmail.Clear();
                dateTimePicker1.CustomFormat = "";
                showData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            showData();
            NoOtomatis();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var delete = (from a in db.Employees
                          where a.EmployeeID == txtEmpID.Text
                          select a).Single();
            db.Employees.DeleteOnSubmit(delete);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Delete Data Berhasil");

                txtEmpID.Clear();
                txtEmpName.Clear();
                txtEmpPos.Clear();
                txtEmpAdd.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtEmail.Clear();
                dateTimePicker1.CustomFormat = "";
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
            ReportViewEmployee fve = new ReportViewEmployee();
            fve.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtEmpID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtEmpName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEmpPos.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmpAdd.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUsername.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select * from Employee WHERE EmployeeName = '" + txtSearch.Text + "'", koneksi);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportViewerEmployee2 re = new ReportViewerEmployee2();
            re.Show();

        }
    }
}

