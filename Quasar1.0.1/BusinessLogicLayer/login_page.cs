using Quasar1._0._1.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using Quasar1._0._1.BusinessLogicLayer;
namespace Quasar1._0._1
{
    public partial class login_page : Form
    {
        Thread th_mainpage;
        Thread th_forgotpasswordpage;

        public login_page()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ferhan\Desktop\quasar.accdb");
        OleDbCommand oc;
        OleDbDataReader odr;

        private void login_page_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_login_page_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void input_password_login_page_TextChanged(object sender, EventArgs e)
        {
           
        }

        bool show_pswd = false;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!show_pswd)
            {
                input_password_login_page.PasswordChar = '\0';
                show_pswd = true;
            }
            else if (show_pswd)
            {
                input_password_login_page.PasswordChar = '*';
                show_pswd = false;
            }
        }

        private void forgot_password_login_page_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th_forgotpasswordpage = new Thread(openForgotPasswordForm);
            th_forgotpasswordpage.SetApartmentState(ApartmentState.STA);
            th_forgotpasswordpage.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void log_in_button_login_page_Click(object sender, EventArgs e)
        {
                    
            try{
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                string sel = "Select u_id from users where username= '" + input_username_login_page.Text + "' and u_password= '" + input_password_login_page.Text + "' ";
                cmd.CommandText = sel;
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                
                    if (dr.HasRows)
                    
                    {
                        
                            this.Close();
                            th_mainpage = new Thread(openMainForm);
                            th_mainpage.SetApartmentState(ApartmentState.STA);
                            th_mainpage.Start();
                            con.Close();
                        }
                        
            }
                    catch (Exception ex)
                    {
                        MessageBox.Show("İstifadəçi adı və ya şifrə yalnış daxil edilmişdir." +
                               "\nZəhmət olmasa xanaları düzgün doldurun və yenidən cəhd edin !");
                        con.Close();
                    }
             
        }

        private void openMainForm(object obj)
        {
            Application.Run(new Main());
        }

        private void OpenRegister(object obj)
        {
            Application.Run(new register());
        }

        private void openForgotPasswordForm(object obj)
        {
            Application.Run(new forgot_password_page());
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

        private void register_login_page_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
             this.Close();
            th_forgotpasswordpage = new Thread(OpenRegister);
            th_forgotpasswordpage.SetApartmentState(ApartmentState.STA);
            th_forgotpasswordpage.Start();
        }
    }
}
