namespace SIS
{
    partial class RefunForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_fine = new System.Windows.Forms.Label();
            this.rdo_fine = new System.Windows.Forms.RadioButton();
            this.rdo_user = new System.Windows.Forms.RadioButton();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_fine = new System.Windows.Forms.TextBox();
            this.cb_emp_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_around = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_value = new System.Windows.Forms.DateTimePicker();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_user);
            this.groupBox1.Controls.Add(this.lb_fine);
            this.groupBox1.Controls.Add(this.rdo_fine);
            this.groupBox1.Controls.Add(this.rdo_user);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.txt_fine);
            this.groupBox1.Controls.Add(this.cb_emp_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_around);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date_value);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "คืนเงินผู้ใช้ทาง";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_user.ForeColor = System.Drawing.Color.Blue;
            this.lb_user.Location = new System.Drawing.Point(332, 230);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(15, 16);
            this.lb_user.TabIndex = 9;
            this.lb_user.Text = "2";
            this.lb_user.Visible = false;
            // 
            // lb_fine
            // 
            this.lb_fine.AutoSize = true;
            this.lb_fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_fine.ForeColor = System.Drawing.Color.Blue;
            this.lb_fine.Location = new System.Drawing.Point(422, 190);
            this.lb_fine.Name = "lb_fine";
            this.lb_fine.Size = new System.Drawing.Size(15, 16);
            this.lb_fine.TabIndex = 8;
            this.lb_fine.Text = "1";
            this.lb_fine.Visible = false;
            // 
            // rdo_fine
            // 
            this.rdo_fine.AutoSize = true;
            this.rdo_fine.Enabled = false;
            this.rdo_fine.Location = new System.Drawing.Point(36, 178);
            this.rdo_fine.Name = "rdo_fine";
            this.rdo_fine.Size = new System.Drawing.Size(219, 33);
            this.rdo_fine.TabIndex = 7;
            this.rdo_fine.Text = "เงินค่าปรับบัตรหาย :";
            this.rdo_fine.UseVisualStyleBackColor = true;
            this.rdo_fine.CheckedChanged += new System.EventHandler(this.rdo_fine_CheckedChanged);
            // 
            // rdo_user
            // 
            this.rdo_user.AutoSize = true;
            this.rdo_user.Enabled = false;
            this.rdo_user.Location = new System.Drawing.Point(36, 218);
            this.rdo_user.Name = "rdo_user";
            this.rdo_user.Size = new System.Drawing.Size(127, 33);
            this.rdo_user.TabIndex = 7;
            this.rdo_user.TabStop = true;
            this.rdo_user.Text = "เงินทอน : ";
            this.rdo_user.UseVisualStyleBackColor = true;
            this.rdo_user.CheckedChanged += new System.EventHandler(this.rdo_user_CheckedChanged);
            // 
            // txt_user
            // 
            this.txt_user.Enabled = false;
            this.txt_user.Location = new System.Drawing.Point(169, 217);
            this.txt_user.MaxLength = 11;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 35);
            this.txt_user.TabIndex = 6;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            // 
            // txt_fine
            // 
            this.txt_fine.Enabled = false;
            this.txt_fine.Location = new System.Drawing.Point(259, 177);
            this.txt_fine.MaxLength = 11;
            this.txt_fine.Name = "txt_fine";
            this.txt_fine.Size = new System.Drawing.Size(100, 35);
            this.txt_fine.TabIndex = 6;
            this.txt_fine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fine_KeyPress);
            // 
            // cb_emp_name
            // 
            this.cb_emp_name.Enabled = false;
            this.cb_emp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_emp_name.FormattingEnabled = true;
            this.cb_emp_name.Location = new System.Drawing.Point(275, 135);
            this.cb_emp_name.Name = "cb_emp_name";
            this.cb_emp_name.Size = new System.Drawing.Size(377, 33);
            this.cb_emp_name.TabIndex = 5;
            this.cb_emp_name.SelectedIndexChanged += new System.EventHandler(this.cb_emp_name_SelectedIndexChanged);
            this.cb_emp_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_emp_name_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "พนักงานที่ปฎิบัติหน้าที่ : ";
            // 
            // cb_around
            // 
            this.cb_around.FormattingEnabled = true;
            this.cb_around.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_around.Location = new System.Drawing.Point(275, 92);
            this.cb_around.Name = "cb_around";
            this.cb_around.Size = new System.Drawing.Size(84, 37);
            this.cb_around.TabIndex = 2;
            this.cb_around.Text = "เลือก";
            this.cb_around.SelectedIndexChanged += new System.EventHandler(this.cb_around_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "บาท";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "บาท";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ผลัดที่ : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "วันที่ : ";
            // 
            // date_value
            // 
            this.date_value.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_value.Location = new System.Drawing.Point(275, 51);
            this.date_value.Name = "date_value";
            this.date_value.Size = new System.Drawing.Size(162, 35);
            this.date_value.TabIndex = 1;
            this.date_value.ValueChanged += new System.EventHandler(this.date_value_ValueChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 295);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 35);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "ย้อนกลับ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(606, 295);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(107, 35);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "ถัดไป";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // RefunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 340);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RefunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RefunForm";
            this.Load += new System.EventHandler(this.RefunForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_value;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ComboBox cb_around;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_emp_name;
        private System.Windows.Forms.RadioButton rdo_fine;
        private System.Windows.Forms.RadioButton rdo_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_fine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_fine;
    }
}