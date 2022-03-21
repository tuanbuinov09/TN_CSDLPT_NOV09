using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace TN_CSDLPT_NOV09.views
{
    public partial class FormKhoa : DevExpress.XtraEditors.XtraForm
    {
        ArrayList undoCommands = new ArrayList();
        String mode = "";
        int vitri = -1;
        String maCoSo;

        public FormKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void kHOABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            // bỏ các ràng buộc để load dữ liệu lên grid view k bị lỗi
            this.TN_CSDLPT_DataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.KHOA' table. You can move, or remove it, as needed.
            this.tableAdapterKhoa.Connection.ConnectionString = Program.connstr;
            this.tableAdapterKhoa.Fill(this.TN_CSDLPT_DataSet.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.LOP' table. You can move, or remove it, as needed.
            this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLop.Fill(this.TN_CSDLPT_DataSet.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.tableAdapterGiaoVien.Connection.ConnectionString = Program.connstr;
            this.tableAdapterGiaoVien.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);

            comboBoxCoSo.DataSource = Program.bds_DanhSachPhanManh;
            comboBoxCoSo.DisplayMember = "TENCS";
            comboBoxCoSo.ValueMember = "TENSERVER";
            comboBoxCoSo.SelectedIndex = Program.indexCoSo;

            if (Program.mGroup == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
            }
            else
            {
                comboBoxCoSo.Enabled = false;

            }

            if (Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN" || Program.mGroup == "SINHVIEN")
            {

                barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                    = barButtonGhi.Enabled = barButtonPhucHoi.Enabled = barButtonHuy.Enabled = false;

            }
            else// mGroup=="COSO" chỉ có quyền cơ sở mới có quyền thao tác thêm xóa sửa khoa
            {

                barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                     = true;

                if (undoCommands.Count > 0)
                {
                    barButtonPhucHoi.Enabled = true;
                }
                else
                {
                    barButtonPhucHoi.Enabled = false;
                }

                barButtonHuy.Enabled = false;
            }

            textBoxMaCoSo.Text = Program.maCoSo;
            // đăng nhập ở đâu thì mã cơ sở mặc định ở đấy, nên ta khỏi cần enable nó để nhập liệu làm gì
            textBoxMaCoSo.Enabled = false;
            barButtonGhi.Enabled = false;

            panelControlNhapLieu.Enabled = false;
        }

        private void comboBoxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }

            Program.servername = comboBoxCoSo.SelectedValue.ToString();
            if (comboBoxCoSo.SelectedIndex != Program.indexCoSo)
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
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.KHOA' table. You can move, or remove it, as needed.
                this.tableAdapterKhoa.Connection.ConnectionString = Program.connstr;
                this.tableAdapterKhoa.Fill(this.TN_CSDLPT_DataSet.KHOA);
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.LOP' table. You can move, or remove it, as needed.
                this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                this.tableAdapterLop.Fill(this.TN_CSDLPT_DataSet.LOP);
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
                this.tableAdapterGiaoVien.Connection.ConnectionString = Program.connstr;
                this.tableAdapterGiaoVien.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);

                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }
        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barButtonReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tableAdapterKhoa.Fill(this.TN_CSDLPT_DataSet.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceKhoa.CancelEdit();
            bindingSourceKhoa.Position = vitri;
            panelControlNhapLieu.Enabled = false;
            gridControlKhoa.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = true;
            barButtonGhi.Enabled = false;
            if (undoCommands.Count > 0)
            {
                barButtonPhucHoi.Enabled = true;
            }
            else
            {
                barButtonPhucHoi.Enabled = false;
            }
            barButtonHuy.Enabled = false;
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "them";
            vitri = bindingSourceKhoa.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceKhoa.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;

            // khi đang thêm sửa thì k thể ấn phục hồi
            barButtonPhucHoi.Enabled = false;
            // khi thêm cho nhập mã khoa, khi sửa không cho sửa mã khoa
            textBoxMaKhoa.Enabled = true;
            gridControlKhoa.Enabled = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "sua";
            vitri = bindingSourceKhoa.Position;
            panelControlNhapLieu.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;

            // khi đang thêm sửa thì k thể ấn phục hồi
            barButtonPhucHoi.Enabled = false;

            barButtonHuy.Enabled = true;

            // khi thêm cho nhập mã khoa, khi sửa không cho sửa mã khoa
            textBoxMaKhoa.Enabled = false;
            gridControlKhoa.Enabled = false;
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "xoa";
            String maKhoa = "";
            String tenKhoa = "";
            if (bindingSourceGiaoVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã chứa giáo viên", "", MessageBoxButtons.OK);
                return;
            }
            if (bindingSourceLop.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã chứa lớp", "", MessageBoxButtons.OK);
                return;
            }
            
            int xacNhanXoa = (int)MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanXoa == (int)DialogResult.OK)
            {
                try
                {
                    maKhoa = (String)((DataRowView)bindingSourceKhoa[bindingSourceKhoa.Position])["MAKH"].ToString();
                    //lấy thông tin khoa để undo redo
                    tenKhoa = (String)((DataRowView)bindingSourceKhoa[bindingSourceKhoa.Position])["TENKH"].ToString();

                    bindingSourceKhoa.RemoveCurrent();
                    this.tableAdapterKhoa.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterKhoa.Update(this.TN_CSDLPT_DataSet.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa môn học thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterKhoa.Update(this.TN_CSDLPT_DataSet.KHOA);
                    bindingSourceKhoa.Position = bindingSourceKhoa.Find("MAKH", maKhoa);
                    return;
                }
            }
            if (bindingSourceKhoa.Count == 0)
            {
                barButtonXoa.Enabled = false;
            }
            undoCommands.Add("EXEC SP_THEM_KHOA '" + maKhoa + "','" + tenKhoa + "', '"+Program.maCoSo+"'");

            mode = "";
            if (undoCommands.Count > 0)
            {
                barButtonPhucHoi.Enabled = true;
            }
            else
            {
                barButtonPhucHoi.Enabled = false;
            }
        }

        private void barButtonGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maKhoa = textBoxMaKhoa.Text.Trim();
            String tenKhoaLucChuaSua = (String)((DataRowView)bindingSourceKhoa[bindingSourceKhoa.Position])["TENKH"].ToString();
            String tenKhoaChuanBiSua = textBoxTenKhoa.Text.Trim();
            if (maKhoa == "")
            {
                MessageBox.Show("Mã khoa không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxMaKhoa.Focus();
                return;
            }
            // lưu ý tenKhoaChuanBiSua cũng là chuẩn bị thêm
            if (tenKhoaChuanBiSua == "")
            {
                MessageBox.Show("Tên khoa không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxTenKhoa.Focus();
                return;
            }

            //check trùng mã môn học khi thêm
            if (mode == "them")
            {
                String strLenh = "EXEC SP_KT_KHOA_DATONTAI '" + maKhoa + "', '" + tenKhoaChuanBiSua + "'";

                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1)
                {
                    textBoxMaKhoa.Focus();
                    return;
                }
                if (kq == 2)
                {
                    textBoxTenKhoa.Focus();
                    return;
                }
            }

            try
            {
                bindingSourceKhoa.EndEdit();
                bindingSourceKhoa.ResetCurrentItem();
                this.tableAdapterKhoa.Connection.ConnectionString = Program.connstr;
                this.tableAdapterKhoa.Update(this.TN_CSDLPT_DataSet.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterKhoa.Update(this.TN_CSDLPT_DataSet.KHOA);
                return;
            }

            // nếu là thêm thì khi undo (xóa nó đi) thì lấy mã của nó trên bảng để sau quay trở về
            if (mode == "them")
            {
                undoCommands.Add("EXEC SP_XOA_KHOA '" + maKhoa + "'");
            }
            if (mode == "sua")
            {
                undoCommands.Add("EXEC SP_SUA_KHOA '" + maKhoa + "','" + tenKhoaLucChuaSua + "'");
            }

            mode = "";

            panelControlNhapLieu.Enabled = false;
            gridControlKhoa.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = true;
            barButtonGhi.Enabled = false;
            if (undoCommands.Count > 0)
            {
                barButtonPhucHoi.Enabled = true;
            }
            else
            {
                barButtonPhucHoi.Enabled = false;
            }
            barButtonHuy.Enabled = false;
        }
    }
}