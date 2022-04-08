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
        private void tableCellLuaChon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            String luaChon = tableCellLuaChon.Text;
            String[] luaChonArray = luaChon.Split(';');
            luaChon = "";
            foreach (String luaChon1 in luaChonArray)
            {
                luaChon = luaChon + luaChon1 + Environment.NewLine;
            }
            tableCellLuaChon.Text = luaChon;
        }
    }
}
