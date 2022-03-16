using System;
using System.Data;
using System.Windows.Forms;

namespace TN_CSDLPT_NOV09.views
{
    public partial class FormMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        int vitri = -1;
        String maCoSo;

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            TN_CSDLPT_DataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);
            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tableAdapterBangDiem.Connection.ConnectionString = Program.connstr;
            this.tableAdapterBangDiem.Fill(this.TN_CSDLPT_DataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.BODE' table. You can move, or remove it, as needed.
            this.tableAdapterBoDe.Connection.ConnectionString = Program.connstr;
            this.tableAdapterBoDe.Fill(this.TN_CSDLPT_DataSet.BODE);
            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tableAdapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
            this.tableAdapterGiaoVienDangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

            comboBoxCoSo.DataSource = Program.bds_DanhSachPhanManh;
            comboBoxCoSo.DisplayMember = "TENCS";
            comboBoxCoSo.ValueMember = "TENSERVER";
            comboBoxCoSo.SelectedIndex = Program.mCoSo;

            if (Program.mGroup == "TRUONG"||Program.mGroup=="GIANGVIEN")
            {
                comboBoxCoSo.Enabled = true;

                barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                    = barButtonGhi.Enabled = barButtonPhucHoi.Enabled = barButtonHuy.Enabled = false;

            }
            else
            {
                comboBoxCoSo.Enabled = false;

                barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                     = barButtonGhi.Enabled = barButtonPhucHoi.Enabled = true;
                barButtonHuy.Enabled = false;
            }
            panelControlNhapLieu.Enabled = false;

        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bindingSourceMonHoc.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceMonHoc.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = barButtonPhucHoi.Enabled = true;
            barButtonHuy.Enabled = true;
            monHocGridControl.Enabled = false;
        }
        
        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bindingSourceMonHoc.Position;
            panelControlNhapLieu.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = barButtonPhucHoi.Enabled = true;
            barButtonHuy.Enabled = true;
            monHocGridControl.Enabled = false;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceMonHoc.CancelEdit();
            bindingSourceMonHoc.Position = vitri;
            panelControlNhapLieu.Enabled = false;
            monHocGridControl.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = true;
            barButtonGhi.Enabled = false;
            barButtonPhucHoi.Enabled = true;
            barButtonHuy.Enabled = false;
        }

        private void barButtonReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
                tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
            
        }

        private void comboBoxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.servername = comboBoxCoSo.SelectedValue.ToString();
            if (comboBoxCoSo.SelectedIndex != Program.mCoSo)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở " + comboBoxCoSo.Text, "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                TN_CSDLPT_DataSet.EnforceConstraints = false;

                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
                this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);
                // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.BANGDIEM' table. You can move, or remove it, as needed.
                this.tableAdapterBangDiem.Connection.ConnectionString = Program.connstr;
                this.tableAdapterBangDiem.Fill(this.TN_CSDLPT_DataSet.BANGDIEM);
                // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.BODE' table. You can move, or remove it, as needed.
                this.tableAdapterBoDe.Connection.ConnectionString = Program.connstr;
                this.tableAdapterBoDe.Fill(this.TN_CSDLPT_DataSet.BODE);
                // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.tableAdapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
                this.tableAdapterGiaoVienDangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }


        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMonHoc = "";
            if (bindingSourceBangDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn này vì đã có bảng điểm", "", MessageBoxButtons.OK);
                return;
            }
            if (bindingSourceBoDe.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn này vì đã có bộ đề", "", MessageBoxButtons.OK);
                return;
            }
            if (bindingSourceGiaoVienDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn này vì đã có giáo viên đăng ký", "", MessageBoxButtons.OK);
                return;
            }
            
            int xacNhanXoa = (int) MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if(xacNhanXoa == (int)DialogResult.OK)
            {
                try
                {
                    maMonHoc = (String)((DataRowView)bindingSourceMonHoc[bindingSourceMonHoc.Position])["MAMH"].ToString();

                    bindingSourceMonHoc.RemoveCurrent();
                    this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);

                }catch(Exception ex)
                {
                    MessageBox.Show("Xóa môn học thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                    bindingSourceMonHoc.Position = bindingSourceMonHoc.Find("MAMH", maMonHoc);
                    return;
                }
            }
            if(bindingSourceMonHoc.Count == 0)
            {
                barButtonXoa.Enabled = false;
            }
        }

        private void barButtonGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBoxMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxMaMonHoc.Focus();
                return;
            }
            if (textBoxTenMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxMaMonHoc.Focus();
                return;
            }

            //check trùng mã

            try
            {
                bindingSourceMonHoc.EndEdit();
                bindingSourceMonHoc.ResetCurrentItem();
                this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi môn học, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                return;
            }

            panelControlNhapLieu.Enabled = false;
            monHocGridControl.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = true;
            barButtonGhi.Enabled = false;
            barButtonPhucHoi.Enabled = true;
            barButtonHuy.Enabled = false;
        }
    }
}