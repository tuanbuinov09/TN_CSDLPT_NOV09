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
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;

namespace TN_CSDLPT_NOV09.views
{
    public partial class FormRpKetQuaThi : DevExpress.XtraEditors.XtraForm
    {
        public FormRpKetQuaThi()
        {
            InitializeComponent();
        }
        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void FormRpKetQuaThi_Load(object sender, EventArgs e)
        {
            TN_CSDLPT_DataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);
            // TODO: This line of code loads data into the 'TN_CSDLPT_DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSinhVien.Fill(this.TN_CSDLPT_DataSet.SINHVIEN);

            laycomboboxSinhVien("SELECT MASV, HOTEN = CONCAT(TRIM(HO), ' ', TRIM(TEN), ' / ', TRIM(MALOP)) FROM SINHVIEN");
            laycomboboxmonhoc("SELECT MAMH, TENMH = CONCAT(TRIM(MAMH), ' - ', TRIM(TENMH)) FROM MONHOC");

            if (Program.mGroup == "SINHVIEN")
            {
                comboBoxMaSinhVien.SelectedValue = Program.maSinhVien.Trim();
                comboBoxMaSinhVien.Enabled = false;
            }

            //load dữ liệu vào combobox cơ sở
            comboBoxCoSo.DataSource = Program.bds_DanhSachPhanManh;
            comboBoxCoSo.DisplayMember = "TENCS";
            comboBoxCoSo.ValueMember = "TENSERVER";
            comboBoxCoSo.SelectedIndex = Program.indexCoSo;

            //chỉ trường mới có quyền xem trên cơ sở khác
            
            if (Program.mGroup == "TRUONG")
            {
                comboBoxCoSo.Enabled = true;
            }
            else
            {
                comboBoxCoSo.Enabled = false;

            }
        }
        void laycomboboxmonhoc(string cmd)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = Program.conn; //database connection
            //cmd.CommandText = "SP_LAY_DS_MONHOC"; //  Stored procedure name
            //cmd.CommandType = CommandType.StoredProcedure; // set it to stored proc

            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd, Program.conn);
            sda.Fill(dt);
            Program.conn.Close();
            BindingSource bdsMonHoc = new BindingSource();
            bdsMonHoc.DataSource = dt;
            comboBoxMaMonHoc.DataSource = bdsMonHoc;
            comboBoxMaMonHoc.DisplayMember = "TENMH";
            comboBoxMaMonHoc.ValueMember = "MAMH";
        }
        void laycomboboxSinhVien(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd, Program.conn);
            sda.Fill(dt);
            Program.conn.Close();
            BindingSource bdsMonHoc = new BindingSource();
            bdsMonHoc.DataSource = dt;
            comboBoxMaSinhVien.DataSource = bdsMonHoc;
            comboBoxMaSinhVien.DisplayMember = "HOTEN";
            comboBoxMaSinhVien.ValueMember = "MASV";
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
                this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
                this.tableAdapterSinhVien.Fill(this.TN_CSDLPT_DataSet.SINHVIEN);
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
                //vif môn học nhân bản nên khi chuyển cơ sở dữ liệu trong combobox cũng k thay đổi
                //this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                //this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);
                laycomboboxSinhVien("SELECT MASV, HOTEN = CONCAT(TRIM(HO), ' ', TRIM(TEN), ' / ', TRIM(MALOP)) FROM SINHVIEN");
                laycomboboxmonhoc("SELECT MAMH, TENMH = CONCAT(TRIM(MAMH), ' - ', TRIM(TENMH)) FROM MONHOC");
                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            String hoTenSinhVien = "";
            String tenLop = "";
            String daThi = "";
            String strLenh = "EXEC SP_REPORT_KETQUATHI_THONGTIN_SINHVIEN '" + comboBoxMaSinhVien.SelectedValue.ToString() + "', '" +
            comboBoxMaMonHoc.SelectedValue.ToString() + "', " + spinEditLan.Value;
           
            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                hoTenSinhVien = Program.myReader.GetString(1).Trim();
                tenLop = Program.myReader.GetString(0).Trim();
                daThi = Program.myReader.GetString(2).Trim();

                if (daThi == "")
                {
                    MessageBox.Show("Sinh viên chưa thi lần "+ spinEditLan.Value +" của môn này");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả thi");
                return;
            }
            finally
            {
                Program.myReader.Close();
                Program.conn.Close();
            }
            // nếu không bận lỗi gì:
            XtraReportKetQuaThi xtraReportKQThi = new XtraReportKetQuaThi(comboBoxMaSinhVien.SelectedValue.ToString().Trim()
                                                              , comboBoxMaMonHoc.SelectedValue.ToString().Trim()
                                                              , Decimal.ToInt16(spinEditLan.Value));
            xtraReportKQThi.labelTieuDe.Text = "KẾT QUẢ THI MÔN " + this.comboBoxMaMonHoc.Text.Trim() + " CỦA SINH VIÊN " + hoTenSinhVien;
            xtraReportKQThi.xrLabelHoTen.Text = hoTenSinhVien;
            xtraReportKQThi.xrLabelLop.Text = tenLop;

            xtraReportKQThi.xrLabelNgayThi.Text = DateTime.Now.ToString("dd/MM/yyyy") /*+ "cần hỏi thầy ngày là lấy ngày của gv đăng kí?"*/;
            xtraReportKQThi.xrLabelMonThi.Text = this.comboBoxMaMonHoc.Text.Trim();
            xtraReportKQThi.xrLabelLan.Text = this.spinEditLan.Value.ToString();

            ReportPrintTool printTool = new ReportPrintTool(xtraReportKQThi);
            printTool.ShowPreviewDialog();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}