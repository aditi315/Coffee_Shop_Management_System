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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {

            OrderController.UpdateOrder(textBoxOrderId.Text, textBoxOrderName.Text, textBoxOrderPrice.Text, textBoxOrderQty.Text);
            dataGridViewOrderWindow.DataSource = OrderController.GetAllOrder();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            dataGridViewOrderWindow.DataSource = OrderController.GetAllOrder();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            OrderController.AddOrder(textBoxOrderId.Text, textBoxOrderName.Text, textBoxOrderPrice.Text, textBoxOrderQty.Text);
            dataGridViewOrderWindow.DataSource = OrderController.GetAllOrder();
            // if (e.StateChanged != DataGridViewElementStates.Selected) return;
        }

        private void ButtonLogoutOrder_Click(object sender, EventArgs e)
        {
           
            Application.Restart();
        }

        private void DataGridViewOrderWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            EmployeeHome lf = new EmployeeHome();
            this.Hide();
            lf.Closed += (s, args) => this.Close();
            lf.Show();
        }
    }
}
