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
    public partial class MoneybagForm : Form
    {
        MenuForm mainForm = null;
        Script scriptCode = new Script();
        string cpoint_id = "";
        public MoneybagForm(Form callingForm, string cpoint)
        {
            InitializeComponent();
            mainForm = callingForm as MenuForm;
            btn_save.Enabled = false;
            cpoint_id = cpoint;
        }

        private void MoneybagForm_Load(object sender, EventArgs e)
        {


        }

        private void txt_emp_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            scriptCode.CheckNumber(e);
        }

        private void txt_bag_KeyPress(object sender, KeyPressEventArgs e)
        {
            scriptCode.CheckNumber(e);
        }

        private void txt_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            scriptCode.CheckNumber(e);
        }

        private void txt_cabinet_KeyPress(object sender, KeyPressEventArgs e)
        {
            scriptCode.CheckNumber(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_emp_id.Text != "" && txt_bag.Text != "" && txt_cabinet.Text != "" && txt_money.Text != "")
            {
                ConfirmMoneyBag cfMoneyBag = new ConfirmMoneyBag(mainForm, this, txt_bag.Text, txt_emp_id.Text, txt_cabinet.Text, txt_money.Text, cpoint_id);
                cfMoneyBag.Show();
            }
            else
            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_emp_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_emp_id.Text.Length > 1)
            {
                string sql = "SELECT * FROM tbl_emp WHERE tbl_emp_id = '" + txt_emp_id.Text + "'";

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
                        lb_emp_name.Text = reader.GetString("tbl_emp_name");
                        btn_save.Enabled = true;
                    }
                    else
                    {
                        lb_emp_name.Text = "ไม่พบข้อมูลพนักงาน";
                        btn_save.Enabled = false;
                    }
                    reader.Close();
                }
                catch
                {
                    //MessageBox.Show(e.ToString());
                    btn_save.Enabled = false;
                }
                conn.Close();

            }
        }
    }
}
