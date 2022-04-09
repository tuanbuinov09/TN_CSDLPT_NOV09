using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_NOV09
{
    public partial class XtraReportKetQuaThi : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportKetQuaThi()
        {
            InitializeComponent();
        }
        public XtraReportKetQuaThi(String maSinhVien, String maMonHoc, int lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maSinhVien;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMonHoc;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();

        }
        //xử lý lựa chọn abcd thành các dòng trong 1 ô trong report
        private void tableCellLuaChon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // lấy nguồn sự kiện thành tablecell
            XRTableCell cell = sender as XRTableCell;
            // lấy giá trị trong cell
            String luaChon = cell.Report.GetCurrentColumnValue("LUACHON").ToString();
            // phân tách theo dấu ; (khi lấy các lựa chọn trong sql đã concat với ;)
            String[] luaChonArray = luaChon.Split(';');
            luaChon = "";
            foreach (String luaChon1 in luaChonArray)
            {
                luaChon = luaChon + luaChon1 + Environment.NewLine;
            }
            //cell.BackColor = Color.Khaki;
            cell.Text = luaChon;
        }
    }
}
