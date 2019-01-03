namespace SIS
{
    partial class SendMoneyForm
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
            this.group_sendMoney = new System.Windows.Forms.GroupBox();
            this.txt_straps = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_bag = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_bank = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fine = new System.Windows.Forms.TextBox();
            this.txt_chang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.MaskedTextBox();
            this.txt_start = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.group_sendMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_sendMoney
            // 
            this.group_sendMoney.Controls.Add(this.txt_straps);
            this.group_sendMoney.Controls.Add(this.label15);
            this.group_sendMoney.Controls.Add(this.txt_bag);
            this.group_sendMoney.Controls.Add(this.label14);
            this.group_sendMoney.Controls.Add(this.txt_job);
            this.group_sendMoney.Controls.Add(this.label13);
            this.group_sendMoney.Controls.Add(this.label12);
            this.group_sendMoney.Controls.Add(this.txt_bank);
            this.group_sendMoney.Controls.Add(this.label11);
            this.group_sendMoney.Controls.Add(this.label10);
            this.group_sendMoney.Controls.Add(this.label9);
            this.group_sendMoney.Controls.Add(this.label8);
            this.group_sendMoney.Controls.Add(this.txt_fine);
            this.group_sendMoney.Controls.Add(this.txt_chang);
            this.group_sendMoney.Controls.Add(this.label7);
            this.group_sendMoney.Controls.Add(this.label6);
            this.group_sendMoney.Controls.Add(this.label5);
            this.group_sendMoney.Controls.Add(this.txt_total);
            this.group_sendMoney.Controls.Add(this.txt_end);
            this.group_sendMoney.Controls.Add(this.txt_start);
            this.group_sendMoney.Controls.Add(this.label4);
            this.group_sendMoney.Controls.Add(this.label3);
            this.group_sendMoney.Controls.Add(this.txt_emp_name);
            this.group_sendMoney.Controls.Add(this.txt_emp_id);
            this.group_sendMoney.Controls.Add(this.label2);
            this.group_sendMoney.Controls.Add(this.label1);
            this.group_sendMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.group_sendMoney.Location = new System.Drawing.Point(12, 12);
            this.group_sendMoney.Name = "group_sendMoney";
            this.group_sendMoney.Size = new System.Drawing.Size(973, 495);
            this.group_sendMoney.TabIndex = 0;
            this.group_sendMoney.TabStop = false;
            this.group_sendMoney.Text = "นำส่งเงินรายได้";
            this.group_sendMoney.Enter += new System.EventHandler(this.group_sendMoney_Enter);
            // 
            // txt_straps
            // 
            this.txt_straps.Location = new System.Drawing.Point(292, 218);
            this.txt_straps.MaxLength = 6;
            this.txt_straps.Name = "txt_straps";
            this.txt_straps.Size = new System.Drawing.Size(322, 35);
            this.txt_straps.TabIndex = 7;
            this.txt_straps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 29);
            this.label15.TabIndex = 25;
            this.label15.Text = "หมายเลขสายรัด : ";
            // 
            // txt_bag
            // 
            this.txt_bag.Enabled = false;
            this.txt_bag.Location = new System.Drawing.Point(292, 177);
            this.txt_bag.MaxLength = 6;
            this.txt_bag.Name = "txt_bag";
            this.txt_bag.Size = new System.Drawing.Size(82, 35);
            this.txt_bag.TabIndex = 5;
            this.txt_bag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 29);
            this.label14.TabIndex = 23;
            this.label14.Text = "หมายเลขถุงเงิน : ";
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(499, 177);
            this.txt_job.MaxLength = 2;
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(82, 35);
            this.txt_job.TabIndex = 6;
            this.txt_job.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_job.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_job_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 29);
            this.label13.TabIndex = 21;
            this.label13.Text = "งานที่ : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(894, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "บาท";
            // 
            // txt_bank
            // 
            this.txt_bank.Enabled = false;
            this.txt_bank.Location = new System.Drawing.Point(687, 432);
            this.txt_bank.MaxLength = 6;
            this.txt_bank.Name = "txt_bank";
            this.txt_bank.Size = new System.Drawing.Size(201, 35);
            this.txt_bank.TabIndex = 11;
            this.txt_bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(442, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "เงินที่ต้องนำส่งธนาคาร : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "ค่าปรับบัตรหาย : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(894, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "บาท";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(894, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "บาท";
            // 
            // txt_fine
            // 
            this.txt_fine.Location = new System.Drawing.Point(687, 391);
            this.txt_fine.MaxLength = 11;
            this.txt_fine.Name = "txt_fine";
            this.txt_fine.Size = new System.Drawing.Size(201, 35);
            this.txt_fine.TabIndex = 10;
            this.txt_fine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fine_KeyPress);
            this.txt_fine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_fine_KeyUp);
            // 
            // txt_chang
            // 
            this.txt_chang.Location = new System.Drawing.Point(687, 350);
            this.txt_chang.MaxLength = 11;
            this.txt_chang.Name = "txt_chang";
            this.txt_chang.Size = new System.Drawing.Size(201, 35);
            this.txt_chang.TabIndex = 9;
            this.txt_chang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_chang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_chang_KeyPress);
            this.txt_chang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_chang_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "ผู้ใช้ทางไม่รับเงินทอน : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "จำนวนเงินทั้งหมด : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(894, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "บาท";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(687, 309);
            this.txt_total.MaxLength = 11;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(201, 35);
            this.txt_total.TabIndex = 8;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txt_total.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_total_KeyUp);
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(499, 136);
            this.txt_end.Mask = "00:00";
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(82, 35);
            this.txt_end.TabIndex = 4;
            this.txt_end.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_end.ValidatingType = typeof(System.DateTime);
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(292, 136);
            this.txt_start.Mask = "00:00";
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(82, 35);
            this.txt_start.TabIndex = 3;
            this.txt_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_start.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "เวลาออก : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "เวลาเข้า : ";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Enabled = false;
            this.txt_emp_name.Location = new System.Drawing.Point(292, 95);
            this.txt_emp_name.MaxLength = 6;
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(322, 35);
            this.txt_emp_name.TabIndex = 1;
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Enabled = false;
            this.txt_emp_id.Location = new System.Drawing.Point(292, 52);
            this.txt_emp_id.MaxLength = 6;
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(126, 35);
            this.txt_emp_id.TabIndex = 1;
            this.txt_emp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ-สกุล : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสพนักงาน : ";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_back.Location = new System.Drawing.Point(12, 513);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 37);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "ย้อนกลับ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_confirm.Location = new System.Drawing.Point(879, 513);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(106, 37);
            this.btn_confirm.TabIndex = 10;
            this.btn_confirm.Text = "ยืนยัน";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // SendMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 562);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.group_sendMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendMoneyForm";
            this.Load += new System.EventHandler(this.SendMoneyForm_Load);
            this.group_sendMoney.ResumeLayout(false);
            this.group_sendMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_sendMoney;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.MaskedTextBox txt_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_end;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_bank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fine;
        private System.Windows.Forms.TextBox txt_chang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_bag;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_straps;
    }
}