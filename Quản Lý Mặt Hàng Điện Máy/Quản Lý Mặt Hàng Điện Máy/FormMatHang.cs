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

namespace Quản_Lý_Mặt_Hàng_Điện_Máy
{
    public partial class FormMatHang : Form
    {
        public FormMatHang()
        {
            InitializeComponent();
        }
        string ChuoiKetNoi = @"Data Source=(local);Initial Catalog=QuanLyMatHangDienMay;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader DocDuLieu;


        private void FormMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyMatHangDienMayDataSet.Hang' table. You can move, or remove it, as needed.
            this.hangTableAdapter.Fill(this.quanLyMatHangDienMayDataSet.Hang);
            KetNoi = new SqlConnection(ChuoiKetNoi);
            comboBoxHangSX.Text = "";
            contextMenuStripXoa.Enabled = false;
        }

        private void comboBoxHangSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            contextMenuStripXoa.Enabled = false;
            comboBoxLoai.Items.Clear();
            listView.Items.Clear();
            comboBoxLoai.Text = "";
            Lenh = @"SELECT       Loai.TenLoai, Hang.TenHangSx
                     FROM            Loai INNER JOIN
                                                 Hang ON Loai.MaHangSx = Hang.MaHangSx
                     WHERE        (Hang.TenHangSx = N'"+comboBoxHangSX.Text+"')";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            KetNoi.Open();
            DocDuLieu = ThucHien.ExecuteReader();
            while(DocDuLieu.Read())
            {
                comboBoxLoai.Items.Add(DocDuLieu[0].ToString());
            }
            KetNoi.Close();
        }

        private void comboBoxLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hien();
        }
        void Hien()
        {
            contextMenuStripXoa.Enabled = false;
            listView.Items.Clear();
            Lenh = @"SELECT       MatHang.TenHangHoa, Loai.TenLoai, Hang.TenHangSx
                    FROM            MatHang INNER JOIN
                                             Loai ON MatHang.MaLoai = Loai.MaLoai INNER JOIN
                                             Hang ON Loai.MaHangSx = Hang.MaHangSx
                    WHERE        (Loai.TenLoai = N'" + comboBoxLoai.Text + "') AND (Hang.TenHangSx = N'" + comboBoxHangSX.Text + "')";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            KetNoi.Open();
            int i = 0;
            DocDuLieu = ThucHien.ExecuteReader();
            while (DocDuLieu.Read())
            {
                listView.Items.Add((i + 1).ToString());
                listView.Items[i].SubItems.Add(DocDuLieu[0].ToString());
                i++;
            }
            KetNoi.Close();
        }
        private void listView_Click(object sender, EventArgs e)
        {
            contextMenuStripXoa.Enabled = true;
        }

        private void xóaMặtHàngĐãChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn xóa không?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                Lenh = @"DELETE FROM MatHang
                     WHERE        (TenHangHoa = N'" + listView.SelectedItems[0].SubItems[1].Text + "')";
                ThucHien = new SqlCommand(Lenh, KetNoi);
                KetNoi.Open();
                ThucHien.ExecuteNonQuery();
                KetNoi.Close();
            }
            Hien();
        }
    }
}
