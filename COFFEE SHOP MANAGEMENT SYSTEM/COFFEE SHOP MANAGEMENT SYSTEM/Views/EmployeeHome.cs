using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Views
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void EmployeeHome_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEmployeeManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageProducts().Show();
        }

        private void ButtonManageOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageOrders().Show();

        }

        private void ButtonManageCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageCustomer().Show();
            
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
           
            Application.Restart();

        }

        private void ButtonManageEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageEmployee().Show();
        }
    }
}
