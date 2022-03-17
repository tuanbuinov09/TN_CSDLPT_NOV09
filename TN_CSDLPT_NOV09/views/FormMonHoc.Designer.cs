namespace TN_CSDLPT_NOV09.views
{
    partial class FormMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonHoc));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
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
            this.bindingSourceMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterMonHoc = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager();
            this.tableAdapterBangDiem = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.BANGDIEMTableAdapter();
            this.tableAdapterBoDe = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.BODETableAdapter();
            this.tableAdapterGiaoVienDangKy = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.monHocGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.textBoxTenMonHoc = new System.Windows.Forms.TextBox();
            this.textBoxMaMonHoc = new System.Windows.Forms.TextBox();
            this.bindingSourceGiaoVienDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceBangDiem = new System.Windows.Forms.BindingSource(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).BeginInit();
            this.panelControlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVienDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(38, 53);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(41, 13);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            mAMHLabel.Click += new System.EventHandler(this.mAMHLabel_Click);
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(38, 111);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(45, 13);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 40);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(779, 0);
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
            this.barButtonGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonGhi_ItemClick);
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
            this.barButtonPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPhucHoi_ItemClick);
            // 
            // barButtonHuy
            // 
            this.barButtonHuy.Caption = "Hủy";
            this.barButtonHuy.Id = 8;
            this.barButtonHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonHuy.ImageOptions.Image")));
            this.barButtonHuy.Name = "barButtonHuy";
            this.barButtonHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHuy_ItemClick);
            // 
            // barButtonReload
            // 
            this.barButtonReload.Caption = "Reload";
            this.barButtonReload.Id = 5;
            this.barButtonReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonReload.ImageOptions.Image")));
            this.barButtonReload.Name = "barButtonReload";
            this.barButtonReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonReload_ItemClick);
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
            this.barDockControl1.Size = new System.Drawing.Size(779, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 584);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(779, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 544);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(779, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 544);
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
            this.panelControl1.Size = new System.Drawing.Size(779, 38);
            this.panelControl1.TabIndex = 6;
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
            // bindingSourceMonHoc
            // 
            this.bindingSourceMonHoc.DataMember = "MONHOC";
            this.bindingSourceMonHoc.DataSource = this.TN_CSDLPT_DataSet;
            // 
            // tableAdapterMonHoc
            // 
            this.tableAdapterMonHoc.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.tableAdapterBangDiem;
            this.tableAdapterManager.BODETableAdapter = this.tableAdapterBoDe;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.tableAdapterGiaoVienDangKy;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.tableAdapterMonHoc;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterBangDiem
            // 
            this.tableAdapterBangDiem.ClearBeforeFill = true;
            // 
            // tableAdapterBoDe
            // 
            this.tableAdapterBoDe.ClearBeforeFill = true;
            // 
            // tableAdapterGiaoVienDangKy
            // 
            this.tableAdapterGiaoVienDangKy.ClearBeforeFill = true;
            // 
            // monHocGridControl
            // 
            this.monHocGridControl.DataSource = this.bindingSourceMonHoc;
            this.monHocGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.monHocGridControl.Location = new System.Drawing.Point(0, 78);
            this.monHocGridControl.MainView = this.gridViewMonHoc;
            this.monHocGridControl.MenuManager = this.barManager1;
            this.monHocGridControl.Name = "monHocGridControl";
            this.monHocGridControl.Size = new System.Drawing.Size(779, 220);
            this.monHocGridControl.TabIndex = 7;
            this.monHocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMonHoc});
            // 
            // gridViewMonHoc
            // 
            this.gridViewMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridViewMonHoc.GridControl = this.monHocGridControl;
            this.gridViewMonHoc.Name = "gridViewMonHoc";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // panelControlNhapLieu
            // 
            this.panelControlNhapLieu.Controls.Add(tENMHLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxTenMonHoc);
            this.panelControlNhapLieu.Controls.Add(mAMHLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxMaMonHoc);
            this.panelControlNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlNhapLieu.Location = new System.Drawing.Point(0, 298);
            this.panelControlNhapLieu.Name = "panelControlNhapLieu";
            this.panelControlNhapLieu.Size = new System.Drawing.Size(779, 286);
            this.panelControlNhapLieu.TabIndex = 8;
            // 
            // textBoxTenMonHoc
            // 
            this.textBoxTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMonHoc, "TENMH", true));
            this.textBoxTenMonHoc.Location = new System.Drawing.Point(89, 108);
            this.textBoxTenMonHoc.Name = "textBoxTenMonHoc";
            this.textBoxTenMonHoc.Size = new System.Drawing.Size(214, 21);
            this.textBoxTenMonHoc.TabIndex = 3;
            // 
            // textBoxMaMonHoc
            // 
            this.textBoxMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMonHoc, "MAMH", true));
            this.textBoxMaMonHoc.Location = new System.Drawing.Point(89, 50);
            this.textBoxMaMonHoc.Name = "textBoxMaMonHoc";
            this.textBoxMaMonHoc.Size = new System.Drawing.Size(214, 21);
            this.textBoxMaMonHoc.TabIndex = 1;
            // 
            // bindingSourceGiaoVienDangKy
            // 
            this.bindingSourceGiaoVienDangKy.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.bindingSourceGiaoVienDangKy.DataSource = this.bindingSourceMonHoc;
            // 
            // bindingSourceBoDe
            // 
            this.bindingSourceBoDe.DataMember = "FK_BODE_MONHOC";
            this.bindingSourceBoDe.DataSource = this.bindingSourceMonHoc;
            // 
            // bindingSourceBangDiem
            // 
            this.bindingSourceBangDiem.DataMember = "FK_BANGDIEM_MONHOC";
            this.bindingSourceBangDiem.DataSource = this.bindingSourceMonHoc;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 584);
            this.Controls.Add(this.panelControlNhapLieu);
            this.Controls.Add(this.monHocGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormMonHoc";
            this.Text = "FormMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).EndInit();
            this.panelControlNhapLieu.ResumeLayout(false);
            this.panelControlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVienDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonThem;
        private DevExpress.XtraBars.BarButtonItem barButtonSua;
        private DevExpress.XtraBars.BarButtonItem barButtonGhi;
        private DevExpress.XtraBars.BarButtonItem barButtonXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonPhucHoi;
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
        private System.Windows.Forms.BindingSource bindingSourceMonHoc;
        private TN_CSDLPT_DataSet TN_CSDLPT_DataSet;
        private TN_CSDLPT_DataSetTableAdapters.MONHOCTableAdapter tableAdapterMonHoc;
        private TN_CSDLPT_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl monHocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMonHoc;
        private DevExpress.XtraEditors.PanelControl panelControlNhapLieu;
        private System.Windows.Forms.TextBox textBoxTenMonHoc;
        private System.Windows.Forms.TextBox textBoxMaMonHoc;
        private TN_CSDLPT_DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tableAdapterGiaoVienDangKy;
        private System.Windows.Forms.BindingSource bindingSourceGiaoVienDangKy;
        private TN_CSDLPT_DataSetTableAdapters.BODETableAdapter tableAdapterBoDe;
        private System.Windows.Forms.BindingSource bindingSourceBoDe;
        private TN_CSDLPT_DataSetTableAdapters.BANGDIEMTableAdapter tableAdapterBangDiem;
        private System.Windows.Forms.BindingSource bindingSourceBangDiem;
        private DevExpress.XtraBars.BarButtonItem barButtonHuy;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
    }
}