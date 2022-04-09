namespace TN_CSDLPT_NOV09.views
{
    partial class FormRpBangDiemMonHoc
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label lANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRpBangDiemMonHoc));
            this.TN_CSDLPT_DataSet = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSet();
            this.bindingSourceMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterMonHoc = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager();
            this.tableAdapterLop = new TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.LOPTableAdapter();
            this.bindingSourceLop = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMaLop = new System.Windows.Forms.ComboBox();
            this.comboBoxMaMonHoc = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spinEditLan = new DevExpress.XtraEditors.SpinEdit();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(45, 72);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(28, 13);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "Lớp:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(45, 113);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(51, 13);
            mAMHLabel.TabIndex = 3;
            mAMHLabel.Text = "Môn học:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(45, 155);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(43, 13);
            lANLabel.TabIndex = 21;
            lANLabel.Text = "Lần thi:";
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
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.tableAdapterLop;
            this.tableAdapterManager.MONHOCTableAdapter = this.tableAdapterMonHoc;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_NOV09.TN_CSDLPT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterLop
            // 
            this.tableAdapterLop.ClearBeforeFill = true;
            // 
            // bindingSourceLop
            // 
            this.bindingSourceLop.DataMember = "LOP";
            this.bindingSourceLop.DataSource = this.TN_CSDLPT_DataSet;
            // 
            // comboBoxMaLop
            // 
            this.comboBoxMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLop, "MALOP", true));
            this.comboBoxMaLop.DataSource = this.bindingSourceLop;
            this.comboBoxMaLop.DisplayMember = "TENLOP";
            this.comboBoxMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaLop.FormattingEnabled = true;
            this.comboBoxMaLop.Location = new System.Drawing.Point(114, 69);
            this.comboBoxMaLop.Name = "comboBoxMaLop";
            this.comboBoxMaLop.Size = new System.Drawing.Size(190, 21);
            this.comboBoxMaLop.TabIndex = 3;
            this.comboBoxMaLop.ValueMember = "MALOP";
            // 
            // comboBoxMaMonHoc
            // 
            this.comboBoxMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMonHoc, "MAMH", true));
            this.comboBoxMaMonHoc.DataSource = this.bindingSourceMonHoc;
            this.comboBoxMaMonHoc.DisplayMember = "TENMH";
            this.comboBoxMaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaMonHoc.FormattingEnabled = true;
            this.comboBoxMaMonHoc.Location = new System.Drawing.Point(114, 110);
            this.comboBoxMaMonHoc.Name = "comboBoxMaMonHoc";
            this.comboBoxMaMonHoc.Size = new System.Drawing.Size(190, 21);
            this.comboBoxMaMonHoc.TabIndex = 4;
            this.comboBoxMaMonHoc.ValueMember = "MAMH";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.buttonThoat);
            this.panelControl1.Controls.Add(this.comboBoxCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(838, 50);
            this.panelControl1.TabIndex = 18;
            // 
            // comboBoxCoSo
            // 
            this.comboBoxCoSo.FormattingEnabled = true;
            this.comboBoxCoSo.Location = new System.Drawing.Point(95, 16);
            this.comboBoxCoSo.Name = "comboBoxCoSo";
            this.comboBoxCoSo.Size = new System.Drawing.Size(190, 21);
            this.comboBoxCoSo.TabIndex = 1;
            this.comboBoxCoSo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn cơ sở";
            // 
            // spinEditLan
            // 
            this.spinEditLan.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditLan.Location = new System.Drawing.Point(114, 152);
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
            this.spinEditLan.TabIndex = 22;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(114, 204);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(190, 23);
            this.buttonPreview.TabIndex = 23;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.FlatAppearance.BorderSize = 0;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.Image")));
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(750, 5);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(76, 40);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // FormRpBangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 392);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.spinEditLan);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.comboBoxMaMonHoc);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.comboBoxMaLop);
            this.Name = "FormRpBangDiemMonHoc";
            this.Text = "FormRpBangDiemMonHoc";
            this.Load += new System.EventHandler(this.FormRpBangDiemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPT_DataSet TN_CSDLPT_DataSet;
        private System.Windows.Forms.BindingSource bindingSourceMonHoc;
        private TN_CSDLPT_DataSetTableAdapters.MONHOCTableAdapter tableAdapterMonHoc;
        private TN_CSDLPT_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPT_DataSetTableAdapters.LOPTableAdapter tableAdapterLop;
        private System.Windows.Forms.BindingSource bindingSourceLop;
        private System.Windows.Forms.ComboBox comboBoxMaLop;
        private System.Windows.Forms.ComboBox comboBoxMaMonHoc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBoxCoSo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinEditLan;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonThoat;
    }
}