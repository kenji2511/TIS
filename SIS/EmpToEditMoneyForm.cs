using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIS
{
    public partial class EmpToEditMoneyForm : Form
    {
        MenuForm mainForm = null;
        public EmpToEditMoneyForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as MenuForm;
            mainForm.Enabled = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_emp_id.Text !="")
            {
                next();
            }
            else
            {
                MessageBox.Show("กรุณานาใส่รหัสพนักงาน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_emp_id.Focus();
            }
        }
        private void next()
        {
            string sql = "SELECT * FROM tbl_income JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id JOIN tbl_emp ON tbl_emp_id = tbl_income_emp_id WHERE tbl_income_emp_id = '" + txt_emp_id.Text + "' AND tbl_status_around_close = '0' AND tbl_income_status_job = '1' AND tbl_income_other IS NULL";

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
                    //MessageBox.Show("OK");
                    EditMoneyForm editMoneyForm = new EditMoneyForm(mainForm,reader.GetString("tbl_emp_id"), reader.GetString("tbl_emp_name"),reader.GetString("tbl_income_around_id"));
                    //EditMoneyForm editMoneyForm = new EditMoneyForm(mainForm, "", "", "");
                    editMoneyForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูล อาจจะยังไม่ได้นำส่งยอดของพนักงาน หรือปรับยอดไปแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_emp_id.Clear();
                    txt_emp_id.Focus();
                }
                reader.Close();
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
            conn.Close();
        }

        private void txt_emp_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
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
                    MessageBox.Show("กรุณานาใส่รหัสพนักงาน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_emp_id.Focus();
                }
            }
        }

        private void EditMoneyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_emp_id.Text != "")
                {
                    next();
                }
                else
                {
                    MessageBox.Show("กรุณานาใส่รหัสพนักงาน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_emp_id.Focus();
                }
            }
        }
    }
}
