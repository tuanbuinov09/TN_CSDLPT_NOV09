using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TN_CSDLPT_NOV09.views;
namespace TN_CSDLPT_NOV09
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Form frm = this.CheckExists(typeof(FormDangNhap));
            //if (frm != null) frm.Activate();
            //else
            //{
            //    FormDangNhap f = new FormDangNhap();
            //    f.MdiParent = this;
            //    f.Show();
            //}


            //nếu là quyền cơ sở tất cả đều enable
            this.ribbonPageQuanLy.Visible = true;
            this.ribbonPageGroupDangKy.Visible = true;
            this.ribbonPageBoDe.Visible = true;
            this.ribbonPageGroupGiaoVien_DangKy.Visible = true;
            this.ribbonPageGroupVaoThi.Visible = true;

            if (Program.mGroup == "SINHVIEN")
            {
                this.ribbonPageQuanLy.Visible = false;
                this.ribbonPageGroupDangKy.Visible = false;
                this.ribbonPageBoDe.Visible = false;
                this.ribbonPageGroupGiaoVien_DangKy.Visible = false;
                this.ribbonPageGroupVaoThi.Visible = true;

                return;
            }
            if (Program.mGroup == "GIANGVIEN")
            {
                this.ribbonPageGroupDangKy.Visible = false;

                return;
            }

            if (Program.mGroup == "TRUONG")
            {

                this.ribbonPageGroupVaoThi.Visible = false;

                return;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barButtonDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        //private void showFormDangNhapTrenFormMain()
        //{
        //    Form frm = this.CheckExists(typeof(FormDangNhap));
        //    if (frm != null) frm.Activate();
        //    else
        //    {
        //        FormDangNhap f = new FormDangNhap();
        //        f.MdiParent = this;
        //        f.Show();
        //    }
        //}
        private void barButtonQuanLyMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (Program.mGroup == "")
            //{
            //    showFormDangNhap();
            //    return;
            //}
            Form frm = this.CheckExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormMonHoc f = new FormMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // lặp qua các form đang mở trên mdi và đóng tất
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }

            Program.username = "";
            Program.maSinhVien = "";
            Program.mHoTen = "";
            Program.mGroup = "";
            Program.mlogin = "";
            Program.password = "";
            //Program.mLoginDN = "";
            //Program.passwordDN = "";
            //Program.conn.Close();
            this.Hide();
            Program.formDangNhap.textBoxMatKhau.Text = "";
            Program.formDangNhap.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonQuanLyGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                FormGiaoVien f = new FormGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonQuanLyCauHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBoDe));
            if (frm != null) frm.Activate();
            else
            {
                FormBoDe f = new FormBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonQuanLyKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKhoa));
            if (frm != null) frm.Activate();
            else
            {
                FormKhoa f = new FormKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonQuanLyLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                FormLop f = new FormLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonQuanLySinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                FormSinhVien f = new FormSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonGiaoVien_DangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGiaoVienDangKy));
            if (frm != null) frm.Activate();
            else
            {
                FormGiaoVienDangKy f = new FormGiaoVienDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormThi));
            if (frm != null) frm.Activate();
            else
            {
                FormThi f = new FormThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonXemKetQuaThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XtraReportKetQuaThi xtraReportKQThi = new XtraReportKetQuaThi("001"
            //                                                   , "MMTCB"
            //                                                   , 1);
            //ReportPrintTool printTool = new ReportPrintTool(xtraReportKQThi);
            //printTool.ShowPreviewDialog();

            Form frm = this.CheckExists(typeof(FormRpKetQuaThi));
            if (frm != null) frm.Activate();
            else
            {
                FormRpKetQuaThi f = new FormRpKetQuaThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonXemBangDiemMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormRpBangDiemMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormRpBangDiemMonHoc f = new FormRpBangDiemMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
