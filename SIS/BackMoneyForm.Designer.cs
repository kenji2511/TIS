namespace SIS
{
    partial class BackMoneyForm
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
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.txt_bag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_emp_name);
            this.groupBox1.Controls.Add(this.txt_bag);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_money);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_emp_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "คืนเงินยืม";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Enabled = false;
            this.txt_emp_name.Location = new System.Drawing.Point(227, 99);
            this.txt_emp_name.MaxLength = 4;
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(358, 35);
            this.txt_emp_name.TabIndex = 9;
            // 
            // txt_bag
            // 
            this.txt_bag.Enabled = false;
            this.txt_bag.Location = new System.Drawing.Point(227, 144);
            this.txt_bag.MaxLength = 4;
            this.txt_bag.Name = "txt_bag";
            this.txt_bag.Size = new System.Drawing.Size(100, 35);
            this.txt_bag.TabIndex = 8;
            this.txt_bag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "ถุงเงิน : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "บาท";
            // 
            // txt_money
            // 
            this.txt_money.Enabled = false;
            this.txt_money.Location = new System.Drawing.Point(227, 192);
            this.txt_money.MaxLength = 10;
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(143, 35);
            this.txt_money.TabIndex = 2;
            this.txt_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_money.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_money_KeyDown);
            this.txt_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "จำนวนเงินที่ยืม : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อ-สกุล : ";
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Enabled = false;
            this.txt_emp_id.Location = new System.Drawing.Point(227, 48);
            this.txt_emp_id.MaxLength = 6;
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(143, 35);
            this.txt_emp_id.TabIndex = 1;
            this.txt_emp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_emp_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_emp_id_KeyDown);
            this.txt_emp_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txt_emp_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_emp_id_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสพนักงาน : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(12, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "ย้อนกลับ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_next.Location = new System.Drawing.Point(465, 277);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(151, 35);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "ยืนยันคืนเงินยืม";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // BackMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 324);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendForm";
            this.Load += new System.EventHandler(this.BackMoneyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emp_name;
    }
}