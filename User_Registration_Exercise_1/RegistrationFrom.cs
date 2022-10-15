using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration_Exercise_1
{
    public partial class RegistrationFrom : Form
    {
        public RegistrationFrom()
        {
            InitializeComponent();
        }

        public string ConfigarationManager { get; private set; }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "")
            {
                MessageBox.Show("   Name can not be empty.  ");                                       //Show the message
            }
            else if (userNameTextBox.Text == "")
            {
                MessageBox.Show("   Userame can not be empty.  ");                                       //Show the message
            }
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("   Email can not be empty.  ");                                       //Show the message
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("   Password can not be empty.  ");                                       //Show the message
            }
            if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("   Confirm Password can not be empty.  ");                                       //Show the message
            }
            if (dateOfBirthDatePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("   Date of Birth incorrect.  ");                                       //Show the message
            }
            if ((genderRadioButton1.Checked == false) && (genderRadioButton2.Checked == false))
            {
                MessageBox.Show("   Select gender.  ");                                       //Show the message
            }
            if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("   Blood Group can not be empty.  ");                                       //Show the message
            }
            else
            {
                if(passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password doesn't match.");
                }
                else
                {
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2"].ConnectionString); //Connect the SQL

                    connection.Open();

                    User user = new User();

                    user.Name = nameTextBox.Text;
                    user.Username = userNameTextBox.Text;
                    user.Email = emailTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.DateOfBirth = dateOfBirthDatePicker.Text;
                    if(genderRadioButton1.Checked)
                    {
                        user.Gender = "Male";
                    }
                    else
                    {
                        user.Gender = "Female";
                    }
                    user.BloodGroup = bloodGroupComboBox.Text;

                    string sql = "INSERT INTO Users(Name,Username,Email,Password,DateOfBirth,Gender,BloodGroup)" +
                        "VALUES('" + user.Name + "','" + user.Username + "','" + user.Email + "','" + user.Password + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.BloodGroup + "')";

                    SqlCommand command = new SqlCommand(sql, connection);

                    int result = command.ExecuteNonQuery();

                    connection.Close();

                    if(result > 0)
                    {
                        MessageBox.Show("User added successfully.");

                        UserList userList = new UserList();
                        userList.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User added unsuccessfully.");
                    }
                }
            }
        }

        private void termsheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(termscheckBox.Checked)
            {
                submitButton1.Enabled = true;
            }
            else
            { 
                submitButton1.Enabled = false;
            }
        }
    }
}
