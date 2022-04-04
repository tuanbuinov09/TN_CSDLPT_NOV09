namespace TN_CSDLPT_NOV09.views
{
    partial class FormChonMonThi
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
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPT_DataSet = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSet();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager();
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.buttonBatDauThi = new System.Windows.Forms.Button();
            this.comboBoxTrinhDo = new System.Windows.Forms.ComboBox();
            this.spinEditThoiGian = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditSoCauThi = new DevExpress.XtraEditors.SpinEdit();
            this.buttonTimMonThi = new System.Windows.Forms.Button();
            this.spinEditLan = new DevExpress.XtraEditors.SpinEdit();
            this.mAMHComboBox = new System.Windows.Forms.ComboBox();
            this.nGAYTHIDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.buttonNopBai = new System.Windows.Forms.Button();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            nGAYTHILabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSoCauThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(25, 60);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(55, 13);
            nGAYTHILabel.TabIndex = 2;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(25, 23);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(41, 13);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(25, 97);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(43, 13);
            lANLabel.TabIndex = 21;
            lANLabel.Text = "Lần thi:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(23, 215);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(50, 13);
            tRINHDOLabel.TabIndex = 34;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(23, 253);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(69, 13);
            tHOIGIANLabel.TabIndex = 31;
            tHOIGIANLabel.Text = "Thời gian thi:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(23, 179);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(58, 13);
            sOCAUTHILabel.TabIndex = 29;
            sOCAUTHILabel.Text = "Số câu thi:";
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.tN_CSDLPT_DataSet;
            // 
            // tN_CSDLPT_DataSet
            // 
            this.tN_CSDLPT_DataSet.DataSetName = "TN_CSDLPT_DataSet";
            this.tN_CSDLPT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tN_CSDLPT_DataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(313, 483);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.buttonBatDauThi);
            this.panelControl4.Controls.Add(tRINHDOLabel);
            this.panelControl4.Controls.Add(this.comboBoxTrinhDo);
            this.panelControl4.Controls.Add(this.spinEditThoiGian);
            this.panelControl4.Controls.Add(this.spinEditSoCauThi);
            this.panelControl4.Controls.Add(tHOIGIANLabel);
            this.panelControl4.Controls.Add(sOCAUTHILabel);
            this.panelControl4.Controls.Add(this.buttonTimMonThi);
            this.panelControl4.Controls.Add(this.spinEditLan);
            this.panelControl4.Controls.Add(this.mAMHComboBox);
            this.panelControl4.Controls.Add(lANLabel);
            this.panelControl4.Controls.Add(mAMHLabel);
            this.panelControl4.Controls.Add(nGAYTHILabel);
            this.panelControl4.Controls.Add(this.nGAYTHIDateEdit);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 153);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(309, 328);
            this.panelControl4.TabIndex = 7;
            // 
            // buttonBatDauThi
            // 
            this.buttonBatDauThi.Enabled = false;
            this.buttonBatDauThi.Location = new System.Drawing.Point(206, 280);
            this.buttonBatDauThi.Name = "buttonBatDauThi";
            this.buttonBatDauThi.Size = new System.Drawing.Size(75, 23);
            this.buttonBatDauThi.TabIndex = 30;
            this.buttonBatDauThi.Text = "Bắt đầu thi";
            this.buttonBatDauThi.UseVisualStyleBackColor = true;
            this.buttonBatDauThi.Click += new System.EventHandler(this.buttonBatDauThi_Click);
            // 
            // comboBoxTrinhDo
            // 
            this.comboBoxTrinhDo.Enabled = false;
            this.comboBoxTrinhDo.FormattingEnabled = true;
            this.comboBoxTrinhDo.Location = new System.Drawing.Point(103, 212);
            this.comboBoxTrinhDo.Name = "comboBoxTrinhDo";
            this.comboBoxTrinhDo.Size = new System.Drawing.Size(178, 21);
            this.comboBoxTrinhDo.TabIndex = 35;
            // 
            // spinEditThoiGian
            // 
            this.spinEditThoiGian.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditThoiGian.Enabled = false;
            this.spinEditThoiGian.Location = new System.Drawing.Point(103, 250);
            this.spinEditThoiGian.Name = "spinEditThoiGian";
            this.spinEditThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditThoiGian.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEditThoiGian.Properties.MaxValue = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.spinEditThoiGian.Properties.MinValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spinEditThoiGian.Size = new System.Drawing.Size(178, 20);
            this.spinEditThoiGian.TabIndex = 33;
            // 
            // spinEditSoCauThi
            // 
            this.spinEditSoCauThi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditSoCauThi.Enabled = false;
            this.spinEditSoCauThi.Location = new System.Drawing.Point(103, 176);
            this.spinEditSoCauThi.Name = "spinEditSoCauThi";
            this.spinEditSoCauThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditSoCauThi.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEditSoCauThi.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditSoCauThi.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditSoCauThi.Size = new System.Drawing.Size(178, 20);
            this.spinEditSoCauThi.TabIndex = 32;
            // 
            // buttonTimMonThi
            // 
            this.buttonTimMonThi.Location = new System.Drawing.Point(206, 129);
            this.buttonTimMonThi.Name = "buttonTimMonThi";
            this.buttonTimMonThi.Size = new System.Drawing.Size(75, 23);
            this.buttonTimMonThi.TabIndex = 23;
            this.buttonTimMonThi.Text = "Tìm môn thi";
            this.buttonTimMonThi.UseVisualStyleBackColor = true;
            this.buttonTimMonThi.Click += new System.EventHandler(this.buttonTimMonThi_Click);
            // 
            // spinEditLan
            // 
            this.spinEditLan.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditLan.Location = new System.Drawing.Point(103, 94);
            this.spinEditLan.Name = "spinEditLan";
            this.spinEditLan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditLan.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinEditLan.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditLan.Size = new System.Drawing.Size(178, 20);
            this.spinEditLan.TabIndex = 22;
            // 
            // mAMHComboBox
            // 
            this.mAMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHComboBox.DataSource = this.mONHOCBindingSource;
            this.mAMHComboBox.DisplayMember = "TENMH";
            this.mAMHComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mAMHComboBox.FormattingEnabled = true;
            this.mAMHComboBox.Location = new System.Drawing.Point(103, 20);
            this.mAMHComboBox.Name = "mAMHComboBox";
            this.mAMHComboBox.Size = new System.Drawing.Size(178, 21);
            this.mAMHComboBox.TabIndex = 1;
            this.mAMHComboBox.ValueMember = "MAMH";
            // 
            // nGAYTHIDateEdit
            // 
            this.nGAYTHIDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "NGAYTHI", true));
            this.nGAYTHIDateEdit.EditValue = null;
            this.nGAYTHIDateEdit.Location = new System.Drawing.Point(103, 57);
            this.nGAYTHIDateEdit.Name = "nGAYTHIDateEdit";
            this.nGAYTHIDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Size = new System.Drawing.Size(178, 20);
            this.nGAYTHIDateEdit.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label9);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(309, 151);
            this.panelControl2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên:";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.buttonNopBai);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(313, 437);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(873, 46);
            this.panelControl3.TabIndex = 6;
            // 
            // buttonNopBai
            // 
            this.buttonNopBai.Location = new System.Drawing.Point(786, 11);
            this.buttonNopBai.Name = "buttonNopBai";
            this.buttonNopBai.Size = new System.Drawing.Size(75, 23);
            this.buttonNopBai.TabIndex = 0;
            this.buttonNopBai.Text = "Nộp bài";
            this.buttonNopBai.UseVisualStyleBackColor = true;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.flowLayoutPanel1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(313, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(873, 437);
            this.panelControl5.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(869, 433);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FormChonMonThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 483);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormChonMonThi";
            this.Text = "FormChuanBiThi";
            this.Load += new System.EventHandler(this.FormChonMonThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSoCauThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TN_CSDLPT_DataSet tN_CSDLPT_DataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private TN_CSDLPT_DataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private TN_CSDLPT_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPT_DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit nGAYTHIDateEdit;
        private System.Windows.Forms.ComboBox mAMHComboBox;
        private DevExpress.XtraEditors.SpinEdit spinEditLan;
        private System.Windows.Forms.Button buttonTimMonThi;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBatDauThi;
        private System.Windows.Forms.ComboBox comboBoxTrinhDo;
        private DevExpress.XtraEditors.SpinEdit spinEditThoiGian;
        private DevExpress.XtraEditors.SpinEdit spinEditSoCauThi;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button buttonNopBai;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}