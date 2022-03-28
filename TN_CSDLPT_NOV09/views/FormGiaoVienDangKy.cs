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
            this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
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
            comboBoxMaMonHoc.ValueMember = "MAMH";

            comboBoxTrinhDo.Items.Add("A");
            comboBoxTrinhDo.Items.Add("B");
            comboBoxTrinhDo.Items.Add("C");

            barButtonGhi.Enabled = false;
            panelControlNhapLieu.Enabled = false;

            if (bindingSourceGiaoVien_DangKy.Count == 0)
            {
                barButtonSua.Enabled = barButtonXoa.Enabled = false;
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
                // bỏ các ràng buộc để load dữ liệu lên grid view k bị lỗi
                this.TN_CSDLPT_DataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
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

            comboBoxMaGiaoVien.SelectedIndex = 0;
            comboBoxMaMonHoc.SelectedIndex = 0;
            comboBoxMaLop.SelectedIndex = 0;
            comboBoxTrinhDo.SelectedIndex = 0;

            comboBoxMaMonHoc.Enabled = true;
            comboBoxMaLop.Enabled = true;
            spinEditLan.Enabled = true;

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

            comboBoxMaMonHoc.Enabled = false;
            comboBoxMaLop.Enabled = false;
            spinEditLan.Enabled = false;

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

            int xacNhanXoa = (int)MessageBox.Show("Bạn có chắc muốn xóa đăng ký thi này này?", "Xác nhận", MessageBoxButtons.OKCancel);
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
                    int index = bindingSourceGiaoVien_DangKy.Find("LAN", lan) + bindingSourceGiaoVien_DangKy.Find("MALOP", maLop) + bindingSourceGiaoVien_DangKy.Find("MAMH", maMonHoc);
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
            String maGiaoVienChuaSua = "";
            String trinhDoChuaSua = "";
            String ngayThiChuaSua = "";

            DateTime myDateTime = new DateTime();
            String ngayThiChuaSuaSQLFormat = "";
            int soCauThiChuaSua = -1;
            int thoiGianChuaSua = -1;

            if (mode == "sua")
            {
                //lấy thông tin gvien_dangky để undo redo
                maGiaoVienChuaSua = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MAGV"].ToString().Trim();
                trinhDoChuaSua = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["TRINHDO"].ToString().Trim();
                ngayThiChuaSua = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["NGAYTHI"].ToString().Trim();

                //format thành định dạng date của sql để undo sửa
                myDateTime = DateTime.Parse(ngayThiChuaSua);
                ngayThiChuaSuaSQLFormat = myDateTime.ToString("yyyy-MM-dd");
                soCauThiChuaSua = int.Parse((String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["SOCAUTHI"].ToString().Trim());
                thoiGianChuaSua = int.Parse((String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["THOIGIAN"].ToString().Trim());
            }

            String maGiaoVienChuanBiSua = comboBoxMaGiaoVien.SelectedValue.ToString().Trim();

            //không cho sửa mã lớp, mã môn và lần
            //String maLop = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MALOP"].ToString().Trim();
            //String maLopChuanBiThem = comboBoxMaLop.SelectedValue.ToString().Trim();
            String maLop = comboBoxMaLop.Text.Trim();

            //String maMonHoc = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MAMH"].ToString().Trim();
            //String maMonHocChuanBiThem = comboBoxMaMonHoc.SelectedValue.ToString().Trim();
            String maMonHoc = comboBoxMaMonHoc.Text.Trim();
            String trinhDoChuanBiSua = comboBoxTrinhDo.Text.Trim();
            String ngayThiChuanBiSua = dateEditNgayThi.Text.Trim();

            // ta k cho sửa lần thi
            int lan = int.Parse(spinEditLan.Value.ToString());
            int soCauThiChuanBiSua = int.Parse(spinEditSoCauThi.Value.ToString());
            int thoiGianChuanBiSua = int.Parse(spinEditThoiGian.Value.ToString());


            // lưu ý chuẩn bị sửa cũng là chuẩn bị thêm
            // những combobox load dữ liệu lên từ csdl ta k cần check vì nó có chắc r
            if (lan < 1 || lan > 2)
            {
                MessageBox.Show("Một môn chỉ thi tối đa 2 lần", "", MessageBoxButtons.OK);
                spinEditThoiGian.Focus();
                return;
            }
            if (soCauThiChuanBiSua < 20||soCauThiChuanBiSua>100)
            {
                MessageBox.Show("Đề thi phải có tối thiểu 20 câu, tối đa 100 câu", "", MessageBoxButtons.OK);
                spinEditSoCauThi.Focus();
                return;
            }
            if (thoiGianChuanBiSua < 30)
            {
                MessageBox.Show("Thời gian thi phải lớn hơn 30 phút", "", MessageBoxButtons.OK);
                spinEditThoiGian.Focus();
                return;
            }
            if (dateEditNgayThi.Text=="")
            {
                MessageBox.Show("Hãy nhập ngày thi", "", MessageBoxButtons.OK);
                dateEditNgayThi.Focus();
                return;
            }
            if (dateEditNgayThi.DateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Chủ nhật thì không tổ chức thi", "", MessageBoxButtons.OK);
                dateEditNgayThi.Focus();
                return;
            }
            if (dateEditNgayThi.DateTime <= DateTime.Now.AddDays(7))
            {
                MessageBox.Show("Ngày thi phải cách ngày đăng kí ít nhất 1 tuần", "", MessageBoxButtons.OK);
                dateEditNgayThi.Focus();
                return;
            }


            //check trùng mã, tên lớp khi thêm
            if (mode == "them")
            {
                String strLenh = "EXEC SP_KT_GIAOVIEN_DANGKY_DATONTAI '" + maLop + "', '" +maMonHoc+ "', "+lan+"";

                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1) //
                {
                    //tự raiserror, ta chỉ cần focus về field nhập
                    spinEditLan.Focus();
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
                bindingSourceGiaoVien_DangKy.EndEdit();
                bindingSourceGiaoVien_DangKy.ResetCurrentItem();
                this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
                this.tableAdapterGiaoVien_DangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterGiaoVien_DangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
                return;
            }

            // nếu là thêm thì khi undo (xóa nó đi) thì lấy mã của nó trên bảng để sau quay trở về
            if (mode == "them")
            {
                undoCommands.Add("EXEC SP_XOA_GIAOVIEN_DANGKY '" + maMonHoc + "', '" + maLop + "', "+lan+"");
            }
            // đăngký thi chỉ cho sửa ngày thi, giáo viên coi thi số câu thi, trình độ, thời gian, k cho sửa môn học
            if (mode == "sua")
            {
                undoCommands.Add("EXEC SP_SUA_GIAOVIEN_DANGKY '" + maGiaoVienChuaSua + "', '" + maMonHoc + "', '" + maLop + "', '" + trinhDoChuaSua
                    + "', '" + ngayThiChuaSuaSQLFormat + "', " +lan + ", " + soCauThiChuaSua + ", " + thoiGianChuaSua + "");
            }

            mode = "";

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
                this.tableAdapterGiaoVien_DangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
                Program.myReader.Close();
                Program.conn.Close();
                return;
            }

            // lấy ra mã sinh viên bị ảnh hưởng khi undo 
            String affected_id = "";
            String affected_maMonHoc = "";
            String affected_maLop = "";
            int affected_lan = -1;
            try
            {
                //lay AFFECTED_ID tu sp
                affected_id = Program.myReader.GetString(0).Trim(); // không dùng
                affected_maMonHoc = Program.myReader.GetString(1).Trim();
                affected_maLop = Program.myReader.GetString(2).Trim();
                affected_lan = Program.myReader.GetInt16(3);
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
                this.tableAdapterGiaoVien_DangKy.Connection.ConnectionString = Program.connstr;
                //this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                this.tableAdapterGiaoVien_DangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }

            // chuyển dòng được chọn trên gridview thành dòng có mã bị ảnh hưởng (affected_id)
            if (affected_id != "" || affected_id != null)
            {
                //bindingSourceSinhVien.Position = bindingSourceSinhVien.Find("MASV", affected_id);
                
                //quay về dòng có 3 dữ liệu bên dưới
                int index = bindingSourceGiaoVien_DangKy.Find("LAN", affected_lan) + bindingSourceGiaoVien_DangKy.Find("MALOP", affected_maLop) + bindingSourceGiaoVien_DangKy.Find("MAMH", affected_maMonHoc);
                bindingSourceGiaoVien_DangKy.Position = index;

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

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}