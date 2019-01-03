namespace SIS
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            this.lb_cpoint = new System.Windows.Forms.Label();
            this.timer_show = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_around = new System.Windows.Forms.GroupBox();
            this.lb_emp_name = new System.Windows.Forms.Label();
            this.lb_around = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refund = new System.Windows.Forms.Button();
            this.btn_around = new System.Windows.Forms.Button();
            this.btn_bag = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.group_around.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_cpoint
            // 
            this.lb_cpoint.AutoEllipsis = true;
            this.lb_cpoint.AutoSize = true;
            this.lb_cpoint.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_cpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_cpoint.ForeColor = System.Drawing.Color.White;
            this.lb_cpoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_cpoint.Location = new System.Drawing.Point(991, 0);
            this.lb_cpoint.Name = "lb_cpoint";
            this.lb_cpoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_cpoint.Size = new System.Drawing.Size(255, 42);
            this.lb_cpoint.TabIndex = 25;
            this.lb_cpoint.Text = "ไม่พบข้อมูลด่าน";
            this.lb_cpoint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer_show
            // 
            this.timer_show.Enabled = true;
            this.timer_show.Tick += new System.EventHandler(this.timer_show_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoEllipsis = true;
            this.lb_time.AutoSize = true;
            this.lb_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_time.Location = new System.Drawing.Point(0, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(172, 42);
            this.lb_time.TabIndex = 27;
            this.lb_time.Text = "00:00:00";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.group_around);
            this.groupBox1.Controls.Add(this.btn_refund);
            this.groupBox1.Controls.Add(this.btn_around);
            this.groupBox1.Controls.Add(this.btn_bag);
            this.groupBox1.Controls.Add(this.btn_send);
            this.groupBox1.Controls.Add(this.btn_report);
            this.groupBox1.Controls.Add(this.btn_setting);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 565);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ระบบนำส่งเงินรายได้ค่าธรรมเนียม";
            // 
            // group_around
            // 
            this.group_around.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_around.Controls.Add(this.lb_emp_name);
            this.group_around.Controls.Add(this.lb_around);
            this.group_around.Controls.Add(this.label1);
            this.group_around.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.group_around.ForeColor = System.Drawing.Color.White;
            this.group_around.Location = new System.Drawing.Point(689, 34);
            this.group_around.Name = "group_around";
            this.group_around.Size = new System.Drawing.Size(509, 121);
            this.group_around.TabIndex = 8;
            this.group_around.TabStop = false;
            this.group_around.Text = "ข้อมูลผลัด";
            this.group_around.Visible = false;
            // 
            // lb_emp_name
            // 
            this.lb_emp_name.AutoSize = true;
            this.lb_emp_name.Location = new System.Drawing.Point(154, 31);
            this.lb_emp_name.Name = "lb_emp_name";
            this.lb_emp_name.Size = new System.Drawing.Size(91, 29);
            this.lb_emp_name.TabIndex = 2;
            this.lb_emp_name.Text = "ชื่อ-สกุล";
            // 
            // lb_around
            // 
            this.lb_around.AutoSize = true;
            this.lb_around.Location = new System.Drawing.Point(62, 76);
            this.lb_around.Name = "lb_around";
            this.lb_around.Size = new System.Drawing.Size(54, 29);
            this.lb_around.TabIndex = 1;
            this.lb_around.Text = "ผลัด";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "รองฯ : ";
            // 
            // btn_refund
            // 
            this.btn_refund.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refund.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_refund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refund.ForeColor = System.Drawing.Color.Black;
            this.btn_refund.Image = global::SIS.Properties.Resources.notes1;
            this.btn_refund.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_refund.Location = new System.Drawing.Point(837, 192);
            this.btn_refund.Name = "btn_refund";
            this.btn_refund.Size = new System.Drawing.Size(151, 189);
            this.btn_refund.TabIndex = 6;
            this.btn_refund.Text = "คืนเงินผู้ใช้ทาง\r\n ";
            this.btn_refund.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_refund.UseVisualStyleBackColor = true;
            this.btn_refund.Click += new System.EventHandler(this.btn_refund_Click);
            // 
            // btn_around
            // 
            this.btn_around.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_around.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_around.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_around.ForeColor = System.Drawing.Color.Black;
            this.btn_around.Image = global::SIS.Properties.Resources.error;
            this.btn_around.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_around.Location = new System.Drawing.Point(52, 192);
            this.btn_around.Name = "btn_around";
            this.btn_around.Size = new System.Drawing.Size(151, 189);
            this.btn_around.TabIndex = 1;
            this.btn_around.Text = "สถานะผลัด\r\n ";
            this.btn_around.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_around.UseVisualStyleBackColor = true;
            this.btn_around.Click += new System.EventHandler(this.btn_around_Click);
            // 
            // btn_bag
            // 
            this.btn_bag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_bag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_bag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bag.ForeColor = System.Drawing.Color.Black;
            this.btn_bag.Image = global::SIS.Properties.Resources.rich;
            this.btn_bag.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_bag.Location = new System.Drawing.Point(209, 192);
            this.btn_bag.Name = "btn_bag";
            this.btn_bag.Size = new System.Drawing.Size(151, 189);
            this.btn_bag.TabIndex = 2;
            this.btn_bag.Text = "เบิกถุงเงิน\r\n ";
            this.btn_bag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_bag.UseVisualStyleBackColor = true;
            this.btn_bag.Click += new System.EventHandler(this.btn_bag_Click);
            // 
            // btn_send
            // 
            this.btn_send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.Black;
            this.btn_send.Image = global::SIS.Properties.Resources.change;
            this.btn_send.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_send.Location = new System.Drawing.Point(366, 192);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(151, 189);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "คืนเงินยืม\r\nนำส่งเงินรายได้";
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_report
            // 
            this.btn_report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_report.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.Black;
            this.btn_report.Image = global::SIS.Properties.Resources.receipt;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_report.Location = new System.Drawing.Point(680, 192);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(151, 189);
            this.btn_report.TabIndex = 5;
            this.btn_report.Text = "พิมพ์รายงาน\r\n ";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_setting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.Black;
            this.btn_setting.Image = global::SIS.Properties.Resources.settings;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_setting.Location = new System.Drawing.Point(994, 192);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(151, 189);
            this.btn_setting.TabIndex = 7;
            this.btn_setting.Text = "ตั้งค่า\r\n ";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Image = global::SIS.Properties.Resources.get_money__1_;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_edit.Location = new System.Drawing.Point(523, 192);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(151, 189);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "ปรับยอด\r\n ";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1246, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_cpoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.group_around.ResumeLayout(false);
            this.group_around.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_around;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_bag;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lb_cpoint;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Timer timer_show;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_refund;
        private System.Windows.Forms.GroupBox group_around;
        private System.Windows.Forms.Label lb_emp_name;
        private System.Windows.Forms.Label lb_around;
        private System.Windows.Forms.Label label1;
    }
}