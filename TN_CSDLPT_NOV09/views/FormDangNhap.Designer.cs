namespace TN_CSDLPT_NOV09.views
{
    partial class FormDangNhap
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
            this.comboBoxCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.radioButtonSinhVien = new System.Windows.Forms.RadioButton();
            this.radioButtonGiangVien = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCoSo
            // 
            this.comboBoxCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoSo.FormattingEnabled = true;
            this.comboBoxCoSo.Location = new System.Drawing.Point(149, 95);
            this.comboBoxCoSo.Name = "comboBoxCoSo";
            this.comboBoxCoSo.Size = new System.Drawing.Size(232, 21);
            this.comboBoxCoSo.TabIndex = 0;
            this.comboBoxCoSo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn cơ sở";
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(149, 184);
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(231, 21);
            this.textBoxTenDangNhap.TabIndex = 2;
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenDangNhap.Location = new System.Drawing.Point(39, 187);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(91, 14);
            this.labelTenDangNhap.TabIndex = 3;
            this.labelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.Location = new System.Drawing.Point(43, 267);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(338, 31);
            this.buttonDangNhap.TabIndex = 7;
            this.buttonDangNhap.Text = "ĐĂNG NHẬP";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(150, 224);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(231, 21);
            this.textBoxMatKhau.TabIndex = 9;
            // 
            // radioButtonSinhVien
            // 
            this.radioButtonSinhVien.AutoSize = true;
            this.radioButtonSinhVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSinhVien.Location = new System.Drawing.Point(155, 8);
            this.radioButtonSinhVien.Name = "radioButtonSinhVien";
            this.radioButtonSinhVien.Size = new System.Drawing.Size(74, 18);
            this.radioButtonSinhVien.TabIndex = 14;
            this.radioButtonSinhVien.TabStop = true;
            this.radioButtonSinhVien.Text = "Sinh viên";
            this.radioButtonSinhVien.UseVisualStyleBackColor = true;
            this.radioButtonSinhVien.CheckedChanged += new System.EventHandler(this.radioButtonSinhVien_CheckedChanged);
            // 
            // radioButtonGiangVien
            // 
            this.radioButtonGiangVien.AutoSize = true;
            this.radioButtonGiangVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGiangVien.Location = new System.Drawing.Point(3, 8);
            this.radioButtonGiangVien.Name = "radioButtonGiangVien";
            this.radioButtonGiangVien.Size = new System.Drawing.Size(81, 18);
            this.radioButtonGiangVien.TabIndex = 13;
            this.radioButtonGiangVien.TabStop = true;
            this.radioButtonGiangVien.Text = "Giảng viên";
            this.radioButtonGiangVien.UseVisualStyleBackColor = true;
            this.radioButtonGiangVien.CheckedChanged += new System.EventHandler(this.radioButtonGiangVien_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonGiangVien);
            this.panel1.Controls.Add(this.radioButtonSinhVien);
            this.panel1.Location = new System.Drawing.Point(150, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 36);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Image = global::TN_CSDLPT_NOV09.Properties.Resources.icons8_maybe_64px_3;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.MaximumSize = new System.Drawing.Size(1000, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 77);
            this.label2.TabIndex = 18;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(144, 29);
            this.label4.MaximumSize = new System.Drawing.Size(1000, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "TRẮC NGHIỆM CSDLPT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chọn chức vụ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 355);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTenDangNhap);
            this.Controls.Add(this.textBoxTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCoSo);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDangNhap;
        public System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.RadioButton radioButtonSinhVien;
        private System.Windows.Forms.RadioButton radioButtonGiangVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}