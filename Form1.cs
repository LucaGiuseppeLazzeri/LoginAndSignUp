using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CreateUser
{
    public partial class Form1 : Form
    {

        String connectionString = @"Data Source=DESKTOP-37PB8E2\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Submit_Click(object sender, EventArgs e)

        {

            if (txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("All fields are mandatory");
            }
            else if (txt_Password.Text != txt_ConPass.Text)
            {
                MessageBox.Show("Passwords dont match");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@FirstName", txt_firstname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@LastName", txt_LastName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Username", txt_Username.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", txt_Password.Text.Trim());



                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("registraition is sucessfull");
                    Clear();


                }
            }

           
        }

        void Clear()
        {
            txt_firstname.Text = txt_LastName.Text = txt_Username.Text = txt_Password.Text = txt_ConPass.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_ConPass_TextChanged(object sender, EventArgs e)
        {

        }
    }

}