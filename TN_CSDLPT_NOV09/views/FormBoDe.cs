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

            if (Program.mGroup == "TRUONG"||Program.mGroup=="COSO"|| Program.mGroup == "SINHVIEN")
            {
                if (Program.mGroup == "TRUONG")
                {
                    comboBoxCoSo.Enabled = true;
                }
                else
                {
                    comboBoxCoSo.Enabled = false;
                }

                barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                    = barButtonGhi.Enabled = barButtonPhucHoi.Enabled = barButtonHuy.Enabled = false;

            }// chỉ có quyền giảng viên mới đc thao tác thêm xóa sửa bộ đề
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

            //vì lúc thêm mã giáo viên lấy từ username (mã gv) bên Program.cs, 
            //và lúc sửa thì k cho sửa mã giáo viên nốt, nên ta disable nó từ đầu

            textBoxMaGiaoVien.Enabled = false;

            panelControlNhapLieu.Enabled = false;
        }

        private void tRINHDOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}