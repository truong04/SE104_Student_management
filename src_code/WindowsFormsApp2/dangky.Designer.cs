namespace WindowsFormsApp2
{
    partial class dangky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangky));
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.Matkhau2 = new System.Windows.Forms.TextBox();
            this.textBox_tentk = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Matkhau1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.btnDangKi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Location = new System.Drawing.Point(486, 327);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(114, 20);
            this.checkbox2.TabIndex = 22;
            this.checkbox2.Text = "Hiện mật khẩu";
            this.checkbox2.UseVisualStyleBackColor = true;
            this.checkbox2.CheckedChanged += new System.EventHandler(this.Btn_checkbox_CheckedChanged);
            // 
            // Matkhau2
            // 
            this.Matkhau2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Matkhau2.Location = new System.Drawing.Point(256, 327);
            this.Matkhau2.Name = "Matkhau2";
            this.Matkhau2.Size = new System.Drawing.Size(209, 22);
            this.Matkhau2.TabIndex = 19;
            this.Matkhau2.TabStop = false;
            this.Matkhau2.UseSystemPasswordChar = true;
            // 
            // textBox_tentk
            // 
            this.textBox_tentk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tentk.Location = new System.Drawing.Point(255, 248);
            this.textBox_tentk.Name = "textBox_tentk";
            this.textBox_tentk.Size = new System.Drawing.Size(209, 22);
            this.textBox_tentk.TabIndex = 17;
            this.textBox_tentk.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(485, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 20);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Matkhau1
            // 
            this.Matkhau1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Matkhau1.Location = new System.Drawing.Point(255, 286);
            this.Matkhau1.Name = "Matkhau1";
            this.Matkhau1.Size = new System.Drawing.Size(209, 22);
            this.Matkhau1.TabIndex = 24;
            this.Matkhau1.TabStop = false;
            this.Matkhau1.UseSystemPasswordChar = true;
            this.Matkhau1.TextChanged += new System.EventHandler(this.Matkhau1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(42, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nhập tên tài khoản";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(42, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhập mật khẩu";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(42, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(42, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nhập Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textbox_email
            // 
            this.textbox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_email.Location = new System.Drawing.Point(255, 211);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(209, 22);
            this.textbox_email.TabIndex = 31;
            this.textbox_email.TabStop = false;
            this.textbox_email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangKi.Location = new System.Drawing.Point(299, 372);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(107, 34);
            this.btnDangKi.TabIndex = 33;
            this.btnDangKi.Tag = "";
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 480);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Matkhau1);
            this.Controls.Add(this.checkbox2);
            this.Controls.Add(this.Matkhau2);
            this.Controls.Add(this.textBox_tentk);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dangky";
            this.Text = "dangky";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.TextBox Matkhau2;
        private System.Windows.Forms.TextBox textBox_tentk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Matkhau1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Label label4;
    }
}