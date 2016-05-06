using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class ManageCoffee : Form
    {
        public ManageCoffee()
        {
            InitializeComponent();
        }

        private void ManageCoffee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDbDataSet.cs_Coffee' table. You can move, or remove it, as needed.
            this.cs_CoffeeTableAdapter.Fill(this.coffeeShopDbDataSet.cs_Coffee);

            lblMessage.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.cs_CoffeeTableAdapter.Update(this.coffeeShopDbDataSet.cs_Coffee);

                lblMessage.Text = "Saved successfully";
            }
            catch (Exception)
            {
                lblMessage.Text = "Error occured while saving, pls contact admin";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //check if any row was selected 
            if (dataGridView1.SelectedRows.Count < 1)
            {

                lblMessage.Text = "Please select a row to delete";
                return;
            }

            try
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    string coffeeId = "" + item.Cells[0].Value;

                    //delete the item
                    this.cs_CoffeeTableAdapter.DeleteQuery(Convert.ToInt32(coffeeId));

                    string coffeeName = "" + item.Cells[1].Value;

                    lblMessage.Text = coffeeName + " was deleted successfully";
                }

                //refresh grid
                this.cs_CoffeeTableAdapter.Fill(this.coffeeShopDbDataSet.cs_Coffee);

            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error occured while deleting, pls contact admin " + ex;
            }

        }
    }
}
