using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEE_SHOP_MANAGEMENT_SYSTEM.Controllers;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void LabelUserId_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var result = LoginController.AuthenticateUser(textBoxUserName.Text, textBoxPassword.Text);
            if (result == 1)
            {
          
              // MessageBox.Show("Success", "Alert");

            
              // new EmployeeHome().Show();
              
                EmployeeHome ef = new EmployeeHome();
                this.Hide();
                ef.Closed += (s, args) => this.Close();
                ef.Show();
            }
            else if (result == 2)
            {
                /*
                MessageBox.Show("Success", "Alert");


                new CustomerHome().Show();
                */
                CustomerHome cf = new CustomerHome();
                this.Hide();
                cf.Closed += (s, args) => this.Close();
                cf.Show();
            }
            else
            {
                MessageBox.Show("Failure", "Alert");
            }

        }

        private void TextBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
