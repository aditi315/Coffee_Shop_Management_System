namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Views
{
    partial class ManageEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployee));
            this.labelMAnageEmployeelabel = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonEmpoyeeGetAll = new System.Windows.Forms.Button();
            this.buttonEmployeeLogOut = new System.Windows.Forms.Button();
            this.buttonGoBackEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMAnageEmployeelabel
            // 
            this.labelMAnageEmployeelabel.AutoSize = true;
            this.labelMAnageEmployeelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMAnageEmployeelabel.Location = new System.Drawing.Point(333, 54);
            this.labelMAnageEmployeelabel.Name = "labelMAnageEmployeelabel";
            this.labelMAnageEmployeelabel.Size = new System.Drawing.Size(170, 24);
            this.labelMAnageEmployeelabel.TabIndex = 0;
            this.labelMAnageEmployeelabel.Text = "EMPLOYEE LIST";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(262, 91);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(362, 245);
            this.dataGridViewEmployee.TabIndex = 5;
            // 
            // buttonEmpoyeeGetAll
            // 
            this.buttonEmpoyeeGetAll.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpoyeeGetAll.Location = new System.Drawing.Point(366, 355);
            this.buttonEmpoyeeGetAll.Name = "buttonEmpoyeeGetAll";
            this.buttonEmpoyeeGetAll.Size = new System.Drawing.Size(137, 34);
            this.buttonEmpoyeeGetAll.TabIndex = 6;
            this.buttonEmpoyeeGetAll.Text = "Get All Employee";
            this.buttonEmpoyeeGetAll.UseVisualStyleBackColor = true;
            this.buttonEmpoyeeGetAll.Click += new System.EventHandler(this.ButtonEmpoyeeGetAll_Click);
            // 
            // buttonEmployeeLogOut
            // 
            this.buttonEmployeeLogOut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeLogOut.ForeColor = System.Drawing.Color.Red;
            this.buttonEmployeeLogOut.Location = new System.Drawing.Point(698, 23);
            this.buttonEmployeeLogOut.Name = "buttonEmployeeLogOut";
            this.buttonEmployeeLogOut.Size = new System.Drawing.Size(110, 33);
            this.buttonEmployeeLogOut.TabIndex = 7;
            this.buttonEmployeeLogOut.Text = "Logout";
            this.buttonEmployeeLogOut.UseVisualStyleBackColor = true;
            this.buttonEmployeeLogOut.Click += new System.EventHandler(this.ButtonEmployeeLogOut_Click);
            // 
            // buttonGoBackEmployee
            // 
            this.buttonGoBackEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBackEmployee.Location = new System.Drawing.Point(34, 12);
            this.buttonGoBackEmployee.Name = "buttonGoBackEmployee";
            this.buttonGoBackEmployee.Size = new System.Drawing.Size(110, 32);
            this.buttonGoBackEmployee.TabIndex = 8;
            this.buttonGoBackEmployee.Text = "Go Back";
            this.buttonGoBackEmployee.UseVisualStyleBackColor = true;
            this.buttonGoBackEmployee.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(848, 512);
            this.Controls.Add(this.buttonGoBackEmployee);
            this.Controls.Add(this.buttonEmployeeLogOut);
            this.Controls.Add(this.buttonEmpoyeeGetAll);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.labelMAnageEmployeelabel);
            this.DoubleBuffered = true;
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMAnageEmployeelabel;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonEmpoyeeGetAll;
        private System.Windows.Forms.Button buttonEmployeeLogOut;
        private System.Windows.Forms.Button buttonGoBackEmployee;
    }
}