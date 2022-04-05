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
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        public FormThi()
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
            this.labelHoTen.Text = Program.mHoTen;
            this.labelMaSinhVien.Text = Program.maSinhVien;
            this.labelMaLop.Text = Program.maLop;
            this.labelTenLop.Text = Program.tenLop;

            this.tN_CSDLPT_DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_CSDLPT_DataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPT_DataSet.MONHOC);

            spinEditSoCauThi.Enabled = spinEditThoiGian.Enabled = comboBoxTrinhDo.Enabled;
            buttonNopBai.Enabled = buttonBatDauThi.Enabled = false;
             
        }

        public int totalsecs = 0;

        private void countdownTimer()
        {
            var startTime = DateTime.Now;
            var timer = new Timer() { Interval = 1000 };
            timer.Tick += (obj, args) =>
            {
                totalsecs = totalsecs - 1;
                if (totalsecs < 1)
                {
                    MessageBox.Show("HET GIO");
                    timer.Stop();
                }
                else
                {
                    labelTimer.Text =
                   (TimeSpan.FromSeconds(totalsecs) - (DateTime.Now - startTime))
                       .ToString("hh\\:mm\\:ss");
                }
            };

            timer.Start();
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
            buttonNopBai.Enabled = false;
            buttonTimMonThi.Enabled = false;

            String strLenh = "EXEC MY_SP_LAY_CAUHOI '" + mAMHComboBox.SelectedValue.ToString().Trim() + "', '" +
             comboBoxTrinhDo.Text + "', " + spinEditSoCauThi.Value;
            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                int i = 0;
                while (Program.myReader.Read())
                {
                    i = i + 1;
                    CauHoi ch = new CauHoi();
                    ch.IDDe = int.Parse(Program.myReader["CAUHOI"].ToString());
                    ch.IDBaiThi = -1;
                    ch.CauSo = i;
                    ch.NDCauHoi = Program.myReader["NOIDUNG"].ToString();
                    ch.CauA = Program.myReader["A"].ToString();
                    ch.CauB = Program.myReader["B"].ToString();
                    ch.CauC = Program.myReader["C"].ToString();
                    ch.CauD = Program.myReader["D"].ToString();
                    ch.CauDapAn = Program.myReader["DAP_AN"].ToString();

                    flowLayoutPanelCauHoiThi.Controls.Add(ch);
                }



                //totalsecs = int.Parse(spinEditThoiGian.Value.ToString()) * 60;
                totalsecs = 60;
                countdownTimer();

                mAMHComboBox.Enabled = false;
                spinEditLan.Enabled = false;
                nGAYTHIDateEdit.Enabled = false;
                buttonNopBai.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm đủ câu hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                Program.myReader.Close();
                Program.conn.Close();
                buttonNopBai.Enabled = false;
                mAMHComboBox.Enabled = true;
                spinEditLan.Enabled = true;
                nGAYTHIDateEdit.Enabled = true;
                buttonBatDauThi.Enabled = false;
                buttonTimMonThi.Enabled = true;
                return;
            }

            Program.myReader.Close();
            Program.conn.Close();

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timeSpanEditCountDown_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}