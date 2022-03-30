namespace TN_CSDLPT_NOV09.views
{
    partial class FormSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSinhVien));
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
            this.bindingSourceSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterSinhVien = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager();
            this.tableAdapterBangDiem = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.BANGDIEMTableAdapter();
            this.gridControlSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControlNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxMaLop = new System.Windows.Forms.ComboBox();
            this.textBoxMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.textBoxDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.dateEditNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.textBoxTen = new DevExpress.XtraEditors.TextEdit();
            this.textBoxHo = new DevExpress.XtraEditors.TextEdit();
            this.textBoxMaSinhVien = new DevExpress.XtraEditors.TextEdit();
            this.bindingSourceBangDiem = new System.Windows.Forms.BindingSource(this.components);
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).BeginInit();
            this.panelControlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(34, 36);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(38, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(34, 70);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(228, 70);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(489, 36);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(62, 13);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(34, 110);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(489, 70);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(59, 13);
            mATKHAULabel.TabIndex = 10;
            mATKHAULabel.Text = "MATKHAU:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(489, 110);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 12;
            mALOPLabel.Text = "MALOP:";
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
            this.barDockControl1.Size = new System.Drawing.Size(873, 44);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(873, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 457);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(873, 44);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 457);
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
            this.panelControl1.Location = new System.Drawing.Point(0, 44);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(873, 38);
            this.panelControl1.TabIndex = 18;
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
            // bindingSourceSinhVien
            // 
            this.bindingSourceSinhVien.DataMember = "SINHVIEN";
            this.bindingSourceSinhVien.DataSource = this.TN_CSDLPT_DataSet;
            // 
            // tableAdapterSinhVien
            // 
            this.tableAdapterSinhVien.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.tableAdapterBangDiem;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.tableAdapterSinhVien;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterBangDiem
            // 
            this.tableAdapterBangDiem.ClearBeforeFill = true;
            // 
            // gridControlSinhVien
            // 
            this.gridControlSinhVien.DataSource = this.bindingSourceSinhVien;
            this.gridControlSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlSinhVien.Location = new System.Drawing.Point(0, 82);
            this.gridControlSinhVien.MainView = this.gridViewSinhVien;
            this.gridControlSinhVien.MenuManager = this.barManager1;
            this.gridControlSinhVien.Name = "gridControlSinhVien";
            this.gridControlSinhVien.Size = new System.Drawing.Size(873, 220);
            this.gridControlSinhVien.TabIndex = 19;
            this.gridControlSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSinhVien});
            // 
            // gridViewSinhVien
            // 
            this.gridViewSinhVien.GridControl = this.gridControlSinhVien;
            this.gridViewSinhVien.Name = "gridViewSinhVien";
            this.gridViewSinhVien.OptionsBehavior.Editable = false;
            // 
            // panelControlNhapLieu
            // 
            this.panelControlNhapLieu.Controls.Add(mALOPLabel);
            this.panelControlNhapLieu.Controls.Add(this.comboBoxMaLop);
            this.panelControlNhapLieu.Controls.Add(mATKHAULabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxMatKhau);
            this.panelControlNhapLieu.Controls.Add(dIACHILabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxDiaChi);
            this.panelControlNhapLieu.Controls.Add(nGAYSINHLabel);
            this.panelControlNhapLieu.Controls.Add(this.dateEditNgaySinh);
            this.panelControlNhapLieu.Controls.Add(tENLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxTen);
            this.panelControlNhapLieu.Controls.Add(hOLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxHo);
            this.panelControlNhapLieu.Controls.Add(mASVLabel);
            this.panelControlNhapLieu.Controls.Add(this.textBoxMaSinhVien);
            this.panelControlNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlNhapLieu.Location = new System.Drawing.Point(0, 302);
            this.panelControlNhapLieu.Name = "panelControlNhapLieu";
            this.panelControlNhapLieu.Size = new System.Drawing.Size(873, 199);
            this.panelControlNhapLieu.TabIndex = 20;
            // 
            // comboBoxMaLop
            // 
            this.comboBoxMaLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMaLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSinhVien, "MALOP", true));
            this.comboBoxMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaLop.FormattingEnabled = true;
            this.comboBoxMaLop.Location = new System.Drawing.Point(562, 107);
            this.comboBoxMaLop.Name = "comboBoxMaLop";
            this.comboBoxMaLop.Size = new System.Drawing.Size(142, 21);
            this.comboBoxMaLop.TabIndex = 13;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceSinhVien, "MATKHAU", true));
            this.textBoxMatKhau.EditValue = "123";
            this.textBoxMatKhau.Location = new System.Drawing.Point(562, 67);
            this.textBoxMatKhau.MenuManager = this.barManager1;
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(142, 20);
            this.textBoxMatKhau.TabIndex = 11;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceSinhVien, "DIACHI", true));
            this.textBoxDiaChi.Location = new System.Drawing.Point(90, 107);
            this.textBoxDiaChi.MenuManager = this.barManager1;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(274, 20);
            this.textBoxDiaChi.TabIndex = 9;
            // 
            // dateEditNgaySinh
            // 
            this.dateEditNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceSinhVien, "NGAYSINH", true));
            this.dateEditNgaySinh.EditValue = null;
            this.dateEditNgaySinh.Location = new System.Drawing.Point(562, 33);
            this.dateEditNgaySinh.MenuManager = this.barManager1;
            this.dateEditNgaySinh.Name = "dateEditNgaySinh";
            this.dateEditNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgaySinh.Size = new System.Drawing.Size(142, 20);
            this.dateEditNgaySinh.TabIndex = 7;
            // 
            // textBoxTen
            // 
            this.textBoxTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceSinhVien, "TEN", true));
            this.textBoxTen.Location = new System.Drawing.Point(264, 67);
            this.textBoxTen.MenuManager = this.barManager1;
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(100, 20);
            this.textBoxTen.TabIndex = 5;
            // 
            // textBoxHo
            // 
            this.textBoxHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceSinhVien, "HO", true));
            this.textBoxHo.Location = new System.Drawing.Point(90, 67);
            this.textBoxHo.MenuManager = this.barManager1;
            this.textBoxHo.Name = "textBoxHo";
            this.textBoxHo.Size = new System.Drawing.Size(123, 20);
            this.textBoxHo.TabIndex = 3;
            // 
            // textBoxMaSinhVien
            // 
            this.textBoxMaSinhVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceSinhVien, "MASV", true));
            this.textBoxMaSinhVien.Location = new System.Drawing.Point(90, 33);
            this.textBoxMaSinhVien.MenuManager = this.barManager1;
            this.textBoxMaSinhVien.Name = "textBoxMaSinhVien";
            this.textBoxMaSinhVien.Size = new System.Drawing.Size(274, 20);
            this.textBoxMaSinhVien.TabIndex = 1;
            // 
            // bindingSourceBangDiem
            // 
            this.bindingSourceBangDiem.DataMember = "FK_BANGDIEM_SINHVIEN1";
            this.bindingSourceBangDiem.DataSource = this.bindingSourceSinhVien;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 501);
            this.Controls.Add(this.panelControlNhapLieu);
            this.Controls.Add(this.gridControlSinhVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieu)).EndInit();
            this.panelControlNhapLieu.ResumeLayout(false);
            this.panelControlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBangDiem)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceSinhVien;
        private TN_CSDLPT_DataSet TN_CSDLPT_DataSet;
        private TN_CSDLPT_DataSetTableAdapters.SINHVIENTableAdapter tableAdapterSinhVien;
        private TN_CSDLPT_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControlNhapLieu;
        private DevExpress.XtraGrid.GridControl gridControlSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSinhVien;
        private DevExpress.XtraEditors.TextEdit textBoxMatKhau;
        private DevExpress.XtraEditors.TextEdit textBoxDiaChi;
        private DevExpress.XtraEditors.DateEdit dateEditNgaySinh;
        private DevExpress.XtraEditors.TextEdit textBoxTen;
        private DevExpress.XtraEditors.TextEdit textBoxHo;
        private DevExpress.XtraEditors.TextEdit textBoxMaSinhVien;
        private TN_CSDLPT_DataSetTableAdapters.BANGDIEMTableAdapter tableAdapterBangDiem;
        private System.Windows.Forms.BindingSource bindingSourceBangDiem;
        private System.Windows.Forms.ComboBox comboBoxMaLop;
    }
}