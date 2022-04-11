using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT_NOV09
{
    public partial class XtraReportDSDangKyThiTracNghiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportDSDangKyThiTracNghiem()
        {
            InitializeComponent();
        }
        public XtraReportDSDangKyThiTracNghiem(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denNgay;
            this.sqlDataSource1.Fill();
        }
    }
}
