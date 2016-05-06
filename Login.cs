using CoffeeShopApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = ""; //empty error message

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                //display error
                errorProvider1.SetError(txtEmail, "Please enter email");

                errorProvider1.SetError(txtPassword, "");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                //display error
                errorProvider1.SetError(txtPassword, "Please enter password");
                errorProvider1.SetError(txtEmail, "");

            }
            else
            {
                //remove all errors
                errorProvider1.SetError(txtEmail, "");
                errorProvider1.SetError(txtPassword, "");

                //prevent sql injection
                email = email.Replace("'", "").Replace("%", "").Replace(";", "");
                password = password.Replace("'", "").Replace("%", "").Replace(";", "");
                
                //query
                string query =
                    string.Format("Select role from cs_User where email='{0}' " +
                    "and password='{1}';", email, password);

                try
                {

                    //create an instance of Dbhandler
                    DbHandler dbhandle = new DbHandler();

                    //get the query result
                    DataTable dt = dbhandle.GetData(query);

                    if (dt.Rows.Count > 0)
                    {
                        //user exist
                        string role = "" + dt.Rows[0]["role"];
                        
                        if (role.ToUpper() == "ADMIN")
                        {
                            new MainForm().Show();

                            //hide this window
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You are not allowed to use system, contact Admin", "Invalid User");
                        }
                    }
                    else
                    {
                        //user does not exist
                        lblMessage.Text = "email and/or password is incorrect";
                    }

                }
                catch (SqlException)
                {
                    lblMessage.Text = "Sql Exception occured";
                }
                catch (Exception)
                {
                    lblMessage.Text = "Exception occured";
                }
            }
        }
    }
}
