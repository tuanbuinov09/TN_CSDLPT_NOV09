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
    public partial class FormLop : DevExpress.XtraEditors.XtraForm
    {
        ArrayList undoCommands = new ArrayList();
        String mode = "";
        int vitri = -1;

        public FormLop()
        {
            InitializeComponent();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            // bỏ các ràng buộc để load dữ liệu lên grid view k bị lỗi
            this.TN_CSDLPT_DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.LOP' table. You can move, or remove it, as needed.
            this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLop.Fill(this.TN_CSDLPT_DataSet.LOP);

            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
            this.tableAdapterGiaoVien_DangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSinhVien.Fill(this.TN_CSDLPT_DataSet.SINHVIEN);

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
            else// mGroup=="COSO" chỉ có quyền cơ sở mới có quyền thao tác thêm xóa sửa lopws
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

            barButtonGhi.Enabled = false;
            panelControlNhapLieu.Enabled = false;

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

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
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.LOP' table. You can move, or remove it, as needed.
                this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                this.tableAdapterLop.Fill(this.TN_CSDLPT_DataSet.LOP);

                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
                this.tableAdapterGiaoVien_DangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.SINHVIEN' table. You can move, or remove it, as needed.
                this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
                this.tableAdapterSinhVien.Fill(this.TN_CSDLPT_DataSet.SINHVIEN);

                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "them";
            vitri = bindingSourceLop.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceLop.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;

            // khi đang thêm sửa thì k thể ấn phục hồi
            barButtonPhucHoi.Enabled = false;
            // khi thêm cho nhập mã khoa, khi sửa không cho sửa mã khoa
            textBoxMaLop.Enabled = true;
            gridControlLop.Enabled = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "sua";
            vitri = bindingSourceLop.Position;
            panelControlNhapLieu.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;

            // khi đang thêm sửa thì k thể ấn phục hồi
            barButtonPhucHoi.Enabled = false;
            barButtonHuy.Enabled = true;

            gridControlLop.Enabled = false;
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "xoa";
            String maLop = "";
            String tenLop = "";
            String maKhoa = "";
            if (bindingSourceSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã chứa sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (bindingSourceGiaoVien_DangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã đăng ký thi", "", MessageBoxButtons.OK);
                return;
            }

            int xacNhanXoa = (int)MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanXoa == (int)DialogResult.OK)
            {
                try
                {
                    maLop = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["MALOP"].ToString();
                    //lấy thông tin lớp để undo redo
                    tenLop = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["TENLOP"].ToString();
                    maKhoa = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["MAKH"].ToString();
                    bindingSourceLop.RemoveCurrent();
                    this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterLop.Update(this.TN_CSDLPT_DataSet.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa môn học thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterLop.Update(this.TN_CSDLPT_DataSet.LOP);
                    bindingSourceLop.Position = bindingSourceLop.Find("MAKH", maKhoa);
                    return;
                }
            }
            if (bindingSourceLop.Count == 0)
            {
                barButtonXoa.Enabled = false;
            }
            undoCommands.Add("EXEC SP_THEM_LOP '" + maLop + "', N'" + tenLop + "', '" + maKhoa + "'");

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
    }
}