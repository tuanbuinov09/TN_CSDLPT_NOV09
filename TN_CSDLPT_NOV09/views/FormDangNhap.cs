using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
//@author tuanbuinov09
namespace TN_CSDLPT_NOV09.views
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoiCSDLGoc() == 0)
            {
                return;
            }
            LayDanhSachPhanManh("SELECT * FROM VIEW_DS_COSO");

            //comboBoxCoSo.SelectedIndex = 0;
            Program.servername = (String)comboBoxCoSo.SelectedValue;
            radioButtonGiangVien.Select();
        }

        private void comboBoxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxCoSo.SelectedValue + "");
            Program.servername = comboBoxCoSo.SelectedValue + "";
        }

        private void LayDanhSachPhanManh(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd, conn_publisher);
            sda.Fill(dt);
            conn_publisher.Close();
            Program.bds_DanhSachPhanManh.DataSource = dt;
            comboBoxCoSo.DataSource = Program.bds_DanhSachPhanManh;
            comboBoxCoSo.DisplayMember = "TENCS";
            comboBoxCoSo.ValueMember = "TENSERVER";
        }

        private int KetNoiCSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại username và password.","", MessageBoxButtons.OK);
            }
            return 0;
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text.Trim() == "" || textBoxMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được bỏ trống", "", MessageBoxButtons.OK);
                return;
            }
            // lấy mã cơ sở
            // lấy vị trí của mã đã chọn trên combobox
            Program.maCoSo = comboBoxCoSo.Text.Split('-')[0].ToString().Trim();
            Program.indexCoSo = comboBoxCoSo.SelectedIndex;

            if (radioButtonGiangVien.Checked)
            {
                Program.mlogin = textBoxTenDangNhap.Text.Trim();
                Program.password = textBoxMatKhau.Text.Trim();
                if (Program.KetNoi() == 0)
                {
                    return;
                }
               
                Program.mLoginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                String strLenh = "EXEC SP_LAY_TT_GIANGVIEN_LOGIN '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);

                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản bạn dùng không có quyền truy cập dữ liệu\nXem lại tên đăng nhập và mật khẩu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoTen = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                Program.formChinh.toolStripMaUser.Text = Program.username;
                Program.formChinh.toolStripHoTen.Text = Program.mHoTen;
                Program.formChinh.toolStripNhomPhanQuyen.Text = Program.mGroup;
            }
            if (radioButtonSinhVien.Checked)
            {
                Program.mlogin = "sv_dungchung";
                Program.password = "123";
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                Program.mLoginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                String strLenh = "EXEC SP_LAY_TT_SV '" 
                    + textBoxTenDangNhap.Text.Trim() + "', '"+textBoxMatKhau.Text.Trim()+"'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);

                if (Program.myReader == null)
                {
                    return;
                }

                Program.myReader.Read();

                //Program.username = Program.myReader.GetString(0);
                try
                {
                    Program.maSinhVien = Program.myReader.GetString(0);
                    Program.mHoTen = Program.myReader.GetString(1);
                    Program.maLop = Program.myReader.GetString(2);
                    Program.tenLop = Program.myReader.GetString(3);
                    Program.mGroup = "SINHVIEN";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đăng nhập không thành công, xem lại mã sinh viên và mật khẩu:" ,"Lỗi", MessageBoxButtons.OK);
                    return;
                }

                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản bạn dùng không có quyền truy cập dữ liệu\nXem lại tên đăng nhập và mật khẩu", "", MessageBoxButtons.OK);
                    return;
                }

                
                Program.myReader.Close();
                Program.conn.Close();

                Program.formChinh.toolStripMaUser.Text = Program.maSinhVien;
                Program.formChinh.toolStripHoTen.Text = Program.mHoTen;
                Program.formChinh.toolStripNhomPhanQuyen.Text = Program.mGroup;
            }

            this.Hide();
            Program.formChinh.Show();
            //chạy lại để ẩn hiện các button
            Program.formChinh.FormMainLoadHandler();
        }

        private void radioButtonGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            labelTenDangNhap.Text = "Tên đăng nhập";
        }

        private void radioButtonSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            labelTenDangNhap.Text = "Mã sinh viên";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }

}