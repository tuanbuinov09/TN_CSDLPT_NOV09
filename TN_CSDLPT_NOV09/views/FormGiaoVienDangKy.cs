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
using TN_CSDLPT_NOV09.model;

namespace TN_CSDLPT_NOV09.views
{
    public partial class FormGiaoVienDangKy : DevExpress.XtraEditors.XtraForm
    {
        ArrayList undoCommands = new ArrayList();
        String mode = "";
        int vitri = -1;

        public FormGiaoVienDangKy()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceGiaoVien_DangKy.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void FormGiaoVienDangKy_Load(object sender, EventArgs e)
        {
            // bỏ các ràng buộc để load dữ liệu lên grid view k bị lỗi
            this.TN_CSDLPT_DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tableAdapterGiaoVien_DangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

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
            //load cacs danh sachs mã vào các combobox
            DataTable dtDSLop = Program.ExecSqlDataTable("EXEC SP_LAY_DS_LOP");
            comboBoxMaLop.DataSource = dtDSLop;
            comboBoxMaLop.DisplayMember = "MALOP";
            comboBoxMaLop.ValueMember = "MALOP";

            DataTable dtDSGiaoVien = Program.ExecSqlDataTable("EXEC SP_LAY_DS_GIAOVIEN");
            comboBoxMaGiaoVien.DataSource = dtDSGiaoVien;
            comboBoxMaGiaoVien.DisplayMember = "MAGV";
            comboBoxMaGiaoVien.ValueMember = "MAGV";

            DataTable dtDSMonHoc = Program.ExecSqlDataTable("EXEC SP_LAY_DS_MONHOC");
            comboBoxMaMonHoc.DataSource = dtDSMonHoc;
            comboBoxMaMonHoc.DisplayMember = "MAMH";
            comboBoxMaMonHoc.ValueMember = "MANH";

            comboBoxTrinhDo.Items.Add("A");
            comboBoxTrinhDo.Items.Add("B");
            comboBoxTrinhDo.Items.Add("C");

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
                // bỏ các ràng buộc để load dữ liệu lên grid view k bị lỗi
                this.TN_CSDLPT_DataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.tableAdapterGiaoVien_DangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }
            // mỗi khi chuyển site, cái combobox mã lớp sẽ bị mất dữ liệu nếu dữ liệu trong combobox phân mảnh ngang
            // mỗi khi chuyển ta lấy lại dữ liệu vào combobox

            DataTable dtDSLop = Program.ExecSqlDataTable("EXEC SP_LAY_DS_LOP");
            comboBoxMaLop.DataSource = dtDSLop;
            comboBoxMaLop.DisplayMember = "MALOP";
            comboBoxMaLop.ValueMember = "MALOP";

            DataTable dtDSGiaoVien = Program.ExecSqlDataTable("EXEC SP_LAY_DS_GIAOVIEN");
            comboBoxMaGiaoVien.DataSource = dtDSGiaoVien;
            comboBoxMaGiaoVien.DisplayMember = "MAGV";
            comboBoxMaGiaoVien.ValueMember = "MAGV";

            DataTable dtDSMonHoc = Program.ExecSqlDataTable("EXEC SP_LAY_DS_MONHOC");
            comboBoxMaMonHoc.DataSource = dtDSMonHoc;
            comboBoxMaMonHoc.DisplayMember = "MAMH";
            comboBoxMaMonHoc.ValueMember = "MANH";

            //combobox trinh do khỏi cần load lại
            //comboBoxTrinhDo.Items.Add("A");
            //comboBoxTrinhDo.Items.Add("B");
            //comboBoxTrinhDo.Items.Add("C");

        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "them";
            vitri = bindingSourceGiaoVien_DangKy.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceGiaoVien_DangKy.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;
            comboBoxMaLop.SelectedIndex = 0;
            // khi đang thêm sửa thì k thể ấn phục hồi, reload
            barButtonPhucHoi.Enabled = false;
            barButtonReload.Enabled = false;

