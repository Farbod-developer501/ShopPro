namespace ShopPro
{
    partial class ProductForm
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
            SpecificationTextBox = new TextBox();
            NameTextBox = new TextBox();
            ProductDataGridView = new DataGridView();
            label1 = new Label();
            SaveButton = new Button();
            label2 = new Label();
            PriceTextBox = new TextBox();
            BrandTextBox = new TextBox();
            label3 = new Label();
            ErrorBrandLabel = new Label();
            label6 = new Label();
            IsActiveRadioButton = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            ProductPictureBox = new PictureBox();
            ResetButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            CountTextBox = new TextBox();
            label5 = new Label();
            ErrorNamelabel = new Label();
            ErrorPricelabel = new Label();
            label9 = new Label();
            ErrorCountlabel = new Label();
            ErrorSpeceficationlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // SpecificationTextBox
            // 
            SpecificationTextBox.Location = new Point(108, 334);
            SpecificationTextBox.Multiline = true;
            SpecificationTextBox.Name = "SpecificationTextBox";
            SpecificationTextBox.Size = new Size(637, 69);
            SpecificationTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(108, 79);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(630, 27);
            NameTextBox.TabIndex = 1;
            NameTextBox.KeyPress += NameTextBox_KeyPress;
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.BackgroundColor = Color.White;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.GridColor = Color.Black;
            ProductDataGridView.Location = new Point(12, 436);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.Size = new Size(853, 268);
            ProductDataGridView.TabIndex = 2;
            ProductDataGridView.CellClick += ProductDataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 79);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(871, 489);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(138, 40);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 353);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Specificaion";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(108, 142);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(630, 27);
            PriceTextBox.TabIndex = 6;
            PriceTextBox.KeyPress += PriceTextBox_KeyPress;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(108, 202);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(630, 27);
            BrandTextBox.TabIndex = 7;
            BrandTextBox.KeyPress += BrandTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 142);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // ErrorBrandLabel
            // 
            ErrorBrandLabel.AutoSize = true;
            ErrorBrandLabel.Location = new Point(117, 239);
            ErrorBrandLabel.Name = "ErrorBrandLabel";
            ErrorBrandLabel.Size = new Size(0, 20);
            ErrorBrandLabel.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(853, 56);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 3;
            label6.Text = "Image";
            // 
            // IsActiveRadioButton
            // 
            IsActiveRadioButton.AutoSize = true;
            IsActiveRadioButton.Location = new Point(784, 406);
            IsActiveRadioButton.Name = "IsActiveRadioButton";
            IsActiveRadioButton.Size = new Size(81, 24);
            IsActiveRadioButton.TabIndex = 9;
            IsActiveRadioButton.TabStop = true;
            IsActiveRadioButton.Text = "IsActive";
            IsActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.BackColor = Color.Silver;
            ProductPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            ProductPictureBox.Location = new Point(744, 79);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(265, 321);
            ProductPictureBox.TabIndex = 10;
            ProductPictureBox.TabStop = false;
            ProductPictureBox.Click += ProductPictureBox_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(871, 535);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(138, 42);
            ResetButton.TabIndex = 11;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(871, 583);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(138, 42);
            UpdateButton.TabIndex = 12;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(871, 631);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(138, 46);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, customerToolStripMenuItem, orderToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1021, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // CountTextBox
            // 
            CountTextBox.Location = new Point(108, 262);
            CountTextBox.Name = "CountTextBox";
            CountTextBox.Size = new Size(630, 27);
            CountTextBox.TabIndex = 15;
            CountTextBox.KeyPress += CountTextBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 262);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 3;
            label5.Text = "Count";
            // 
            // ErrorNamelabel
            // 
            ErrorNamelabel.AutoSize = true;
            ErrorNamelabel.Location = new Point(117, 109);
            ErrorNamelabel.Name = "ErrorNamelabel";
            ErrorNamelabel.Size = new Size(0, 20);
            ErrorNamelabel.TabIndex = 3;
            // 
            // ErrorPricelabel
            // 
            ErrorPricelabel.AutoSize = true;
            ErrorPricelabel.Location = new Point(117, 165);
            ErrorPricelabel.Name = "ErrorPricelabel";
            ErrorPricelabel.Size = new Size(0, 20);
            ErrorPricelabel.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 209);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 3;
            label9.Text = "Brand";
            // 
            // ErrorCountlabel
            // 
            ErrorCountlabel.AutoSize = true;
            ErrorCountlabel.Location = new Point(108, 298);
            ErrorCountlabel.Name = "ErrorCountlabel";
            ErrorCountlabel.Size = new Size(0, 20);
            ErrorCountlabel.TabIndex = 3;
            // 
            // ErrorSpeceficationlabel
            // 
            ErrorSpeceficationlabel.AutoSize = true;
            ErrorSpeceficationlabel.Location = new Point(108, 406);
            ErrorSpeceficationlabel.Name = "ErrorSpeceficationlabel";
            ErrorSpeceficationlabel.Size = new Size(0, 20);
            ErrorSpeceficationlabel.TabIndex = 3;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 716);
            Controls.Add(CountTextBox);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(ResetButton);
            Controls.Add(ProductPictureBox);
            Controls.Add(IsActiveRadioButton);
            Controls.Add(BrandTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(SaveButton);
            Controls.Add(label6);
            Controls.Add(ErrorCountlabel);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(ErrorBrandLabel);
            Controls.Add(ErrorPricelabel);
            Controls.Add(label3);
            Controls.Add(ErrorSpeceficationlabel);
            Controls.Add(label2);
            Controls.Add(ErrorNamelabel);
            Controls.Add(label1);
            Controls.Add(ProductDataGridView);
            Controls.Add(NameTextBox);
            Controls.Add(SpecificationTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SpecificationTextBox;
        private TextBox NameTextBox;
        private DataGridView ProductDataGridView;
        private Label label1;
        private Button SaveButton;
        private Label label2;
        private TextBox PriceTextBox;
        private TextBox BrandTextBox;
        private Label label3;
        private Label ErrorBrandLabel;
        private Label label6;
        private RadioButton IsActiveRadioButton;
        private OpenFileDialog openFileDialog1;
        private PictureBox ProductPictureBox;
        private Button ResetButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private TextBox CountTextBox;
        private Label label5;
        private Label ErrorNamelabel;
        private Label ErrorPricelabel;
        private Label label9;
        private Label ErrorCountlabel;
        private Label ErrorSpeceficationlabel;
    }
}