using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Quasar1._0._1.DataAccessLayer;
using Quasar1._0._1.BusinessLogicLayer;
using System.Data.OleDb;

namespace Quasar1._0._1.BusinessLogicLayer
{


    public partial class forgot_password_page : Form
    {
        Thread th_loginpage;
        Thread th_userlistpage;

        public forgot_password_page()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ferhan\Desktop\quasar.accdb");
        private void log_in_button_login_page_Click(object sender, EventArgs e)
        {
            this.Close();
            th_loginpage = new Thread(openLoginForm);
            th_loginpage.SetApartmentState(ApartmentState.STA);
            th_loginpage.Start();
        }

        private void openLoginForm(object obj)
        {
            Application.Run(new login_page());
        }

        private void openUserListForm(object obj)
        {
            Application.Run(new user_list_form());
        }

        private void exit_login_page_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_forgot_password_Click(object sender, EventArgs e)
        {

            try
            {
                con.Close();
                string sel = "select u_id from users where username='" + input_username_forgot_password_page.Text + "' and u_password='" + input_password_forgot_password_page.Text + "' and u_status='admin'";
                OleDbCommand oc = new OleDbCommand(sel, con);
                oc.CommandType = CommandType.Text;
                con.Open();
                OleDbDataReader odr = oc.ExecuteReader();
                odr.Read();


                if (Int32.Parse(odr.GetValue(0).ToString()) > 0)
                {
                    con.Close();
                    string update = "update users set u_password='" + textBox1.Text + "' where username='" + textBox2.Text + "'";
                    OleDbCommand ooc = new OleDbCommand(update, con);
                    oc.CommandType = CommandType.Text;
                    con.Open();
                    ooc.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Şifrəniz uğurla yeniləndi");

                }

                else
                {
                    MessageBox.Show("Məlumatların düzgnlüyünə əmin olduqdan sonrə təkrar yoxlayın");
                }
            }
            catch (Exception ex) { MessageBox.Show("Məlumatların düzgünlüyündən əmin olun"); }

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