            gridControlGiaoVienDangKy.Enabled = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "sua";
            vitri = bindingSourceGiaoVien_DangKy.Position;
            panelControlNhapLieu.Enabled = true;
            // khi ấn sửa lấy mã lớp, mã môn, mã giáo viên để set trên combobox chưa sửa chọn ở combobox lớp
            String maLop = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MALOP"].ToString().Trim();
            String maGiaoVien = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MAGV"].ToString().Trim();
            String maMonHoc = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MAMH"].ToString().Trim();
            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;

            comboBoxMaLop.SelectedValue = maLop;
            comboBoxMaMonHoc.SelectedValue = maMonHoc;
            comboBoxMaGiaoVien.SelectedValue = maGiaoVien;
            // khi đang thêm sửa thì k thể ấn phục hồi
            barButtonPhucHoi.Enabled = false;
            barButtonReload.Enabled = false;

            //khỏi cho sữa mã nhỉ
            //textBoxMaSinhVien.Enabled = false;
            gridControlGiaoVienDangKy.Enabled = false;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceGiaoVien_DangKy.CancelEdit();
            if (mode == "them")
            {
                //xóa cái dòng được tạo từ bindingSource.addNew khi ấn thêm trên gridview
                gridViewGiaoVienDangKy.DeleteRow(gridViewGiaoVienDangKy.FocusedRowHandle);
            }

            bindingSourceGiaoVien_DangKy.Position = vitri;
            panelControlNhapLieu.Enabled = false;
            gridControlGiaoVienDangKy.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = true;
            barButtonGhi.Enabled = false;
            barButtonReload.Enabled = true;
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

        private void barButtonReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tableAdapterGiaoVien_DangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "xoa";
            String maGiaoVien = "";
            String maMonHoc = "";
            String maLop = "";
            String trinhDo = "";
            String ngayThi = "";
            int lan = -1;
            int soCauThi = -1;
            int thoiGian = -1;


            // sau này có thể có bảng khác khóa ngoại tới bảng này
            //if (bindingSourceChiTietBaiThi.Count > 0)
            //{
            //    MessageBox.Show("Không thể xóa sinh viên này vì đã thi", "", MessageBoxButtons.OK);
            //    return;
            //}

            int xacNhanXoa = (int)MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanXoa == (int)DialogResult.OK)
            {
                try
                {
                    maLop = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MALOP"].ToString().Trim();
                    maGiaoVien = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MAGV"].ToString().Trim();
                    maMonHoc = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MAMH"].ToString().Trim();
                    trinhDo = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["TRINHDO"].ToString().Trim();
                    ngayThi = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["NGAYTHI"].ToString().Trim();
                    lan = int.Parse((String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["LAN"].ToString().Trim());
                    soCauThi = int.Parse((String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["SOCAUTHI"].ToString().Trim());
                    thoiGian = int.Parse((String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["THOIGIAN"].ToString().Trim());

                    bindingSourceGiaoVien_DangKy.RemoveCurrent();
                    this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterGiaoVien_DangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa đăng ký thi thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterGiaoVien_DangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

                    //quay về dòng có 3 dữ liệu bên dưới
                    int index = bindingSourceGiaoVien_DangKy.Find(
                        new Key { PropertyName = "LAN", Value = lan },
                        new Key { PropertyName = "MALOP", Value = maLop },
                        new Key { PropertyName = "MAMH", Value = maMonHoc }
                        );

                    bindingSourceGiaoVien_DangKy.Position = index;
                    return;
                }
            }
            if (bindingSourceGiaoVien_DangKy.Count == 0)
            {
                barButtonXoa.Enabled = false;
            }

            undoCommands.Add("EXEC SP_THEM_GIAOVIEN_DANGKY '" + maGiaoVien + "', '"
                + maMonHoc + "', '" + maLop + "', '" + trinhDo + "', '" + ngayThi + "', " + lan + ", " + soCauThi + ", "+thoiGian+"");

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

        }
    }
}