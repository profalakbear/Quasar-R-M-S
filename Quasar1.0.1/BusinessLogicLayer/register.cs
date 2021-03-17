using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace Quasar1._0._1.BusinessLogicLayer
{
    public partial class register : Form
    {
        Thread th_loginpage;
        public register()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ferhan\Desktop\quasar.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioButton1.Checked ==true)
                {
                  string instr = "insert into users (username,u_password,u_name,u_surname,u_father_name,u_status) values  ('" + input_username_register_page.Text + "' , '" +
            input_password_register_page.Text + "' , '" +
            input_name_register_page.Text + "' , '" + input_surname_register_page.Text +
            "' , '" + textBox1.Text + "' , 'admin')";
                    OleDbCommand oc = new OleDbCommand(instr, con);
                    oc.CommandType = CommandType.Text;

                    con.Open();
                    oc.ExecuteNonQuery();
                    con.Dispose();
                    con.Close();
                    MessageBox.Show("qeydiyyat tamamlandı");


                }
                else if (radioButton2.Checked ==  true)
                {
                    string instr = "insert into users (username,u_password,u_name,u_surname,u_father_name,u_status) values  ('" + input_username_register_page.Text + "' , '" +
            input_password_register_page.Text + "' , '" +
            input_name_register_page.Text + "' , '" + input_surname_register_page.Text +
            "' , '" + textBox1.Text + "' , 'user')";
                    OleDbCommand oc = new OleDbCommand(instr, con);

                    con.Open();
                    oc.ExecuteNonQuery();
                    con.Dispose();
                    con.Close();
                    MessageBox.Show("qeydiyyat tamamlandı");
                }


                else
                {
                    MessageBox.Show("Admin yaxud istifadəçi kimi qeydiyyatdan keçmək istədiyiniz qey edilməyib. \nZəhmət olmasa qeyd edin");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OpenFile(object obj)
        {
            Application.Run(new register());
        }

        private void container_panel_register_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_login_page_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openLoginForm(object obj)
        {
            Application.Run(new login_page());
        }

        private void log_in_button_login_page_Click(object sender, EventArgs e)
        {
            this.Close();
            th_loginpage = new Thread(openLoginForm);
            th_loginpage.SetApartmentState(ApartmentState.STA);
            th_loginpage.Start();
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void mouse_down(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
