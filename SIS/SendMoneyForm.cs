using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIS
{
    public partial class SendMoneyForm : Form
    {
        MenuForm mainForm = null;
        string emp_id;
        int total_tmp = 0;
        int chang_tmp = 0;
        int fine_tmp = 0;
        int bank_tmp = 0;
        public SendMoneyForm(Form callingForm, string emp)
        {
            InitializeComponent();
            mainForm = callingForm as MenuForm;
            emp_id = emp;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void txt_chang_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void txt_fine_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (btn_confirm.Text == "ยืนยัน")
            {
                if (txt_start.Text.Length == 5 && txt_end.Text.Length == 5)
                {
                    if (txt_job.Text != "" && txt_straps.Text != "")
                    {
                        if (txt_total.Text != "" && txt_fine.Text != "" && txt_chang.Text != "")
                        {
                            group_sendMoney.Enabled = false;
                            total_tmp = Int32.Parse(txt_total.Text);
                            chang_tmp = Int32.Parse(txt_chang.Text);
                            fine_tmp = Int32.Parse(txt_fine.Text);

                            txt_total.Text = Int32.Parse(txt_total.Text).ToString("N", new CultureInfo("en-US"));
                            txt_chang.Text = Int32.Parse(txt_chang.Text).ToString("N", new CultureInfo("en-US"));
                            txt_fine.Text = Int32.Parse(txt_fine.Text).ToString("N", new CultureInfo("en-US"));

                            txt_total.TextAlign = HorizontalAlignment.Right;
                            txt_chang.TextAlign = HorizontalAlignment.Right;
                            txt_fine.TextAlign = HorizontalAlignment.Right;
                            txt_bank.TextAlign = HorizontalAlignment.Right;

                            btn_confirm.Text = "ส่งข้อมูล";
                            btn_back.Text = "แก้ไขข้อมูล";
                        }
                        else
                        {
                            MessageBox.Show("กรุณาใส่จำนวนเงินให้ครบทุกช่อง ถ้าไม่มีให้ใส่ 0", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_total.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณาใส่งานที่ และ หมายเลขสายรัด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_job.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("กรุณาป้อน เวลาเข้า และ เวลาออก ให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (btn_confirm.Text == "ส่งข้อมูล")
            {
                if (MessageBox.Show("ยืนยันข้อมูลถูกต้อง ใช่หรือไม่?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //MessageBox.Show("บันทึกโลด");
                    ConnectDB contxt = new ConnectDB();
                    MySqlConnection conn = new MySqlConnection();
                    conn = new MySqlConnection(contxt.context());
                    conn.Open();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "UPDATE tbl_income SET tbl_income_straps = '" + txt_straps.Text + "', tbl_income_job = '" + txt_job.Text + "', tbl_income_in_time = '" + txt_start.Text + "', tbl_income_out_time = '" + txt_end.Text + "', tbl_income_total = '" + total_tmp + "', tbl_income_bank  = '" + bank_tmp + "', tbl_income_user  = '" + chang_tmp + "',tbl_income_fine  = '" + fine_tmp + "', tbl_income_status_job = '1' WHERE tbl_income_emp_id = '" + emp_id + "' AND tbl_income_status_backmaney = '1' AND tbl_income_status_job = '0'";
                    comm.ExecuteNonQuery();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อนแล้ว", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.Enabled = true;
                    this.Close();
                }
            }
        }

        private void group_sendMoney_Enter(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (btn_back.Text == "ย้อนกลับ")
            {
                mainForm.Enabled = true;
                this.Close();
            }
            else
            {
                group_sendMoney.Enabled = true;
                btn_back.Text = "ย้อนกลับ";
                btn_confirm.Text = "ยืนยัน";
                txt_total.Text = total_tmp.ToString();
                txt_chang.Text = chang_tmp.ToString();
                txt_fine.Text = fine_tmp.ToString();

                txt_total.TextAlign = HorizontalAlignment.Center;
                txt_chang.TextAlign = HorizontalAlignment.Center;
                txt_fine.TextAlign = HorizontalAlignment.Center;
                txt_bank.TextAlign = HorizontalAlignment.Center;

            }
        }
        private void calculateBank()
        {
            int total = Int32.Parse(txt_total.Text == "" ? "0" : txt_total.Text);
            int chang = Int32.Parse(txt_chang.Text == "" ? "0" : txt_chang.Text);
            int fine = Int32.Parse(txt_fine.Text == "" ? "0" : txt_fine.Text);

            txt_bank.Text = (total - chang - fine).ToString("N", new CultureInfo("en-US"));
            bank_tmp = total - chang - fine;
        }

        private void txt_total_KeyUp(object sender, KeyEventArgs e)
        {
            calculateBank();
        }

        private void txt_chang_KeyUp(object sender, KeyEventArgs e)
        {
            calculateBank();
        }

        private void txt_fine_KeyUp(object sender, KeyEventArgs e)
        {
            calculateBank();
        }

        private void txt_job_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void SendMoneyForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_income JOIN tbl_emp ON tbl_income_emp_id = tbl_emp_id WHERE tbl_emp_id = '" + emp_id + "' AND tbl_income_status_backmaney = '1' AND tbl_income_status_job = '0'";
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
                    txt_emp_id.Text = emp_id;
                    txt_emp_name.Text = reader.GetString("tbl_emp_name");
                    txt_bag.Text = reader.GetString("tbl_income_money_bag");
                }
                reader.Close();
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
            conn.Close();
        }
    }
}
