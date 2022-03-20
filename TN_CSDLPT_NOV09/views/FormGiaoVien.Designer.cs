namespace TN_CSDLPT_NOV09.views
{
    partial class FormGiaoVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoVien));
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
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
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TN_CSDLPT_DataSet = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSet();
            this.bindingSourceGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterGiaoVien = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager();
            this.tableAdapterBoDe = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.BODETableAdapter();
            this.tableAdapterGiaoVien_DangKy = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.gridControlGiaoVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiaoVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControlNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxMaKhoa = new System.Windows.Forms.ComboBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.textBoxHo = new System.Windows.Forms.TextBox();
            this.textBoxMaGiaoVien = new System.Windows.Forms.TextBox();
            this.bindingSourceGiaoVien_DangKy = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterKhoa = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.KHOATableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).BeginInit();
            this.panelControlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVien_DangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(32, 32);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(39, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(344, 32);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(546, 32);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            tENLabel.Click += new System.EventHandler(this.tENLabel_Click);
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(344, 79);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(32, 79);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(39, 13);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "MAKH:";
            // 
            // barDockControl1
            // 
            this.barDockControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControl1.Appearance.Options.UseFont = true;
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 40);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Size = new System.Drawing.Size(879, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl2);
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
            // barDockControl2
            // 
            this.barDockControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControl2.Appearance.Options.UseFont = true;
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(879, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 672);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(879, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 632);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(879, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 632);
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
            this.panelControl1.Size = new System.Drawing.Size(879, 38);
            this.panelControl1.TabIndex = 14;
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
            // bindingSourceGiaoVien
            // 
            this.bindingSourceGiaoVien.DataMember = "GIAOVIEN";
            this.bindingSourceGiaoVien.DataSource = this.TN_CSDLPT_DataSet;
            // 
            // tableAdapterGiaoVien
            // 
            this.tableAdapterGiaoVien.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.tableAdapterBoDe;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.tableAdapterGiaoVien_DangKy;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.tableAdapterGiaoVien;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterBoDe
            // 
            this.tableAdapterBoDe.ClearBeforeFill = true;
            // 
            // tableAdapterGiaoVien_DangKy
            // 
            this.tableAdapterGiaoVien_DangKy.ClearBeforeFill = true;
            // 
            // gridControlGiaoVien
            // 
            this.gridControlGiaoVien.DataSource = this.bindingSourceGiaoVien;
            this.gridControlGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlGiaoVien.Location = new System.Drawing.Point(0, 78);
            this.gridControlGiaoVien.MainView = this.gridViewGiaoVien;
            this.gridControlGiaoVien.MenuManager = this.barManager1;
            this.gridControlGiaoVien.Name = "gridControlGiaoVien";
            this.gridControlGiaoVien.Size = new System.Drawing.Size(879, 204);
            this.gridControlGiaoVien.TabIndex = 15;
            this.gridControlGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiaoVien});
            // 
            // gridViewGiaoVien
            // 
            this.gridViewGiaoVien.GridControl = this.gridControlGiaoVien;
            this.gridViewGiaoVien.Name = "gridViewGiaoVien";
            // 
            // panelControlNhapLieu
            // 
            this.panelControlNhapLieu.Controls.Add(mAKHLabel);
            this.panelControlNhapLieu.Controls.Add(this.comboBoxMaKhoa);
            this.panelControlNhapLieu.Controls.Add(dIACHILabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxDiaChi);
            this.panelControlNhapLieu.Controls.Add(tENLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxTen);
            this.panelControlNhapLieu.Controls.Add(hOLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxHo);
            this.panelControlNhapLieu.Controls.Add(mAGVLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxMaGiaoVien);
            this.panelControlNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlNhapLieu.Location = new System.Drawing.Point(0, 282);
            this.panelControlNhapLieu.Name = "panelControlNhapLieu";
            this.panelControlNhapLieu.Size = new System.Drawing.Size(879, 390);
            this.panelControlNhapLieu.TabIndex = 16;
            // 
            // comboBoxMaKhoa
            // 
            this.comboBoxMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaoVien, "MAKH", true));
            this.comboBoxMaKhoa.FormattingEnabled = true;
            this.comboBoxMaKhoa.Location = new System.Drawing.Point(90, 76);
            this.comboBoxMaKhoa.Name = "comboBoxMaKhoa";
            this.comboBoxMaKhoa.Size = new System.Drawing.Size(190, 21);
            this.comboBoxMaKhoa.TabIndex = 9;
            this.comboBoxMaKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaKhoa_SelectedIndexChanged);
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaoVien, "DIACHI", true));
            this.textBoxDiaChi.Location = new System.Drawing.Point(397, 76);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(285, 21);
            this.textBoxDiaChi.TabIndex = 7;
            // 
            // textBoxTen
            // 
            this.textBoxTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaoVien, "TEN", true));
            this.textBoxTen.Location = new System.Drawing.Point(582, 29);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(100, 21);
            this.textBoxTen.TabIndex = 5;
            this.textBoxTen.TextChanged += new System.EventHandler(this.textBoxTen_TextChanged);
            // 
            // textBoxHo
            // 
            this.textBoxHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaoVien, "HO", true));
            this.textBoxHo.Location = new System.Drawing.Point(397, 29);
            this.textBoxHo.Name = "textBoxHo";
            this.textBoxHo.Size = new System.Drawing.Size(143, 21);
            this.textBoxHo.TabIndex = 3;
            // 
            // textBoxMaGiaoVien
            // 
            this.textBoxMaGiaoVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaoVien, "MAGV", true));
            this.textBoxMaGiaoVien.Location = new System.Drawing.Point(90, 29);
            this.textBoxMaGiaoVien.Name = "textBoxMaGiaoVien";
            this.textBoxMaGiaoVien.Size = new System.Drawing.Size(190, 21);
            this.textBoxMaGiaoVien.TabIndex = 1;
            // 
            // bindingSourceGiaoVien_DangKy
            // 
            this.bindingSourceGiaoVien_DangKy.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.bindingSourceGiaoVien_DangKy.DataSource = this.bindingSourceGiaoVien;
            // 
            // bindingSourceBoDe
            // 
            this.bindingSourceBoDe.DataMember = "FK_BODE_GIAOVIEN";
            this.bindingSourceBoDe.DataSource = this.bindingSourceGiaoVien;
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
            // FormGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 672);
            this.Controls.Add(this.panelControlNhapLieu);
            this.Controls.Add(this.gridControlGiaoVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.Name = "FormGiaoVien";
            this.Text = "FormGiaoVien";
            this.Load += new System.EventHandler(this.FormGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).EndInit();
            this.panelControlNhapLieu.ResumeLayout(false);
            this.panelControlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaoVien_DangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControl1;
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
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBoxCoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceGiaoVien;
        private TN_CSDLPT_DataSet TN_CSDLPT_DataSet;
        private TN_CSDLPT_DataSetTableAdapters.GIAOVIENTableAdapter tableAdapterGiaoVien;
        private TN_CSDLPT_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControlGiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiaoVien;
        private DevExpress.XtraEditors.PanelControl panelControlNhapLieu;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.TextBox textBoxHo;
        private System.Windows.Forms.TextBox textBoxMaGiaoVien;
        private TN_CSDLPT_DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tableAdapterGiaoVien_DangKy;
        private System.Windows.Forms.BindingSource bindingSourceGiaoVien_DangKy;
        private TN_CSDLPT_DataSetTableAdapters.BODETableAdapter tableAdapterBoDe;
        private System.Windows.Forms.BindingSource bindingSourceBoDe;
        private System.Windows.Forms.BindingSource bindingSourceKhoa;
        private TN_CSDLPT_DataSetTableAdapters.KHOATableAdapter tableAdapterKhoa;
        private System.Windows.Forms.ComboBox comboBoxMaKhoa;
    }
}