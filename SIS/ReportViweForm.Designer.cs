namespace SIS
{
    partial class ReportViweForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx_main = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_u1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_u2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_u3 = new System.Windows.Forms.TextBox();
            this.label_u3 = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
            this.label_u2 = new System.Windows.Forms.Label();
            this.label_u1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cryViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.group_date = new System.Windows.Forms.GroupBox();
            this.rd_p3 = new System.Windows.Forms.RadioButton();
            this.rd_p2 = new System.Windows.Forms.RadioButton();
            this.rd_p1 = new System.Windows.Forms.RadioButton();
            this.txt_date_end = new System.Windows.Forms.DateTimePicker();
            this.txt_date_start = new System.Windows.Forms.DateTimePicker();
            this.lb_date2 = new System.Windows.Forms.Label();
            this.lb_date1 = new System.Windows.Forms.Label();
            this.cb_select_report = new System.Windows.Forms.ComboBox();
            this.CrystalReport11 = new SIS.CrystalReport1();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.group_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cryViewer);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.group_date);
            this.groupBox1.Controls.Add(this.cb_select_report);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 838);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "พิมพ์รายงาน";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_no);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtx_main);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_u1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_u2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_u3);
            this.groupBox2.Controls.Add(this.label_u3);
            this.groupBox2.Controls.Add(this.label_main);
            this.groupBox2.Controls.Add(this.label_u2);
            this.groupBox2.Controls.Add(this.label_u1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(38, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 241);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(191, 20);
            this.txt_no.MaxLength = 4;
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(66, 29);
            this.txt_no.TabIndex = 7;
            this.txt_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_KeyPress);
            this.txt_no.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_no_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "เลขที่ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ใส่รหัสประธาน ก.ส.ธ. : ";
            // 
            // txtx_main
            // 
            this.txtx_main.Location = new System.Drawing.Point(191, 91);
            this.txtx_main.MaxLength = 6;
            this.txtx_main.Name = "txtx_main";
            this.txtx_main.Size = new System.Drawing.Size(89, 29);
            this.txtx_main.TabIndex = 9;
            this.txtx_main.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtx_main_KeyPress);
            this.txtx_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtx_main_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "ใส่รหัสผู้นำส่งเงิน : ";
            // 
            // txt_u1
            // 
            this.txt_u1.Location = new System.Drawing.Point(191, 56);
            this.txt_u1.MaxLength = 6;
            this.txt_u1.Name = "txt_u1";
            this.txt_u1.Size = new System.Drawing.Size(89, 29);
            this.txt_u1.TabIndex = 8;
            this.txt_u1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_u1_KeyPress);
            this.txt_u1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_u1_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "ใส่รหัสผู้นำส่งเงิน : ";
            // 
            // txt_u2
            // 
            this.txt_u2.Location = new System.Drawing.Point(191, 126);
            this.txt_u2.MaxLength = 6;
            this.txt_u2.Name = "txt_u2";
            this.txt_u2.Size = new System.Drawing.Size(89, 29);
            this.txt_u2.TabIndex = 10;
            this.txt_u2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_u2_KeyPress);
            this.txt_u2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_u2_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ใส่รหัสผู้นำส่งเงิน : ";
            // 
            // txt_u3
            // 
            this.txt_u3.Location = new System.Drawing.Point(191, 161);
            this.txt_u3.MaxLength = 6;
            this.txt_u3.Name = "txt_u3";
            this.txt_u3.Size = new System.Drawing.Size(89, 29);
            this.txt_u3.TabIndex = 11;
            this.txt_u3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_u3_KeyPress);
            this.txt_u3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_u3_KeyUp);
            // 
            // label_u3
            // 
            this.label_u3.AutoSize = true;
            this.label_u3.Location = new System.Drawing.Point(286, 164);
            this.label_u3.Name = "label_u3";
            this.label_u3.Size = new System.Drawing.Size(0, 24);
            this.label_u3.TabIndex = 4;
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Location = new System.Drawing.Point(286, 94);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(0, 24);
            this.label_main.TabIndex = 4;
            // 
            // label_u2
            // 
            this.label_u2.AutoSize = true;
            this.label_u2.Location = new System.Drawing.Point(286, 129);
            this.label_u2.Name = "label_u2";
            this.label_u2.Size = new System.Drawing.Size(0, 24);
            this.label_u2.TabIndex = 4;
            // 
            // label_u1
            // 
            this.label_u1.AutoSize = true;
            this.label_u1.Location = new System.Drawing.Point(286, 59);
            this.label_u1.Name = "label_u1";
            this.label_u1.Size = new System.Drawing.Size(0, 24);
            this.label_u1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.Location = new System.Drawing.Point(870, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 28);
            this.button4.TabIndex = 13;
            this.button4.Text = "ย้อนกลับ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cryViewer
            // 
            this.cryViewer.ActiveViewIndex = -1;
            this.cryViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cryViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryViewer.Location = new System.Drawing.Point(521, 188);
            this.cryViewer.Name = "cryViewer";
            this.cryViewer.ShowCloseButton = false;
            this.cryViewer.ShowCopyButton = false;
            this.cryViewer.ShowExportButton = false;
            this.cryViewer.ShowGotoPageButton = false;
            this.cryViewer.ShowGroupTreeButton = false;
            this.cryViewer.ShowLogo = false;
            this.cryViewer.ShowPageNavigateButtons = false;
            this.cryViewer.ShowParameterPanelButton = false;
            this.cryViewer.ShowTextSearchButton = false;
            this.cryViewer.Size = new System.Drawing.Size(434, 644);
            this.cryViewer.TabIndex = 6;
            this.cryViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // group_date
            // 
            this.group_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_date.Controls.Add(this.rd_p3);
            this.group_date.Controls.Add(this.rd_p2);
            this.group_date.Controls.Add(this.rd_p1);
            this.group_date.Controls.Add(this.txt_date_end);
            this.group_date.Controls.Add(this.txt_date_start);
            this.group_date.Controls.Add(this.lb_date2);
            this.group_date.Controls.Add(this.lb_date1);
            this.group_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.group_date.Location = new System.Drawing.Point(38, 83);
            this.group_date.Name = "group_date";
            this.group_date.Size = new System.Drawing.Size(896, 80);
            this.group_date.TabIndex = 5;
            this.group_date.TabStop = false;
            this.group_date.Text = "วันที่";
            this.group_date.Visible = false;
            // 
            // rd_p3
            // 
            this.rd_p3.AutoSize = true;
            this.rd_p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rd_p3.Location = new System.Drawing.Point(732, 44);
            this.rd_p3.Name = "rd_p3";
            this.rd_p3.Size = new System.Drawing.Size(161, 22);
            this.rd_p3.TabIndex = 6;
            this.rd_p3.TabStop = true;
            this.rd_p3.Text = "ผลัดที่ 3 (14:00-22:00)";
            this.rd_p3.UseVisualStyleBackColor = true;
            this.rd_p3.Visible = false;
            this.rd_p3.CheckedChanged += new System.EventHandler(this.rd_p3_CheckedChanged);
            // 
            // rd_p2
            // 
            this.rd_p2.AutoSize = true;
            this.rd_p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rd_p2.Location = new System.Drawing.Point(565, 44);
            this.rd_p2.Name = "rd_p2";
            this.rd_p2.Size = new System.Drawing.Size(161, 22);
            this.rd_p2.TabIndex = 5;
            this.rd_p2.TabStop = true;
            this.rd_p2.Text = "ผลัดที่ 2 (06:00-14:00)";
            this.rd_p2.UseVisualStyleBackColor = true;
            this.rd_p2.Visible = false;
            this.rd_p2.CheckedChanged += new System.EventHandler(this.rd_p2_CheckedChanged);
            // 
            // rd_p1
            // 
            this.rd_p1.AutoSize = true;
            this.rd_p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rd_p1.Location = new System.Drawing.Point(398, 44);
            this.rd_p1.Name = "rd_p1";
            this.rd_p1.Size = new System.Drawing.Size(161, 22);
            this.rd_p1.TabIndex = 4;
            this.rd_p1.TabStop = true;
            this.rd_p1.Text = "ผลัดที่ 1 (22:00-06:00)";
            this.rd_p1.UseVisualStyleBackColor = true;
            this.rd_p1.Visible = false;
            this.rd_p1.CheckedChanged += new System.EventHandler(this.rd_p1_CheckedChanged);
            // 
            // txt_date_end
            // 
            this.txt_date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_date_end.Location = new System.Drawing.Point(251, 38);
            this.txt_date_end.Name = "txt_date_end";
            this.txt_date_end.Size = new System.Drawing.Size(141, 29);
            this.txt_date_end.TabIndex = 3;
            // 
            // txt_date_start
            // 
            this.txt_date_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_date_start.Location = new System.Drawing.Point(71, 38);
            this.txt_date_start.Name = "txt_date_start";
            this.txt_date_start.Size = new System.Drawing.Size(141, 29);
            this.txt_date_start.TabIndex = 2;
            this.txt_date_start.ValueChanged += new System.EventHandler(this.txt_date_start_ValueChanged);
            // 
            // lb_date2
            // 
            this.lb_date2.AutoSize = true;
            this.lb_date2.Location = new System.Drawing.Point(218, 42);
            this.lb_date2.Name = "lb_date2";
            this.lb_date2.Size = new System.Drawing.Size(27, 24);
            this.lb_date2.TabIndex = 0;
            this.lb_date2.Text = "ถึง";
            // 
            // lb_date1
            // 
            this.lb_date1.AutoSize = true;
            this.lb_date1.Location = new System.Drawing.Point(16, 42);
            this.lb_date1.Name = "lb_date1";
            this.lb_date1.Size = new System.Drawing.Size(49, 24);
            this.lb_date1.TabIndex = 0;
            this.lb_date1.Text = "ตั้งแต่";
            // 
            // cb_select_report
            // 
            this.cb_select_report.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_select_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_select_report.FormattingEnabled = true;
            this.cb_select_report.Items.AddRange(new object[] {
            "รายงานนำส่งรายได้/ผลัด",
            "รายงานนำส่งรายได้ ธร.4",
            "รายงานนำส่งรายได้ ธร.5"});
            this.cb_select_report.Location = new System.Drawing.Point(38, 44);
            this.cb_select_report.Name = "cb_select_report";
            this.cb_select_report.Size = new System.Drawing.Size(318, 33);
            this.cb_select_report.TabIndex = 1;
            this.cb_select_report.Text = "เลือก";
            this.cb_select_report.SelectedIndexChanged += new System.EventHandler(this.cb_select_report_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "แสดง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportViweForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 862);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReportViweForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportViweForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViweForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.group_date.ResumeLayout(false);
            this.group_date.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cb_select_report;
        private System.Windows.Forms.GroupBox group_date;
        private System.Windows.Forms.DateTimePicker txt_date_end;
        private System.Windows.Forms.DateTimePicker txt_date_start;
        private System.Windows.Forms.Label lb_date2;
        private System.Windows.Forms.Label lb_date1;
        private System.Windows.Forms.RadioButton rd_p3;
        private System.Windows.Forms.RadioButton rd_p2;
        private System.Windows.Forms.RadioButton rd_p1;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.TextBox txt_u3;
        private System.Windows.Forms.TextBox txt_u2;
        private System.Windows.Forms.TextBox txt_u1;
        private System.Windows.Forms.TextBox txtx_main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_u3;
        private System.Windows.Forms.Label label_u2;
        private System.Windows.Forms.Label label_u1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryViewer;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}