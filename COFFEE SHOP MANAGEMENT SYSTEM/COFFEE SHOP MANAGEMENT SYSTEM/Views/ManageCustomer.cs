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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserController.UpdateUser(textBoxId.Text, textBoxName.Text, textBoxUserName.Text, textBoxcPassword.Text, textBoxUserType.Text);
            dataGridViewManageCustomer.DataSource = UserController.GetAllCustomer();
        }

        private void ButtonGetAllCus_Click(object sender, EventArgs e)
        {
            dataGridViewManageCustomer.DataSource = UserController.GetAllCustomer();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            Application.Restart();
        }

        private void ButtonGoBackC_Click(object sender, EventArgs e)
        {
            EmployeeHome lf = new EmployeeHome();
            this.Hide();
            lf.Closed += (s, args) => this.Close();
            lf.Show();
            
        }

        private void ButtonSubmitCustomer_Click(object sender, EventArgs e)
        {
            UserController.AddUser(textBoxId.Text,textBoxName.Text,textBoxUserName.Text, textBoxcPassword.Text,textBoxUserType.Text);
            dataGridViewManageCustomer.DataSource = UserController.GetAllCustomer();

        }
    }
    
}
