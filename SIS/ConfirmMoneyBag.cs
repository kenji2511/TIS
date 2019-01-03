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
    public partial class ConfirmMoneyBag : Form
    {
        MoneybagForm moneyBagF = null;
        MenuForm mainForm = null;
        string bag = "";
        string emp_id = "";
        string cabinet = "";
        string money = "";
        string cpoint_id = "";
        public ConfirmMoneyBag(Form callingFrm, Form callingMoneyBagForm, string bag_tmp, string emp_id_tmp, string cabinet_tmp, string money_tmp, string cpoint)
        {
            InitializeComponent();
            mainForm = callingFrm as MenuForm;
            moneyBagF = callingMoneyBagForm as MoneybagForm;
            bag = bag_tmp;
            emp_id = emp_id_tmp;
            cabinet = cabinet_tmp;
            money = money_tmp;
            cpoint_id = cpoint;
            //MessageBox.Show(bag+"\r\n"+ emp_id + "\r\n" +cabinet + "\r\n" +money);
            moneyBagF.Enabled = false;
        }

        private void txt_emp_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void txt_emp_id_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            moneyBagF.Enabled = true;
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            next();
        }
        private void next()
        {
            if (txt_emp_id.Text != "")
            {
                string dateNow = DateTime.Today.ToString("dd-MM-yyyy");
                string dateNext = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy");
                string dateNextDay = dateNext.Split('-')[0] + "-" + dateNext.Split('-')[1] + "-" + dateNext.Split('-')[2];
                bool check = false;

                string sqL_check_bag = "SELECT * FROM tbl_income JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id WHERE (tbl_status_around_date = '" + dateNow + "' OR (tbl_status_around_aid = '1' AND tbl_status_around_date = '" + dateNextDay + "')) AND tbl_income_money_bag = '" + bag + "'";
                string sql_around = "SELECT * FROM tbl_status_around WHERE tbl_status_around_emp_open_id = '" + txt_emp_id.Text + "' AND tbl_status_around_close = '0' AND (tbl_status_around_date = '" + dateNow + "' OR (tbl_status_around_aid = '1' AND tbl_status_around_date = '" + dateNextDay + "') ) AND tbl_status_around_cpoint_id = '" + cpoint_id + "'";

                //MessageBox.Show(sql_around + "\r\n\r\n" + sqL_check_bag);

                ConnectDB contxt = new ConnectDB();
                MySqlConnection conn = new MySqlConnection();
                conn = new MySqlConnection(contxt.context());
                MySqlCommand cmd = new MySqlCommand(sqL_check_bag, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (!reader.Read())
                    {
                        check = true;
                    }
                    else
                    {
                        MessageBox.Show("ถุงเงินซ้ำ!!!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        moneyBagF.Enabled = true;
                        this.Close();
                    }
                    reader.Close();

                    if (check)
                    {
                        cmd = new MySqlCommand(sql_around, conn);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            //MessageBox.Show("ok");
                            conn = new MySqlConnection(contxt.context());
                            conn.Open();
                            MySqlCommand comm = conn.CreateCommand();
                            comm.CommandText = "INSERT INTO tbl_income (tbl_income_money_bag,tbl_income_emp_id,tbl_income_cabinet,tbl_income_around_id,tbl_income_money,tbl_income_status_job,tbl_income_status_backmaney) VALUE (@money_bag,@emp_id,@cabinet,@around_id,@money_amount,'0','0')";
                            comm.Parameters.Add("@money_bag", bag);
                            comm.Parameters.Add("@emp_id", emp_id);
                            comm.Parameters.Add("@cabinet", cabinet);
                            comm.Parameters.Add("@around_id", reader.GetString("tbl_status_around_id"));
                            comm.Parameters.Add("@money_amount", money);
                            comm.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("เรีบยร้อย", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            moneyBagF.Close();
                            mainForm.Enabled = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("รหัสไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_emp_id.Clear();
                            txt_emp_id.Focus();
                        }
                        reader.Close();
                    }
                }
                catch
                {
                    //MessageBox.Show(e.ToString());
                }
                conn.Close();
                //MessageBox.Show(sqL_check_bag+"\r\n\r\n"+sql_around);
            }
            else
            {
                MessageBox.Show("กรุงณาป้อนรหัสเพื่อยืนยัน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_emp_id_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_emp_id.Text != "")
                {
                    next();
                }
                else
                {
                    MessageBox.Show("กรุณาใส่รหัสเพื่อยืนยัน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
