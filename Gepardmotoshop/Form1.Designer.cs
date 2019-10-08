namespace Gepardmotoshop
{
    partial class FrmInputBarang
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datagridbarang = new System.Windows.Forms.DataGridView();
            this.dataBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gepardmotoshopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gepardmotoshopDataSet = new Gepardmotoshop.gepardmotoshopDataSet();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBarangTableAdapter = new Gepardmotoshop.gepardmotoshopDataSetTableAdapters.DataBarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gepardmotoshopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gepardmotoshopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jumlah";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(244, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(244, 26);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Harga";
            // 
            // datagridbarang
            // 
            this.datagridbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbarang.Location = new System.Drawing.Point(25, 259);
            this.datagridbarang.Name = "datagridbarang";
            this.datagridbarang.RowTemplate.Height = 28;
            this.datagridbarang.Size = new System.Drawing.Size(600, 351);
            this.datagridbarang.TabIndex = 8;
            this.datagridbarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridbarang_CellContentClick);
            // 
            // dataBarangBindingSource
            // 
            this.dataBarangBindingSource.DataMember = "DataBarang";
            this.dataBarangBindingSource.DataSource = this.gepardmotoshopDataSetBindingSource;
            // 
            // gepardmotoshopDataSetBindingSource
            // 
            this.gepardmotoshopDataSetBindingSource.DataSource = this.gepardmotoshopDataSet;
            this.gepardmotoshopDataSetBindingSource.Position = 0;
            this.gepardmotoshopDataSetBindingSource.CurrentChanged += new System.EventHandler(this.GepardmotoshopDataSetBindingSource_CurrentChanged);
            // 
            // gepardmotoshopDataSet
            // 
            this.gepardmotoshopDataSet.DataSetName = "gepardmotoshopDataSet";
            this.gepardmotoshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(417, 171);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 34);
            this.btnhapus.TabIndex = 9;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(417, 133);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 32);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(417, 88);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 39);
            this.btnsimpan.TabIndex = 11;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Barang";
            // 
            // dataBarangTableAdapter
            // 
            this.dataBarangTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInputBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.datagridbarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInputBarang";
            this.Text = "Input Barang";
            this.Load += new System.EventHandler(this.FrmInputBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridbarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gepardmotoshopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gepardmotoshopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datagridbarang;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource gepardmotoshopDataSetBindingSource;
        private gepardmotoshopDataSet gepardmotoshopDataSet;
        private System.Windows.Forms.BindingSource dataBarangBindingSource;
        private gepardmotoshopDataSetTableAdapters.DataBarangTableAdapter dataBarangTableAdapter;
    }
}

