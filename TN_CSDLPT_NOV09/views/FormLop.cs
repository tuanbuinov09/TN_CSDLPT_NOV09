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
                // nếu trong dữ liệu k có dòng nào disable nút thêm xóa
                if (bindingSourceLop.Count == 0)
                {
                    barButtonSua.Enabled = barButtonXoa.Enabled = false;
                }
                barButtonHuy.Enabled = false;
            }

            //load danh sách khoa vào comboBox
            DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_DS_KHOA");
            comboBoxMaKhoa.DataSource = dt;
            comboBoxMaKhoa.DisplayMember = "MAKH";
            comboBoxMaKhoa.ValueMember = "MAKH";

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
            // mỗi khi chuyển site, cái combobox mã khoa sẽ bị mất dữ liệu
            // mỗi khi chuyển ta lấy lại dữ liệu vào combobox
            DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_DS_KHOA");
            comboBoxMaKhoa.DataSource = dt;
            comboBoxMaKhoa.DisplayMember = "MAKH";
            comboBoxMaKhoa.ValueMember = "MAKH";
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

            comboBoxMaKhoa.SelectedIndex = 0;
            // khi đang thêm sửa thì k thể ấn phục hồi
            barButtonPhucHoi.Enabled = false;
            barButtonReload.Enabled = false;
            // khi thêm cho nhập mã khoa, khi sửa không cho sửa mã khoa
            textBoxMaLop.Enabled = true;
            gridControlLop.Enabled = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "sua";
            vitri = bindingSourceLop.Position;
            panelControlNhapLieu.Enabled = true;
            // khi ấn sửa lấy mã khoa chưa sửa chọn ở combobox khoa
            String maKhoa = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["MAKH"].ToString().Trim();
            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            comboBoxMaKhoa.SelectedValue = maKhoa;
            // khi đang thêm sửa thì k thể ấn phục hồi
            barButtonPhucHoi.Enabled = false;
            barButtonHuy.Enabled = true;
            barButtonReload.Enabled = false;
            // không cho sửa mã lớp
            textBoxMaLop.Enabled = false;
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
                MessageBox.Show("Không thể xóa lớp này vì đã đăng ký thi", "", MessageBoxButtons.OK);
                return;
            }

            int xacNhanXoa = (int)MessageBox.Show("Bạn có chắc muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanXoa == (int)DialogResult.OK)
            {
                try
                {
                    maLop = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["MALOP"].ToString().Trim();
                    //lấy thông tin lớp để undo redo
                    tenLop = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["TENLOP"].ToString().Trim();
                    maKhoa = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["MAKH"].ToString().Trim();
                    bindingSourceLop.RemoveCurrent();
                    this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterLop.Update(this.TN_CSDLPT_DataSet.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lớp thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
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

        private void barButtonGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tenLopLucChuaSua = "";
            String maKhoaLucChuaSua = "";
            if (mode == "sua")
            {
                tenLopLucChuaSua = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["TENLOP"].ToString();
                maKhoaLucChuaSua = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["MAKH"].ToString();
            }
            String maLop = textBoxMaLop.Text.Trim();
            //String tenLopLucChuaSua = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["TENLOP"].ToString();
            String tenLopChuanBiSua = textBoxTenLop.Text.Trim();
            //String maKhoaLucChuaSua = (String)((DataRowView)bindingSourceLop[bindingSourceLop.Position])["MAKH"].ToString();
            String maKhoaChuanBiSua = comboBoxMaKhoa.Text.Trim();
            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxMaLop.Focus();
                return;
            }
            // lưu ý chuẩn bị sửa cũng là chuẩn bị thêm
            if (tenLopChuanBiSua == "")
            {
                MessageBox.Show("Tên lớp không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxTenLop.Focus();
                return;
            }

            //check trùng mã, tên lớp khi thêm
            if (mode == "them")
            {
                String strLenh = "EXEC SP_KT_LOP_DATONTAI '" + maLop + "', N'" + tenLopChuanBiSua +"', '" + maKhoaChuanBiSua +"', 'KTRATHEM'";

                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1) //
                {
                    //tự raiserror, ta chỉ cần focus về field nhập
                    textBoxMaLop.Focus();
                    return;
                }
                if (kq == 2)
                {
                    textBoxTenLop.Focus();
                    return;
                }
            }
            //check trùng tên lớp khi sửa (trường hợp mã lớp tên lớp đều giống nhau ta cho là đúng
            // trường hợp mã lớp khác, tên lớp giống thì báo k thể sửa)
            if (mode == "sua")
            {
                String strLenh = "EXEC SP_KT_LOP_DATONTAI '" + maLop + "', N'" + tenLopChuanBiSua + "', '" + maKhoaChuanBiSua + "', 'KTRASUA'";

                int kq = Program.ExecSqlNonQuery(strLenh);
                //if (kq == 1) //
                //{
                //    //tự raiserror, ta chỉ cần focus về field nhập
                //    textBoxMaKhoa.Focus();
                //    return;
                //}
                if (kq == 2)
                {
                    //tên lớp trùng lớp khác
                    textBoxTenLop.Focus();
                    return;
                }
            }
            try
            {
                bindingSourceLop.EndEdit();
                bindingSourceLop.ResetCurrentItem();
                this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                this.tableAdapterLop.Update(this.TN_CSDLPT_DataSet.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterLop.Update(this.TN_CSDLPT_DataSet.LOP);
                return;
            }

            // nếu là thêm thì khi undo (xóa nó đi) thì lấy mã của nó trên bảng để sau quay trở về
            if (mode == "them")
            {
                undoCommands.Add("EXEC SP_XOA_LOP '" + maLop + "'");
            }
            if (mode == "sua")
            {
                undoCommands.Add("EXEC SP_SUA_LOP '" + maLop + "', N'" + tenLopLucChuaSua + "', '"+maKhoaLucChuaSua+"'");
            }

            mode = "";

            panelControlNhapLieu.Enabled = false;
            gridControlLop.Enabled = true;

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
                this.tableAdapterLop.Update(this.TN_CSDLPT_DataSet.LOP);
                Program.myReader.Close();
                Program.conn.Close();
                return;
            }

            // lấy ra mã lớp bị ảnh hưởng khi undo 
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
                this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                //this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                this.tableAdapterLop.Fill(this.TN_CSDLPT_DataSet.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }

            // chuyển dòng được chọn trên gridview thành dòng có mã bị ảnh hưởng (affected_id)
            if (affected_id != "" || affected_id != null)
            {
                //int row = gridViewKhoa.LocateByValue("MAKH", affected_id);
                //gridViewMonHoc.FocusedRowHandle = row; 
                bindingSourceLop.Position = bindingSourceLop.Find("MALOP", affected_id);
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

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceLop.CancelEdit();
            if (mode == "them")
            {
                //xóa cái dòng được tạo từ bindingSource.addNew khi ấn thêm trên gridview
                gridViewLop.DeleteRow(gridViewLop.FocusedRowHandle);
            }
            bindingSourceLop.Position = vitri;
            panelControlNhapLieu.Enabled = false;
            gridControlLop.Enabled = true;

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
            barButtonReload.Enabled = true;
            barButtonHuy.Enabled = false;
        }

        private void barButtonReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tableAdapterLop.Fill(this.TN_CSDLPT_DataSet.LOP);
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
    }
}