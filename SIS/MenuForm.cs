using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIS
{
    public partial class MenuForm : Form
    {
        public bool aroundStatus = false;
        public bool bagStatus = false;
        string cpoint_id;
        public MenuForm()
        {
            InitializeComponent();

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            FileInfo DirInfo = new FileInfo("conf.txt");
            if (!DirInfo.Exists)
            {
                MessageBox.Show("ไม่พบไฟล์การเชื่อมต่อฐานข้อมูล กรุณาเปิดโปรแกรมใหม่อีกครั้ง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //server=localhost;database=testDB;uid=root;pwd=abc123;
                StreamWriter file = new StreamWriter(@"conf.txt");
                file.WriteLine("server=localhost;database=sis;uid=root;pwd=12345678");
                file.Close();

                this.Close();
            }
            else
            {
                FileInfo DirInfo1 = new FileInfo("around.txt");
                if (!DirInfo1.Exists)
                {
                    btn_around.Image = Properties.Resources.success;
                    btn_around.Text = "เปิดกะ";
                    aroundStatus = true;
                }
                else
                {
                    btn_around.Image = Properties.Resources.error;
                    btn_around.Text = "ปิดกะ";
                    aroundStatus = false;
                }

                FileInfo DirInfo2 = new FileInfo("cpoint.txt");
                if (DirInfo2.Exists)
                {
                    string[] cpoint = File.ReadAllText(@"cpoint.txt").Replace("\r", "").Split('\n');
                    string sql = "SELECT * FROM tbl_cpoint WHERE tbl_cpoint_id =  '" + cpoint[0] + "'";
                    ConnectDB contxt = new ConnectDB();
                    MySqlConnection conn = new MySqlConnection();
                    conn = new MySqlConnection(contxt.context());
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                lb_cpoint.Text = cpoint[0] + "  ด่าน" + reader.GetString("tbl_cpoint_name") + "    ";
                                cpoint_id = cpoint[0];
                            }
                        }
                        else
                        {
                            lb_cpoint.Text = "ไม่พบข้อมูลด่าน";
                            btn_around.Enabled = false;
                        }
                        reader.Close();
                    }
                    catch
                    {

                    }
                    conn.Close();
                }
                else
                {
                    btn_around.Enabled = false;
                    btn_bag.Enabled = false;
                    btn_send.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_report.Enabled = false;
                    btn_refund.Enabled = false;
                }

                if (aroundStatus)
                {
                    btn_bag.Enabled = false;
                    btn_send.Enabled = false;
                    btn_edit.Enabled = false;
                    group_around.Visible = false;
                }
                else
                {
                    group_around.Visible = true;
                    string[] around = File.ReadAllText(@"around.txt").Split('|');
                    string sql = "SELECT * FROM tbl_status_around JOIN tbl_emp ON tbl_status_around_emp_open_id = tbl_emp_id WHERE tbl_status_around_close = '0' AND tbl_emp_id = '"+around[0]+"'";
                    ConnectDB contxt = new ConnectDB();
                    MySqlConnection conn = new MySqlConnection();
                    conn = new MySqlConnection(contxt.context());
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                Script script = new Script();
                                lb_emp_name.Text = reader.GetString("tbl_emp_name");
                                lb_around.Text = script.GetAroundName(reader.GetString("tbl_status_around_aid"));
                            }
                        }
                        else
                        {
                            lb_cpoint.Text = "ไม่พบข้อมูลด่าน";
                            btn_around.Enabled = false;
                        }
                        reader.Close();
                    }
                    catch
                    {

                    }
                    conn.Close();
                }
            }
        }

        private void btn_around_Click(object sender, EventArgs e)
        {

            if (btn_around.Text == "เปิดกะ")
            {
                //IndexForm formMain = new IndexForm();
                AroundForm form = new AroundForm(this, cpoint_id);
                form.Show();
                this.Enabled = false;
                //this.Hide();
            }
            else
            {
                AroundCloseForm closeAround = new AroundCloseForm(this);
                closeAround.Show();
                this.Enabled = false;
            }

        }

        private void btn_bag_Click(object sender, EventArgs e)
        {
            MoneybagForm getBagForm = new MoneybagForm(this, cpoint_id);
            getBagForm.Show();
            this.Enabled = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            EmpSendMoneyForm sendForm = new EmpSendMoneyForm(this);
            sendForm.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EmpToEditMoneyForm editMoneyForm = new EmpToEditMoneyForm(this);
            editMoneyForm.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(this);
            form.Show();
            this.Enabled = false;
        }

        private void timer_show_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportViweForm reportViweForm = new ReportViweForm(this);
            reportViweForm.Show();
        }

        private void btn_refund_Click(object sender, EventArgs e)
        {
            RefunForm refunForm = new RefunForm(this);
            refunForm.Show();
        }
    }
}
