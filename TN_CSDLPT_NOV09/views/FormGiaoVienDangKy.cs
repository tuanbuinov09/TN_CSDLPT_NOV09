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
            this.bindingSourceGiaoVienDangKy.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void FormGiaoVienDangKy_Load(object sender, EventArgs e)
        {
            // bỏ các ràng buộc để load dữ liệu lên grid view k bị lỗi
            this.TN_CSDLPT_DataSet.EnforceConstraints = false;
          

            //những cái này để đổ dữ liệu vào combobox
            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.TN_CSDLPT_DataSet.LOP);
            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);

            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tableAdapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
            this.tableAdapterGiaoVienDangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

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
            // thay vì làm cách này, ta kéo thả binding source các bảng cần lấy mã vào
            // rồi vào properties của combobox tương ứng chọn bindingsource đó, chọn dipslay member, value member
            //DataTable dtDSLop = Program.ExecSqlDataTable("EXEC SP_LAY_DS_LOP");
            //comboBoxMaLop.DataSource = dtDSLop;
            //comboBoxMaLop.DisplayMember = "MALOP";
            //comboBoxMaLop.ValueMember = "MALOP";

            //DataTable dtDSGiaoVien = Program.ExecSqlDataTable("EXEC SP_LAY_DS_GIAOVIEN");
            //comboBoxMaGiaoVien.DataSource = dtDSGiaoVien;
            //comboBoxMaGiaoVien.DisplayMember = "MAGV";
            //comboBoxMaGiaoVien.ValueMember = "MAGV";

            //DataTable dtDSMonHoc = Program.ExecSqlDataTable("EXEC SP_LAY_DS_MONHOC");
            //comboBoxMaMonHoc.DataSource = dtDSMonHoc;
            //comboBoxMaMonHoc.DisplayMember = "MAMH";
            //comboBoxMaMonHoc.ValueMember = "MAMH";

            comboBoxTrinhDo.Items.Add("A");
            comboBoxTrinhDo.Items.Add("B");
            comboBoxTrinhDo.Items.Add("C");

            comboBoxTrinhDo.SelectedValue = "A";
            comboBoxTrinhDo.Text = comboBoxTrinhDo.SelectedText;

            barButtonGhi.Enabled = false;
            panelControlNhapLieu.Enabled = false;

            if (bindingSourceGiaoVienDangKy.Count == 0)
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
                this.tableAdapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
                this.tableAdapterGiaoVienDangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

                //những cái này để đổ dữ liệu vào combobox
                // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.TN_CSDLPT_DataSet.LOP);
                // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);
                // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
                this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);

                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }
            // mỗi khi chuyển site, cái combobox mã lớp sẽ bị mất dữ liệu nếu dữ liệu trong combobox phân mảnh ngang
            // mỗi khi chuyển ta lấy lại dữ liệu vào combobox

            //DataTable dtDSLop = Program.ExecSqlDataTable("EXEC SP_LAY_DS_LOP");
            //comboBoxMaLop.DataSource = dtDSLop;
            //comboBoxMaLop.DisplayMember = "MALOP";
            //comboBoxMaLop.ValueMember = "MALOP";

            //DataTable dtDSGiaoVien = Program.ExecSqlDataTable("EXEC SP_LAY_DS_GIAOVIEN");
            //comboBoxMaGiaoVien.DataSource = dtDSGiaoVien;
            //comboBoxMaGiaoVien.DisplayMember = "MAGV";
            //comboBoxMaGiaoVien.ValueMember = "MAGV";

            //DataTable dtDSMonHoc = Program.ExecSqlDataTable("EXEC SP_LAY_DS_MONHOC");
            //comboBoxMaMonHoc.DataSource = dtDSMonHoc;
            //comboBoxMaMonHoc.DisplayMember = "MAMH";
            //comboBoxMaMonHoc.ValueMember = "MANH";

            //combobox trinh do khỏi cần load lại
            //comboBoxTrinhDo.Items.Add("A");
            //comboBoxTrinhDo.Items.Add("B");
            //comboBoxTrinhDo.Items.Add("C");

        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "them";
            vitri = bindingSourceGiaoVienDangKy.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceGiaoVienDangKy.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;
            // khi đang thêm sửa thì k thể ấn phục hồi, reload
            barButtonPhucHoi.Enabled = false;
            barButtonReload.Enabled = false;

            comboBoxMaMonHoc.Enabled = true;
            comboBoxMaLop.Enabled = true;
            spinEditLan.Enabled = true;

            
            comboBoxTrinhDo.SelectedIndex = 0;
            //nếu k làm vầy thì lúc thêm, nếu không chọn giá trị khác trên combobox thì gridcontrol auto lấy giá trị null
            comboBoxTrinhDo.Text = comboBoxTrinhDo.SelectedText;
            comboBoxMaGiaoVien.SelectedIndex = 0;
            //nếu k làm vầy thì lúc thêm, nếu không chọn giá trị khác trên combobox thì gridcontrol auto lấy giá trị null
            comboBoxMaGiaoVien.Text = comboBoxMaGiaoVien.SelectedText;
            comboBoxMaMonHoc.SelectedIndex = 0;
            //nếu k làm vầy thì lúc thêm, nếu không chọn giá trị khác trên combobox thì gridcontrol auto lấy giá trị null
            comboBoxMaMonHoc.Text = comboBoxMaMonHoc.SelectedText;
            comboBoxMaLop.SelectedIndex = 0;
            //nếu k làm vầy thì lúc thêm, nếu không chọn giá trị khác trên combobox thì gridcontrol auto lấy giá trị null
            comboBoxMaLop.Text = comboBoxMaLop.SelectedText;

            dateEditNgayThi.DateTime = DateTime.Now;

            spinEditLan.Value = 1;
            spinEditSoCauThi.Value = 10;
            spinEditThoiGian.Value = 15;

            gridControlGiaoVienDangKy.Enabled = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "sua";
            vitri = bindingSourceGiaoVienDangKy.Position;
            panelControlNhapLieu.Enabled = true;
            // khi ấn sửa lấy mã lớp, mã môn, mã giáo viên để set trên combobox chưa sửa chọn ở combobox lớp
            String maLop = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["MALOP"].ToString().Trim();
            String maGiaoVien = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["MAGV"].ToString().Trim();
            String maMonHoc = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["MAMH"].ToString().Trim();
            String trinhDo = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["TRINHDO"].ToString().Trim();
            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;

            comboBoxMaLop.SelectedValue = maLop;
            comboBoxMaMonHoc.SelectedValue = maMonHoc;
            comboBoxMaGiaoVien.SelectedValue = maGiaoVien;
            comboBoxTrinhDo.SelectedValue = trinhDo;

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
            if (mode == "them")
            {
                //xóa cái dòng được tạo từ bindingSource.addNew khi ấn thêm trên gridview
                gridViewGiaoVienDangKy.DeleteRow(gridViewGiaoVienDangKy.FocusedRowHandle);
            }
            bindingSourceGiaoVienDangKy.CancelEdit();

            bindingSourceGiaoVienDangKy.Position = vitri;
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
                tableAdapterGiaoVienDangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
                // load lại luôn đề phòng có thay đổi
                this.lOPTableAdapter.Fill(this.TN_CSDLPT_DataSet.LOP);
                this.gIAOVIENTableAdapter.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN);
                this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);
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
            DateTime myDateTime = new DateTime();
            String ngayThiSQLFormat = "";
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
                    maLop = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["MALOP"].ToString().Trim();
                    maGiaoVien = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["MAGV"].ToString().Trim();
                    maMonHoc = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["MAMH"].ToString().Trim();
                    trinhDo = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["TRINHDO"].ToString().Trim();
                    ngayThi = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["NGAYTHI"].ToString().Trim();
                    lan = int.Parse((String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["LAN"].ToString().Trim());
                    soCauThi = int.Parse((String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["SOCAUTHI"].ToString().Trim());
                    thoiGian = int.Parse((String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["THOIGIAN"].ToString().Trim());

                    
                    myDateTime = DateTime.Parse(ngayThi);
                    ngayThiSQLFormat = myDateTime.ToString("yyyy-MM-dd");
                    // chạy sp ktra, nếu là xóa lần 1 thì phải k có lần 2

                    String strLenh = "EXEC SP_KT_XOA_GIAOVIEN_DANGKY '" + maLop + "', '" + maMonHoc + "', " + lan + ", '" + ngayThiSQLFormat + "'";

                        int kq = Program.ExecSqlNonQuery(strLenh);
     
                        if (kq == 2) //
                        {
                            //tự raiserror, ta chỉ cần focus về field nhập
                            return;
                        }

                    bindingSourceGiaoVienDangKy.RemoveCurrent();
                    this.tableAdapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterGiaoVienDangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

                    undoCommands.Add("EXEC SP_THEM_GIAOVIEN_DANGKY '" + maGiaoVien + "', '"
                        + maMonHoc + "', '" + maLop + "', '" + trinhDo + "', '" + ngayThiSQLFormat + "', " + lan + ", " + soCauThi + ", " + thoiGian + "");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa đăng ký thi thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterGiaoVienDangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);

                    //quay về dòng có 3 dữ liệu bên dưới
                    int index = bindingSourceGiaoVienDangKy.Find("LAN", lan) + bindingSourceGiaoVienDangKy.Find("MALOP", maLop) + bindingSourceGiaoVienDangKy.Find("MAMH", maMonHoc);
                    bindingSourceGiaoVienDangKy.Position = index;
                    return;
                }
            }
            if (bindingSourceGiaoVienDangKy.Count == 0)
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
                maGiaoVienChuaSua = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["MAGV"].ToString().Trim();
                trinhDoChuaSua = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["TRINHDO"].ToString().Trim();
                ngayThiChuaSua = (String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["NGAYTHI"].ToString().Trim();

                //format thành định dạng date của sql để undo sửa
                myDateTime = DateTime.Parse(ngayThiChuaSua);
                ngayThiChuaSuaSQLFormat = myDateTime.ToString("yyyy-MM-dd");
                soCauThiChuaSua = int.Parse((String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["SOCAUTHI"].ToString().Trim());
                thoiGianChuaSua = int.Parse((String)((DataRowView)bindingSourceGiaoVienDangKy[bindingSourceGiaoVienDangKy.Position])["THOIGIAN"].ToString().Trim());
            }

            String maGiaoVienChuanBiSua = comboBoxMaGiaoVien.Text.ToString().Trim();

            //không cho sửa mã lớp, mã môn và lần
            //String maLop = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MALOP"].ToString().Trim();
            //String maLopChuanBiThem = comboBoxMaLop.SelectedValue.ToString().Trim();
            String maLop = comboBoxMaLop.SelectedValue.ToString().Trim();

            //String maMonHoc = (String)((DataRowView)bindingSourceGiaoVien_DangKy[bindingSourceGiaoVien_DangKy.Position])["MAMH"].ToString().Trim();
            //String maMonHocChuanBiThem = comboBoxMaMonHoc.SelectedValue.ToString().Trim();
            String maMonHoc = comboBoxMaMonHoc.SelectedValue.ToString().Trim();
            String trinhDoChuanBiSua = comboBoxTrinhDo.Text.Trim();
            String ngayThiChuanBiSua = dateEditNgayThi.Text.Trim();

            DateTime myDateTimeCBSua = new DateTime();
            String ngayThiChuanBiSuaSQLFormat = "";

            if (ngayThiChuanBiSua != "")
            {
                myDateTimeCBSua = DateTime.Parse(ngayThiChuanBiSua);
                ngayThiChuanBiSuaSQLFormat = myDateTimeCBSua.ToString("yyyy-MM-dd");
            }
            

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
            if (soCauThiChuanBiSua < 10||soCauThiChuanBiSua>100)
            {
                MessageBox.Show("Đề thi phải có tối thiểu 10 câu, tối đa 100 câu", "", MessageBoxButtons.OK);
                spinEditSoCauThi.Focus();
                return;
            }
            if (thoiGianChuanBiSua < 15)
            {
                MessageBox.Show("Thời gian thi phải lớn hơn 15 phút", "", MessageBoxButtons.OK);
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

            //if (dateEditNgayThi.DateTime.Date <= DateTime.Now.Date)
            //{
            //    MessageBox.Show("Không thể nhập ngày hiện tại trở về trước", "", MessageBoxButtons.OK);
            //    dateEditNgayThi.Focus();
            //    return;
            //}

            //if (dateEditNgayThi.DateTime <= DateTime.Now.AddDays(7) || dateEditNgayThi.DateTime.Date <= DateTime.Now.Date)
            //{
            //    MessageBox.Show("Ngày thi phải cách ngày đăng kí ít nhất 1 tuần", "", MessageBoxButtons.OK);
            //    dateEditNgayThi.Focus();
            //    return;
            //}

            if (dateEditNgayThi.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày thi không hợp lệ", "", MessageBoxButtons.OK);
                dateEditNgayThi.Focus();
                return;
            }



            //check trùng mã, tên lớp khi thêm
            if (mode == "them")
            {
                String strLenh = "EXEC SP_KT_GIAOVIEN_DANGKY_DATONTAI '" + maLop + "', '" +maMonHoc+ "', "+lan+", '"+ ngayThiChuanBiSuaSQLFormat + "'";

                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1) //
                {
                    //tự raiserror, ta chỉ cần focus về field nhập
                    spinEditLan.Focus();
                    return;
                }

                if (kq == 2) //
                {
                    //tự raiserror, ta chỉ cần focus về field nhập
                    spinEditLan.Focus();
                    return;
                }

                if (kq == 3) //
                {
                    //tự raiserror, ta chỉ cần focus về field nhập
                    dateEditNgayThi.Focus();
                    return;
                }
            }

            if (mode == "sua")
            {
                
                String strLenh = "EXEC SP_KT_SUA_GIAOVIEN_DANGKY '" + maLop + "', '" + maMonHoc + "', " + lan + ", '" + ngayThiChuanBiSuaSQLFormat + "'";

                int kq = Program.ExecSqlNonQuery(strLenh);

                if (kq == 3) //
                {
                    //tự raiserror, ta chỉ cần focus về field nhập
                    dateEditNgayThi.Focus();
                    return;
                }
            }
            try
            {
                bindingSourceGiaoVienDangKy.EndEdit();
                bindingSourceGiaoVienDangKy.ResetCurrentItem();
                this.tableAdapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
                this.tableAdapterGiaoVienDangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterGiaoVienDangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
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
                this.tableAdapterGiaoVienDangKy.Update(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
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
                this.tableAdapterGiaoVienDangKy.Connection.ConnectionString = Program.connstr;
                //this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                this.tableAdapterGiaoVienDangKy.Fill(this.TN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
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
                int index = bindingSourceGiaoVienDangKy.Find("LAN", affected_lan) + bindingSourceGiaoVienDangKy.Find("MALOP", affected_maLop) + bindingSourceGiaoVienDangKy.Find("MAMH", affected_maMonHoc);
                bindingSourceGiaoVienDangKy.Position = index;

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