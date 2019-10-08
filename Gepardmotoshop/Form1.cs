using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Gepardmotoshop
{
    public partial class FrmInputBarang : Form
    {
        OleDbConnection konek = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bagus\Documents\gepardmotoshop.accdb");

        public FrmInputBarang()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into DataBarang (ID,NmBarang,Jml,Harga) VALUES ('{0}','{1}','{2}','{3}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                konek.Open();
                OleDbCommand cmd = new OleDbCommand(sql, konek);
                cmd.ExecuteNonQuery();
                konek.Close();
                MessageBox.Show("Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
            
        }

        private void Datagridbarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = datagridbarang.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void GepardmotoshopDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmInputBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gepardmotoshopDataSet.DataBarang' table. You can move, or remove it, as needed.
            string sql = "select * from Databarang";
            //konek.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, konek);
            DataSet ds = new DataSet();
            da.Fill(ds, "Databarang");
            datagridbarang.DataSource = ds.Tables["Databarang"].DefaultView;
            // konek.Close();
            dataBarangTableAdapter.Dispose();
        

        }
    }
}
