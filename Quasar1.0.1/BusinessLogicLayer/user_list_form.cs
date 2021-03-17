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

namespace Quasar1._0._1.BusinessLogicLayer
{

    public partial class user_list_form : Form
    {
        Thread th_loginpage;

        public user_list_form()
        {
            InitializeComponent();
        }

        bool show_pswd = false;
        bool show_pswd_confirm = false;

        private void exit_login_page_Click(object sender, EventArgs e)
        {
            this.Close();
            th_loginpage = new Thread(openLoginForm);
            th_loginpage.SetApartmentState(ApartmentState.STA);
            th_loginpage.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!show_pswd)
            {
                input_password_userlist_page.PasswordChar = '\0';
                show_pswd = true;
            }
            else if (show_pswd)
            {
                input_password_userlist_page.PasswordChar = '*';
                show_pswd = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!show_pswd_confirm)
            {
                input_confirm_password_userlist_page.PasswordChar = '\0';
                show_pswd_confirm = true;
            }
            else if (show_pswd_confirm)
            {
                input_confirm_password_userlist_page.PasswordChar = '*';
                show_pswd_confirm = false;
            }
        }

        private void openLoginForm(object obj)
        {
            Application.Run(new login_page());
        }

        private void log_in_button_login_page_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrWhiteSpace(input_username_userlist_page.Text) &&
              !string.IsNullOrWhiteSpace(input_password_userlist_page.Text) &&
              !string.IsNullOrWhiteSpace(input_confirm_password_userlist_page.Text))
            {
                USERS user = null;
                using (testWinFormDBEntities dbcontext = new testWinFormDBEntities())
                {
                    user = dbcontext.USERS.Where(s => s.USERNAME == input_username_userlist_page.Text).FirstOrDefault<USERS>();

                    if (user != null)
                    {
                        if (input_password_userlist_page.Text == input_confirm_password_userlist_page.Text)
                        {
                            user.PASSWORD = input_password_userlist_page.Text;

                            try
                            {
                                dbcontext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                                dbcontext.SaveChanges();
                                MessageBox.Show("Şifrəniz uğurla yeniləndi !");
                                input_username_userlist_page.Text = "";
                                input_password_userlist_page.Text = "";
                                input_confirm_password_userlist_page.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Şifrə yenilənərkən xəta baş verdi ! " + ex.Message);
                            }
                        }
                        else if (input_password_userlist_page.Text != input_confirm_password_userlist_page.Text)
                        {
                            MessageBox.Show("Daxil etdiyiniz şifrələr bir biri ilə uyğun gəlmir. \nZəhmət olmasa şifrələri yoxlayın və yenidən cəhd edin");
                        }
                    }
                    else if (user == null)
                    {
                        MessageBox.Show("Daxil etdiyiniz adda istifadəçi yoxdur !");
                    }
                }
            }
           else
            {
                MessageBox.Show("Xanalar boşdur. Xanaları doldurub yenidən cəhd edin !");
            }
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
