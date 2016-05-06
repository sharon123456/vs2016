using CoffeeShopApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
        }

        private void ManageStock_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'coffeeShopDbDataSet.cs_Coffee' table. You can move, or remove it, as needed.
            this.cs_CoffeeTableAdapter.FillBy(this.coffeeShopDbDataSet.cs_Coffee);

            lblMessage.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                this.cs_CoffeeTableAdapter.Update(this.coffeeShopDbDataSet.cs_Coffee);

                lblMessage.Text = "Stock saved successfully";

                //send email to suscribers
                SendEmail();
            }
            catch (Exception)
            {
                lblMessage.Text = "Error occured while saving, pls contact admin";
            }
        }

        private void SendEmail()
        {
            string query = "Select s.email, c.coffeeName from cs_Subscribe s " +
                "Join cs_Coffee c on c.coffeeId = s.coffeeId " +
                "Where c.stockQuantity > 10";

            try
            {
                DbHandler dbhandle = new DbHandler();

                DataTable dt = dbhandle.GetData(query);

                foreach (DataRow dr in dt.Rows)
                {
                    string email = "" + dr["email"];
                    string coffeeName = "" + dr["coffeeName"];
                    string cc = "gertrude861@yahoo.co.uk";//I just want to get a copy

                    //send an email
                    string title = "New Stock Available";
                    string recipient = email;
                    string message = "We have more quantities available for " + coffeeName;

                    //create an instance of smtp client
                    SmtpClient client = new SmtpClient("smtp.gmail.com");

                    //set the credentials
                    client.Credentials = new NetworkCredential("dotpeaktester@gmail.com", "123dotpeak");

                    //EnableTheming ssl
                    client.EnableSsl = true;

                    //create an instance of mail message
                    MailMessage mm = new MailMessage("dotpeaktester@gmail.com", recipient, title, message);


                    if (!string.IsNullOrWhiteSpace(cc))
                    {
                        //create an instance of mailaddress
                        MailAddress macc = new MailAddress(cc);

                        //add address to mail message
                        mm.CC.Add(macc);

                    }

                    //send the mail 
                    client.Send(mm);

                    //display message sent
                    lblMessage.Text += ", Email sent successfully";

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Eor" + e);
                lblMessage.Text += "Error occured, pls contact IT Support";
            }
        }
    }
}
