namespace TN_CSDLPT_NOV09.views
{
    partial class FormRpKetQuaThi
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
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRpKetQuaThi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.comboBoxCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.spinEditLan = new DevExpress.XtraEditors.SpinEdit();
            this.comboBoxMaMonHoc = new System.Windows.Forms.ComboBox();
            this.bindingSourceMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPT_DataSet = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSet();
            this.comboBoxMaSinhVien = new System.Windows.Forms.ComboBox();
            this.bindingSourceSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterMonHoc = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager();
            this.tableAdapterSinhVien = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.SINHVIENTableAdapter();
            lANLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(45, 118);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(43, 13);
            lANLabel.TabIndex = 28;
            lANLabel.Text = "Lần thi:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(45, 76);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(51, 13);
            mAMHLabel.TabIndex = 25;
            mAMHLabel.Text = "Môn học:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(45, 35);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(70, 13);
            mALOPLabel.TabIndex = 24;
            mALOPLabel.Text = "Mã sinh viên:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.buttonThoat);
            this.panelControl1.Controls.Add(this.comboBoxCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(882, 50);
            this.panelControl1.TabIndex = 19;
            // 
            // buttonThoat
            // 
            this.buttonThoat.FlatAppearance.BorderSize = 0;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.Image")));
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(772, 5);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(73, 40);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // comboBoxCoSo
            // 
            this.comboBoxCoSo.FormattingEnabled = true;
            this.comboBoxCoSo.Location = new System.Drawing.Point(92, 14);
            this.comboBoxCoSo.Name = "comboBoxCoSo";
            this.comboBoxCoSo.Size = new System.Drawing.Size(190, 21);
            this.comboBoxCoSo.TabIndex = 1;
            this.comboBoxCoSo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn cơ sở";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.buttonPreview);
            this.panelControl2.Controls.Add(this.spinEditLan);
            this.panelControl2.Controls.Add(lANLabel);
            this.panelControl2.Controls.Add(mAMHLabel);
            this.panelControl2.Controls.Add(this.comboBoxMaMonHoc);
            this.panelControl2.Controls.Add(mALOPLabel);
            this.panelControl2.Controls.Add(this.comboBoxMaSinhVien);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 50);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(882, 312);
            this.panelControl2.TabIndex = 20;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(119, 167);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(190, 23);
            this.buttonPreview.TabIndex = 30;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // spinEditLan
            // 
            this.spinEditLan.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditLan.Location = new System.Drawing.Point(119, 115);
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
            this.spinEditLan.Size = new System.Drawing.Size(190, 20);
            this.spinEditLan.TabIndex = 29;
            // 
            // comboBoxMaMonHoc
            // 
            this.comboBoxMaMonHoc.DataSource = this.bindingSourceMonHoc;
            this.comboBoxMaMonHoc.DisplayMember = "TENMH";
            this.comboBoxMaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaMonHoc.FormattingEnabled = true;
            this.comboBoxMaMonHoc.Location = new System.Drawing.Point(119, 73);
            this.comboBoxMaMonHoc.Name = "comboBoxMaMonHoc";
            this.comboBoxMaMonHoc.Size = new System.Drawing.Size(190, 21);
            this.comboBoxMaMonHoc.TabIndex = 27;
            this.comboBoxMaMonHoc.ValueMember = "MAMH";
            // 
            // bindingSourceMonHoc
            // 
            this.bindingSourceMonHoc.DataMember = "MONHOC";
            this.bindingSourceMonHoc.DataSource = this.TN_CSDLPT_DataSet;
            // 
            // TN_CSDLPT_DataSet
            // 
            this.TN_CSDLPT_DataSet.DataSetName = "TN_CSDLPT_DataSet";
            this.TN_CSDLPT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxMaSinhVien
            // 
            this.comboBoxMaSinhVien.DataSource = this.bindingSourceSinhVien;
            this.comboBoxMaSinhVien.DisplayMember = "MASV";
            this.comboBoxMaSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaSinhVien.FormattingEnabled = true;
            this.comboBoxMaSinhVien.Location = new System.Drawing.Point(119, 32);
            this.comboBoxMaSinhVien.Name = "comboBoxMaSinhVien";
            this.comboBoxMaSinhVien.Size = new System.Drawing.Size(190, 21);
            this.comboBoxMaSinhVien.TabIndex = 26;
            this.comboBoxMaSinhVien.ValueMember = "MASV";
            // 
            // bindingSourceSinhVien
            // 
            this.bindingSourceSinhVien.DataMember = "SINHVIEN";
            this.bindingSourceSinhVien.DataSource = this.TN_CSDLPT_DataSet;
            // 
            // tableAdapterMonHoc
            // 
            this.tableAdapterMonHoc.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.tableAdapterMonHoc;
            this.tableAdapterManager.SINHVIENTableAdapter = this.tableAdapterSinhVien;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterSinhVien
            // 
            this.tableAdapterSinhVien.ClearBeforeFill = true;
            // 
            // FormRpKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 362);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormRpKetQuaThi";
            this.Text = "FormRpKetQuaThi";
            this.Load += new System.EventHandler(this.FormRpKetQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBoxCoSo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button buttonPreview;
        private DevExpress.XtraEditors.SpinEdit spinEditLan;
        private System.Windows.Forms.ComboBox comboBoxMaMonHoc;
        private System.Windows.Forms.ComboBox comboBoxMaSinhVien;
        private TN_CSDLPT_DataSet TN_CSDLPT_DataSet;
        private System.Windows.Forms.BindingSource bindingSourceMonHoc;
        private TN_CSDLPT_DataSetTableAdapters.MONHOCTableAdapter tableAdapterMonHoc;
        private TN_CSDLPT_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPT_DataSetTableAdapters.SINHVIENTableAdapter tableAdapterSinhVien;
        private System.Windows.Forms.BindingSource bindingSourceSinhVien;
        private System.Windows.Forms.Button buttonThoat;
    }
}