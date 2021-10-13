namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Views
{
    partial class ManageOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrderWindow = new System.Windows.Forms.DataGridView();
            this.buttonLogoutOrder = new System.Windows.Forms.Button();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.labelOrderName = new System.Windows.Forms.Label();
            this.labelOrderPrice = new System.Windows.Forms.Label();
            this.labelOrderQuantity = new System.Windows.Forms.Label();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.textBoxOrderPrice = new System.Windows.Forms.TextBox();
            this.textBoxOrderQty = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER WINDOW";
            // 
            // dataGridViewOrderWindow
            // 
            this.dataGridViewOrderWindow.AllowUserToOrderColumns = true;
            this.dataGridViewOrderWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderWindow.Location = new System.Drawing.Point(466, 63);
            this.dataGridViewOrderWindow.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrderWindow.Name = "dataGridViewOrderWindow";
            this.dataGridViewOrderWindow.RowHeadersWidth = 51;
            this.dataGridViewOrderWindow.RowTemplate.Height = 24;
            this.dataGridViewOrderWindow.Size = new System.Drawing.Size(287, 297);
            this.dataGridViewOrderWindow.TabIndex = 1;
            this.dataGridViewOrderWindow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOrderWindow_CellContentClick);
            // 
            // buttonLogoutOrder
            // 
            this.buttonLogoutOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLogoutOrder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogoutOrder.ForeColor = System.Drawing.Color.Red;
            this.buttonLogoutOrder.Location = new System.Drawing.Point(664, 2);
            this.buttonLogoutOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogoutOrder.Name = "buttonLogoutOrder";
            this.buttonLogoutOrder.Size = new System.Drawing.Size(119, 45);
            this.buttonLogoutOrder.TabIndex = 2;
            this.buttonLogoutOrder.Text = "LOGOUT";
            this.buttonLogoutOrder.UseVisualStyleBackColor = false;
            this.buttonLogoutOrder.Click += new System.EventHandler(this.ButtonLogoutOrder_Click);
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdateOrder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateOrder.Location = new System.Drawing.Point(169, 281);
            this.buttonUpdateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(118, 45);
            this.buttonUpdateOrder.TabIndex = 3;
            this.buttonUpdateOrder.Text = "Update Order";
            this.buttonUpdateOrder.UseVisualStyleBackColor = false;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderId.Location = new System.Drawing.Point(36, 112);
            this.labelOrderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(64, 20);
            this.labelOrderId.TabIndex = 5;
            this.labelOrderId.Text = "Order Id:";
            // 
            // labelOrderName
            // 
            this.labelOrderName.AutoSize = true;
            this.labelOrderName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderName.Location = new System.Drawing.Point(35, 153);
            this.labelOrderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderName.Name = "labelOrderName";
            this.labelOrderName.Size = new System.Drawing.Size(87, 20);
            this.labelOrderName.TabIndex = 6;
            this.labelOrderName.Text = "Order Name:";
            // 
            // labelOrderPrice
            // 
            this.labelOrderPrice.AutoSize = true;
            this.labelOrderPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderPrice.Location = new System.Drawing.Point(36, 188);
            this.labelOrderPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderPrice.Name = "labelOrderPrice";
            this.labelOrderPrice.Size = new System.Drawing.Size(84, 20);
            this.labelOrderPrice.TabIndex = 7;
            this.labelOrderPrice.Text = "Order Price:";
            // 
            // labelOrderQuantity
            // 
            this.labelOrderQuantity.AutoSize = true;
            this.labelOrderQuantity.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderQuantity.Location = new System.Drawing.Point(20, 221);
            this.labelOrderQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderQuantity.Name = "labelOrderQuantity";
            this.labelOrderQuantity.Size = new System.Drawing.Size(115, 16);
            this.labelOrderQuantity.TabIndex = 8;
            this.labelOrderQuantity.Text = "Order Quantity:";
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonGetAll.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetAll.Location = new System.Drawing.Point(574, 364);
            this.buttonGetAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(96, 34);
            this.buttonGetAll.TabIndex = 9;
            this.buttonGetAll.Text = "GetAll";
            this.buttonGetAll.UseVisualStyleBackColor = false;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(157, 115);
            this.textBoxOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(76, 20);
            this.textBoxOrderId.TabIndex = 11;
            // 
            // textBoxOrderName
            // 
            this.textBoxOrderName.Location = new System.Drawing.Point(158, 154);
            this.textBoxOrderName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrderName.Name = "textBoxOrderName";
            this.textBoxOrderName.Size = new System.Drawing.Size(76, 20);
            this.textBoxOrderName.TabIndex = 12;
            // 
            // textBoxOrderPrice
            // 
            this.textBoxOrderPrice.Location = new System.Drawing.Point(158, 188);
            this.textBoxOrderPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrderPrice.Name = "textBoxOrderPrice";
            this.textBoxOrderPrice.Size = new System.Drawing.Size(76, 20);
            this.textBoxOrderPrice.TabIndex = 13;
            // 
            // textBoxOrderQty
            // 
            this.textBoxOrderQty.Location = new System.Drawing.Point(157, 221);
            this.textBoxOrderQty.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrderQty.Name = "textBoxOrderQty";
            this.textBoxOrderQty.Size = new System.Drawing.Size(76, 20);
            this.textBoxOrderQty.TabIndex = 14;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSubmit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonSubmit.Location = new System.Drawing.Point(23, 282);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(123, 45);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(23, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 39);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "GO BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(813, 487);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxOrderQty);
            this.Controls.Add(this.textBoxOrderPrice);
            this.Controls.Add(this.textBoxOrderName);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.buttonGetAll);
            this.Controls.Add(this.labelOrderQuantity);
            this.Controls.Add(this.labelOrderPrice);
            this.Controls.Add(this.labelOrderName);
            this.Controls.Add(this.labelOrderId);
            this.Controls.Add(this.buttonUpdateOrder);
            this.Controls.Add(this.buttonLogoutOrder);
            this.Controls.Add(this.dataGridViewOrderWindow);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageOrders";
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrderWindow;
        private System.Windows.Forms.Button buttonLogoutOrder;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.Label labelOrderName;
        private System.Windows.Forms.Label labelOrderPrice;
        private System.Windows.Forms.Label labelOrderQuantity;
        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.TextBox textBoxOrderName;
        private System.Windows.Forms.TextBox textBoxOrderPrice;
        private System.Windows.Forms.TextBox textBoxOrderQty;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;
    }
}