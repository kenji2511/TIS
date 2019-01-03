using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SIS
{
    public partial class AroundCloseForm : Form
    {
        MenuForm maniForm = null;
        public AroundCloseForm(Form callingForm)
        {
            InitializeComponent();
            maniForm = callingForm as MenuForm;
        }

        private void next()
        {
            bool chk = false;
            ConnectDB contxt = new ConnectDB();
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection(contxt.context());
            string sql = "select * from tbl_status_around WHERE tbl_status_around_close = '0' AND tbl_status_around_emp_open_id = '" + txt_emp_id.Text + "'";
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
                        chk = true;
                    }
                }
                reader.Close();
            }
            catch
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("รหัสไม่ถูกต้อง");
                txt_emp_id.Clear();
            }
            conn.Close();

            if (chk)
            {
                bool ck_job = false;
                string sql_check_job = "SELECT * FROM tbl_income JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id WHERE tbl_income_status_job = '0' AND tbl_status_around_emp_open_id = '" +txt_emp_id.Text+"'";
                conn.Open();
                cmd = new MySqlCommand(sql_check_job, conn);
                reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    ck_job = true;
                }
                else
                {
                    MessageBox.Show("ยังปิด JOB งานไม่ครบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    maniForm.Enabled = true;
                    this.Close();
                }
                conn.Close();

                if (ck_job)
                {
                    MySqlCommand comm = conn.CreateCommand();
                    conn.Open();
                    sql = "UPDATE tbl_status_around SET tbl_status_around_close = '1' WHERE tbl_status_around_close = '0' AND tbl_status_around_emp_open_id = '" + txt_emp_id.Text + "'";
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();
                    MessageBox.Show("ปิดกะเรียบร้อย", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    File.Delete(@"around.txt");

                    Application.Restart();
                }
            }else{
                MessageBox.Show("รหัสไม่ถูกต้อง","แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_emp_id.Clear();
            }

        }

        private void AroundCloseForm_Load(object sender, EventArgs e)
        {
            txt_emp_id.Focus();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            maniForm.Enabled = true;
            this.Close();
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("ปิดกะ");
            if (txt_emp_id.Text != "")
            {
                next();
            }
            else
            {
                MessageBox.Show("กรุณาใส่รหัสผู้ปิดผลัด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_emp_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_emp_id.Text != "")
                {
                    next();
                }
                else
                {
                    MessageBox.Show("กรุณาใส่รหัสผู้ปิดผลัด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void AroundCloseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_emp_id.Text != "")
                {
                    next();
                }
                else
                {
                    MessageBox.Show("กรุณาใส่รหัสผู้ปิดผลัด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_emp_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }
    }
}
