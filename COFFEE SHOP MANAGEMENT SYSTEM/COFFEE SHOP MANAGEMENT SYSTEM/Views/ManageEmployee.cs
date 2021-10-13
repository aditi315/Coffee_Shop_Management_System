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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {

        }

        private void LabelEmployeePassword_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            EmployeeHome lf = new EmployeeHome();
            this.Hide();
            lf.Closed += (s, args) => this.Close();
            lf.Show();
            
        }

        private void ButtonEmployeeLogOut_Click(object sender, EventArgs e)
        {
           
            Application.Restart();
        }

        private void ButtonEmpoyeeGetAll_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = UserController.GetAllEmployee();
        }

        private void ButtonSubmitEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
