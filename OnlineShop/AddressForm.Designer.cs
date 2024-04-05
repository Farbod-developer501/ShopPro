namespace ShopPro
{
    partial class AddressForm
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
            CountryTextBox = new TextBox();
            PostalCodeTextBox = new TextBox();
            StateTextBox = new TextBox();
            CountryCodeTextBox = new TextBox();
            StreetLineTextBox = new TextBox();
            CityTextBox = new TextBox();
            StreetTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            AddressDataGridView = new DataGridView();
            ErrorCountrylabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            SaveButton = new Button();
            ResetButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            IsActiveCheckBox = new CheckBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            TotoalTimeLabel = new Label();
            CustomerDataGridView = new DataGridView();
            ErrorAddressDataGridVeiw = new Label();
            label10 = new Label();
            label11 = new Label();
            ErrorCountryCodelabel = new Label();
            ErrorPostalCodelabel = new Label();
            ErrorCitylabel = new Label();
            ErrorStatelabel = new Label();
            label16 = new Label();
            ErrorStreetLinelabel = new Label();
            ErrorStreetlabel = new Label();
            ErrorDescriptionlabel = new Label();
            label20 = new Label();
            ErrorCustomerDataGridView = new Label();
            ((System.ComponentModel.ISupportInitialize)AddressDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(103, 62);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(413, 27);
            CountryTextBox.TabIndex = 0;
            CountryTextBox.KeyPress += CountryTextBox_KeyPress;
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Location = new Point(103, 176);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(413, 27);
            PostalCodeTextBox.TabIndex = 1;
            PostalCodeTextBox.KeyPress += PostalCodeTextBox_KeyPress;
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(103, 297);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(414, 27);
            StateTextBox.TabIndex = 2;
            StateTextBox.KeyPress += StateTextBox_KeyPress;
            // 
            // CountryCodeTextBox
            // 
            CountryCodeTextBox.Location = new Point(103, 121);
            CountryCodeTextBox.Name = "CountryCodeTextBox";
            CountryCodeTextBox.Size = new Size(413, 27);
            CountryCodeTextBox.TabIndex = 3;
            CountryCodeTextBox.KeyPress += CountryCodeTextBox_KeyPress;
            // 
            // StreetLineTextBox
            // 
            StreetLineTextBox.Location = new Point(621, 121);
            StreetLineTextBox.Name = "StreetLineTextBox";
            StreetLineTextBox.Size = new Size(349, 27);
            StreetLineTextBox.TabIndex = 4;
            StreetLineTextBox.KeyPress += StreetLineTextBox_KeyPress;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(103, 238);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(414, 27);
            CityTextBox.TabIndex = 5;
            CityTextBox.KeyPress += CityTextBox_KeyPress;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(621, 55);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(349, 27);
            StreetTextBox.TabIndex = 6;
            StreetTextBox.KeyPress += StreetTextBox_KeyPress;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(621, 176);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(473, 72);
            DescriptionTextBox.TabIndex = 7;
            // 
            // AddressDataGridView
            // 
            AddressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddressDataGridView.Location = new Point(12, 446);
            AddressDataGridView.Name = "AddressDataGridView";
            AddressDataGridView.RowHeadersWidth = 51;
            AddressDataGridView.Size = new Size(914, 188);
            AddressDataGridView.TabIndex = 9;
            AddressDataGridView.CellClick += AddressDataGridView_CellClick;
            // 
            // ErrorCountrylabel
            // 
            ErrorCountrylabel.AutoSize = true;
            ErrorCountrylabel.Location = new Point(103, 92);
            ErrorCountrylabel.Name = "ErrorCountrylabel";
            ErrorCountrylabel.Size = new Size(0, 20);
            ErrorCountrylabel.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 128);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 10;
            label2.Text = "CountryCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 10;
            label3.Text = "PostalCode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 245);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 10;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 637);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 10;
            label5.Text = "Customer data grid view";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 58);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 10;
            label8.Text = "Street";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(530, 208);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 10;
            label9.Text = "Description";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(932, 606);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(174, 40);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(932, 771);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(174, 38);
            ResetButton.TabIndex = 12;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(932, 661);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(174, 39);
            UpdateButton.TabIndex = 13;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(932, 718);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(174, 38);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // IsActiveCheckBox
            // 
            IsActiveCheckBox.AutoSize = true;
            IsActiveCheckBox.Location = new Point(809, 646);
            IsActiveCheckBox.Name = "IsActiveCheckBox";
            IsActiveCheckBox.Size = new Size(82, 24);
            IsActiveCheckBox.TabIndex = 15;
            IsActiveCheckBox.Text = "IsActive";
            IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, productToolStripMenuItem, orderToolStripMenuItem, customerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1106, 28);
            menuStrip1.TabIndex = 16;
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
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 128);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "StreetLine";
            // 
            // TotoalTimeLabel
            // 
            TotoalTimeLabel.AutoSize = true;
            TotoalTimeLabel.BorderStyle = BorderStyle.Fixed3D;
            TotoalTimeLabel.Location = new Point(845, 411);
            TotoalTimeLabel.Name = "TotoalTimeLabel";
            TotoalTimeLabel.Size = new Size(81, 22);
            TotoalTimeLabel.TabIndex = 10;
            TotoalTimeLabel.Text = "Total time:";
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(12, 692);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowHeadersWidth = 51;
            CustomerDataGridView.Size = new Size(914, 188);
            CustomerDataGridView.TabIndex = 17;
            CustomerDataGridView.CellClick += CustomerDataGridView_CellClick;
            // 
            // ErrorAddressDataGridVeiw
            // 
            ErrorAddressDataGridVeiw.AutoSize = true;
            ErrorAddressDataGridVeiw.Location = new Point(337, 423);
            ErrorAddressDataGridVeiw.Name = "ErrorAddressDataGridVeiw";
            ErrorAddressDataGridVeiw.Size = new Size(0, 20);
            ErrorAddressDataGridVeiw.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 304);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 10;
            label10.Text = "State";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 65);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 10;
            label11.Text = "Country";
            // 
            // ErrorCountryCodelabel
            // 
            ErrorCountryCodelabel.AutoSize = true;
            ErrorCountryCodelabel.Location = new Point(103, 151);
            ErrorCountryCodelabel.Name = "ErrorCountryCodelabel";
            ErrorCountryCodelabel.Size = new Size(0, 20);
            ErrorCountryCodelabel.TabIndex = 10;
            // 
            // ErrorPostalCodelabel
            // 
            ErrorPostalCodelabel.AutoSize = true;
            ErrorPostalCodelabel.Location = new Point(103, 215);
            ErrorPostalCodelabel.Name = "ErrorPostalCodelabel";
            ErrorPostalCodelabel.Size = new Size(0, 20);
            ErrorPostalCodelabel.TabIndex = 10;
            // 
            // ErrorCitylabel
            // 
            ErrorCitylabel.AutoSize = true;
            ErrorCitylabel.Location = new Point(103, 268);
            ErrorCitylabel.Name = "ErrorCitylabel";
            ErrorCitylabel.Size = new Size(0, 20);
            ErrorCitylabel.TabIndex = 10;
            // 
            // ErrorStatelabel
            // 
            ErrorStatelabel.AutoSize = true;
            ErrorStatelabel.Location = new Point(103, 327);
            ErrorStatelabel.Name = "ErrorStatelabel";
            ErrorStatelabel.Size = new Size(0, 20);
            ErrorStatelabel.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(621, 92);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 10;
            // 
            // ErrorStreetLinelabel
            // 
            ErrorStreetLinelabel.AutoSize = true;
            ErrorStreetLinelabel.Location = new Point(621, 151);
            ErrorStreetLinelabel.Name = "ErrorStreetLinelabel";
            ErrorStreetLinelabel.Size = new Size(0, 20);
            ErrorStreetLinelabel.TabIndex = 10;
            // 
            // ErrorStreetlabel
            // 
            ErrorStreetlabel.AutoSize = true;
            ErrorStreetlabel.Location = new Point(621, 92);
            ErrorStreetlabel.Name = "ErrorStreetlabel";
            ErrorStreetlabel.Size = new Size(0, 20);
            ErrorStreetlabel.TabIndex = 10;
            // 
            // ErrorDescriptionlabel
            // 
            ErrorDescriptionlabel.AutoSize = true;
            ErrorDescriptionlabel.Location = new Point(621, 251);
            ErrorDescriptionlabel.Name = "ErrorDescriptionlabel";
            ErrorDescriptionlabel.Size = new Size(0, 20);
            ErrorDescriptionlabel.TabIndex = 10;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(355, 381);
            label20.Name = "label20";
            label20.Size = new Size(161, 20);
            label20.TabIndex = 10;
            label20.Text = "Address data grid view";
            // 
            // ErrorCustomerDataGridView
            // 
            ErrorCustomerDataGridView.AutoSize = true;
            ErrorCustomerDataGridView.Location = new Point(346, 670);
            ErrorCustomerDataGridView.Name = "ErrorCustomerDataGridView";
            ErrorCustomerDataGridView.Size = new Size(0, 20);
            ErrorCustomerDataGridView.TabIndex = 10;
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 892);
            Controls.Add(CustomerDataGridView);
            Controls.Add(IsActiveCheckBox);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(ResetButton);
            Controls.Add(SaveButton);
            Controls.Add(ErrorDescriptionlabel);
            Controls.Add(label9);
            Controls.Add(ErrorStreetlabel);
            Controls.Add(label16);
            Controls.Add(ErrorStreetLinelabel);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(TotoalTimeLabel);
            Controls.Add(ErrorCustomerDataGridView);
            Controls.Add(label5);
            Controls.Add(ErrorStatelabel);
            Controls.Add(label10);
            Controls.Add(label20);
            Controls.Add(ErrorAddressDataGridVeiw);
            Controls.Add(ErrorCitylabel);
            Controls.Add(label4);
            Controls.Add(ErrorPostalCodelabel);
            Controls.Add(label3);
            Controls.Add(ErrorCountryCodelabel);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(ErrorCountrylabel);
            Controls.Add(AddressDataGridView);
            Controls.Add(DescriptionTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(StreetLineTextBox);
            Controls.Add(CountryCodeTextBox);
            Controls.Add(StateTextBox);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AddressForm";
            Text = "AddressForm";
            Load += AddressForm_Load;
            ((System.ComponentModel.ISupportInitialize)AddressDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CountryTextBox;
        private TextBox PostalCodeTextBox;
        private TextBox StateTextBox;
        private TextBox CountryCodeTextBox;
        private TextBox StreetLineTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox DescriptionTextBox;
        private DataGridView AddressDataGridView;
        private Label ErrorCountrylabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Button SaveButton;
        private Button ResetButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private CheckBox IsActiveCheckBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private Label label6;
        private Label TotoalTimeLabel;
        private DataGridView CustomerDataGridView;
        private Label ErrorAddressDataGridVeiw;
        private Label label10;
        private Label label11;
        private Label ErrorCountryCodelabel;
        private Label ErrorPostalCodelabel;
        private Label ErrorCitylabel;
        private Label ErrorStatelabel;
        private Label label16;
        private Label ErrorStreetLinelabel;
        private Label ErrorStreetlabel;
        private Label ErrorDescriptionlabel;
        private Label label20;
        private Label ErrorCustomerDataGridView;
    }
}