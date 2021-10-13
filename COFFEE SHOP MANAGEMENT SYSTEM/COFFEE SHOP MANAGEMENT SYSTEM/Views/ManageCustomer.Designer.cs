namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Views
{
    partial class ManageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            this.dataGridViewManageCustomer = new System.Windows.Forms.DataGridView();
            this.labelCcaption = new System.Windows.Forms.Label();
            this.buttonGetAllCus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGoBackC = new System.Windows.Forms.Button();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxcPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonSubmitCustomer = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUserType = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUserType = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManageCustomer
            // 
            this.dataGridViewManageCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageCustomer.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewManageCustomer.Location = new System.Drawing.Point(416, 74);
            this.dataGridViewManageCustomer.Name = "dataGridViewManageCustomer";
            this.dataGridViewManageCustomer.Size = new System.Drawing.Size(294, 283);
            this.dataGridViewManageCustomer.TabIndex = 2;
            // 
            // labelCcaption
            // 
            this.labelCcaption.AutoSize = true;
            this.labelCcaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCcaption.Location = new System.Drawing.Point(125, 32);
            this.labelCcaption.Name = "labelCcaption";
            this.labelCcaption.Size = new System.Drawing.Size(335, 24);
            this.labelCcaption.TabIndex = 5;
            this.labelCcaption.Text = "CUSTOMER MANAGING WINDOW";
            // 
            // buttonGetAllCus
            // 
            this.buttonGetAllCus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetAllCus.Location = new System.Drawing.Point(533, 363);
            this.buttonGetAllCus.Name = "buttonGetAllCus";
            this.buttonGetAllCus.Size = new System.Drawing.Size(75, 36);
            this.buttonGetAllCus.TabIndex = 6;
            this.buttonGetAllCus.Text = "Get All";
            this.buttonGetAllCus.UseVisualStyleBackColor = true;
            this.buttonGetAllCus.Click += new System.EventHandler(this.ButtonGetAllCus_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(680, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonGoBackC
            // 
            this.buttonGoBackC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBackC.Location = new System.Drawing.Point(4, 21);
            this.buttonGoBackC.Name = "buttonGoBackC";
            this.buttonGoBackC.Size = new System.Drawing.Size(107, 35);
            this.buttonGoBackC.TabIndex = 8;
            this.buttonGoBackC.Text = "Go Back";
            this.buttonGoBackC.UseVisualStyleBackColor = true;
            this.buttonGoBackC.Click += new System.EventHandler(this.ButtonGoBackC_Click);
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerId.Location = new System.Drawing.Point(34, 227);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(137, 20);
            this.labelCustomerId.TabIndex = 1;
            this.labelCustomerId.Text = "Customer Password:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(40, 177);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(131, 20);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Customer Userame:";
            // 
            // textBoxcPassword
            // 
            this.textBoxcPassword.Location = new System.Drawing.Point(177, 227);
            this.textBoxcPassword.Name = "textBoxcPassword";
            this.textBoxcPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxcPassword.TabIndex = 4;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(177, 177);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(215, 20);
            this.textBoxUserName.TabIndex = 3;
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(177, 363);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(96, 35);
            this.buttonUpdateCustomer.TabIndex = 9;
            this.buttonUpdateCustomer.Text = "Update";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonSubmitCustomer
            // 
            this.buttonSubmitCustomer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitCustomer.Location = new System.Drawing.Point(293, 363);
            this.buttonSubmitCustomer.Name = "buttonSubmitCustomer";
            this.buttonSubmitCustomer.Size = new System.Drawing.Size(99, 35);
            this.buttonSubmitCustomer.TabIndex = 10;
            this.buttonSubmitCustomer.Text = "Submit";
            this.buttonSubmitCustomer.UseVisualStyleBackColor = true;
            this.buttonSubmitCustomer.Click += new System.EventHandler(this.ButtonSubmitCustomer_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(177, 276);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(215, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxUserType
            // 
            this.textBoxUserType.Location = new System.Drawing.Point(177, 316);
            this.textBoxUserType.Name = "textBoxUserType";
            this.textBoxUserType.Size = new System.Drawing.Size(215, 20);
            this.textBoxUserType.TabIndex = 13;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(62, 280);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 16);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name:";
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserType.Location = new System.Drawing.Point(62, 320);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(74, 16);
            this.labelUserType.TabIndex = 15;
            this.labelUserType.Text = "User Type:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(177, 143);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(215, 20);
            this.textBoxId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id:";
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelUserType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxUserType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSubmitCustomer);
            this.Controls.Add(this.buttonUpdateCustomer);
            this.Controls.Add(this.buttonGoBackC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGetAllCus);
            this.Controls.Add(this.labelCcaption);
            this.Controls.Add(this.textBoxcPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.dataGridViewManageCustomer);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.labelCustomerName);
            this.DoubleBuffered = true;
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewManageCustomer;
        private System.Windows.Forms.Label labelCcaption;
        private System.Windows.Forms.Button buttonGetAllCus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGoBackC;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxcPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonSubmitCustomer;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUserType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
    }
}