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
            if (Program.mGroup == "TRUONG")
            {
                //chỉ trường mới có quyền xem trên cơ sở khác, nhưng ở đây false luôn vì báo cáo cả 2
                comboBoxCoSo.Enabled = false;
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
            if (this.dateEditTuNgay.Text == "")
            {
                MessageBox.Show("Hãy nhập ngày bắt đầu của khoảng thời gian muốn xem", "", MessageBoxButtons.OK);
                this.dateEditTuNgay.Focus();
                return;
            }
            if (this.dateEditDenNgay.Text == "")
            {
                MessageBox.Show("Hãy nhập ngày kết thúc của khoảng thời gian muốn xem", "", MessageBoxButtons.OK);
                this.dateEditDenNgay.Focus();
                return;
            }

            if (this.dateEditDenNgay.DateTime.Date < this.dateEditTuNgay.DateTime.Date)
            {
                MessageBox.Show("Ngày không hợp lệ", "", MessageBoxButtons.OK);
                dateEditTuNgay.Focus();
                return;
            }
            //XtraReportDSDangKyThiTracNghiem xtraReportKQThi = new XtraReportDSDangKyThiTracNghiem(
            //    this.dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
            XtraReportDSDangKyThi2CoSo xtraReportDSDKThi = new XtraReportDSDangKyThi2CoSo(
                this.dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
            xtraReportDSDKThi.labelTieuDe.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM 2 CƠ SỞ TỪ NGÀY "
                + this.dateEditTuNgay.DateTime.ToString("dd/M/yyyy")+" ĐẾN NGÀY "+ this.dateEditDenNgay.DateTime.ToString("dd/M/yyyy");

            ReportPrintTool printTool = new ReportPrintTool(xtraReportDSDKThi);
            printTool.ShowPreviewDialog();
        }
    }
}