using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml;


namespace Quasar1._0._1.BusinessLogicLayer
{
    public partial class Main : Form 
    {
        public Main()
        {
            InitializeComponent();
        }

        OleDbCommand oc;
        DataSet ds;
        OleDbDataAdapter oda;
        OleDbCommandBuilder ocb;
        private void Main_Load(object sender, EventArgs e)
        {
            XmlDocument dc = new XmlDocument();
            dc.Load("D:\\document.xml");
            var c = dc.SelectNodes("/body/last");
            string k = c[0].InnerText;
             label5.Text = k;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            logo_panel_main.Visible = true;
            label5Dish.Visible = false;
            comboBox3Dish.Visible = false;
            label19DishAdd.Visible = false;
            comboBox1DishAdd.Visible = false;
            

        }

        private void exit_login_page_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_button_main_page_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bütün məlumatlarınızı yadda saxladığınıza əminsinizmi?", "Xəbərdarlıq !", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
                con.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //something here
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void sales_button_main_page_Click(object sender, EventArgs e)
        {
            if (tabControl1.Visible == false)
            {
                tabControl1.Visible = true;
                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void expenses_button_main_page_Click(object sender, EventArgs e)
        {
            if (tabControl1.Visible == false)
            {
                tabControl1.Visible = true;
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void statistics_button_main_page_Click(object sender, EventArgs e)
        {
            if (tabControl1.Visible == false)
            {
                tabControl1.Visible = true;
                tabControl1.SelectedTab = tabPage3;
            }
            else
            {
                tabControl1.SelectedTab = tabPage3;
            }
        }

        private void add_menu_sales_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage4;
            }
            else
            {
                tabControl2.SelectedTab = tabPage4;
            }
        }

        private void edit_menu_sales_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage5;
            }
            else
            {
                tabControl2.SelectedTab = tabPage5;
            }
        }

        private void delete_menu_sales_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage6;
            }
            else
            {
                tabControl2.SelectedTab = tabPage6;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage7;
            }
            else
            {
                tabControl2.SelectedTab = tabPage7;
            }


