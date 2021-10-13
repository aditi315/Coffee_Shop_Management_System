namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Views
{
    partial class EmployeeHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHome));
            this.buttonManageProducts = new System.Windows.Forms.Button();
            this.buttonManageCustomer = new System.Windows.Forms.Button();
            this.buttonManageOrder = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelEmployeeHome = new System.Windows.Forms.Label();
            this.buttonManageEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageProducts
            // 
            this.buttonManageProducts.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageProducts.Location = new System.Drawing.Point(45, 108);
            this.buttonManageProducts.Name = "buttonManageProducts";
            this.buttonManageProducts.Size = new System.Drawing.Size(172, 41);
            this.buttonManageProducts.TabIndex = 0;
            this.buttonManageProducts.Text = "Manage Products";
            this.buttonManageProducts.UseVisualStyleBackColor = true;
            this.buttonManageProducts.Click += new System.EventHandler(this.ButtonEmployeeManage_Click);
            // 
            // buttonManageCustomer
            // 
            this.buttonManageCustomer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageCustomer.Location = new System.Drawing.Point(45, 155);
            this.buttonManageCustomer.Name = "buttonManageCustomer";
            this.buttonManageCustomer.Size = new System.Drawing.Size(172, 41);
            this.buttonManageCustomer.TabIndex = 1;
            this.buttonManageCustomer.Text = "Manage Customer";
            this.buttonManageCustomer.UseVisualStyleBackColor = true;
            this.buttonManageCustomer.Click += new System.EventHandler(this.ButtonManageCustomer_Click);
            // 
            // buttonManageOrder
            // 
            this.buttonManageOrder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageOrder.Location = new System.Drawing.Point(45, 202);
            this.buttonManageOrder.Name = "buttonManageOrder";
            this.buttonManageOrder.Size = new System.Drawing.Size(172, 40);
            this.buttonManageOrder.TabIndex = 3;
            this.buttonManageOrder.Text = "Manage Order";
            this.buttonManageOrder.UseVisualStyleBackColor = true;
            this.buttonManageOrder.Click += new System.EventHandler(this.ButtonManageOrder_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLogout.Location = new System.Drawing.Point(664, 3);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(113, 42);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // labelEmployeeHome
            // 
            this.labelEmployeeHome.AutoSize = true;
            this.labelEmployeeHome.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeHome.ForeColor = System.Drawing.Color.Maroon;
            this.labelEmployeeHome.Location = new System.Drawing.Point(203, 31);
            this.labelEmployeeHome.Name = "labelEmployeeHome";
            this.labelEmployeeHome.Size = new System.Drawing.Size(351, 26);
            this.labelEmployeeHome.TabIndex = 6;
            this.labelEmployeeHome.Text = "WELCOME TO EMPLOYEE HOME";
            // 
            // buttonManageEmployee
            // 
            this.buttonManageEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageEmployee.Location = new System.Drawing.Point(45, 248);
            this.buttonManageEmployee.Name = "buttonManageEmployee";
            this.buttonManageEmployee.Size = new System.Drawing.Size(172, 40);
            this.buttonManageEmployee.TabIndex = 7;
            this.buttonManageEmployee.Text = " Employee List";
            this.buttonManageEmployee.UseVisualStyleBackColor = true;
            this.buttonManageEmployee.Click += new System.EventHandler(this.ButtonManageEmployee_Click);
            // 
            // EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.buttonManageEmployee);
            this.Controls.Add(this.labelEmployeeHome);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonManageOrder);
            this.Controls.Add(this.buttonManageCustomer);
            this.Controls.Add(this.buttonManageProducts);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "EmployeeHome";
            this.Text = "EmployeeHome";
            this.Load += new System.EventHandler(this.EmployeeHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManageProducts;
        private System.Windows.Forms.Button buttonManageCustomer;
        private System.Windows.Forms.Button buttonManageOrder;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelEmployeeHome;
        private System.Windows.Forms.Button buttonManageEmployee;
    }
}