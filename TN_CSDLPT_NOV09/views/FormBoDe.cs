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
    public partial class FormBoDe : DevExpress.XtraEditors.XtraForm
    {
        ArrayList undoCommands = new ArrayList();
        String mode = "";
        int vitri = -1;
        String maCoSo;
        
        public FormBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void FormBoDe_Load(object sender, EventArgs e)
        {
            //chỉ có mỗi bảng bộ đề khỏi cần dòng này cũng đc, nhưng thêm vào cho chắc
            TN_CSDLPT_DataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.BODE' table. You can move, or remove it, as needed.
            this.tableAdapterBoDe.Connection.ConnectionString = Program.connstr;
            this.tableAdapterBoDe.Fill(this.TN_CSDLPT_DataSet.BODE);

            comboBoxCoSo.DataSource = Program.bds_DanhSachPhanManh;
            comboBoxCoSo.DisplayMember = "TENCS";
            comboBoxCoSo.ValueMember = "TENSERVER";
            comboBoxCoSo.SelectedIndex = Program.mCoSo;

            if (Program.mGroup == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
            }
            else
            {
                comboBoxCoSo.Enabled = false;

            }

            if (Program.mGroup == "TRUONG"||Program.mGroup=="COSO"|| Program.mGroup == "SINHVIEN")
            {

                barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                    = barButtonGhi.Enabled = barButtonPhucHoi.Enabled = barButtonHuy.Enabled = false;

            }
            else// mGroup=="GIANGVIEN" chỉ có quyền giảng viên mới đc thao tác thêm xóa sửa bộ đề
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

            //vì lúc thêm mã giáo viên lấy từ username (mã gv) bên Program.cs, 
            //và lúc sửa thì k cho sửa mã giáo viên nốt, nên ta disable nó từ đầu
            textBoxMaGiaoVien.Enabled = false;
            spinEditCauHoi.Enabled = false;

            //load danh sách môn học vào comboBox
            DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_DS_MONHOC");
            comboBoxMaMonHoc.DataSource = dt;
            comboBoxMaMonHoc.DisplayMember = "MAMH";
            //comboBoxMaMonHoc.DisplayMember = "TENMH";
            comboBoxMaMonHoc.ValueMember = "MAMH";

            comboBoxDapAn.Items.Add("A");
            comboBoxDapAn.Items.Add("B");
            comboBoxDapAn.Items.Add("C");
            comboBoxDapAn.Items.Add("D");

            comboBoxTrinhDo.Items.Add("A");
            comboBoxTrinhDo.Items.Add("B");
            comboBoxTrinhDo.Items.Add("C");

            panelControlNhapLieu.Enabled = false;
        }

        private void tRINHDOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "them";
            vitri = bindingSourceBoDe.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceBoDe.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;
            if (undoCommands.Count > 0)
            {
                barButtonPhucHoi.Enabled = true;
            }
            else
            {
                barButtonPhucHoi.Enabled = false;
            }

            String strLenh = "EXEC [SP_LAY_STT_CAUHOI_TIEPTHEO]";

            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int thuTuCauHoiTiepTheo = Program.myReader.GetInt32(0);
                //đặt id tiếp theo cho spinEdit
                spinEditCauHoi.EditValue = thuTuCauHoiTiepTheo;
                Program.myReader.Close();
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy số thứ tự câu hỏi kế\n" + ex.Message, "", MessageBoxButtons.OK);
                Program.myReader.Close();
                Program.conn.Close();
                return;
            }
            //mã giáo viên tạo câu hỏi là mã giáo viên đang đăng nhập
            textBoxMaGiaoVien.Text = Program.username;

            comboBoxMaMonHoc.Text = "Chọn mã môn";


            comboBoxDapAn.Text = "Chọn đáp án";
            //comboBoxDapAn.SelectedIndex = 0;


            comboBoxTrinhDo.Text = "Chọn trình độ";

            //comboBoxTrinhDo.SelectedIndex = 0;

            gridControlBoDe.Enabled = false;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceBoDe.CancelEdit();
            bindingSourceBoDe.Position = vitri;
            panelControlNhapLieu.Enabled = false;
            gridControlBoDe.Enabled = true;

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

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGiaoVien = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["MAGV"].ToString();

            if (maGiaoVien != Program.username)
            {
                MessageBox.Show("Xin lỗi, bạn không thể sửa câu hỏi của giáo viên khác tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            mode = "sua";
            vitri = bindingSourceBoDe.Position;
            panelControlNhapLieu.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
           
            if (undoCommands.Count > 0)
            {
                barButtonPhucHoi.Enabled = true;
            }
            else
            {
                barButtonPhucHoi.Enabled = false;
            }

            String maMonHoc = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["MAMH"].ToString();
            String trinhDo = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["TRINHDO"].ToString();
            String dapAn = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["DAP_AN"].ToString();

            comboBoxMaMonHoc.SelectedValue = maMonHoc;

            comboBoxDapAn.SelectedValue = dapAn;
            //comboBoxDapAn.SelectedIndex = 0;

            comboBoxTrinhDo.SelectedValue = trinhDo;
            //comboBoxTrinhDo.SelectedIndex = 0;

            barButtonHuy.Enabled = true;

            textBoxMaGiaoVien.Enabled = false;
            gridControlBoDe.Enabled = false;
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGiaoVien = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["MAGV"].ToString();

            if (maGiaoVien != Program.username)
            {
                MessageBox.Show("Xin lỗi, bạn không thể xóa câu hỏi của giáo viên khác tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            mode = "xoa";
            int idCauHoi = -1;
            String maMonHoc = "";
            String trinhDo = "";
            String noiDung = "";
            String a = "";
            String b = "";
            String c = "";
            String d = "";
            String dapAn = "";

            //bộ đề không là khóa ngoại với bảng nào khác nên khỏi check

            //if (bindingSourceBoDe.Count > 0)
            //{
            //    MessageBox.Show("Không thể xóa giáo viên đã tạo đề", "", MessageBoxButtons.OK);
            //    return;
            //}
            //if (bindingSourceGiaoVien_DangKy.Count > 0)
            //{
            //    MessageBox.Show("Không thể xóa giáo viên đã đăng kí thi", "", MessageBoxButtons.OK);
            //    return;
            //}


            int xacNhanXoa = (int)MessageBox.Show("Bạn có chắc muốn xóa câu hỏi này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanXoa == (int)DialogResult.OK)
            {
                try
                {
                    maGiaoVien = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["MAGV"].ToString();
                    //lấy thông tin câu hỏi để undo redo
                    idCauHoi = (int) ((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["CAUHOI"];
                    maMonHoc = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["MAMH"].ToString();
                    trinhDo = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["TRINHDO"].ToString();
                    noiDung = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["NOIDUNG"].ToString();
                    a = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["A"].ToString();
                    b = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["B"].ToString();
                    c = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["C"].ToString();
                    d = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["D"].ToString();
                    dapAn = (String)((DataRowView)bindingSourceBoDe[bindingSourceBoDe.Position])["DAP_AN"].ToString();

                    bindingSourceBoDe.RemoveCurrent();
                    this.tableAdapterBoDe.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterBoDe.Update(this.TN_CSDLPT_DataSet.BODE);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa câu hỏi thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterBoDe.Update(this.TN_CSDLPT_DataSet.BODE);
                    bindingSourceBoDe.Position = bindingSourceBoDe.Find("CAUHOI", idCauHoi);
                    return;
                }
            }
            if (bindingSourceBoDe.Count == 0)
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
    }
}