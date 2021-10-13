using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COFFEE_SHOP_MANAGEMENT_SYSTEM.Controllers;



namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Views
{
    public partial class CustomerHome : Form
    {
        string[] row;
        float totalPrice = 0.00f;
        String[] order= new string[] { "", "", "" };
        public CustomerHome()
        {
            InitializeComponent();
            comboLoad();
            dataGridViewMenu.ColumnCount = 3;
            dataGridViewMenu.Columns[0].Name = " Product Name";
            dataGridViewMenu.Columns[1].Name = "Quantity";
            dataGridViewMenu.Columns[2].Name = "Total Price";

        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {

        }

        private void ButtonViewOrder_Click(object sender, EventArgs e)
        {

        }

        private void ButtonViewMenu_Click(object sender, EventArgs e)
        {

        }

        public void comboLoad()
        {
           
           comboBox1.DataSource = ProductController.GetAllProductName();
            ArrayList arr2 = new ArrayList();
            for (int i = 1; i <= 10; i++) arr2.Add(i);
            comboBox2.DataSource = arr2;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // dataGridViewMenu.DataSource = ProductController.getProductByName(comboBox1.SelectedItem.ToString());
            MessageBox.Show("products: " + order[0] + "\n Quantity: " + order[1] + "\nTotal price: " + order[2]);

            UserController u = new UserController();
            u.insertIntoOrder(order[0], order[1], order[2]);
        }
        private void DataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
            string selectedProduct = comboBox1.SelectedItem.ToString();
            string selectedQuantity = comboBox2.SelectedItem.ToString();
           if(selectedProduct=="Select Item")
            {
                MessageBox.Show("Please select an Item!");
            }
            ProductController u = new ProductController();
            float productPrice = u.getPrice(selectedProduct)* float.Parse(selectedQuantity);
            row = new string[] { selectedProduct, selectedQuantity ,productPrice.ToString()};
            if (!row.Contains(selectedProduct)){
                MessageBox.Show("You have already selected this Item");
            }

            totalPrice += productPrice;
            textBox1.Text = totalPrice.ToString();
            if(order[0]!="")
            {
                order[0] += "," + selectedProduct;
                order[1] += "," + selectedQuantity;
                order[2] = totalPrice.ToString();
            }
            else
            {
                order[0] += selectedProduct;
                order[1] += selectedQuantity;
                order[2] = totalPrice.ToString();
            }
           
            dataGridViewMenu.Rows.Add(row);
        }

        private void ButtonCustomerLogout_Click(object sender, EventArgs e)
        {
            
            Application.Restart();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}

