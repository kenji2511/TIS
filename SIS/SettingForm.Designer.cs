namespace SIS
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cpoint_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cpoint = new System.Windows.Forms.TextBox();
            this.btn_save_cpoint = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตั้งค่า";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_cpoint_name);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_cpoint);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox3.Location = new System.Drawing.Point(12, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 168);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ตั้งค่าด่าน";
            // 
            // txt_cpoint_name
            // 
            this.txt_cpoint_name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_cpoint_name.Location = new System.Drawing.Point(137, 111);
            this.txt_cpoint_name.Name = "txt_cpoint_name";
            this.txt_cpoint_name.ReadOnly = true;
            this.txt_cpoint_name.Size = new System.Drawing.Size(247, 31);
            this.txt_cpoint_name.TabIndex = 7;
            this.txt_cpoint_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "ชื่อด่าน : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "รหัสด่าน : ";
            // 
            // txt_cpoint
            // 
            this.txt_cpoint.Location = new System.Drawing.Point(137, 63);
            this.txt_cpoint.MaxLength = 3;
            this.txt_cpoint.Name = "txt_cpoint";
            this.txt_cpoint.Size = new System.Drawing.Size(129, 31);
            this.txt_cpoint.TabIndex = 1;
            this.txt_cpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cpoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cpoint_KeyDown);
            this.txt_cpoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpoint_KeyPress);
            this.txt_cpoint.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_cpoint_KeyUp);
            // 
            // btn_save_cpoint
            // 
            this.btn_save_cpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_save_cpoint.Location = new System.Drawing.Point(330, 228);
            this.btn_save_cpoint.Name = "btn_save_cpoint";
            this.btn_save_cpoint.Size = new System.Drawing.Size(96, 40);
            this.btn_save_cpoint.TabIndex = 4;
            this.btn_save_cpoint.Text = "บันทึก";
            this.btn_save_cpoint.UseVisualStyleBackColor = true;
            this.btn_save_cpoint.Click += new System.EventHandler(this.btn_save_cpoint_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_back.Location = new System.Drawing.Point(12, 228);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(89, 40);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "ย้อนกลับ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 279);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save_cpoint);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_save_cpoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cpoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_cpoint_name;
    }
}