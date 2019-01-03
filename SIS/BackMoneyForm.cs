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
    public partial class BackMoneyForm : Form
    {
        MenuForm mainForm = null;
        string emp_id = "";
        public BackMoneyForm(Form callingForm,string emp)
        {
            InitializeComponent();
            mainForm = callingForm as MenuForm;
            mainForm.Enabled = false;
            emp_id = emp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script script = new Script();
            script.CheckNumber(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script script = new Script();
            script.CheckNumber(e);
        }

        private void txt_emp_id_KeyUp(object sender, KeyEventArgs e)
        {
                
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_money.Text != "")
            {
                next();
            }
            else
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_money.Focus();
            }
        }
        private void next()
        {
            //MessageBox.Show("คืนเงิน");
            if (MessageBox.Show("ต้องการยืนยันการคืนเงินยืม ใช่ หรือ ไม่", "ยืนยัน", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ConnectDB contxt = new ConnectDB();
                MySqlConnection conn = new MySqlConnection();
                conn = new MySqlConnection(contxt.context());
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                try
                {
                    comm.CommandText = "UPDATE tbl_income SET tbl_income_status_backmaney = '1' WHERE tbl_income_emp_id = '"+ txt_emp_id.Text + "' AND tbl_income_status_backmaney = '0'";
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                    if(MessageBox.Show("คืนเงินยืมเรียบร้อยแล้ว \r\n ต้องการทำรายการ \"นำส่งเงินรายได้\" ต่อไปหรือไม่", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //
                        SendMoneyForm sendMoneyForm = new SendMoneyForm(mainForm,emp_id);
                        sendMoneyForm.Show();

                    }
                    else
                    {
                        mainForm.Enabled = true;
                    }
                    
                }
                catch
                {
                    //
                }
            }
        }

        private void txt_emp_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_money.Text != "")
            {
                next();
            }
            else
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_money.Focus();
            }
        }

        private void txt_money_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_money.Text != "")
            {
                next();
            }
            else
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_money.Focus();
            }
        }

        private void BackMoneyForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_income JOIN tbl_emp ON tbl_income_emp_id = tbl_emp_id WHERE tbl_emp_id = '" + emp_id + "' AND tbl_income_status_backmaney = '0'";
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
                    txt_money.Text = reader.GetString("tbl_income_money");
                    btn_next.Enabled = true;
                }
                reader.Close();
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }
    }
}
