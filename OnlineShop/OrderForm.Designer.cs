namespace ShopPro
{
    partial class OrderForm
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            addressToolStripMenuItem = new ToolStripMenuItem();
            OrderDataGridView = new DataGridView();
            CustomerDataGridView = new DataGridView();
            ProductDataGridView = new DataGridView();
            OrderDescriptionTextBox = new TextBox();
            AddressDescriptionTextBox = new TextBox();
            label1 = new Label();
            SaveButton = new Button();
            Order = new Label();
            UserComboBox = new Label();
            AddressDataGridView = new DataGridView();
            ResetButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IsActiveRadioButton = new RadioButton();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, productToolStripMenuItem, customerToolStripMenuItem, addressToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1607, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // addressToolStripMenuItem
            // 
            addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            addressToolStripMenuItem.Size = new Size(76, 24);
            addressToolStripMenuItem.Text = "Address";
            addressToolStripMenuItem.Click += addressToolStripMenuItem_Click;
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Location = new Point(12, 436);
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.RowHeadersWidth = 51;
            OrderDataGridView.Size = new Size(730, 188);
            OrderDataGridView.TabIndex = 1;
            OrderDataGridView.CellClick += OrderDataGridView_CellClick;
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(936, 436);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowHeadersWidth = 51;
            CustomerDataGridView.Size = new Size(659, 188);
            CustomerDataGridView.TabIndex = 2;
            CustomerDataGridView.CellClick += CustomerDataGridView_CellClick;
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Location = new Point(936, 222);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.Size = new Size(659, 188);
            ProductDataGridView.TabIndex = 3;
            ProductDataGridView.CellClick += ProductDataGridView_CellClick;
            // 
            // OrderDescriptionTextBox
            // 
            OrderDescriptionTextBox.Location = new Point(182, 103);
            OrderDescriptionTextBox.Multiline = true;
            OrderDescriptionTextBox.Name = "OrderDescriptionTextBox";
            OrderDescriptionTextBox.Size = new Size(355, 52);
            OrderDescriptionTextBox.TabIndex = 4;
            // 
            // AddressDescriptionTextBox
            // 
            AddressDescriptionTextBox.Location = new Point(182, 41);
            AddressDescriptionTextBox.Multiline = true;
            AddressDescriptionTextBox.Name = "AddressDescriptionTextBox";
            AddressDescriptionTextBox.Size = new Size(355, 56);
            AddressDescriptionTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 44);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 6;
            label1.Text = "Address description";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(748, 412);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(182, 48);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Order
            // 
            Order.AutoSize = true;
            Order.Location = new Point(35, 119);
            Order.Name = "Order";
            Order.Size = new Size(125, 20);
            Order.TabIndex = 6;
            Order.Text = "Order description";
            // 
            // UserComboBox
            // 
            UserComboBox.AutoSize = true;
            UserComboBox.Location = new Point(263, 199);
            UserComboBox.Name = "UserComboBox";
            UserComboBox.Size = new Size(161, 20);
            UserComboBox.TabIndex = 6;
            UserComboBox.Text = "Address data grid view";
            // 
            // AddressDataGridView
            // 
            AddressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddressDataGridView.Location = new Point(12, 222);
            AddressDataGridView.Name = "AddressDataGridView";
            AddressDataGridView.RowHeadersWidth = 51;
            AddressDataGridView.Size = new Size(730, 188);
            AddressDataGridView.TabIndex = 13;
            AddressDataGridView.CellClick += AddressDataGridView_CellClick;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(748, 466);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(182, 45);
            ResetButton.TabIndex = 14;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(748, 517);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(182, 43);
            UpdateButton.TabIndex = 15;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(748, 566);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(182, 58);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 412);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 6;
            label3.Text = "Order data grid view";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1249, 413);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 6;
            label4.Text = "Customer data grid view";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1249, 199);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 6;
            label5.Text = "Product data grid view";
            // 
            // IsActiveRadioButton
            // 
            IsActiveRadioButton.AutoSize = true;
            IsActiveRadioButton.Location = new Point(543, 131);
            IsActiveRadioButton.Name = "IsActiveRadioButton";
            IsActiveRadioButton.Size = new Size(83, 24);
            IsActiveRadioButton.TabIndex = 17;
            IsActiveRadioButton.TabStop = true;
            IsActiveRadioButton.Text = "Is active";
            IsActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 636);
            Controls.Add(IsActiveRadioButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(ResetButton);
            Controls.Add(AddressDataGridView);
            Controls.Add(SaveButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(UserComboBox);
            Controls.Add(Order);
            Controls.Add(label1);
            Controls.Add(AddressDescriptionTextBox);
            Controls.Add(OrderDescriptionTextBox);
            Controls.Add(ProductDataGridView);
            Controls.Add(CustomerDataGridView);
            Controls.Add(OrderDataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "OrderForm";
            Text = "OrderForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private DataGridView OrderDataGridView;
        private DataGridView CustomerDataGridView;
        private DataGridView ProductDataGridView;
        private TextBox OrderDescriptionTextBox;
        private TextBox AddressDescriptionTextBox;
        private Label label1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button SaveButton;
        private Label Order;
        private Label UserComboBox;
        private DataGridView AddressDataGridView;
        private Button ResetButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private ToolStripMenuItem addressToolStripMenuItem;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton IsActiveRadioButton;
    }
}