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

namespace TN_CSDLPT_NOV09.views
{
    public partial class FormRpDSDangKyThi : DevExpress.XtraEditors.XtraForm
    {
        public FormRpDSDangKyThi()
        {
            InitializeComponent();
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
              
            }
        }

        private void FormRpDSDangKyThi_Load(object sender, EventArgs e)
        {
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

            this.dateEditDenNgay.DateTime = DateTime.Now;
            this.dateEditTuNgay.DateTime = DateTime.Now;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            XtraReportDSDangKyThiTracNghiem xtraReportKQThi = new XtraReportDSDangKyThiTracNghiem(
                this.dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
            //xtraReportKQThi.labelTieuDe.Text = "KẾT QUẢ THI MÔN " + this.comboBoxMaMonHoc.Text.Trim() + " CỦA SINH VIÊN " + hoTenSinhVien;
            //xtraReportKQThi.xrLabelHoTen.Text = hoTenSinhVien;
            //xtraReportKQThi.xrLabelLop.Text = tenLop;

            //xtraReportKQThi.xrLabelNgayThi.Text = DateTime.Now.ToString("dd/MM/yyyy") + "cần hỏi thầy ngày là lấy ngày của gv đăng kí?";
            //xtraReportKQThi.xrLabelMonThi.Text = this.comboBoxMaMonHoc.Text.Trim();
            //xtraReportKQThi.xrLabelLan.Text = this.spinEditLan.Value.ToString();

            ReportPrintTool printTool = new ReportPrintTool(xtraReportKQThi);
            printTool.ShowPreviewDialog();
        }
    }
}