namespace SIS
{
    partial class MoneybagForm
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
            this.txt_cabinet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_emp_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.txt_bag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cabinet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_emp_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_money);
            this.groupBox1.Controls.Add(this.txt_bag);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_emp_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เบิกถุงเงินและรับเงินยืม";
            // 
            // txt_cabinet
            // 
            this.txt_cabinet.Location = new System.Drawing.Point(483, 165);
            this.txt_cabinet.MaxLength = 2;
            this.txt_cabinet.Name = "txt_cabinet";
            this.txt_cabinet.Size = new System.Drawing.Size(49, 35);
            this.txt_cabinet.TabIndex = 3;
            this.txt_cabinet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cabinet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cabinet_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "บาท";
            // 
            // lb_emp_name
            // 
            this.lb_emp_name.AutoSize = true;
            this.lb_emp_name.Location = new System.Drawing.Point(253, 114);
            this.lb_emp_name.Name = "lb_emp_name";
            this.lb_emp_name.Size = new System.Drawing.Size(202, 29);
            this.lb_emp_name.TabIndex = 10;
            this.lb_emp_name.Text = "ไม่พบข้อมูลพนักงาน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "ชื่อ-สกุล : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "รับเงินทอนจำนวน : ";
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(253, 215);
            this.txt_money.MaxLength = 10;
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(224, 35);
            this.txt_money.TabIndex = 4;
            this.txt_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_money_KeyPress);
            // 
            // txt_bag
            // 
            this.txt_bag.Location = new System.Drawing.Point(253, 165);
            this.txt_bag.MaxLength = 4;
            this.txt_bag.Name = "txt_bag";
            this.txt_bag.Size = new System.Drawing.Size(115, 35);
            this.txt_bag.TabIndex = 2;
            this.txt_bag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bag_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "ตู้ที่ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ถุงเงิน : ";
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Location = new System.Drawing.Point(253, 56);
            this.txt_emp_id.MaxLength = 6;
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(115, 35);
            this.txt_emp_id.TabIndex = 1;
            this.txt_emp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_emp_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_id_KeyPress);
            this.txt_emp_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_emp_id_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสพนักงาน : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(12, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "ย้อนกลับ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_save.Location = new System.Drawing.Point(571, 322);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 34);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "เสร็จสิ้น";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // MoneybagForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 369);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MoneybagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneybagForm";
            this.Load += new System.EventHandler(this.MoneybagForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.TextBox txt_bag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_emp_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.TextBox txt_cabinet;
    }
}