using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_NOV09
{
    public partial class XtraReportBangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBangDiemMonHoc()
        {
            InitializeComponent();
        }

        public XtraReportBangDiemMonHoc(String maLop, String maMonHoc, int lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMonHoc;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
