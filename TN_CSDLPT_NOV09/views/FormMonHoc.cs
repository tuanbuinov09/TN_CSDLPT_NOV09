using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace TN_CSDLPT_NOV09.views
{
    public partial class FormMonHoc : DevExpress.XtraEditors.XtraForm
    {
        ArrayList undoCommands = new ArrayList();
        //ArrayList redoCommands = new ArrayList();
        String mode = "";
        int vitri = -1;
        String maCoSo;

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
            comboBoxCoSo.SelectedIndex = Program.indexCoSo;

            if (Program.mGroup == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
            }
            else
            {
                comboBoxCoSo.Enabled = false;
            }

            if (Program.mGroup == "TRUONG"|| Program.mGroup == "GIANGVIEN"|| Program.mGroup == "SINHVIEN")
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
                // nếu trong dữ liệu k có dòng nào disable nút thêm xóa
                if (bindingSourceMonHoc.Count == 0)
                {
                    barButtonSua.Enabled = barButtonXoa.Enabled = false;
                }
                barButtonHuy.Enabled = false;
            }
            panelControlNhapLieu.Enabled = false;

        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "them";
            vitri = bindingSourceMonHoc.Position;
            panelControlNhapLieu.Enabled = true;
            bindingSourceMonHoc.AddNew();

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonHuy.Enabled = true;
            barButtonReload.Enabled = false;
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
            textBoxMaMonHoc.Enabled = true;
            gridControlMonHoc.Enabled = false;
        }
        
        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = "sua";
            vitri = bindingSourceMonHoc.Position;
            panelControlNhapLieu.Enabled = true;

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled = barButtonThoat.Enabled = false;
            barButtonGhi.Enabled = true;
            barButtonReload.Enabled = false;
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

            textBoxMaMonHoc.Enabled = false;
            gridControlMonHoc.Enabled = false;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceMonHoc.CancelEdit();
            if (mode == "them")
            {
                //xóa cái dòng được tạo từ bindingSource.addNew khi ấn thêm trên gridview
                gridViewMonHoc.DeleteRow(gridViewMonHoc.FocusedRowHandle);
            }
            bindingSourceMonHoc.Position = vitri;
            panelControlNhapLieu.Enabled = false;
            gridControlMonHoc.Enabled = true;

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
            mode = "xoa";
            String maMonHoc = "";
            String tenMonHoc = "";
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
            if(xacNhanXoa == (int) DialogResult.OK)
            {
                try
                {
                    maMonHoc = (String)((DataRowView)bindingSourceMonHoc[bindingSourceMonHoc.Position])["MAMH"].ToString();
                    //lấy tên môn học để undo redo
                    tenMonHoc = (String)((DataRowView)bindingSourceMonHoc[bindingSourceMonHoc.Position])["TENMH"].ToString(); 
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
            undoCommands.Add("EXEC SP_THEM_MONHOC '" + maMonHoc + "','" + tenMonHoc + "'");

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
            String tenMonHocLucChuaSua = "";
            if (mode == "sua")
            {
                tenMonHocLucChuaSua = (String)((DataRowView)bindingSourceMonHoc[bindingSourceMonHoc.Position])["TENMH"].ToString();
            }
            String maMonHoc = textBoxMaMonHoc.Text.Trim();
            //String tenMonHocLucChuaSua  = (String)((DataRowView)bindingSourceMonHoc[bindingSourceMonHoc.Position])["TENMH"].ToString();
            String tenMonHocChuanBiSua = textBoxTenMonHoc.Text.Trim();
            if (maMonHoc == "")
            {
                MessageBox.Show("Mã môn học không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxMaMonHoc.Focus();
                return;
            }
            // lưu ý tenMonHocChuanBiSua cũng là chuẩn bị thêm
            if (tenMonHocChuanBiSua == "")
            {
                MessageBox.Show("Tên môn học không được bỏ trống", "", MessageBoxButtons.OK);
                textBoxMaMonHoc.Focus();
                return;
            }

            //check trùng mã môn học khi thêm
            if (mode == "them")
            {
                String strLenh = "EXEC SP_KT_MONHOC_DATONTAI '" + maMonHoc + "', N'"+tenMonHocChuanBiSua+"', 'KTRATHEM'";

                int kq = Program.ExecSqlNonQuery(strLenh);
                //lỗi mã môn
                if (kq == 1)
                {
                    textBoxMaMonHoc.Focus();
                    return;
                }
                // lỗi tên môn
                if(kq == 2)
                {
                    textBoxTenMonHoc.Focus();
                    return;
                }
            }
            if (mode == "sua")
            {
                String strLenh = "EXEC SP_KT_MONHOC_DATONTAI '" + maMonHoc + "', N'" + tenMonHocChuanBiSua + "', 'KTRASUA'";

                int kq = Program.ExecSqlNonQuery(strLenh);
                //lỗi mã môn
                //if (kq == 1)
               // {
               //     textBoxMaMonHoc.Focus();
               //     return;
                //}
                // lỗi tên môn
                if (kq == 2)
                {
                    textBoxTenMonHoc.Focus();
                    return;
                }
            }
            try
            {
                bindingSourceMonHoc.EndEdit();
                bindingSourceMonHoc.ResetCurrentItem();
                this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                return;
            }

            // nếu là thêm thì khi undo (xóa nó đi) thì lấy mã của nó trên bảng để sau quay trở về
            if (mode == "them")
            {
                undoCommands.Add("EXEC SP_XOA_MONHOC '" + maMonHoc + "'");
            }
            if (mode == "sua")
            {
                undoCommands.Add("EXEC SP_SUA_MONHOC '" + maMonHoc + "', N'" + tenMonHocLucChuaSua + "'");
            }
            
            mode = "";

            panelControlNhapLieu.Enabled = false;
            gridControlMonHoc.Enabled = true;

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

        private void barButtonPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strLenh = (String) undoCommands[undoCommands.Count-1];

            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
            }catch(Exception ex)
            {
                MessageBox.Show("Không thể phục hồi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                Program.myReader.Close();
                Program.conn.Close();
                return;
            }

            // lấy ra mã môn học bị ảnh hưởng khi undo 
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
                this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                //this.tableAdapterMonHoc.Update(this.TN_CSDLPT_DataSet.MONHOC);
                tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
            
            // chuyển dòng được chọn trên gridview thành dòng có mã bị ảnh hưởng (affected_id)
            if (affected_id != "" || affected_id != null)
            {
               int row = gridViewMonHoc.LocateByValue("MAMH" ,affected_id);
               //gridViewMonHoc.FocusedRowHandle = row; 
               bindingSourceMonHoc.Position = bindingSourceMonHoc.Find("MAMH", affected_id);
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