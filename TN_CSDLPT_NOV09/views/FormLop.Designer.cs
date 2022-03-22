namespace TN_CSDLPT_NOV09.views
{
    partial class FormLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLop));
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonThem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TN_CSDLPT_DataSet = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSet();
            this.bindingSourceLop = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterLop = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager();
            this.gridControlLop = new DevExpress.XtraGrid.GridControl();
            this.gridViewLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControlNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.textBoxMaLop = new DevExpress.XtraEditors.TextEdit();
            this.textBoxTenLop = new DevExpress.XtraEditors.TextEdit();
            this.textBoxMaKhoa = new System.Windows.Forms.ComboBox();
            this.bindingSourceSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterSinhVien = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.SINHVIENTableAdapter();
            this.bindingSourceGiaoVien_DangKy = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterGiaoVien_DangKy = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).BeginInit();
            this.panelControlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVien_DangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonThem,
            this.barButtonSua,
            this.barButtonGhi,
            this.barButtonXoa,
            this.barButtonPhucHoi,
            this.barButtonReload,
            this.barButtonThoat,
            this.barButtonItem1,
            this.barButtonHuy});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonThem
            // 
            this.barButtonThem.Caption = "Thêm";
            this.barButtonThem.Id = 0;
            this.barButtonThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonThem.ImageOptions.Image")));
            this.barButtonThem.Name = "barButtonThem";
            this.barButtonThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonThem_ItemClick);
            // 
            // barButtonSua
            // 
            this.barButtonSua.Caption = "Chỉnh sửa";
            this.barButtonSua.Id = 1;
            this.barButtonSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSua.ImageOptions.Image")));
            this.barButtonSua.Name = "barButtonSua";
            this.barButtonSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSua_ItemClick);
            // 
            // barButtonGhi
            // 
            this.barButtonGhi.Caption = "Ghi";
            this.barButtonGhi.Id = 2;
            this.barButtonGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonGhi.ImageOptions.Image")));
            this.barButtonGhi.Name = "barButtonGhi";
            // 
            // barButtonXoa
            // 
            this.barButtonXoa.Caption = "Xóa";
            this.barButtonXoa.Id = 3;
            this.barButtonXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonXoa.ImageOptions.Image")));
            this.barButtonXoa.Name = "barButtonXoa";
            this.barButtonXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonXoa_ItemClick);
            // 
            // barButtonPhucHoi
            // 
            this.barButtonPhucHoi.Caption = "Phục hồi";
            this.barButtonPhucHoi.Id = 4;
            this.barButtonPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonPhucHoi.ImageOptions.Image")));
            this.barButtonPhucHoi.Name = "barButtonPhucHoi";
            // 
            // barButtonHuy
            // 
            this.barButtonHuy.Caption = "Hủy";
            this.barButtonHuy.Id = 8;
            this.barButtonHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonHuy.ImageOptions.Image")));
            this.barButtonHuy.Name = "barButtonHuy";
            // 
            // barButtonReload
            // 
            this.barButtonReload.Caption = "Reload";
            this.barButtonReload.Id = 5;
            this.barButtonReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonReload.ImageOptions.Image")));
            this.barButtonReload.Name = "barButtonReload";
            // 
            // barButtonThoat
            // 
            this.barButtonThoat.Caption = "Thoát";
            this.barButtonThoat.Id = 6;
            this.barButtonThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonThoat.ImageOptions.Image")));
            this.barButtonThoat.Name = "barButtonThoat";
            // 
            // barDockControl1
            // 
            this.barDockControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControl1.Appearance.Options.UseFont = true;
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(862, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 472);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(862, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(862, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.comboBoxCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(862, 38);
            this.panelControl1.TabIndex = 17;
            // 
            // comboBoxCoSo
            // 
            this.comboBoxCoSo.FormattingEnabled = true;
            this.comboBoxCoSo.Location = new System.Drawing.Point(90, 10);
            this.comboBoxCoSo.Name = "comboBoxCoSo";
            this.comboBoxCoSo.Size = new System.Drawing.Size(190, 21);
            this.comboBoxCoSo.TabIndex = 1;
            this.comboBoxCoSo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn cơ sở";
            // 
            // TN_CSDLPT_DataSet
            // 
            this.TN_CSDLPT_DataSet.DataSetName = "TN_CSDLPT_DataSet";
            this.TN_CSDLPT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceLop
            // 
            this.bindingSourceLop.DataMember = "LOP";
            this.bindingSourceLop.DataSource = this.TN_CSDLPT_DataSet;
            // 
            // tableAdapterLop
            // 
            this.tableAdapterLop.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.tableAdapterGiaoVien_DangKy;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.tableAdapterLop;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.tableAdapterSinhVien;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridControlLop
            // 
            this.gridControlLop.DataSource = this.bindingSourceLop;
            this.gridControlLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlLop.Location = new System.Drawing.Point(0, 78);
            this.gridControlLop.MainView = this.gridViewLop;
            this.gridControlLop.MenuManager = this.barManager1;
            this.gridControlLop.Name = "gridControlLop";
            this.gridControlLop.Size = new System.Drawing.Size(862, 220);
            this.gridControlLop.TabIndex = 18;
            this.gridControlLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLop});
            // 
            // gridViewLop
            // 
            this.gridViewLop.GridControl = this.gridControlLop;
            this.gridViewLop.Name = "gridViewLop";
            // 
            // panelControlNhapLieu
            // 
            this.panelControlNhapLieu.Controls.Add(mAKHLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxMaKhoa);
            this.panelControlNhapLieu.Controls.Add(tENLOPLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxTenLop);
            this.panelControlNhapLieu.Controls.Add(mALOPLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxMaLop);
            this.panelControlNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlNhapLieu.Location = new System.Drawing.Point(0, 298);
            this.panelControlNhapLieu.Name = "panelControlNhapLieu";
            this.panelControlNhapLieu.Size = new System.Drawing.Size(862, 174);
            this.panelControlNhapLieu.TabIndex = 19;
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(30, 28);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceLop, "MALOP", true));
            this.textBoxMaLop.Location = new System.Drawing.Point(90, 25);
            this.textBoxMaLop.MenuManager = this.barManager1;
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(190, 20);
            this.textBoxMaLop.TabIndex = 1;
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(30, 73);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(49, 13);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceLop, "TENLOP", true));
            this.textBoxTenLop.Location = new System.Drawing.Point(90, 70);
            this.textBoxTenLop.MenuManager = this.barManager1;
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(190, 20);
            this.textBoxTenLop.TabIndex = 3;
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(30, 117);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(39, 13);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MAKH:";
            // 
            // textBoxMaKhoa
            // 
            this.textBoxMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLop, "MAKH", true));
            this.textBoxMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxMaKhoa.FormattingEnabled = true;
            this.textBoxMaKhoa.Location = new System.Drawing.Point(90, 114);
            this.textBoxMaKhoa.Name = "textBoxMaKhoa";
            this.textBoxMaKhoa.Size = new System.Drawing.Size(190, 21);
            this.textBoxMaKhoa.TabIndex = 5;
            // 
            // bindingSourceSinhVien
            // 
            this.bindingSourceSinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bindingSourceSinhVien.DataSource = this.bindingSourceLop;
            // 
            // tableAdapterSinhVien
            // 
            this.tableAdapterSinhVien.ClearBeforeFill = true;
            // 
            // bindingSourceGiaoVien_DangKy
            // 
            this.bindingSourceGiaoVien_DangKy.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.bindingSourceGiaoVien_DangKy.DataSource = this.bindingSourceLop;
            // 
            // tableAdapterGiaoVien_DangKy
            // 
            this.tableAdapterGiaoVien_DangKy.ClearBeforeFill = true;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 472);
            this.Controls.Add(this.panelControlNhapLieu);
            this.Controls.Add(this.gridControlLop);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormLop";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).EndInit();
            this.panelControlNhapLieu.ResumeLayout(false);
            this.panelControlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVien_DangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonThem;
        private DevExpress.XtraBars.BarButtonItem barButtonSua;
        private DevExpress.XtraBars.BarButtonItem barButtonGhi;
        private DevExpress.XtraBars.BarButtonItem barButtonXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonPhucHoi;
        private DevExpress.XtraBars.BarButtonItem barButtonHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonReload;
        private DevExpress.XtraBars.BarButtonItem barButtonThoat;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBoxCoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceLop;
        private TN_CSDLPT_DataSet TN_CSDLPT_DataSet;
        private TN_CSDLPT_DataSetTableAdapters.LOPTableAdapter tableAdapterLop;
        private TN_CSDLPT_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControlLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLop;
        private DevExpress.XtraEditors.PanelControl panelControlNhapLieu;
        private System.Windows.Forms.ComboBox textBoxMaKhoa;
        private DevExpress.XtraEditors.TextEdit textBoxTenLop;
        private DevExpress.XtraEditors.TextEdit textBoxMaLop;
        private TN_CSDLPT_DataSetTableAdapters.SINHVIENTableAdapter tableAdapterSinhVien;
        private System.Windows.Forms.BindingSource bindingSourceSinhVien;
        private TN_CSDLPT_DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tableAdapterGiaoVien_DangKy;
        private System.Windows.Forms.BindingSource bindingSourceGiaoVien_DangKy;
    }
}