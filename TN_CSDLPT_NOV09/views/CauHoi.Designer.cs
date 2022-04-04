namespace TN_CSDLPT_NOV09.views
{
    partial class CauHoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSoThuTu = new System.Windows.Forms.Label();
            this.labelNoiDungCauHoi = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSoThuTu
            // 
            this.labelSoThuTu.AutoSize = true;
            this.labelSoThuTu.Location = new System.Drawing.Point(13, 10);
            this.labelSoThuTu.Name = "labelSoThuTu";
            this.labelSoThuTu.Size = new System.Drawing.Size(39, 13);
            this.labelSoThuTu.TabIndex = 0;
            this.labelSoThuTu.Text = "Câu: 1";
            // 
            // labelNoiDungCauHoi
            // 
            this.labelNoiDungCauHoi.AutoSize = true;
            this.labelNoiDungCauHoi.Location = new System.Drawing.Point(13, 38);
            this.labelNoiDungCauHoi.Name = "labelNoiDungCauHoi";
            this.labelNoiDungCauHoi.Size = new System.Drawing.Size(86, 13);
            this.labelNoiDungCauHoi.TabIndex = 1;
            this.labelNoiDungCauHoi.Text = "Nội dung câu hỏi";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.radioButtonD);
            this.panelControl1.Controls.Add(this.radioButtonC);
            this.panelControl1.Controls.Add(this.radioButtonB);
            this.panelControl1.Controls.Add(this.radioButtonA);
            this.panelControl1.Location = new System.Drawing.Point(16, 72);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(823, 186);
            this.panelControl1.TabIndex = 2;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(18, 14);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(83, 17);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A. Đáp án a";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(18, 56);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(82, 17);
            this.radioButtonB.TabIndex = 1;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B. Đáp án b";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(18, 99);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(82, 17);
            this.radioButtonC.TabIndex = 2;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C. Đáp án c";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(18, 145);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(83, 17);
            this.radioButtonD.TabIndex = 3;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D. Đáp án d";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.radioButtonD_CheckedChanged);
            // 
            // CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelNoiDungCauHoi);
            this.Controls.Add(this.labelSoThuTu);
            this.Name = "CauHoi";
            this.Size = new System.Drawing.Size(857, 280);
            this.Load += new System.EventHandler(this.CauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoThuTu;
        private System.Windows.Forms.Label labelNoiDungCauHoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
    }
}