            if (Int32.Parse(label5.Text) >= 1)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }

            if (Int32.Parse(label5.Text) >= 2)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }

            if (Int32.Parse(label5.Text) >= 3)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }

            if (Int32.Parse(label5.Text) >= 4)
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 5)
            {
                groupBox5.Visible = true;
            }
            else
            {
                groupBox5.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 6)
            {
                groupBox6.Visible = true;
            }
            else
            {
                groupBox6.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 7)
            {
                groupBox7.Visible = true;
            }
            else
            {
                groupBox7.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 8)
            {
                groupBox8.Visible = true;
            }
            else
            {
                groupBox8.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 9)
            {
                groupBox9.Visible = true;
            }
            else
            {
                groupBox9.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 10)
            {
                groupBox10.Visible = true;
            }
            else
            {
                groupBox10.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 11)
            {
                groupBox11.Visible = true;
            }
            else
            {
                groupBox11.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 12)
            {
                groupBox12.Visible = true;
            }
            else
            {
                groupBox12.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 13)
            {
                groupBox13.Visible = true;
            }
            else
            {
                groupBox13.Visible = false;
            }
            if (Int32.Parse(label5.Text) >= 14)
            {
                groupBox14.Visible = true;
            }
            else
            {
                groupBox14.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage8;
            }
            else
            {
                tabControl2.SelectedTab = tabPage8;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage8;
            }
            else
            {
                tabControl2.SelectedTab = tabPage9;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage10;
            }
            else
            {
                tabControl2.SelectedTab = tabPage10;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage11;
            }
            else
            {
                tabControl2.SelectedTab = tabPage11;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
                tabControl2.SelectedTab = tabPage12;
            }
            else
            {
                tabControl2.SelectedTab = tabPage12;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tabControl3.Visible == false)
            {
                tabControl3.Visible = true;
                tabControl3.SelectedTab = tabPage13;
            }
            else
            {
                tabControl3.SelectedTab = tabPage13;
            }

            oc = new OleDbCommand("select * from xercler", con);
            oc.CommandType = CommandType.Text;
            oda = new OleDbDataAdapter(oc);
            ocb = new OleDbCommandBuilder(oda);
            ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
            dataGridView1.Columns[1].HeaderText = "xərclər";
            dataGridView1.Columns[2].HeaderText = "qeyd";
            dataGridView1.Columns[2].Width = 230;
            con.Close();
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Items.Clear();

            }
            else
            {
                oc = new OleDbCommand("select * from xercler", con);
                oc.CommandType = CommandType.Text;
                con.Open();
                OleDbDataReader odr = oc.ExecuteReader();
               
                while (odr.Read())
                {
                    comboBox1.Items.Add(odr.GetValue(1));
                    
                }
                con.Close();


            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tabControl3.Visible == false)
            {
                tabControl3.Visible = true;
                tabControl3.SelectedTab = tabPage15;
            }
            else
            {
                tabControl3.SelectedTab = tabPage15;
            }


            oc = new OleDbCommand("select * from gundelik_xerc", con);
            oc.CommandType = CommandType.Text;
            oda = new OleDbDataAdapter(oc);
            ocb = new OleDbCommandBuilder(oda);
            ds = new DataSet();
            oda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            dataGridView2.Columns[0].HeaderText = "sira nomresi";
            dataGridView2.Columns[0].Width = 30;
            dataGridView2.Columns[1].HeaderText = "xerc nomresi";
            dataGridView2.Columns[1].Width = 230;
            dataGridView2.Columns[2].HeaderText = "xercin adi";
            con.Close();


            if (comboBox3.Items.Count > 0)
            {
                comboBox3.Items.Clear();
                oc = new OleDbCommand("select * from xercler", con);
                oc.CommandType = CommandType.Text;
                con.Open();
                OleDbDataReader odr = oc.ExecuteReader();

                while (odr.Read())
                {
                    comboBox3.Items.Add(odr.GetValue(0) + "." + odr.GetValue(1));

                }
                con.Close();
            }
            else
            {
                oc = new OleDbCommand("select * from xercler", con);
                oc.CommandType = CommandType.Text;
                con.Open();
                OleDbDataReader odr = oc.ExecuteReader();

                while (odr.Read())
                {
                    comboBox3.Items.Add(odr.GetValue(0)+"."+odr.GetValue(1));

                }
                con.Close();

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                label5Dish.Visible = true;
                comboBox3Dish.Visible = true;
                label22.Visible = true;
                pictureBox3.Visible = true;
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                cmd.Connection = con;
                if (comboBox3Dish.Items.Count > 0)
                {
                    comboBox3Dish.Items.Clear();

                }
                else
                {
                    cmd.CommandText = @"Select qida_adi from qida_elave_et where alt_qida= ""false"" ";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                        comboBox3Dish.Items.Add(dr.GetValue(0));
                }
                con.Close();

                con.Open();
                if (comboBox4.Items.Count > 0)
                {
                    comboBox4.Items.Clear();
                }

                else
                {
                    cmd.CommandText = @"Select qida_adi from qida_elave_et where alt_qida= ""true"" ";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                        comboBox4.Items.Add(dr.GetValue(0));
                }

                con.Close();
            }
            catch (Exception) { MessageBox.Show("qidanin adi tekrar secin"); }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label22.Visible = false;
            pictureBox3.Visible = false;
            label5Dish.Visible = false;
            comboBox3Dish.Visible = false;
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            con.Open();
            if (comboBox4.Items.Count > 0)
            {
                comboBox4.Items.Clear();
            }
            else
            {
                cmd.CommandText = @"Select qida_adi from qida_elave_et where alt_qida= ""false"" ";
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    comboBox4.Items.Add(dr.GetValue(0));

            }
            con.Close();


        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void admin_radio_register_page_CheckedChanged(object sender, EventArgs e)
        {
            label16.Visible = true;
            textBox1.Visible = true;
            pictureBox2.Visible = true;
            label19DishAdd.Visible = true;
            comboBox1DishAdd.Visible = true;
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            if (comboBox1DishAdd.Items.Count > 0)
            {
                comboBox1DishAdd.Items.Clear();

            }
            else
            {
                cmd.CommandText = @"Select qida_adi from qida_elave_et where alt_qida= ""false"" ";
                //  comboBox1DishAdd.Text = cmd.ExecuteReader().ToString();

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    //cmd.ExecuteReader();
                    // comboBox1DishAdd.Items.Remove(0);

                    comboBox1DishAdd.Items.Add(dr.GetValue(0));
            }
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label16.Visible = false;
            textBox1.Visible = false;
            pictureBox2.Visible = false;
            label19DishAdd.Visible = false;
            comboBox1DishAdd.Visible = false;

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ferhan\Desktop\quasar.accdb");

        private void submit_add_menu_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                if (admin_radio_register_page.Checked == true)
                {

                    cmd.CommandText = "Insert into qida_elave_et(qida_adi,alt_qida,ust_qida,qiymet)  Values('" + input_username_login_page.Text + " " + comboBox1DishAdd.SelectedItem + "','" + "true" + "','" + comboBox1DishAdd.SelectedItem + "','" + float.Parse(textBox1.Text) + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Submitted", "Congrats");
                }
                else if (radioButton1.Checked == true)
                {

                    cmd.CommandText = "Insert into qida_elave_et(qida_adi,alt_qida)  Values('" + input_username_login_page.Text + "','" + "false" + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Submitted", "Congrats");
                }

                con.Close();
            }

            catch (Exception ex) { MessageBox.Show("bu ad movcuddur"); }
        }

        private void comboBox1DishAdd_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                if (radioButton2.Checked == true)
                {
                    cmd.CommandText = @"update qida_elave_et set qida_adi = " + " '" + textBox3.Text + "' where qida_adi =  " +
                        " '" + comboBox4.Text + " '";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Submitted", "Congrats");
                }
                con.Close();


                con.Open();
                if (radioButton3.Checked == true)
                {
                    cmd.CommandText = @"update qida_elave_et set qida_adi = " + " '" +
                        textBox3.Text + " " + comboBox3Dish.Text + "' , qiymet = " +
                        decimal.Parse(textBox2.Text) + " where qida_adi =  " +
                        " '" + comboBox4.Text + " '";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Submitted", "Congrats");
                }
                con.Close();
            }
            catch (Exception) { MessageBox.Show("adi tekrar secin"); }
        }







        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_username_login_page_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                cmd.Connection = con;
                if (radioButton1.Checked == true)
                {
                    cmd.CommandText = @"Select qida_adi from qida_elave_et where alt_qida = ""false"" ";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        col.Add(dr.GetString(0));
                    }

                    input_username_login_page.AutoCompleteCustomSource = col;
                    con.Close();
                }
                if (admin_radio_register_page.Checked == true)
                {

                    cmd.CommandText = @"Select qida_adi from qida_elave_et where alt_qida = ""true"" ";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        col.Add(dr.GetString(0));
                    }

                    input_username_login_page.AutoCompleteCustomSource = col;
                    con.Close();
                }



            }
            catch (Exception) { };
        }
        Boolean a;
        int b;
        
        
        private void button12_Click(object sender, EventArgs e)
        {

            XmlDocument dc = new XmlDocument();
            dc.Load("D:\\document.xml");
            var c = dc.SelectNodes("/body/last");
             string  d = c[0].InnerText;
            label5.Text = d;

            b = Int32.Parse(d);
            if (b < 15)
            {
                b++;
                label5.Text = b.ToString();

                string xmlFile = "D:\\document.xml";
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.Load(xmlFile);
                xmlDoc.SelectSingleNode("/body/last").InnerText = b.ToString();
                xmlDoc.Save(xmlFile);

                
      
            }
            else
            {
                MessageBox.Show("maximum limite catmisiniz");
            }
           

        }
        
      

        private void button14_Click(object sender, EventArgs e)
        {
            XmlDocument dc = new XmlDocument();
            dc.Load("D:\\document.xml");
            var c = dc.SelectNodes("/body/last");
             string  d = c[0].InnerText;
            label5.Text = d;

            b = Int32.Parse(d);
            if (b < 16)
            {
                b = b - 1;
                label5.Text = b.ToString();

                string xmlFile = "D:\\document.xml";
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.Load(xmlFile);
                xmlDoc.SelectSingleNode("/body/last").InnerText = b.ToString();
                xmlDoc.Save(xmlFile);

                
      
            }
          
            else
            {
                MessageBox.Show("maximum limite catmisiniz");
            }
        }

        private void logo_panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.Manual;
            f1.Left = 800;
            f1.Top = 250;
            f1.Show();
           
            
        
        }

    
        private void button18_Click(object sender, EventArgs e)
        {
           
          
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Left = 800;
            f2.Top = 250;
            f2.Show();
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.StartPosition = FormStartPosition.Manual;
            f3.Left = 800;
            f3.Top = 250;
            f3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"delete from qida_elave_et where qida_adi='"+comboBox2.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("məhsul silindi");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.Items.Clear();

            }
            else
            {
                cmd.CommandText = @"Select qida_adi from qida_elave_et where alt_qida= ""true"" ";
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    comboBox2.Items.Add(dr.GetValue(0));
            }
            con.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.Connection = con;
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.Items.Clear();

            }
            else
            {
                cmd.CommandText = @"Select qida_adi from qida_elave_et where alt_qida= ""false"" ";
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    comboBox2.Items.Add(dr.GetValue(0));
            }
            con.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                string instr = "insert into xercler (x_name,x_comment) values ('" + comboBox1.Text + "','" + textBox4.Text + "')";
                OleDbCommand oc = new OleDbCommand(instr, con);
                con.Open();
                oc.ExecuteNonQuery();
                con.Close();

                oc = new OleDbCommand("select * from xercler", con);
                oc.CommandType = CommandType.Text;
                oda = new OleDbDataAdapter(oc);
                ocb = new OleDbCommandBuilder(oda);
                ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex) { MessageBox.Show("xahiş bütün xanalara məlumat daxil edin"); }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string del = "delete * from xercler where x_id="+dataGridView1.Rows[0].Cells[0].Value.ToString();
            OleDbCommand oc = new OleDbCommand(del, con);
            con.Open();
            oc.ExecuteNonQuery();
            con.Close();

            oc = new OleDbCommand("select * from xercler", con);
            oc.CommandType = CommandType.Text;
            oda = new OleDbDataAdapter(oc);
            ocb = new OleDbCommandBuilder(oda);
            ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button38_Click(object sender, EventArgs e)
        {


            string x_id = comboBox3.Text.Substring(0, comboBox3.Text.IndexOf("."));
            string gx_id = comboBox3.Text.Substring(comboBox3.Text.IndexOf(".") + 1);
            string instr = "insert into gundelik_xerc (x_id,gx_adi,gx_mebleg,gx_qeyd) values ("+x_id+",'"+gx_id+"',"+
                textBox5.Text+",'"+textBox6.Text+"')";
            oc = new OleDbCommand(instr, con);
            oc.CommandType = CommandType.Text;
            con.Open();
            oc.ExecuteNonQuery();
            con.Close();

            con.Open();
            oc = new OleDbCommand("select * from gundelik_xerc", con);
            oc.CommandType = CommandType.Text;
            oda = new OleDbDataAdapter(oc);
            ocb = new OleDbCommandBuilder(oda);
            ds = new DataSet();
            oda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();

        }

       
        }
      
    }
