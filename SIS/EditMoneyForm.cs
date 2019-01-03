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
    public partial class EditMoneyForm : Form
    {
        MenuForm mainForm = null;
        string emp_id = "";
        string emp_name = "";
        string around_id = "";
        public EditMoneyForm(Form callingForm, string empId, string empName, string around)
        {
            InitializeComponent();
            mainForm = callingForm as MenuForm;
            emp_id = empId;
            emp_name = empName;
            around_id = around;
        }

        private void EditMoneyForm_Load(object sender, EventArgs e)
        {
            txt_emp_id.Text = emp_id;
            txt_emp_name.Text = emp_name;
            txt_edit_money.Focus();
            CheckData();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Close();
        }

        private bool CheckData()
        {
            string sql = "SELECT * FROM tbl_income WHERE tbl_income_emp_id IS NULL AND tbl_income_around_id = '" + around_id + "'";
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
                    txt_bag_number.Text = reader.GetString("tbl_income_money_bag");
                    txt_straps_number.Text = reader.GetString("tbl_income_straps");
                    lb_income_id.Text = reader.GetString("tbl_income_id");
                    lb_money.Text = reader.GetString("tbl_income_total");
                    txt_bag_number.Enabled = false;
                    txt_straps_number.Enabled = false;
                    return true;
                }
                reader.Close();
            }
            catch
            {

            }
            conn.Close();
            return false;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_edit_money.Text != "" && txt_bag_number.Text != "" && txt_straps_number.Text != "")
            {
                if (MessageBox.Show("ยืนยันเพื่อบันทึกข้อมูลการปรับยอด","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (CheckData())
                    {
                        //MessageBox.Show("Update");
                        ConnectDB contxt = new ConnectDB();
                        MySqlConnection conn = new MySqlConnection();
                        conn = new MySqlConnection(contxt.context());
                        conn.Open();
                        MySqlCommand comm = conn.CreateCommand();
                        string sql = "UPDATE tbl_income SET tbl_income_total = '" + (Int32.Parse(txt_edit_money.Text)+ Int32.Parse(lb_money.Text)) + "' ,tbl_income_bank = '" + (Int32.Parse(txt_edit_money.Text) + Int32.Parse(lb_money.Text)) + "'  WHERE tbl_income_id='" + lb_income_id.Text+"'";
                        comm.CommandText = sql;
                        if (comm.ExecuteNonQuery() > 0)
                        {
                            /*MessageBox.Show("ทำการปรับยอดเรียบร้อยแล้ว", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainForm.Enabled = true;
                            this.Close();*/
                            MySqlCommand comm_up = conn.CreateCommand();
                            string sql_up = "UPDATE tbl_income SET tbl_income_other = '" + txt_edit_money.Text + "' WHERE tbl_income_emp_id ='" + emp_id + "' AND tbl_income_around_id = '" + around_id + "'";
                            comm_up.CommandText = sql_up;
                            if (comm_up.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("ทำการปรับยอดเรียบร้อยแล้ว", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mainForm.Enabled = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("ผิดพลาด", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ผิดพลาด", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();
                    }
                    else
                    {
                        //MessageBox.Show("Insert");
                        bool chkBag = false;
                        string dateNow = DateTime.Today.ToString("dd-MM-yyyy");
                        string dateNext = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy");
                        string dateNextDay = dateNext.Split('-')[0] + "-" + dateNext.Split('-')[1] + "-" + dateNext.Split('-')[2];

                        ConnectDB contxt = new ConnectDB();
                        MySqlConnection conn = new MySqlConnection();
                        conn = new MySqlConnection(contxt.context());
                        string sqL_check_bag = "SELECT * FROM tbl_income JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id WHERE (tbl_status_around_date = '" + dateNow + "' OR (tbl_status_around_aid = '1' AND tbl_status_around_date = '" + dateNextDay + "')) AND tbl_income_money_bag = '" + txt_bag_number.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(sqL_check_bag, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        try
                        {
                            if (!reader.Read())
                            {
                                chkBag = true;
                            }
                            else
                            {
                                MessageBox.Show("ถุงเงินซ้ำ!!!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txt_bag_number.Focus();
                            }
                        }
                        catch { }
                        conn.Close();

                        if (chkBag)
                        {
                            conn.Open();
                            MySqlCommand comm = conn.CreateCommand();
                            comm.CommandText = "INSERT INTO tbl_income (tbl_income_money_bag,tbl_income_straps,tbl_income_total,tbl_income_bank,tbl_income_around_id,tbl_income_status_job) VALUES (@bag,@straps,@total,@bank,'" + around_id + "','1')";
                            comm.Parameters.Add("@bag", txt_bag_number.Text);
                            comm.Parameters.Add("@straps", txt_straps_number.Text);
                            comm.Parameters.Add("@total", txt_edit_money.Text);
                            comm.Parameters.Add("@bank", txt_edit_money.Text);
                            if (comm.ExecuteNonQuery() > 0)
                            {
                                MySqlCommand comm_up = conn.CreateCommand();
                                string sql = "UPDATE tbl_income SET tbl_income_other = '" + txt_edit_money.Text + "' WHERE tbl_income_emp_id ='" + emp_id + "' AND tbl_income_around_id = '" + around_id + "'";
                                comm_up.CommandText = sql;
                                if (comm_up.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("ทำการปรับยอดเรียบร้อยแล้ว", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    mainForm.Enabled = true;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("ผิดพลาด", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
