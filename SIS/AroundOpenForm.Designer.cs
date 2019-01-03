namespace SIS
{
    partial class AroundOpenForm
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
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_emp_name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อผู้เปิดกะ : ";
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rb_2.Location = new System.Drawing.Point(103, 141);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(244, 29);
            this.rb_2.TabIndex = 2;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "ผลัด เช้า   (06:00-14:00)";
            this.rb_2.UseVisualStyleBackColor = true;
            this.rb_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_1_KeyDown);
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rb_3.Location = new System.Drawing.Point(103, 176);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(243, 29);
            this.rb_3.TabIndex = 3;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "ผลัด บ่าย  (14:00-22:00)";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_1_KeyDown);
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rb_1.Location = new System.Drawing.Point(103, 211);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(246, 29);
            this.rb_1.TabIndex = 4;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "ผลัด ดึก    (22:00-06:00)";
            this.rb_1.UseVisualStyleBackColor = true;
            this.rb_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(98, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "เลือกผลัด";
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_next.Location = new System.Drawing.Point(394, 282);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(84, 34);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "เสร็จสิ้น";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_back.Location = new System.Drawing.Point(12, 282);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 34);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "ย้อยกลับ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_emp_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rb_1);
            this.groupBox1.Controls.Add(this.rb_3);
            this.groupBox1.Controls.Add(this.rb_2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 264);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เปิดกะ";
            // 
            // lb_emp_name
            // 
            this.lb_emp_name.AutoSize = true;
            this.lb_emp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_emp_name.Location = new System.Drawing.Point(127, 55);
            this.lb_emp_name.Name = "lb_emp_name";
            this.lb_emp_name.Size = new System.Drawing.Size(35, 25);
            this.lb_emp_name.TabIndex = 8;
            this.lb_emp_name.Text = "ชื่อ";
            // 
            // AroundOpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(490, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AroundOpenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AroundOpenForm";
            this.Load += new System.EventHandler(this.AroundOpenForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_emp_name;
    }
}