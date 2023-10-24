using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CreateUser
{
    public partial class Login_page : Form
    {
        String connectionString = @"Data Source=DESKTOP-37PB8E2\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";

        public Login_page()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_page_Load(object sender, EventArgs e)
        {

        }



        private void button_register_Click(object sender, EventArgs e)
        {
            // hide current view and open register view
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            SqlConnection sqlcon = new SqlConnection(connectionString);
            String querry = "SELECT * FROM tblUser WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, sqlcon);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                username = txt_username.Text;
                user_password = txt_password.Text;
                txt_password.Clear();
                txt_username.Clear();
;                MessageBox.Show("Win");

            }
            else
            {
                MessageBox.Show("Not good news");
            }
        }
    }
}
