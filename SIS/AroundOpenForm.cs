using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIS
{
    public partial class AroundOpenForm : Form
    {
        MenuForm maniForm = null;
        string cpoint_id;
        string emp_id;
        public AroundOpenForm(string emp,Form callingForm,string cpoint)
        {
            maniForm = callingForm as MenuForm;
            InitializeComponent();
            cpoint_id = cpoint;
            emp_id = emp;
            ConnectDB contxt = new ConnectDB();
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection(contxt.context());
            string sql = "SELECT * FROM tbl_emp WHERE tbl_emp_id = '" + emp_id + "'";

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
                        lb_emp_name.Text = reader.GetString("tbl_emp_name");
                    }
                }
                reader.Close();
            }
            catch
            {
                
            }
            conn.Close();

            //txt_emp.Text = data[0]+" "+data[1]+" "+data[2]+" "+data[3];
        }

        private void AroundOpenForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AroundForm form = new AroundForm(maniForm,cpoint_id);
            form.Show();
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            InsertAround();
        }

        private void InsertAround()
        {
            ConnectDB contxt = new ConnectDB();
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection(contxt.context());
            int aid=0;

            if (rb_2.Checked)
            {
                //MessageBox.Show("2");
                aid = 2;
            }
            if (rb_3.Checked)
            {
                //MessageBox.Show("3");
                aid = 3;
            }
            if (rb_1.Checked)
            {
                //MessageBox.Show("1");
                aid = 1;
            }
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO tbl_status_around (tbl_status_around_aid,tbl_status_around_emp_open_id,tbl_status_around_close,tbl_status_around_date,tbl_status_around_cpoint_id) VALUES(@aid, @emp_id,'0',@date,@cpoint)";
            comm.Parameters.Add("@aid", aid);
            comm.Parameters.Add("@emp_id", emp_id);
            comm.Parameters.Add("@date", DateTime.Today.ToString("dd-MM-yyyy"));
            comm.Parameters.Add("@cpoint", cpoint_id);
            comm.ExecuteNonQuery();
            conn.Close();

            StreamWriter file = new StreamWriter(@"around.txt");
            file.WriteLine(emp_id+"|"+aid+"|"+ DateTime.Today.ToString("dd-MM-yyyy"));
            file.Close();

            //maniForm.Refresh();
            Application.Restart();
        }

        private void rb_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertAround();
            }
        }
    }
}
