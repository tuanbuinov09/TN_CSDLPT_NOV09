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

namespace TN_CSDLPT_NOV09.views
{
    public partial class FormRpBangDiemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public FormRpBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }

        private void FormRpBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            TN_CSDLPT_DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.LOP' table. You can move, or remove it, as needed.
            this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLop.Fill(this.TN_CSDLPT_DataSet.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);

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
                // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
                //vif môn học nhân bản nên khi chuyển cơ sở dữ liệu trong combobox cũng k thay đổi
                //this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                //this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);

                //Dùng sau
                //maCoSo = ((DataRowView)bindingSourceMonHoc[0])["MACS"].ToString();
            }
        }
    }
}