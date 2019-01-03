using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SIS
{
    public partial class ReportViweForm : Form
    {
        MenuForm mainForm = null;

        public ReportViweForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as MenuForm;
            mainForm.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Close();
        }

        private void cb_select_report_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_select_report.SelectedIndex)
            {
                case 0:
                    group_date.Visible = true;
                    rd_p1.Visible = true;
                    rd_p2.Visible = true;
                    rd_p3.Visible = true;

                    lb_date1.Visible = false;
                    lb_date2.Visible = false;
                    txt_date_end.Visible = false;
                    groupBox2.Visible = false;
                    label2.Visible = false;
                    txt_u1.Visible = false;
                    cryViewer.Visible = false;
                    txt_no.Clear();
                    break;
                case 1:
                    group_date.Visible = true;
                    groupBox2.Visible = true;
                    label2.Visible = true;
                    txt_u1.Visible = true;
                    rd_p1.Visible = false;
                    rd_p2.Visible = false;
                    rd_p3.Visible = false;

                    lb_date1.Visible = false;
                    lb_date2.Visible = false;
                    txt_date_end.Visible = false;
                    cryViewer.Visible = false;
                    txt_no.Clear();
                    break;
                case 2:
                    group_date.Visible = true;
                    groupBox2.Visible = true;
                    rd_p1.Visible = false;
                    rd_p2.Visible = false;
                    rd_p3.Visible = false;

                    lb_date1.Visible = true;
                    lb_date2.Visible = true;
                    txt_date_end.Visible = true;
                    label2.Visible = false;
                    txt_u1.Visible = false;
                    cryViewer.Visible = false;
                    txt_no.Clear();
                    break;
                default:
                    group_date.Visible = false;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txt_date_start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rd_p1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_p1.Checked)
            {
                cryViewer.Size = new System.Drawing.Size(949, 535);
                Report_around(1, txt_date_start.Text);
            }
        }

        private void rd_p2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_p2.Checked)
            {
                Report_around(2, txt_date_start.Text);
            }
        }

        private void rd_p3_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_p3.Checked)
            {
                Report_around(3, txt_date_start.Text);
            }
        }

        private void Report_around(int around, string date)
        {
            if (cb_select_report.SelectedIndex == 0)
            {
                GetReport1(around, date);
            }
        }

        private void ReportViweForm_Load(object sender, EventArgs e)
        {
            txt_date_end.CustomFormat = "dd-MM-yyyy";
            txt_date_start.CustomFormat = "dd-MM-yyyy";
            groupBox2.Visible = false;
            cryViewer.Visible = false;

        }
        private void GetReport1(int around, string date)
        {
            string sql = "SELECT tbl_status_around_aid, tbl_around_time, tbl_status_around_date, tbl_income_money_bag, tbl_income_straps, tbl_income_emp_id, IF(tbl_emp_name IS NULL,'ถุงเงินพิเศษ',tbl_emp_name) AS tbl_emp_name, tbl_income_cabinet, tbl_income_job, tbl_income_in_time, tbl_income_out_time, tbl_income_total, tbl_income_bank, tbl_income_user, tbl_income_fine, tbl_income_other, tbl_cpoint_name, STR_TO_DATE( tbl_status_around_date, '%e-%c-%Y' ) AS date_around FROM tbl_income LEFT JOIN tbl_emp ON tbl_emp_id = tbl_income_emp_id JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id JOIN tbl_cpoint ON tbl_cpoint_id = tbl_status_around_cpoint_id JOIN tbl_around ON tbl_status_around_aid = tbl_around_id ";
            sql += "WHERE tbl_status_around_aid = '" + around + "' AND tbl_status_around_date = '" + date + "' Group BY tbl_income_money_bag";

            MySqlConnection conn;
            MySqlCommand cmd;
            MySqlDataAdapter adap;

            ConnectDB connectDB = new ConnectDB();
            conn = new MySqlConnection(connectDB.context());
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet_Report reportDB = new DataSet_Report();
            reportDB.Clear();
            adap.Fill(reportDB, "Report_Around");

            if (reportDB.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("ไม่พบข้อมูล", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rd_p1.Checked = false;
                rd_p2.Checked = false;
                rd_p3.Checked = false;
                cryViewer.Visible = false;
            }
            else
            {
                CrystalReport1 myReport = new CrystalReport1();
                myReport.SetDataSource(reportDB);
                cryViewer.ReportSource = myReport;
                cryViewer.Zoom(80);
                cryViewer.Visible = true;
            }
        }

        private void GetReport2()
        {
            string sql = "SELECT tbl_around_id,tbl_around_time,SUM(tbl_income_bank) AS tbl_income_bank,tbl_cpoint_name, ADDDATE(STR_TO_DATE(tbl_status_around_date, '%e-%c-%Y'), -1) AS date_around_befor, STR_TO_DATE( tbl_status_around_date, '%e-%c-%Y') AS date_around FROM tbl_income LEFT JOIN tbl_emp ON tbl_emp_id = tbl_income_emp_id JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id JOIN tbl_cpoint ON tbl_cpoint_id = tbl_status_around_cpoint_id JOIN tbl_around ON tbl_status_around_aid = tbl_around_id WHERE tbl_status_around_date = '" + txt_date_start.Text + "' GROUP BY tbl_around_id ORDER BY tbl_around_id";
            if (txt_no.Text.Length > 3&&txt_u1.Text.Length >= 5 && txtx_main.Text.Length >= 5 && txt_u2.Text.Length >= 5 && txt_u3.Text.Length >= 5) {
                ConnectDB contxt = new ConnectDB();
                MySqlConnection conn = new MySqlConnection();
                conn = new MySqlConnection(contxt.context());
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                ReportIncomeKST1 reportIncomeKST = new ReportIncomeKST1();
                int i = 0;
                int[] data_around_sum = {0,0,0};
                string cpoint = "";
                DateTime date_befor = DateTime.Now;
                DateTime date_around = DateTime.Now;
                while (reader.Read())
                {
                    string para = "around_sum_income_" + i;
                    cpoint = reader.GetString("tbl_cpoint_name");
                    data_around_sum[i] = Int32.Parse(reader.GetString("tbl_income_bank"));
                    date_befor = DateTime.Parse(reader.GetString("date_around_befor"));
                    date_around = DateTime.Parse(reader.GetString("date_around"));
                    i++;
                }
                reader.Close();
                conn.Close();

                sql = "SELECT STR_TO_DATE( `tbl_status_around_date`, '%e-%c-%Y' ) AS tbl_status_around_date, SUM(tbl_income_fine) AS tbl_income_fine, SUM(tbl_income_user) AS tbl_income_user, DATEDIFF(NOW(),STR_TO_DATE(tbl_status_around_date,'%e-%c-%Y'))AS delay FROM `tbl_income` JOIN `tbl_status_around` ON `tbl_income_around_id` = `tbl_status_around_id` JOIN `tbl_around` ON `tbl_status_around_aid` = `tbl_around_id` WHERE DATEDIFF(NOW(),STR_TO_DATE(tbl_status_around_date,'%e-%c-%Y')) = 31 GROUP BY `tbl_around_id`";
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                i = 0;
                int[] data_fine_sum = { 0, 0, 0 };
                int[] data_user_sum = { 0, 0, 0 };
                while (reader.Read())
                {
                    data_fine_sum[i] = Int32.Parse(reader.GetString("tbl_income_fine"));
                    data_user_sum[i] = Int32.Parse(reader.GetString("tbl_income_user"));
                    i++;
                }
                reader.Close();
                conn.Close();

                int total_sum = data_around_sum[0] + data_around_sum[1] + data_around_sum[2] + data_user_sum[0] + data_user_sum[1] + data_user_sum[2] + data_fine_sum[0] + data_fine_sum[1] + data_fine_sum[2];
                reportIncomeKST.SetParameterValue("cpoint", cpoint);
                reportIncomeKST.SetParameterValue("doc_number", txt_no.Text);
                reportIncomeKST.SetParameterValue("around_sum_income_1", data_around_sum[0]);
                reportIncomeKST.SetParameterValue("around_sum_income_2", data_around_sum[1]);
                reportIncomeKST.SetParameterValue("around_sum_income_3", data_around_sum[2]);
                reportIncomeKST.SetParameterValue("date_report", date_befor);
                reportIncomeKST.SetParameterValue("date_report1", date_around);
                reportIncomeKST.SetParameterValue("date_fine", DateTime.Now.AddDays(-31));
                reportIncomeKST.SetParameterValue("around_sum_user_1", data_user_sum[0]);
                reportIncomeKST.SetParameterValue("around_sum_user_2", data_user_sum[1]);
                reportIncomeKST.SetParameterValue("around_sum_user_3", data_user_sum[2]);
                reportIncomeKST.SetParameterValue("around_sum_fine_1", data_fine_sum[0]);
                reportIncomeKST.SetParameterValue("around_sum_fine_2", data_fine_sum[1]);
                reportIncomeKST.SetParameterValue("around_sum_fine_3", data_fine_sum[2]);
                reportIncomeKST.SetParameterValue("total_num", total_sum);
                reportIncomeKST.SetParameterValue("total_thai", ThaiBaht(total_sum.ToString()));

                reportIncomeKST.SetParameterValue("user_send", getEmpName_Group(txt_u1.Text).Split('|')[0]);
                reportIncomeKST.SetParameterValue("group_send", getEmpName_Group(txt_u1.Text).Split('|')[1]);

                reportIncomeKST.SetParameterValue("user_send1", getEmpName_Group(txt_u2.Text).Split('|')[0]);
                reportIncomeKST.SetParameterValue("group_send1", getEmpName_Group(txt_u2.Text).Split('|')[1]);

                reportIncomeKST.SetParameterValue("user_send2", getEmpName_Group(txt_u3.Text).Split('|')[0]);
                reportIncomeKST.SetParameterValue("group_send2", getEmpName_Group(txt_u3.Text).Split('|')[1]);

                reportIncomeKST.SetParameterValue("user_main", getEmpName_Group(txtx_main.Text).Split('|')[0]);
                reportIncomeKST.SetParameterValue("group_main", getEmpName_Group(txtx_main.Text).Split('|')[1]);


                cryViewer.ReportSource = reportIncomeKST;
                cryViewer.Zoom(80);
                cryViewer.Visible = true;
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetReport3()
        {
            ReportIncomeKST2 reportIncomeKST = new ReportIncomeKST2();
            //333333333333333333333333333333333333333333333333333333333333333
            string sql = "SELECT tbl_around_id, tbl_around_time, SUM(tbl_income_bank) AS tbl_income_bank, tbl_cpoint_name, ADDDATE( STR_TO_DATE( tbl_status_around_date, '%e-%c-%Y' ), - 1 ) AS date_around_befor, STR_TO_DATE( tbl_status_around_date, '%e-%c-%Y' ) AS date_around FROM tbl_income LEFT JOIN tbl_emp ON tbl_emp_id = tbl_income_emp_id JOIN tbl_status_around ON tbl_income_around_id = tbl_status_around_id JOIN tbl_cpoint ON tbl_cpoint_id = tbl_status_around_cpoint_id JOIN tbl_around ON tbl_status_around_aid = tbl_around_id WHERE (STR_TO_DATE(tbl_status_around_date,'%e-%c-%Y') BETWEEN STR_TO_DATE('" + txt_date_start.Text + "','%e-%c-%Y') AND STR_TO_DATE('" + txt_date_end.Text + "','%e-%c-%Y')) GROUP BY tbl_around_id ORDER BY tbl_around_id";
            if (txt_no.Text.Length > 3 && txtx_main.Text.Length >= 5 && txt_u2.Text.Length >= 5 && txt_u3.Text.Length >= 5)
            {
                ConnectDB contxt = new ConnectDB();
                MySqlConnection conn = new MySqlConnection();
                conn = new MySqlConnection(contxt.context());
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                int[] data_around_sum = { 0, 0, 0 };
                string cpoint = "";
                DateTime date_befor = DateTime.Now;
                DateTime date_around = DateTime.Now;
                while (reader.Read())
                {
                    string para = "around_sum_income_" + i;
                    cpoint = reader.GetString("tbl_cpoint_name");
                    data_around_sum[i] = Int32.Parse(reader.GetString("tbl_income_bank"));
                    date_befor = DateTime.Parse(reader.GetString("date_around_befor"));
                    date_around = DateTime.Parse(reader.GetString("date_around"));
                    i++;
                }
                reader.Close();
                conn.Close();

                sql = "SELECT STR_TO_DATE( `tbl_status_around_date`, '%e-%c-%Y' ) AS tbl_status_around_date, SUM(tbl_income_fine) AS tbl_income_fine, SUM(tbl_income_user) AS tbl_income_user, DATEDIFF( NOW(), STR_TO_DATE( tbl_status_around_date, '%e-%c-%Y' ) ) AS delay FROM `tbl_income` JOIN `tbl_status_around` ON `tbl_income_around_id` = `tbl_status_around_id` JOIN `tbl_around` ON `tbl_status_around_aid` = `tbl_around_id` WHERE DATEDIFF( NOW(), STR_TO_DATE( tbl_status_around_date, '%e-%c-%Y' ) ) > 30 AND DATEDIFF( NOW(), STR_TO_DATE( tbl_status_around_date, '%e-%c-%Y' ) ) < (30+DATEDIFF( STR_TO_DATE( '" + txt_date_end + "', '%e-%c-%Y' ), STR_TO_DATE( '" + txt_date_start + "', '%e-%c-%Y' ) )) GROUP BY `tbl_around_id`";
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                i = 0;
                int[] data_fine_sum = { 0, 0, 0 };
                int[] data_user_sum = { 0, 0, 0 };
                while (reader.Read())
                {
                    data_fine_sum[i] = Int32.Parse(reader.GetString("tbl_income_fine"));
                    data_user_sum[i] = Int32.Parse(reader.GetString("tbl_income_user"));
                    i++;
                }
                reader.Close();
                conn.Close();

                int total_sum = data_around_sum[0] + data_around_sum[1] + data_around_sum[2] + data_user_sum[0] + data_user_sum[1] + data_user_sum[2] + data_fine_sum[0] + data_fine_sum[1] + data_fine_sum[2];
                reportIncomeKST.SetParameterValue("cpoint", cpoint);
                reportIncomeKST.SetParameterValue("doc_number", txt_no.Text);
                DateTime date_start = DateTime.ParseExact(txt_date_start.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                DateTime date_end = DateTime.ParseExact(txt_date_end.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                if(date_start.Month == date_end.Month)
                {
                    reportIncomeKST.SetParameterValue("date_report", (date_start.Day+" - "+GetMontThai(date_end)));
                }
                else
                {
                    reportIncomeKST.SetParameterValue("date_report", GetMontThai(date_start) +" - "+GetMontThai(date_end));
                }
                //reportIncomeKST.SetParameterValue("around_sum_income_1", data_around_sum[0]);
                //reportIncomeKST.SetParameterValue("around_sum_income_2", data_around_sum[1]);
                //reportIncomeKST.SetParameterValue("around_sum_income_3", data_around_sum[2]);
                //reportIncomeKST.SetParameterValue("date_report", date_befor);
                //reportIncomeKST.SetParameterValue("date_report1", date_around);
                //reportIncomeKST.SetParameterValue("date_fine", DateTime.Now.AddDays(-31));
                //reportIncomeKST.SetParameterValue("around_sum_user_1", data_user_sum[0]);
                //reportIncomeKST.SetParameterValue("around_sum_user_2", data_user_sum[1]);
                //reportIncomeKST.SetParameterValue("around_sum_user_3", data_user_sum[2]);
                //reportIncomeKST.SetParameterValue("around_sum_fine_1", data_fine_sum[0]);
                //reportIncomeKST.SetParameterValue("around_sum_fine_2", data_fine_sum[1]);
                //reportIncomeKST.SetParameterValue("around_sum_fine_3", data_fine_sum[2]);
                reportIncomeKST.SetParameterValue("total_num", total_sum);
                reportIncomeKST.SetParameterValue("total_thai", ThaiBaht(total_sum.ToString()));

                //reportIncomeKST.SetParameterValue("user_send", getEmpName_Group(txt_u1.Text).Split('|')[0]);
                //reportIncomeKST.SetParameterValue("group_send", getEmpName_Group(txt_u1.Text).Split('|')[1]);

                reportIncomeKST.SetParameterValue("user_send1", getEmpName_Group(txt_u2.Text).Split('|')[0]);
                reportIncomeKST.SetParameterValue("group_send1", getEmpName_Group(txt_u2.Text).Split('|')[1]);

                reportIncomeKST.SetParameterValue("user_send2", getEmpName_Group(txt_u3.Text).Split('|')[0]);
                reportIncomeKST.SetParameterValue("group_send2", getEmpName_Group(txt_u3.Text).Split('|')[1]);

                reportIncomeKST.SetParameterValue("user_main", getEmpName_Group(txtx_main.Text).Split('|')[0]);
                reportIncomeKST.SetParameterValue("group_main", getEmpName_Group(txtx_main.Text).Split('|')[1]);


                cryViewer.ReportSource = reportIncomeKST;
                cryViewer.Zoom(80);
                cryViewer.Visible = true;
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string getEmpName_Group(string emp_id)
        {
            string sql = "SELECT * FROM tbl_emp e JOIN tbl_emp_group g ON e.tbl_emp_group_id=g.tbl_emp_group_id WHERE `tbl_emp_id` = '" + emp_id+"'";
            ConnectDB contxt = new ConnectDB();
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection(contxt.context());
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            string emp_data = null;
            try
            {
                if (reader.Read())
                {
                    emp_data = reader.GetString("tbl_emp_name");
                    emp_data += "|"+reader.GetString("tbl_emp_group_name");
                }
                else
                {
                    emp_data = "ไม่พบข้อมูล";
                    
                }
                reader.Close();
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
            conn.Close();
            return emp_data;
        }

        private void txt_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script script = new Script();
            script.CheckNumber(e);
        }

        private void txt_u1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script script = new Script();
            script.CheckNumber(e);
        }

        private void txtx_main_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script script = new Script();
            script.CheckNumber(e);
        }

        private void txt_u2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script script = new Script();
            script.CheckNumber(e);
        }

        private void txt_u3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Script script = new Script();
            script.CheckNumber(e);
        }

        private void txt_u1_KeyUp(object sender, KeyEventArgs e)
        {
            string rs = getEmpName_Group(txt_u1.Text);
            if (rs != "ไม่พบข้อมูล")
            {
                label_u1.Text = rs.Split('|')[0]+" ตำแหน่ง "+ rs.Split('|')[1];
            }
            else
            {
                label_u1.Text = rs;
            }
        }

        private void txtx_main_KeyUp(object sender, KeyEventArgs e)
        {
            string rs = getEmpName_Group(txtx_main.Text);
            if (rs != "ไม่พบข้อมูล")
            {
                label_main.Text = rs.Split('|')[0] + " ตำแหน่ง " + rs.Split('|')[1];
            }
            else
            {
                label_main.Text = rs;
            }
        }

        private void txt_u2_KeyUp(object sender, KeyEventArgs e)
        {
            string rs = getEmpName_Group(txt_u2.Text);
            if (rs != "ไม่พบข้อมูล")
            {
                label_u2.Text = rs.Split('|')[0] + " ตำแหน่ง " + rs.Split('|')[1];
            }
            else
            {
                label_u2.Text = rs;
            }
        }

        private void txt_u3_KeyUp(object sender, KeyEventArgs e)
        {
            string rs = getEmpName_Group(txt_u3.Text);
            if (rs != "ไม่พบข้อมูล")
            {
                label_u3.Text = rs.Split('|')[0] + " ตำแหน่ง " + rs.Split('|')[1];
            }
            else
            {
                label_u3.Text = rs;
            }
        }

        private void txt_no_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cb_select_report.SelectedIndex == 1)
            {
                GetReport2();
            }else if(cb_select_report.SelectedIndex == 2)
            {
                GetReport3();
            }
            
        }
        public static string ThaiBaht(string txt)
        {
            string bahtTxt, n, bahtTH = "";
            double amount;
            try { amount = Convert.ToDouble(txt); }
            catch { amount = 0; }
            bahtTxt = amount.ToString("####.00");
            string[] num = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
            string[] rank = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
            string[] temp = bahtTxt.Split('.');
            string intVal = temp[0];
            string decVal = temp[1];
            if (Convert.ToDouble(bahtTxt) == 0)
                bahtTH = "ศูนย์บาทถ้วน";
            else
            {
                for (int i = 0; i < intVal.Length; i++)
                {
                    n = intVal.Substring(i, 1);
                    if (n != "0")
                    {
                        if ((i == (intVal.Length - 1)) && (n == "1"))
                            bahtTH += "เอ็ด";
                        else if ((i == (intVal.Length - 2)) && (n == "2"))
                            bahtTH += "ยี่";
                        else if ((i == (intVal.Length - 2)) && (n == "1"))
                            bahtTH += "";
                        else
                            bahtTH += num[Convert.ToInt32(n)];
                        bahtTH += rank[(intVal.Length - i) - 1];
                    }
                }
                bahtTH += "บาท";
                if (decVal == "00")
                    bahtTH += "ถ้วน";
                else
                {
                    for (int i = 0; i < decVal.Length; i++)
                    {
                        n = decVal.Substring(i, 1);
                        if (n != "0")
                        {
                            if ((i == decVal.Length - 1) && (n == "1"))
                                bahtTH += "เอ็ด";
                            else if ((i == (decVal.Length - 2)) && (n == "2"))
                                bahtTH += "ยี่";
                            else if ((i == (decVal.Length - 2)) && (n == "1"))
                                bahtTH += "";
                            else
                                bahtTH += num[Convert.ToInt32(n)];
                            bahtTH += rank[(decVal.Length - i) - 1];
                        }
                    }
                    bahtTH += "สตางค์";
                }
            }
            return bahtTH;
        }

        public string GetMontThai(DateTime date)
        {
            string date_txt = "";
            date_txt = date.Day.ToString();
            switch (date.Month.ToString())
            {
                case "1":
                    date_txt += " มกราคม ";
                    break;
                case "2":
                    date_txt += " กุมภาพันธ์ ";
                    break;
                case "3":
                    date_txt += " มีนาคม ";
                    break;
                case "4":
                    date_txt += " เมษายน ";
                    break;
                case "5":
                    date_txt += " พฤษภาคม ";
                    break;
                case "6":
                    date_txt += " มิถุนายน ";
                    break;
                case "7":
                    date_txt += " กรกฎาคม ";
                    break;
                case "8":
                    date_txt += " สิงหาคม ";
                    break;
                case "9":
                    date_txt += " กันยายน ";
                    break;
                case "10":
                    date_txt += " ตุลาคม ";
                    break;
                case "11":
                    date_txt += " พฤศจิกายน ";
                    break;
                case "12":
                    date_txt += " ธันวาคม ";
                    break;
                default: date_txt += " ";
                    break;
            }
            date_txt += date.Year + 543;
            return null;
        }
    }
}
