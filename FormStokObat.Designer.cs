
namespace Aplikasi_Project_Apotek_Kimia_Farma
{
    partial class FormStokObat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMedPrice = new System.Windows.Forms.TextBox();
            this.txtMedNama = new System.Windows.Forms.TextBox();
            this.txtMedId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.univDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.univDataSet = new Aplikasi_Project_Apotek_Kimia_Farma.UnivDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.uASVisprogDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uAS_VisprogDataSet1 = new Aplikasi_Project_Apotek_Kimia_Farma.UAS_VisprogDataSet();
            this.uASVisprogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uAS_VisprogDataSet = new Aplikasi_Project_Apotek_Kimia_Farma.UAS_VisprogDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASVisprogDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAS_VisprogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASVisprogDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAS_VisprogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMedQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtMedPrice);
            this.groupBox1.Controls.Add(this.txtMedNama);
            this.groupBox1.Controls.Add(this.txtMedId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(436, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Stok Obat";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tanggal Masuk";
            // 
            // txtMedQuantity
            // 
            this.txtMedQuantity.Location = new System.Drawing.Point(183, 132);
            this.txtMedQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedQuantity.Name = "txtMedQuantity";
            this.txtMedQuantity.Size = new System.Drawing.Size(108, 22);
            this.txtMedQuantity.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantity";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 261);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 261);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMedPrice
            // 
            this.txtMedPrice.Location = new System.Drawing.Point(183, 100);
            this.txtMedPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedPrice.Name = "txtMedPrice";
            this.txtMedPrice.Size = new System.Drawing.Size(191, 22);
            this.txtMedPrice.TabIndex = 12;
            // 
            // txtMedNama
            // 
            this.txtMedNama.Location = new System.Drawing.Point(183, 69);
            this.txtMedNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedNama.Name = "txtMedNama";
            this.txtMedNama.Size = new System.Drawing.Size(191, 22);
            this.txtMedNama.TabIndex = 11;
            // 
            // txtMedId
            // 
            this.txtMedId.Enabled = false;
            this.txtMedId.Location = new System.Drawing.Point(183, 34);
            this.txtMedId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedId.Name = "txtMedId";
            this.txtMedId.Size = new System.Drawing.Size(88, 22);
            this.txtMedId.TabIndex = 10;
            this.txtMedId.Leave += new System.EventHandler(this.txtMedId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MedicineID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 396);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // univDataSetBindingSource
            // 
            this.univDataSetBindingSource.DataSource = this.univDataSet;
            this.univDataSetBindingSource.Position = 0;
            // 
            // univDataSet
            // 
            this.univDataSet.DataSetName = "UnivDataSet";
            this.univDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1177, 483);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 35);
            this.button5.TabIndex = 20;
            this.button5.Text = "Cetak Report";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(499, 477);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 27);
            this.button6.TabIndex = 21;
            this.button6.Text = "Pilih Data";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // uASVisprogDataSet1BindingSource
            // 
            this.uASVisprogDataSet1BindingSource.DataSource = this.uAS_VisprogDataSet1;
            this.uASVisprogDataSet1BindingSource.Position = 0;
            // 
            // uAS_VisprogDataSet1
            // 
            this.uAS_VisprogDataSet1.DataSetName = "UAS_VisprogDataSet";
            this.uAS_VisprogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uASVisprogDataSetBindingSource
            // 
            this.uASVisprogDataSetBindingSource.DataSource = this.uAS_VisprogDataSet;
            this.uASVisprogDataSetBindingSource.Position = 0;
            // 
            // uAS_VisprogDataSet
            // 
            this.uAS_VisprogDataSet.DataSetName = "UAS_VisprogDataSet";
            this.uAS_VisprogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(971, 483);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 35);
            this.button7.TabIndex = 22;
            this.button7.Text = "Cetak Report Tanggal";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(572, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 22);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(499, 41);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(56, 17);
            this.lblid.TabIndex = 24;
            this.lblid.Text = "ID Obat";
            this.lblid.Click += new System.EventHandler(this.lblid_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(749, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 25;
            this.button8.Text = "Cari";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1213, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "Reset";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // FormStokObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 528);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStokObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Insert Gudang";
            this.Load += new System.EventHandler(this.FormStokObat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASVisprogDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAS_VisprogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASVisprogDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAS_VisprogDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMedNama;
        private System.Windows.Forms.TextBox txtMedId;
        private System.Windows.Forms.TextBox txtMedPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMedQuantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource univDataSetBindingSource;
        private UnivDataSet univDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource uASVisprogDataSetBindingSource;
        private UAS_VisprogDataSet uAS_VisprogDataSet;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource uASVisprogDataSet1BindingSource;
        private UAS_VisprogDataSet uAS_VisprogDataSet1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}