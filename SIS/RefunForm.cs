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
    public partial class RefunForm : Form
    {
        MenuForm mainForm = null;
        string user = "0";
        string fine = "0";
        string[] data = null;
        public RefunForm(Form callingForm)
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

        private void RefunForm_Load(object sender, EventArgs e)
        {
            date_value.CustomFormat = "dd-MM-yyyy";
        }

        private void rdo_fine_CheckedChanged(object sender, EventArgs e)
        {
            txt_fine.Enabled = true;
            txt_user.Enabled = false;
            txt_user.Clear();
        }

        private void rdo_user_CheckedChanged(object sender, EventArgs e)
        {
            txt_user.Enabled = true;
            txt_fine.Enabled = false;
            txt_fine.Clear();
        }

        private void date_value_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.ParseExact(date_value.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.Today;
            TimeSpan dt = d2 - d1;
            if (dt.Days > 30)
            {
                MessageBox.Show("เกินกำหนดรับเงินคืนมาแล้ว " + (dt.Days-30) + " วัน \r\n เงินถูกส่งเป็นรายได้แผ่นดินไปแล้ว","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else { GetEmp(); }

        }

        private void cb_around_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmp();
        }

        private void GetEmp()
        {
            ClearData();
            if (cb_around.Text != "เลือก")
            {
                cb_emp_name.Items.Clear();
                string date_select = date_value.Text;
                if (cb_around.Text == "1")
                {
                    DateTime dt = DateTime.ParseExact(date_select, "dd-MM-yyyy", CultureInfo.InvariantCulture).AddDays(-1);
                    date_select = dt.ToString("dd-MM-yyyy");
                    //MessageBox.Show(date_select);
                }
                string sql = "SELECT * FROM tbl_income JOIN tbl_emp ON tbl_income_emp_id = tbl_emp_id JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id WHERE (tbl_income_user <> '' OR tbl_income_fine <> '') AND tbl_status_around_date = '" + date_select + "' AND tbl_status_around_aid = '" + cb_around.Text + "'";
                //MessageBox.Show(sql);
                ConnectDB contxt = new ConnectDB();
                MySqlConnection conn = new MySqlConnection();
                conn = new MySqlConnection(contxt.context());
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    //cb_emp_name.SelectedIndex = 0;
                    int i = 0;
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            if (i == 0)
                            {
                                cb_emp_name.Text = "เลือกพนักงานที่ทำรายการ";
                            }

                            cb_emp_name.Items.Add(reader.GetString("tbl_emp_id") + " : " + reader.GetString("tbl_status_around_id") + " : " + reader.GetString("tbl_emp_name"));
                            cb_emp_name.Enabled = true;
                        }
                        i++;
                    }
                    if (i == 0)
                    {
                        cb_emp_name.Items.Clear();
                        cb_emp_name.Enabled = false;
                    }

                    reader.Close();
                }
                catch
                {

                }
                conn.Close();
            }
        }

        private void cb_emp_name_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cb_emp_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearData();

            data = cb_emp_name.SelectedItem.ToString().Split(':');
            string sql = "SELECT * FROM tbl_income JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id WHERE tbl_income_emp_id = '" + data[0].Trim() + "' AND tbl_status_around_id = '" + data[1].Trim() + "'";
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
                    if (!reader.IsDBNull(10))//10 = tbl_income_user
                    {
                        user = reader.GetString("tbl_income_user");
                    }
                    else { user = "0"; }
                    if (!reader.IsDBNull(11))// 11 = tbl_income_fine
                    {
                        fine = reader.GetString("tbl_income_fine");
                    }
                    else { fine = "0"; }

                    rdo_user.Enabled = Int32.Parse(user) > 0 ? true : false;
                    rdo_fine.Enabled = Int32.Parse(fine) > 0 ? true : false;

                    lb_user.Text = "( มีเงินในระบบ : " + user + " บาท )";
                    lb_fine.Text = "( มีเงินในระบบ : " + fine + " บาท )"; ;
                    lb_user.Visible = true;
                    lb_fine.Visible = true;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            conn.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (btn_next.Text == "ยืนยัน")
            {
                if ((rdo_fine.Checked == true || rdo_user.Checked == true) && (txt_fine.Text != "" || txt_user.Text != ""))
                {
                    ConnectDB contxt = new ConnectDB();
                    MySqlConnection conn = new MySqlConnection();
                    conn = new MySqlConnection(contxt.context());
                    MySqlCommand comm = conn.CreateCommand();

                    if (rdo_fine.Checked == true)
                    {
                        if (txt_fine.Text != "")
                        {
                            if (Int32.Parse(txt_fine.Text) <= Int32.Parse(fine))
                            {
                                conn.Open();
                                string sql = "UPDATE tbl_income SET tbl_income_fine = '" + (Int32.Parse(fine) - Int32.Parse(txt_fine.Text)) + "' WHERE tbl_income_emp_id = '" + data[0].Trim() + "' AND tbl_income_around_id = '" + data[1].Trim() + "'";
                                comm.CommandText = sql;
                                comm.ExecuteNonQuery();
                                MessageBox.Show("บันทึกข้อมูลเรีบยบร้อย", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                                mainForm.Enabled = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("ยอดเงินที่คืนผู้ใช้ทางมากกว่าเงินในระบบ " + (Int32.Parse(txt_fine.Text) - Int32.Parse(fine)) + " บาท", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }

                    if (rdo_user.Checked == true)
                    {
                        if (txt_user.Text != "")
                        {
                            if (Int32.Parse(txt_user.Text) <= Int32.Parse(user))
                            {
                                conn.Open();
                                string sql = "UPDATE tbl_income SET tbl_income_user = '" + (Int32.Parse(user) - Int32.Parse(txt_user.Text)) + "' WHERE tbl_income_emp_id = '" + data[0].Trim() + "' AND tbl_income_around_id = '" + data[1].Trim() + "'";
                                comm.CommandText = sql;
                                comm.ExecuteNonQuery();
                                MessageBox.Show("บันทึกข้อมูลเรีบยบร้อย", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                                mainForm.Enabled = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("ยอดเงินที่คืนผู้ใช้ทางมากกว่าเงินในระบบ " + (Int32.Parse(txt_user.Text) - Int32.Parse(user)) + " บาท", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกรายการที่คืนเงินลูกค้า และใส่จำนวนเงินให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if ((rdo_fine.Checked == true || rdo_user.Checked == true) && (txt_fine.Text != "" || txt_user.Text != ""))
                {
                    if (MessageBox.Show("ยืนยันข้อมูลคืนเงินผู้ใช้ทาง", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        groupBox1.Enabled = false;
                        btn_next.Text = "ยืนยัน";
                    }
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกรายการที่คืนเงินลูกค้า และใส่จำนวนเงินให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_fine_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script scriptCode = new Script();
            scriptCode.CheckNumber(e);
        }
        private void ClearData()
        {
            //cb_emp_name.Items.Clear();
            rdo_user.Enabled = false;
            rdo_fine.Enabled = false;
            rdo_user.Checked = false;
            rdo_fine.Checked = false;
            lb_user.Visible = false;
            lb_fine.Visible = false;
            txt_fine.Enabled = false;
            txt_user.Enabled = false;
            txt_user.Clear();
            txt_fine.Clear();
        }
    }
}
