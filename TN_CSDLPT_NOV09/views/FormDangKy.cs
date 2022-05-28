using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT_NOV09
{
    public partial class FormDangKy : DevExpress.XtraEditors.XtraForm
    {
        private int check = 0;
        private string sugs = "";

        public FormDangKy()
        {
            InitializeComponent();
        }

        private String SuggestString(String id)
        {
           

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở ", "", MessageBoxButtons.OK);
                
            }
            String cmd = "Select MAKH, HoTen = (select Ho +' '+ Ten from GIAOVIEN where MAGV='" + id + "') from GIAOVIEN where MAGV='" + id + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            Program.myReader.Read();
            
            String infor=" ";

            if(Program.myReader.HasRows)
            {
                if (!(Program.myReader.IsDBNull(0) && Program.myReader.IsDBNull(1)))
                {
                    infor = id + "-" + Program.myReader.GetString(1) + "-" + Program.myReader.GetString(0);
        
                }
            }
            else
            {
                
                if(check==0)
                {
                    MessageBox.Show("Không có dữ liệu", "", MessageBoxButtons.OK);
                    button1.Enabled = false;
                }
                else if(check==1)
                {
                    button1.Enabled = true;
                }
                    
                
            }

            Program.myReader.Close();
           
            return infor;
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

            button1.Enabled = false;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "value";

            barButtonThem.Enabled = barButtonSua.Enabled = barButtonXoa.Enabled
                  = barButtonGhi.Enabled = barButtonPhucHoi.Enabled = barButtonHuy.Enabled = false;

            var items = new[] {
                new { Text = "Trường", Value = "TRUONG" },
                    
                };
            var items2 = new[] {
                new { Text = "Cơ sở", Value = "COSO" },
                new { Text = "Giảng viên", Value = "GIANGVIEN" },
                };
            if(Program.mGroup == "TRUONG")
            {
                comboBox1.DataSource = items;
            }
            else if(Program.mGroup =="COSO")
            {
                comboBox1.DataSource = items2;
            }
            
            comboBox1.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (loginText.Text.Trim() =="" || passText.Text.Trim()==""||userText.Text.Trim()=="")
            {
                MessageBox.Show("Không được bỏ trống các form trên", "", MessageBoxButtons.OK);
                return;
            }
            String loginName = loginText.Text;
            String pass = passText.Text;
            String username = userText.Text.Split('-')[0].ToString().Trim();
            String role = comboBox1.SelectedValue.ToString();
          
            String cmdCheckUser = "select * from sys.sysusers where name='"+username+"'";
            Program.myReader.Close();
            Program.myReader = Program.ExecSqlDataReader(cmdCheckUser);

            Program.myReader.Read();
            if (Program.myReader.HasRows)
            {
                Program.myReader.Close();
                MessageBox.Show("Giáo viên này đã có tài khoản login trong hệ thống", "", MessageBoxButtons.OK);
                return;
            }
            else
            {

                Program.myReader.Close();
                String cmdCheckLogin = "select * from sys.syslogins where name = '"+loginName+"'";
                Program.myReader = Program.ExecSqlDataReader(cmdCheckLogin);
                Program.myReader.Read();
                if(Program.myReader.HasRows)
                {
                    Program.myReader.Close();
                    MessageBox.Show("Tên login đã được sử dụng, vui lòng chọn tên khác", "", MessageBoxButtons.OK);
                    
                }
                else
                {

                    String cmd = "EXEC SP_TAOLOGIN '" + loginName + "', '" + pass + "', '" + username + "', '" + role + "'";
                    Program.myReader.Close();

                    Program.ExecSqlNonQuery(cmd);

                    MessageBox.Show("Đăng ký thành công", "", MessageBoxButtons.OK);
                }
                Program.myReader.Close();

            }
         



        }

        private void userText_TextChanged(object sender, EventArgs e)
        {
           
            TextBox t = sender as TextBox;
            if (t.Text == sugs)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
            if (t != null)
            {
               
                //say you want to do a search when user types 3 or more chars
                if (t.Text.Length > 4)
                {
                    //SuggestStrings will have the logic to return array of strings either from cache/db
                    sugs = SuggestString(t.Text.ToUpper());

                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    collection.Add(sugs);

                    this.userText.AutoCompleteCustomSource = collection;
                    userText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    userText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    
                }
            }
        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}