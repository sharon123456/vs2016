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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit the app
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the app
            Application.Exit();
        }

        private void manageCoffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCoffee obj = (ManageCoffee)Application.OpenForms["ManageCoffee"];

            //check if form is already opened
            if (obj != null)
            {
                MessageBox.Show("Manage Coffee Form is already opened");
            }
            else
            {
                //open manage coffee
                ManageCoffee mc = new ManageCoffee();
                mc.MdiParent = this;
                mc.Show();

                //display
                tsslblMessage.Text = "Manage Coffee Window opened";
                tsslblMessage.ForeColor = Color.Black;

            }
        }

        private void manageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStock obj = (ManageStock)Application.OpenForms["ManageStock"];

            //check if form is already opened
            if (obj != null)
            {
                MessageBox.Show("Manage Stock Form is already opened");
            }
            else
            {
                //open manage stock
                ManageStock mc = new ManageStock();
                mc.MdiParent = this;
                mc.Show();

                //display
                tsslblMessage.Text = "Manage Stock Window opened";
                tsslblMessage.ForeColor = Color.Black;

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tsslblMessage.Text = "";
            tsslblMessage.ForeColor = Color.Black;

            //check stock
            CheckStockQuantity();
        }

        private void CheckStockQuantity()
        {
            string query = "Select * From cs_Coffee where stockQuantity < 10";

            try
            {
                DbHandler dbhandle = new DbHandler();

                DataTable dt = dbhandle.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    //some coffee are out of stock so alert
                    MessageBox.Show(dt.Rows.Count + " coffee items are out of stock",
                        "Stock control issues");

                    tsslblMessage.ForeColor = Color.Red;
                    tsslblMessage.Text = "Your attention is needed, " + dt.Rows.Count + " coffee items are out of stock";

                }
            }
            catch (SqlException)
            {
                tsslblMessage.ForeColor = Color.Red;
                tsslblMessage.Text = "Sql Error occured, please contact IT Support";
            }
            catch (Exception)
            {
                tsslblMessage.ForeColor = Color.Red;
                tsslblMessage.Text = "Error occured, please contact IT Support";
            }
        }
    }
}
