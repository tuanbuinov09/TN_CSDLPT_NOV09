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
    public partial class FormGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        ArrayList undoCommands = new ArrayList();
        String mode = "";
        int vitri;
        public FormGiaoVien()
        {
            InitializeComponent();
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {

            TN_CSDLPT_DataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.KHOA' table. You can move, or remove it, as needed.
            this.tableAdapterKhoa.Connection.ConnectionString = Program.connstr;
            this.tableAdapterKhoa.Fill(this.TN_CSDLPT_DataSet.KHOA);

            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.tableAdapterGiaoVien.Connection.ConnectionString = Program.connstr;
            this.tableAdapterGiaoVien.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.BODE' table. You can move, or remove it, as needed.
            this.tableAdapterBoDe.Connection.ConnectionString = Program.connstr;
            this.tableAdapterBoDe.Fill(this.TN_CSDLPT_DataSet.BODE);
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
            this.tableAdapterGiaoVien_DangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

            comboBoxCoSo.DataSource = Program.bds_DanhSachPhanManh;
            comboBoxCoSo.DisplayMember = "TENCS";
            comboBoxCoSo.ValueMember = "TENSERVER";
            //chọn sẵn cơ sở khi đăng nhập
            comboBoxCoSo.SelectedIndex = Program.indexCoSo;

            if (Program.mGroup == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
            }
            else
            {
                comboBoxCoSo.Enabled = false;
            }

            if (Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN"||Program.mGroup == "SINHVIEN")
            {

                barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                    = barButtonGhi.Enabled = barButtonPhucHoi.Enabled = barButtonHuy.Enabled = false;

            }
            else
            {
                barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                     = barButtonGhi.Enabled = true;

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
            panelControlNhapLieu.Enabled = false;

        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceGiaoVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "them";
            vitri = bindingSourceGiaoVien.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceGiaoVien.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;

            comboBoxMaKhoa.Enabled = true;

            comboBoxMaKhoa.DataSource = bindingSourceKhoa;
            comboBoxMaKhoa.DisplayMember = "MAKH";
            comboBoxMaKhoa.ValueMember = "MAKH";
            comboBoxMaKhoa.SelectedIndex = 0;

            barButtonPhucHoi.Enabled = false;

            // khi đang thêm sửa thì k thể ấn phục hồi
            //if (undoCommands.Count > 0)
            //{
            //    barButtonPhucHoi.Enabled = true;
            //}
            //else
            //{
            //    barButtonPhucHoi.Enabled = false;
            //}
            textBoxMaGiaoVien.Enabled = true;
            gridControlGiaoVien.Enabled = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "sua";
            vitri = bindingSourceGiaoVien.Position;
            panelControlNhapLieu.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;

            //disable combobox chọn khoa, 
            //vì sửa = sp_sua_giaovien_ignore_fk, ta hoàn toàn có thể sửa mã khoa không có tại site hiện tại
            //nhưng v khá vô lý

            comboBoxMaKhoa.Enabled = false;

            barButtonPhucHoi.Enabled = false;

            // khi đang thêm sửa thì k thể ấn phục hồi
            //if (undoCommands.Count > 0)
            //{
            //    barButtonPhucHoi.Enabled = true;
            //}
            //else
            //{
            //    barButtonPhucHoi.Enabled = false;
            //}

            barButtonHuy.Enabled = true;

            textBoxMaGiaoVien.Enabled = false;
            gridControlGiaoVien.Enabled = false;
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "xoa";
            String maGiaoVien = "";
            String ho = "";
            String ten = "";
            String diaChi = "";
            String maKhoa = "";
            if (bindingSourceBoDe.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên đã tạo đề", "", MessageBoxButtons.OK);
                return;
            }
            if (bindingSourceGiaoVien_DangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên đã đăng kí thi", "", MessageBoxButtons.OK);
                return;
            }
         

            int xacNhanXoa = (int)MessageBox.Show("Bạn có chắc muốn xóa giáo viên này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanXoa == (int)DialogResult.OK)
            {
                try
                {
                    maGiaoVien = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["MAGV"].ToString();
                    //lấy thông tin giáo viên để undo redo
                    ho = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["HO"].ToString();
                    ten = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["TEN"].ToString();
                    diaChi = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["DIACHI"].ToString();
                    maKhoa = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["MAKH"].ToString();
                    bindingSourceGiaoVien.RemoveCurrent();
                    this.tableAdapterGiaoVien.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterGiaoVien.Update(this.TN_CSDLPT_DataSet.GIAOVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa giáo viên thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterGiaoVien.Update(this.TN_CSDLPT_DataSet.GIAOVIEN);
                    bindingSourceGiaoVien.Position = bindingSourceGiaoVien.Find("MAGV", maGiaoVien);
                    return;
                }
            }
            if (bindingSourceGiaoVien.Count == 0)
            {
                barButtonXoa.Enabled = false;
            }

            undoCommands.Add("EXEC SP_THEM_GIAOVIEN '" + maGiaoVien + "', N'" + ho + "'" 
                + ", N'" + ten + "'" + ", N'" + diaChi + "'" + ", '" + maKhoa + "'");

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

        private void tENLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void barButtonGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGiaoVien = textBoxMaGiaoVien.Text.Trim();
            String hoLucChuaSua = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["HO"].ToString();
            String hoChuanBiSua = textBoxHo.Text.Trim();
            String tenLucChuaSua = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["TEN"].ToString();
            String tenChuanBiSua = textBoxTen.Text.Trim();
            String diaChiLucChuaSua = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["DIACHI"].ToString();
            String diaChiChuanBiSua = textBoxDiaChi.Text.Trim();
            String maKhoaLucChuaSua = (String)((DataRowView)bindingSourceGiaoVien[bindingSourceGiaoVien.Position])["MAKH"].ToString();
            String maKhoaChuanBiSua = comboBoxMaKhoa.Text.Trim();
            if (maGiaoVien == "")
            {
                MessageBox.Show("Mã giáo viên không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxMaGiaoVien.Focus();
                return;
            }
            // lưu ý tenChuanBiSua cũng là chuẩn bị thêm
            if (hoChuanBiSua == "")
            {
                MessageBox.Show("Họ giáo viên không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxHo.Focus();
                return;
            }
            if (tenChuanBiSua == "")
            {
                MessageBox.Show("Tên giáo viên không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxTen.Focus();
                return;
            }
            if (diaChiChuanBiSua == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxDiaChi.Focus();
                return;
            }

            //check trùng mã giáo viên khi thêm
            if (mode == "them")
            {
                String strLenh = "EXEC SP_KT_GIAOVIEN_DATONTAI '" + maGiaoVien + "'";

                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1)
                {
                    textBoxMaGiaoVien.Focus();
                    return;
                }
            }

            try
            {
                bindingSourceGiaoVien.EndEdit();
                bindingSourceGiaoVien.ResetCurrentItem();
                this.tableAdapterGiaoVien.Connection.ConnectionString = Program.connstr;
                // vì không thể sửa giáo viên nếu khoa thuộc site khác (dù đã disable field nhập mã khoa)
                // giải quyết = sử dụng sp_sua_giao_vien_ignore_ fk // ignore ràng buộc khóa ngoại
                // chi tiết xem trong sp đó
                if (mode == "sua")
                {
                    String strLenh = "EXEC SP_SUA_GIAOVIEN_IGNORE_FK '" + maGiaoVien + "', N'"
                        + hoChuanBiSua + "', N'" + tenChuanBiSua + "', N'" + diaChiChuanBiSua + "', '" + maKhoaChuanBiSua + "'";
                    try
                    {
                        Program.myReader = Program.ExecSqlDataReader(strLenh);
                        Program.myReader.Read();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể ghi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                        this.tableAdapterGiaoVien.Update(this.TN_CSDLPT_DataSet.GIAOVIEN);
                        return;
                    }

                    // lấy ra mã giáo viên bị ảnh hưởng khi undo 
                    String affected_id = "";
                    try
                    {
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

                    // cập nhật lại bảng
                    try
                    {
                        this.tableAdapterGiaoVien.Connection.ConnectionString = Program.connstr;
                        //this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                        tableAdapterGiaoVien.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                    }

                    // chuyển dòng được chọn trên gridview thành dòng có mã bị ảnh hưởng (affected_id)
                    if (affected_id != "" || affected_id != null)
                    {
                        int row = gridViewGiaoVien.LocateByValue("MAGV", affected_id);
                        //gridViewMonHoc.FocusedRowHandle = row; 
                        bindingSourceGiaoVien.Position = bindingSourceGiaoVien.Find("MAGV", affected_id);
                    }


                }
                else //mode= "them"
                {
                    this.tableAdapterGiaoVien.Update(this.TN_CSDLPT_DataSet.GIAOVIEN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterGiaoVien.Update(this.TN_CSDLPT_DataSet.GIAOVIEN);
                return;
            }

            if (mode == "them")
            {
                undoCommands.Add("EXEC SP_XOA_GIAOVIEN '" + maGiaoVien + "'");
            }

            // vì mã khoa không nhân bản nhưng lại có khóa ngoại tới giáo viên, nên khi sửa giáo viên ta k sửa mã khoa
            if (mode == "sua")
            {
                undoCommands.Add("EXEC SP_SUA_GIAOVIEN_IGNORE_FK '" + maGiaoVien + "', N'" 
                    + hoLucChuaSua + "', N'"+tenLucChuaSua+"', N'"+diaChiLucChuaSua+"', '"+maKhoaLucChuaSua+"'");
            }

            mode = "";

            panelControlNhapLieu.Enabled = false;
            gridControlGiaoVien.Enabled = true;

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

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceGiaoVien.CancelEdit();
            bindingSourceGiaoVien.Position = vitri;
            panelControlNhapLieu.Enabled = false;
            gridControlGiaoVien.Enabled = true;

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

        private void barButtonReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tableAdapterGiaoVien.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
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
                this.tableAdapterGiaoVien.Update(this.TN_CSDLPT_DataSet.GIAOVIEN);
                return;
            }

            // lấy ra mã giáo viên bị ảnh hưởng khi undo 
            String affected_id = "";
            try
            {
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
                this.tableAdapterGiaoVien.Connection.ConnectionString = Program.connstr;
                //this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                tableAdapterGiaoVien.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }

            // chuyển dòng được chọn trên gridview thành dòng có mã bị ảnh hưởng (affected_id)
            if (affected_id != "" || affected_id != null)
            {
                int row = gridViewGiaoVien.LocateByValue("MAGV", affected_id);
                //gridViewMonHoc.FocusedRowHandle = row; 
                bindingSourceGiaoVien.Position = bindingSourceGiaoVien.Find("MAGV", affected_id);
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
                // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.KHOA' table. You can move, or remove it, as needed.
                this.tableAdapterKhoa.Connection.ConnectionString = Program.connstr;
                this.tableAdapterKhoa.Fill(this.TN_CSDLPT_DataSet.KHOA);
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
                this.tableAdapterGiaoVien.Connection.ConnectionString = Program.connstr;
                this.tableAdapterGiaoVien.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.BODE' table. You can move, or remove it, as needed.
                this.tableAdapterBoDe.Connection.ConnectionString = Program.connstr;
                this.tableAdapterBoDe.Fill(this.TN_CSDLPT_DataSet.BODE);
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
                this.tableAdapterGiaoVien_DangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }
        }

        private void comboBoxMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}