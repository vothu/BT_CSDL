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
using System.Configuration;

namespace QLQuanCF
{
    public partial class Dangnhap : Form
    {
        string cnstr = @"Data Source=DESKTOP-K6RC40R;Initial Catalog=QLQuanCaPhe;Integrated Security=True";
        SqlConnection cn;
        SqlCommand cm;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnstr);

        }

        private void btndn_Click(object sender, EventArgs e)
        {
            try {


                cn = new SqlConnection(cnstr);
                cn.Open();
                string sql = "select count(*) from NhanVien where TaiKhoan = @tk and MatKhau = @mk";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.Add(new SqlParameter("@tk", txtID.Text));
                cm.Parameters.Add(new SqlParameter("@mk", txtPass.Text));
                int x = (int)cm.ExecuteScalar();
                if (x == 1)
                {

                    Form ht = new QuanLyQuanCF();
                    ht.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
