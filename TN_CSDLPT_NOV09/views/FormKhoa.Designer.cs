namespace TN_CSDLPT_NOV09.views
{
    partial class FormKhoa
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoa));
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
            this.bindingSourceKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterKhoa = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager();
            this.tableAdapterGiaoVien = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterLop = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.LOPTableAdapter();
            this.gridControlKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridViewKhoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControlNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.textBoxMaCoSo = new DevExpress.XtraEditors.TextEdit();
            this.textBoxTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.textBoxMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.bindingSourceLop = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).BeginInit();
            this.panelControlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaCoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(31, 38);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(51, 13);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "Mã khoa:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(31, 74);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(55, 13);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "Tên khoa:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(31, 110);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(53, 13);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "Mã cơ sở:";
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
            this.barButtonThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonThoat_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControl1.Appearance.Options.UseFont = true;
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(784, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 495);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 455);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(784, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 455);
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
            this.panelControl1.Size = new System.Drawing.Size(784, 38);
            this.panelControl1.TabIndex = 16;
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
            // bindingSourceKhoa
            // 
            this.bindingSourceKhoa.DataMember = "KHOA";
            this.bindingSourceKhoa.DataSource = this.TN_CSDLPT_DataSet;
            // 
            // tableAdapterKhoa
            // 
            this.tableAdapterKhoa.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.tableAdapterGiaoVien;
            this.tableAdapterManager.KHOATableAdapter = this.tableAdapterKhoa;
            this.tableAdapterManager.LOPTableAdapter = this.tableAdapterLop;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterGiaoVien
            // 
            this.tableAdapterGiaoVien.ClearBeforeFill = true;
            // 
            // tableAdapterLop
            // 
            this.tableAdapterLop.ClearBeforeFill = true;
            // 
            // gridControlKhoa
            // 
            this.gridControlKhoa.DataSource = this.bindingSourceKhoa;
            this.gridControlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlKhoa.Location = new System.Drawing.Point(0, 78);
            this.gridControlKhoa.MainView = this.gridViewKhoa;
            this.gridControlKhoa.MenuManager = this.barManager1;
            this.gridControlKhoa.Name = "gridControlKhoa";
            this.gridControlKhoa.Size = new System.Drawing.Size(784, 220);
            this.gridControlKhoa.TabIndex = 17;
            this.gridControlKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKhoa});
            // 
            // gridViewKhoa
            // 
            this.gridViewKhoa.GridControl = this.gridControlKhoa;
            this.gridViewKhoa.Name = "gridViewKhoa";
            // 
            // panelControlNhapLieu
            // 
            this.panelControlNhapLieu.Controls.Add(mACSLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxMaCoSo);
            this.panelControlNhapLieu.Controls.Add(tENKHLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxTenKhoa);
            this.panelControlNhapLieu.Controls.Add(mAKHLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxMaKhoa);
            this.panelControlNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlNhapLieu.Location = new System.Drawing.Point(0, 298);
            this.panelControlNhapLieu.Name = "panelControlNhapLieu";
            this.panelControlNhapLieu.Size = new System.Drawing.Size(784, 197);
            this.panelControlNhapLieu.TabIndex = 18;
            // 
            // textBoxMaCoSo
            // 
            this.textBoxMaCoSo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceKhoa, "MACS", true));
            this.textBoxMaCoSo.Location = new System.Drawing.Point(111, 107);
            this.textBoxMaCoSo.MenuManager = this.barManager1;
            this.textBoxMaCoSo.Name = "textBoxMaCoSo";
            this.textBoxMaCoSo.Size = new System.Drawing.Size(169, 20);
            this.textBoxMaCoSo.TabIndex = 5;
            // 
            // textBoxTenKhoa
            // 
            this.textBoxTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceKhoa, "TENKH", true));
            this.textBoxTenKhoa.Location = new System.Drawing.Point(111, 71);
            this.textBoxTenKhoa.MenuManager = this.barManager1;
            this.textBoxTenKhoa.Name = "textBoxTenKhoa";
            this.textBoxTenKhoa.Size = new System.Drawing.Size(169, 20);
            this.textBoxTenKhoa.TabIndex = 3;
            // 
            // textBoxMaKhoa
            // 
            this.textBoxMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceKhoa, "MAKH", true));
            this.textBoxMaKhoa.Location = new System.Drawing.Point(111, 35);
            this.textBoxMaKhoa.MenuManager = this.barManager1;
            this.textBoxMaKhoa.Name = "textBoxMaKhoa";
            this.textBoxMaKhoa.Size = new System.Drawing.Size(169, 20);
            this.textBoxMaKhoa.TabIndex = 1;
            // 
            // bindingSourceLop
            // 
            this.bindingSourceLop.DataMember = "FK_LOP_KHOA";
            this.bindingSourceLop.DataSource = this.bindingSourceKhoa;
            // 
            // bindingSourceGiaoVien
            // 
            this.bindingSourceGiaoVien.DataMember = "FK_GIAOVIEN_KHOA";
            this.bindingSourceGiaoVien.DataSource = this.bindingSourceKhoa;
            // 
            // FormKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.panelControlNhapLieu);
            this.Controls.Add(this.gridControlKhoa);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormKhoa";
            this.Text = "FormKhoa";
            this.Load += new System.EventHandler(this.FormKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).EndInit();
            this.panelControlNhapLieu.ResumeLayout(false);
            this.panelControlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaCoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVien)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceKhoa;
        private TN_CSDLPT_DataSet TN_CSDLPT_DataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBoxCoSo;
        private System.Windows.Forms.Label label1;
        private TN_CSDLPT_DataSetTableAdapters.KHOATableAdapter tableAdapterKhoa;
        private TN_CSDLPT_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControlKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKhoa;
        private DevExpress.XtraEditors.PanelControl panelControlNhapLieu;
        private DevExpress.XtraEditors.TextEdit textBoxMaCoSo;
        private DevExpress.XtraEditors.TextEdit textBoxTenKhoa;
        private DevExpress.XtraEditors.TextEdit textBoxMaKhoa;
        private TN_CSDLPT_DataSetTableAdapters.LOPTableAdapter tableAdapterLop;
        private System.Windows.Forms.BindingSource bindingSourceLop;
        private TN_CSDLPT_DataSetTableAdapters.GIAOVIENTableAdapter tableAdapterGiaoVien;
        private System.Windows.Forms.BindingSource bindingSourceGiaoVien;
    }
}