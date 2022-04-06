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
using System.Timers;
using System.Data.SqlClient;

namespace TN_CSDLPT_NOV09.views
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        public static List<CauHoi> listCauHoi = new List<CauHoi>();
        System.Timers.Timer timer;
        int h, m, s;

        //mỗi khi chọn hay chọn lại đáp án thay đổi vào list câu hỏi
        public static void thayDoiChonDapAn(int cauSo, string dapAnDaChon, int idDe)
        {
            int index = listCauHoi.FindIndex(item => item.CauSo == cauSo);
            listCauHoi[index].CauDaChon = dapAnDaChon; 
        }

        public FormThi()
        {
            InitializeComponent();
        }
        
        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPT_DataSet);

        }
        
        private void FormChonMonThi_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000; //1s
            timer.Elapsed += onTimeEvent;

            this.labelHoTen.Text = Program.mHoTen;
            this.labelMaSinhVien.Text = Program.maSinhVien;
            this.labelMaLop.Text = Program.maLop;
            this.labelTenLop.Text = Program.tenLop;

            this.TN_CSDLPT_DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPT_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.TN_CSDLPT_DataSet.MONHOC);

            spinEditSoCauThi.Enabled = spinEditThoiGian.Enabled = comboBoxTrinhDo.Enabled;
            barButtonNopBai.Enabled = buttonBatDauThi.Enabled = false;
             
        }

        private Boolean kiemTraChuaChonDapAn()
        {
            String msg = "Các câu chưa chọn đáp án: ";
            foreach(CauHoi ch in listCauHoi)
            {
                if (ch.CauDaChon == "")
                {
                    msg = msg + ch.CauSo + ", ";
                }
                continue;
            }
            if(msg!= "Các câu chưa chọn đáp án: ")
            {
                MessageBox.Show(msg);
                return true;
            }
            return false;
        }

        public void themChiTietBaiThi()
        {
            string connectionString = Program.connstr;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // tạo transaction
                using (SqlTransaction trans = conn.BeginTransaction())
                {

                    SqlCommand cmd =
                    new SqlCommand(
                        "INSERT INTO CT_BAITHI (CAUSO, MASV, MAMH, LAN, CAUHOI, DACHON, DAP_AN) " +
                        " VALUES (@CAUSO, @MASV, @MAMH, @LAN, @CAUHOI, @DACHON, @DAPAN)");

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Transaction = trans;
                    cmd.Parameters.AddWithValue("@CAUSO", DbType.Int16);
                    cmd.Parameters.AddWithValue("@MASV", DbType.String);
                    cmd.Parameters.AddWithValue("@MAMH", DbType.String);
                    cmd.Parameters.AddWithValue("@LAN", DbType.Int16);
                    cmd.Parameters.AddWithValue("@CAUHOI", DbType.Int16);
                    cmd.Parameters.AddWithValue("@DACHON", DbType.String);
                    cmd.Parameters.AddWithValue("@DAPAN", DbType.String);

                    foreach (var item in listCauHoi)
                    {
                        cmd.Parameters[0].Value = item.CauSo;
                        cmd.Parameters[1].Value = Program.maSinhVien.Trim();
                        cmd.Parameters[2].Value = comboBoxMaMonHoc.SelectedValue.ToString().Trim();
                        cmd.Parameters[3].Value = Decimal.ToInt16(spinEditLan.Value);
                        cmd.Parameters[4].Value = item.IDDe;
                        cmd.Parameters[5].Value = item.CauDaChon;
                        cmd.Parameters[6].Value = item.CauDapAn;


                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                conn.Close();
            }
        }
        private void onTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (s == 0)
                {
                }
                else
                {
                    s = s - 1;
                }

                if (s == 0 && m>0)
                {
                    s = 59;
                    m = m - 1;
                }
                if (m == 0 && h>0)
                {
                    m = 59;
                    h = h - 1;
                }

                labelTimer.Caption = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

                if (h == 0 && m == 0 && s == 0)
                {
                    timer.Stop();
                    MessageBox.Show("Het me no h r: " + tinhDiem());
                }

            }));
        }

        private Boolean ghiVaoBangDiem()
        {
            String strLenh = "EXEC SP_GHI_VAO_BANGDIEM '" + labelMaSinhVien.Text.Trim() + "', '"
                + comboBoxMaMonHoc.SelectedValue.ToString().Trim() +"', "+spinEditLan.Value+", '" +dateEditNgayThi.DateTime.ToString("yyyy-dd-MM")+"', " + tinhDiem();
            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq == 1)
            {
                return false;
            }
            return true;
        }

        private double tinhDiem()
        {
            double mark = 0;
            double markPerRightAnswer = (double) 10 / Decimal.ToDouble(spinEditSoCauThi.Value);
            foreach (CauHoi ch in listCauHoi)
            {
                if(ch.CauDaChon == ch.CauDapAn)
                {
                    mark = mark + markPerRightAnswer;
                }
            }
            return mark;
        }

        private void buttonTimMonThi_Click(object sender, EventArgs e)
        {
            if(dateEditNgayThi.Text == "")
            {
                MessageBox.Show("Hãy chọn ngày thi cần tìm","Lỗi", MessageBoxButtons.OK);
                return;
            }
            String strLenh = "EXEC SP_TIM_MONTHI '"+ comboBoxMaMonHoc.SelectedValue.ToString()+"', '"+ 
             dateEditNgayThi.DateTime.ToString("yyyy-MM-dd") + "', "+spinEditLan.Value;
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

        private void buttonBatDauThi_Click(object sender, EventArgs e)
        {
            barButtonNopBai.Enabled = false;
            buttonTimMonThi.Enabled = false;

            String strLenh = "EXEC SP_KT_SINHVIEN_DATHI '" + Program.maSinhVien.Trim() + "', '"+comboBoxMaMonHoc.SelectedValue.ToString().Trim()+"', " + spinEditLan.Value;

            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq == 1)
            {
                return;
            }

            strLenh = "EXEC MY_SP_LAY_CAUHOI '" + comboBoxMaMonHoc.SelectedValue.ToString().Trim() + "', '" +
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
                    //ch.IDBaiThi = -1;
                    ch.CauSo = i;
                    ch.NDCauHoi = Program.myReader["NOIDUNG"].ToString();
                    ch.CauA = Program.myReader["A"].ToString();
                    ch.CauB = Program.myReader["B"].ToString();
                    ch.CauC = Program.myReader["C"].ToString();
                    ch.CauD = Program.myReader["D"].ToString();
                    ch.CauDapAn = Program.myReader["DAP_AN"].ToString();

                    listCauHoi.Add(ch);
                    flowLayoutPanelCauHoiThi.Enabled = true;
                    flowLayoutPanelCauHoiThi.Controls.Add(ch);

                } 

                int thoiGianGiay = Decimal.ToInt16(spinEditThoiGian.Value)*60;

                //thoiGianGiay = 20; // de test

                h = thoiGianGiay / 3600;
                thoiGianGiay = thoiGianGiay - h * 3600;
                m = thoiGianGiay / 60;
                thoiGianGiay = thoiGianGiay - m * 60;
                s = thoiGianGiay;

                timer.Start();

                buttonBatDauThi.Enabled = false;
                comboBoxMaMonHoc.Enabled = false;
                spinEditLan.Enabled = false;
                dateEditNgayThi.Enabled = false;
                barButtonNopBai.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm đủ câu hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                Program.myReader.Close();
                Program.conn.Close();
                barButtonNopBai.Enabled = false;
                comboBoxMaMonHoc.Enabled = true;
                spinEditLan.Enabled = true;
                dateEditNgayThi.Enabled = true;
                buttonBatDauThi.Enabled = false;
                buttonTimMonThi.Enabled = true;
                return;
            }
            //totalsecs = int.Parse(spinEditThoiGian.Value.ToString()) * 60;

            Program.myReader.Close();
            Program.conn.Close();
        }

        private void barButtonNopBai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //kiemTraChuaChonDapAn();
            if (kiemTraChuaChonDapAn())
            {
                return;
            }
            timer.Stop();

            themChiTietBaiThi();

            ghiVaoBangDiem();
            
            MessageBox.Show("Chúc mừng kết quả thi của bạn là: " + tinhDiem());

            barButtonNopBai.Enabled = false;
            comboBoxMaMonHoc.Enabled = true;
            spinEditLan.Enabled = true;
            dateEditNgayThi.Enabled = true;
            buttonBatDauThi.Enabled = false;
            buttonTimMonThi.Enabled = true;
            flowLayoutPanelCauHoiThi.Enabled = false;
            labelTimer.Caption = "00:00:00";
        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int xacNhanThoat = (int)MessageBox.Show("Bạn có chắc muốn thoát và tính điểm những câu đã chọn?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanThoat == (int)DialogResult.OK)
            {
                timer.Stop();
                MessageBox.Show("" + tinhDiem());
            }
             this.Dispose();
        }
    }
}