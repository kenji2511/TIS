namespace SIS
{
    partial class EditMoneyForm
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_money = new System.Windows.Forms.Label();
            this.lb_income_id = new System.Windows.Forms.Label();
            this.txt_straps_number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.txt_edit_money = new System.Windows.Forms.TextBox();
            this.txt_bag_number = new System.Windows.Forms.TextBox();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 294);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 37);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "ย้อนกลับ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(538, 294);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(96, 37);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "เสร็จสิ้น";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_money);
            this.groupBox1.Controls.Add(this.lb_income_id);
            this.groupBox1.Controls.Add(this.txt_straps_number);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_emp_name);
            this.groupBox1.Controls.Add(this.txt_edit_money);
            this.groupBox1.Controls.Add(this.txt_bag_number);
            this.groupBox1.Controls.Add(this.txt_emp_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ปรับยอด";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Location = new System.Drawing.Point(493, 59);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(85, 29);
            this.lb_money.TabIndex = 9;
            this.lb_money.Text = "money";
            this.lb_money.Visible = false;
            // 
            // lb_income_id
            // 
            this.lb_income_id.AutoSize = true;
            this.lb_income_id.Location = new System.Drawing.Point(493, 31);
            this.lb_income_id.Name = "lb_income_id";
            this.lb_income_id.Size = new System.Drawing.Size(125, 29);
            this.lb_income_id.TabIndex = 8;
            this.lb_income_id.Text = "id_income";
            this.lb_income_id.Visible = false;
            // 
            // txt_straps_number
            // 
            this.txt_straps_number.Location = new System.Drawing.Point(268, 223);
            this.txt_straps_number.MaxLength = 6;
            this.txt_straps_number.Name = "txt_straps_number";
            this.txt_straps_number.Size = new System.Drawing.Size(209, 35);
            this.txt_straps_number.TabIndex = 5;
            this.txt_straps_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "หมายเลขสายรัด : ";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Enabled = false;
            this.txt_emp_name.Location = new System.Drawing.Point(268, 100);
            this.txt_emp_name.MaxLength = 6;
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_emp_name.Size = new System.Drawing.Size(333, 35);
            this.txt_emp_name.TabIndex = 2;
            // 
            // txt_edit_money
            // 
            this.txt_edit_money.Location = new System.Drawing.Point(268, 141);
            this.txt_edit_money.MaxLength = 11;
            this.txt_edit_money.Name = "txt_edit_money";
            this.txt_edit_money.Size = new System.Drawing.Size(117, 35);
            this.txt_edit_money.TabIndex = 3;
            this.txt_edit_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bag_number
            // 
            this.txt_bag_number.Location = new System.Drawing.Point(268, 182);
            this.txt_bag_number.MaxLength = 4;
            this.txt_bag_number.Name = "txt_bag_number";
            this.txt_bag_number.Size = new System.Drawing.Size(117, 35);
            this.txt_bag_number.TabIndex = 4;
            this.txt_bag_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Enabled = false;
            this.txt_emp_id.Location = new System.Drawing.Point(268, 59);
            this.txt_emp_id.MaxLength = 6;
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_emp_id.Size = new System.Drawing.Size(117, 35);
            this.txt_emp_id.TabIndex = 1;
            this.txt_emp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "หมายเลขถุงเงินพิเศษ : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "บาท";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ปรับยอด : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ-สกุล : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสพนักงาน : ";
            // 
            // EditMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMoneyForm";
            this.Load += new System.EventHandler(this.EditMoneyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.TextBox txt_edit_money;
        private System.Windows.Forms.TextBox txt_bag_number;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_straps_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_income_id;
        private System.Windows.Forms.Label lb_money;
    }
}