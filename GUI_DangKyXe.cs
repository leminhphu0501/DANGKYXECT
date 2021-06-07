using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_DangKyXeCT;
using DTO_DangKyXeCT;

namespace GUI_DangKyXeCT
{
    public partial class GUI_DangKyXe : Form
    {
        BUS_DangKyXe busDK = new BUS_DangKyXe();
        private DTO_DangKyXe dk;

        public GUI_DangKyXe()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbNguoicb.Text != "" && dtimeBatdau.Text != "" && dtimeKetthuc.Text != "" &&
                txtNoidi.Text != "" && txtNoiden.Text != "" && cbThanhphan.Text != "" && nudSokm.Text != "" && nudSoghe.Text != "" && rtbNoidung.Text != "" 
                && cbChutri.Text != "" && rtbGhichu.Text != "")
            {
                
                DTO_DangKyXe tv = new DTO_DangKyXe(0, cbNguoicb.Text, dtimeBatdau.Text, dtimeKetthuc.Text, txtNoidi.Text, txtNoiden.Text,
                    cbThanhphan.Text, nudSokm.Text, nudSoghe.Text, rtbNoidung.Text, cbChutri.Text, rtbGhichu.Text);

                
                if (busDK.themDangKyXe(dk))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDK.DataSource = busDK.getDangKyXe();
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvDK.SelectedRows.Count > 0)
            {
                if (cbNguoicb.Text != "" && dtimeBatdau.Text != "" && dtimeKetthuc.Text != "" &&
                txtNoidi.Text != "" && txtNoiden.Text != "" && cbThanhphan.Text != "" && nudSokm.Text != "" && nudSoghe.Text != "" && rtbNoidung.Text != ""
                && cbChutri.Text != "" && rtbGhichu.Text != "")
                {
                    
                    DataGridViewRow row = dgvDK.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    
                    DTO_DangKyXe tv = new DTO_DangKyXe(ID, cbNguoicb.Text, dtimeBatdau.Text, dtimeKetthuc.Text, txtNoidi.Text, txtNoiden.Text,
                    cbThanhphan.Text, nudSokm.Text, nudSoghe.Text, rtbNoidung.Text, cbChutri.Text, rtbGhichu.Text); 

                    // Sửa
                    if (busDK.suaDangKyXe(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvDK.DataSource = busDK.getDangKyXe(); 
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvDK.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgvDK.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                if (busDK.xoaDangKyXe(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDK.DataSource = busDK.getDangKyXe(); 
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

    private void GUI_DangKyXe_Load(object sender, EventArgs e)
        {
            dgvDK.DataSource = busDK.getDangKyXe();
        }

        private void dgvDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDK.SelectedRows[0];

            // Chuyển giá trị lên form
           DateTime dtimeBatdau = DateTime.Parse(row.Cells[1].ToString());
           DateTime dtimeKetthuc =DateTime.Parse(row.Cells[2].Value.ToString());
            cbNguoicb.Text = row.Cells[3].Value.ToString();
            txtNoidi.Text = row.Cells[4].Value.ToString();
            txtNoiden.Text = row.Cells[5].Value.ToString();
            cbThanhphan.Text = row.Cells[6].Value.ToString();
            nudSokm.Text = row.Cells[7].Value.ToString();
            nudSoghe.Text = row.Cells[8].Value.ToString();
            rtbNoidung.Text = row.Cells[9].Value.ToString();
            cbChutri.Text = row.Cells[10].Value.ToString();
            rtbGhichu.Text = row.Cells[11].Value.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
