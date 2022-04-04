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
    public partial class FormChonMonThi : DevExpress.XtraEditors.XtraForm
    {
        public FormChonMonThi()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPT_DataSet);

        }

        private void FormChonMonThi_Load(object sender, EventArgs e)
        {
            this.label7.Text = Program.mHoTen;
            this.label6.Text = Program.maSinhVien;
            this.label8.Text = Program.maLop;
            this.label9.Text = Program.tenLop;

            this.tN_CSDLPT_DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPT_DataSet.MONHOC);

            spinEditSoCauThi.Enabled = spinEditThoiGian.Enabled = comboBoxTrinhDo.Enabled = buttonBatDauThi.Enabled = false;
        }

        private void buttonTimMonThi_Click(object sender, EventArgs e)
        {
            String strLenh = "EXEC SP_TIM_MONTHI '"+ mAMHComboBox.SelectedValue.ToString()+"', '"+ 
             nGAYTHIDateEdit.DateTime.ToString("yyyy-MM-dd") + "', "+spinEditLan.Value;
            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy môn thi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                Program.myReader.Close();
                Program.conn.Close();
                return;
            }
                try
                {
                    this.spinEditSoCauThi.Value = Program.myReader.GetInt16(3);
                    this.comboBoxTrinhDo.Text = Program.myReader.GetString(4).ToString();
                    this.spinEditThoiGian.Value = Program.myReader.GetInt16(5);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy");
                    buttonBatDauThi.Enabled = false;
                    Program.myReader.Close();
                    Program.conn.Close();
                return;
                }

                Program.myReader.Close();
                Program.conn.Close();

                buttonBatDauThi.Enabled = true;
            
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sOCAUTHILabel_Click(object sender, EventArgs e)
        {

        }

        private void tRINHDOLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonBatDauThi_Click(object sender, EventArgs e)
        {

            CauHoi ch = new CauHoi();
            ch.CauA = "CAu a";
            ch.CauB = "CAu b";
            ch.CauC = "CAu c";
            ch.CauD = "CAu d";
            ch.NDCauHoi = "cau hoi1";
            ch.CauSo = 1;
            flowLayoutPanel1.Controls.Add(ch);

            CauHoi ch2 = new CauHoi();
            ch2.CauA = "CAu a";
            ch2.CauB = "CAu b";
            ch2.CauC = "CAu c";
            ch2.CauD = "CAu d";
            ch2.NDCauHoi = "cau hoi2";
            ch2.CauSo = 1;
            flowLayoutPanel1.Controls.Add(ch2);

            CauHoi ch3 = new CauHoi();
            ch3.CauA = "CAu a";
            ch3.CauB = "CAu b";
            ch3.CauC = "CAu c";
            ch3.CauD = "CAu d";
            ch3.NDCauHoi = "cau hoi 3";
            ch3.CauSo = 1;
            flowLayoutPanel1.Controls.Add(ch3);
        }
    }
}