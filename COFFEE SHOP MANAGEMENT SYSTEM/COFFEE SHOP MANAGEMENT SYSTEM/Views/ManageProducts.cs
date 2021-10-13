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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Get_All_Products_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = ProductController.GetAllProduct();
        }
        private void FormLoad(object sender, EventArgs e)
        {
            
            var products = ProductController.GetAllProduct();
            dataGridViewProducts.DataSource = products;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            ProductController.AddProduct(textBoxPId.Text,textBoxPname.Text, textBoxPPrice.Text, textBoxPQty.Text);
            dataGridViewProducts.DataSource = ProductController.GetAllProduct();
            // if (e.StateChanged != DataGridViewElementStates.Selected) return;
        }

        private void EditUser(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            return;
            if (dataGridViewProducts.Rows.Count > 0)
            {
                var productid = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
                var productName = dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
                var productPrice = dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
                var productQty = dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
                

                textBoxPname.Text = productName;
                textBoxPPrice.Text = productPrice;
                textBoxPQty.Text = productQty;
                textBoxPId.Text = productid;
            }
            //MessageBox.Show("Event");

        }

        private void RowChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductController.UpdateProduct(textBoxPId.Text, textBoxPname.Text, textBoxPPrice.Text, textBoxPQty.Text);
            dataGridViewProducts.DataSource = ProductController.GetAllProduct();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            Application.Restart();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            EmployeeHome l = new EmployeeHome();
            this.Hide();
            l.Closed += (s, args) => this.Close();
            l.Show();
        }
    }
}
