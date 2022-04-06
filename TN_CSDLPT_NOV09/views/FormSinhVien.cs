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
    public partial class FormSinhVien : DevExpress.XtraEditors.XtraForm
    {
        ArrayList undoCommands = new ArrayList();
        String mode = "";
        int vitri = -1;

        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            // bỏ các ràng buộc để load dữ liệu lên grid view k bị lỗi
            this.TN_CSDLPT_DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSinhVien.Fill(this.TN_CSDLPT_DataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tableAdapterBangDiem.Connection.ConnectionString = Program.connstr;
            this.tableAdapterBangDiem.Fill(this.TN_CSDLPT_DataSet.BANGDIEM);

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
                // nếu trong dữ liệu k có dòng nào disable nút thêm xóa
                if (bindingSourceSinhVien.Count == 0)
                {
                    barButtonSua.Enabled = barButtonXoa.Enabled = false;
                }
                barButtonHuy.Enabled = false;
            }

            //load danh sách lớp vào comboBox
            DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_DS_LOP");
            comboBoxMaLop.DataSource = dt;
            comboBoxMaLop.DisplayMember = "MALOP";
            comboBoxMaLop.ValueMember = "MALOP";

            barButtonGhi.Enabled = false;
            panelControlNhapLieu.Enabled = false;

        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceSinhVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "them";
            vitri = bindingSourceSinhVien.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceSinhVien.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;
            comboBoxMaLop.SelectedIndex = 0;
            // khi đang thêm sửa thì k thể ấn phục hồi, reload
            barButtonPhucHoi.Enabled = false;
            barButtonReload.Enabled = false;
            // khi thêm cho nhập mã sinh viene, khi sửa không cho sửa mã 
            textBoxMaSinhVien.Enabled = true;
            gridControlSinhVien.Enabled = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "sua";
            vitri = bindingSourceSinhVien.Position;
            panelControlNhapLieu.Enabled = true;
            // khi ấn sửa lấy mã lopws chưa sửa chọn ở combobox lớp
            String maLop = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MALOP"].ToString().Trim();
            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;

            comboBoxMaLop.SelectedValue = maLop;
            // khi đang thêm sửa thì k thể ấn phục hồi
            barButtonPhucHoi.Enabled = false;
            barButtonReload.Enabled = false;
            // không cho sửa mã sinh viene
            textBoxMaSinhVien.Enabled = false;
            gridControlSinhVien.Enabled = false;
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "xoa";
            String maSinhVien = "";
            String ho = "";
            String ten = "";
            String ngaySinh = "";
            String diaChi = "";
            String matKhau = "";
            String maLop = "";
            if (bindingSourceBangDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có điểm", "", MessageBoxButtons.OK);
                return;
            }
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
                    maSinhVien = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MASV"].ToString().Trim();
                    //lấy thông tin lớp để undo redo
                    ho = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["HO"].ToString().Trim();
                    ten = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["TEN"].ToString().Trim();
                    ngaySinh = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["NGAYSINH"].ToString().Trim();
                    diaChi = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["DIACHI"].ToString().Trim();
                    matKhau = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MATKHAU"].ToString().Trim();
                    maLop = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MALOP"].ToString().Trim();
                    bindingSourceSinhVien.RemoveCurrent();
                    this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterSinhVien.Update(this.TN_CSDLPT_DataSet.SINHVIEN);
                    undoCommands.Add("EXEC SP_THEM_SINHVIEN '" + maSinhVien + "', N'"
                    + ho + "', N'" + ten + "', '" + ngaySinh + "', N'" + diaChi + "', '" + matKhau + "', '" + maLop + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa sinh viên thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterSinhVien.Update(this.TN_CSDLPT_DataSet.SINHVIEN);
                    bindingSourceSinhVien.Position = bindingSourceSinhVien.Find("MASV", maSinhVien);
                    return;
                }
            }
            if (bindingSourceSinhVien.Count == 0)
            {
                barButtonXoa.Enabled = false;
            }
            
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
            String hoChuaSua = "";
            String tenChuaSua = "";
            String ngaySinhChuaSua = "";
            //format thành định dạng date của sql để undo sửa
            DateTime myDateTime = new DateTime();
            String ngaySinhChuaSuaSQLFormat = "";

            String diaChiChuaSua = "";
            String matKhauChuaSua = "";
            String maLopChuaSua = "";

            if (mode == "sua")
            {
                hoChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["HO"].ToString().Trim();
                tenChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["TEN"].ToString().Trim();
                ngaySinhChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["NGAYSINH"].ToString().Trim();
                //format thành định dạng date của sql để undo sửa
                myDateTime = DateTime.Parse(ngaySinhChuaSua);
                ngaySinhChuaSuaSQLFormat = myDateTime.ToString("yyyy-MM-dd");

                diaChiChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["DIACHI"].ToString().Trim();
                matKhauChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MATKHAU"].ToString().Trim();
                maLopChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MALOP"].ToString().Trim();

            }
            //String maSinhVien = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MASV"].ToString().Trim();
            String maSinhVien = textBoxMaSinhVien.Text.Trim();

            //lấy thông tin sinh viên để undo redo
            //String hoChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["HO"].ToString().Trim();
            String hoChuanBiSua = textBoxHo.Text.Trim();

            //String tenChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["TEN"].ToString().Trim();
            String tenChuanBiSua = textBoxTen.Text.Trim();

            //String ngaySinhChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["NGAYSINH"].ToString().Trim();
            String ngaySinhChuanBiSua = dateEditNgaySinh.Text.Trim();

            //format thành định dạng date của sql để undo sửa
            //DateTime myDateTime = DateTime.Parse(ngaySinhChuaSua);
            //String ngaySinhChuaSuaSQLFormat = myDateTime.ToString("yyyy-MM-dd");

            //String diaChiChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["DIACHI"].ToString().Trim();
            String diaChiChuanBiSua = textBoxDiaChi.Text.Trim();

            //String matKhauChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MATKHAU"].ToString().Trim();
            String matKhauChuanBiSua = textBoxMatKhau.Text.Trim();

            //String maLopChuaSua = (String)((DataRowView)bindingSourceSinhVien[bindingSourceSinhVien.Position])["MALOP"].ToString().Trim();
            String maLopChuanBiSua = comboBoxMaLop.Text.Trim();

            if (maSinhVien == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxMaSinhVien.Focus();
                return;
            }
            // lưu ý chuẩn bị sửa cũng là chuẩn bị thêm
            if (hoChuanBiSua == "")
            {
                MessageBox.Show("Họ sinh viên không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxHo.Focus();
                return;
            }
            if (tenChuanBiSua == "")
            {
                MessageBox.Show("Tên sinh viên không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxTen.Focus();
                return;
            }
            if (diaChiChuanBiSua == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxDiaChi.Focus();
                return;
            }
            if (maLopChuanBiSua == "")
            {
                MessageBox.Show("Mã lớp không được bỏ trống", "", MessageBoxButtons.OK);
                comboBoxMaLop.Focus();
                return;
            }

            //check trùng mã, tên lớp khi thêm
            if (mode == "them")
            {
                String strLenh = "EXEC SP_KT_SINHVIEN_DATONTAI '" + maSinhVien+"'";

                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1) //
                {
                    //tự raiserror, ta chỉ cần focus về field nhập
                    textBoxMaSinhVien.Focus();
                    return;
                }
                //vì ngoài mã thông tin của sinh viên hoàn toàn có thể giống nhau

                //if (kq == 2)
                //{
                //    textBoxTenLop.Focus();
                //    return;
                //}
            }
            
            if (mode == "sua")
            {
                // vì mã sinh viên k cho sửa, nên cũng k cần kiểm tra sinh viên tồn tại chưa
                //String strLenh = "EXEC SP_KT_SINHVIEN_DATONTAI '" + maSinhVien;

                //int kq = Program.ExecSqlNonQuery(strLenh);
                ////if (kq == 1) //
                ////{
                ////    //tự raiserror, ta chỉ cần focus về field nhập
                ////    textBoxMaKhoa.Focus();
                ////    return;
                ////}
                //if (kq == 2)
                //{
                //    //tên khoa trùng khoa khác
                //    textBoxTenLop.Focus();
                //    return;
                //}
            }
            try
            {
                bindingSourceSinhVien.EndEdit();
                bindingSourceSinhVien.ResetCurrentItem();
                this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
                this.tableAdapterSinhVien.Update(this.TN_CSDLPT_DataSet.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterSinhVien.Update(this.TN_CSDLPT_DataSet.SINHVIEN);
                return;
            }

            // nếu là thêm thì khi undo (xóa nó đi) thì lấy mã của nó trên bảng để sau quay trở về
            if (mode == "them")
            {
                undoCommands.Add("EXEC SP_XOA_SINHVIEN '" + maSinhVien + "'");
            }
            if (mode == "sua")
            {
                undoCommands.Add("EXEC SP_SUA_SINHVIEN '" + maSinhVien + "', N'"  + hoChuaSua 
                    + "', N'" + tenChuaSua + "', '" + ngaySinhChuaSuaSQLFormat + "', N'" + diaChiChuaSua + "', '" + matKhauChuaSua + "', '" + maLopChuaSua + "'");
            }

            mode = "";

            panelControlNhapLieu.Enabled = false;
            gridControlSinhVien.Enabled = true;

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
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.SINHVIEN' table. You can move, or remove it, as needed.
                this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
                this.tableAdapterSinhVien.Fill(this.TN_CSDLPT_DataSet.SINHVIEN);
                // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.BANGDIEM' table. You can move, or remove it, as needed.
                this.tableAdapterBangDiem.Connection.ConnectionString = Program.connstr;
                this.tableAdapterBangDiem.Fill(this.TN_CSDLPT_DataSet.BANGDIEM);

                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }
            // mỗi khi chuyển site, cái combobox mã lớp sẽ bị mất dữ liệu
            // mỗi khi chuyển ta lấy lại dữ liệu vào combobox
            DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_DS_LOP");
            comboBoxMaLop.DataSource = dt;
            comboBoxMaLop.DisplayMember = "MALOP";
            comboBoxMaLop.ValueMember = "MALOP";
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == "them")
            {
                //xóa cái dòng được tạo từ bindingSource.addNew khi ấn thêm trên gridview
                gridViewSinhVien.DeleteRow(gridViewSinhVien.FocusedRowHandle);
            }
            bindingSourceSinhVien.CancelEdit();
            
           
            bindingSourceSinhVien.Position = vitri;
            panelControlNhapLieu.Enabled = false;
            gridControlSinhVien.Enabled = true;

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
                tableAdapterSinhVien.Fill(this.TN_CSDLPT_DataSet.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barButtonPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strLenh = (String)undoCommands[undoCommands.Count - 1];

            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể phục hồi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterSinhVien.Update(this.TN_CSDLPT_DataSet.SINHVIEN);
                Program.myReader.Close();
                Program.conn.Close();
                return;
            }

            // lấy ra mã sinh viên bị ảnh hưởng khi undo 
            String affected_id = "";
            try
            {
                //lay AFFECTED_ID tu sp
                affected_id = Program.myReader.GetString(0).Trim();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Không lấy được mã môn bị ảnh hưởng\n" + ex.Message, "", MessageBoxButtons.OK);
                //this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                //return;
            }

            Program.myReader.Close();
            Program.conn.Close();

            //hiển thị lại bảng
            try
            {
                this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
                //this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                this.tableAdapterSinhVien.Fill(this.TN_CSDLPT_DataSet.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }

            // chuyển dòng được chọn trên gridview thành dòng có mã bị ảnh hưởng (affected_id)
            if (affected_id != "" || affected_id != null)
            {
                bindingSourceSinhVien.Position = bindingSourceSinhVien.Find("MASV", affected_id);
            }


            //loại bỏ lệnh vừa undo ở cuối undoCommands
            undoCommands.RemoveAt(undoCommands.Count - 1);

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