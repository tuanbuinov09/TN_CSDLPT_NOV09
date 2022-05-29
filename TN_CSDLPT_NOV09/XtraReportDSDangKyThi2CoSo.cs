using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT_NOV09
{
    public partial class XtraReportDSDangKyThi2CoSo : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportDSDangKyThi2CoSo()
        {
            InitializeComponent();
        }
        public XtraReportDSDangKyThi2CoSo(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denNgay;
            this.sqlDataSource1.Fill();
        }

    }
}
