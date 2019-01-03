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
    public partial class SettingForm : Form
    {
        MenuForm maniForm = null;
        public SettingForm(Form callingForm)
        {
            InitializeComponent();
            maniForm = callingForm as MenuForm;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

            FileInfo DirInfo2 = new FileInfo("cpoint.txt");
            if (DirInfo2.Exists)
            {
                string[] cpoint = File.ReadAllText(@"cpoint.txt").Replace("\r", "").Split('\n');
                txt_cpoint.Text = cpoint[0];
                GetCPoint();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            maniForm.Enabled = true;
            this.Close();
        }

        private void txt_cpoint_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_cpoint.Text.Length == 3) {
                GetCPoint();
            }
        }

        private void btn_save_cpoint_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void GetCPoint()
        {
                //MessageBox.Show("ด่าน");
                ConnectDB contxt = new ConnectDB();
                MySqlConnection conn = new MySqlConnection();
                conn = new MySqlConnection(contxt.context());
                string sql = "SELECT * FROM tbl_cpoint WHERE tbl_cpoint_id = '" + txt_cpoint.Text + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //MessageBox.Show(sql);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            txt_cpoint_name.Text = reader.GetString("tbl_cpoint_name");
                            //txt_manager.Text = reader.GetString("tbl_prefix_name") + " " + reader.GetString("tbl_emp_name") + "   " + reader.GetString("tbl_emp_lname");
                        }
                    }
                    else
                    {
                        txt_cpoint_name.Text = "ไม่พบข้อมูล";
                        txt_cpoint.Clear();
                    }
                    reader.Close();
                }
                catch
                {

                }
                conn.Close();
            
        }

        private void txt_bag_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void txt_bag_end_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void txt_cpoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void txt_cpoint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private void Save()
        {
            if (txt_cpoint.Text != "")
            {
                //MessageBox.Show(txt_cpoint.Text);
                StreamWriter file = new StreamWriter(@"cpoint.txt");
                file.WriteLine(txt_cpoint.Text);
                file.Close();
                MessageBox.Show("ตั้งค่าด่านสำเร็จ", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("กรุณาใส่รหัสด่าน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
