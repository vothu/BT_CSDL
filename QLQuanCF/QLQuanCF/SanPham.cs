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


namespace QLQuanCF
{
    public partial class SanPham : Form
    {

        string constr = @"Data Source=DESKTOP-K6RC40R;Initial Catalog=QLQuanCaPhe;Integrated Security=True";
        SqlConnection cn;
        SqlCommand cm;
        public SanPham()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void formsp_load()
        {

        }

        void loadsp()
        {
            DataTable tb = new DataTable();
            cn = new SqlConnection(constr);
            cm.CommandText = "view_sanpham";
            cm.CommandType = CommandType.StoredProcedure;
            
        }
    }
}
