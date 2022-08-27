using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace User_Registration_Exercise_1
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void userLisDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserList_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2"].ConnectionString); //Connect the SQL

            connection.Open();    //For open the connection

            //Write Quary
            String sql = "SELECT * FROM Users";

            SqlCommand command = new SqlCommand(sql, connection);   // For execute the Data

            SqlDataReader reader = command.ExecuteReader();

            List<User> users = new List<User>();  //Create in List

            while (reader.Read())
            {
                User user = new User(); //Create User object ref

                //Calling sql read

                user.Id = (int)reader["Id"]; 
                //user.Name = (string)reader["Name"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString();
                user.Password = reader["Password"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.BloodGroup = reader["BloodGroup"].ToString();
                users.Add(user);
            }

            userLisDataGridView1.DataSource = users; //For data source

            connection.Close();  //For closing
        }

        private void userRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationFrom registrationFrom = new RegistrationFrom();
            registrationFrom.Show();
            this.Hide();
        }
    }
}
