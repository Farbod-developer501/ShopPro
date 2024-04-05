namespace ShopPro
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            NameTextBox = new TextBox();
            label1 = new Label();
            SaveButton = new Button();
            ResetButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            CustomerDataGridView = new DataGridView();
            ErrorLastNameLable = new Label();
            label3 = new Label();
            ErrorEmailLabel = new Label();
            ErrorPhonNumberLabel = new Label();
            ErrorPasswordLabel = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            addressToolStripMenuItem = new ToolStripMenuItem();
            PhoneNumberTextBox = new TextBox();
            IsActiveCheckBox = new CheckBox();
            IsAdminCheckBox = new CheckBox();
            AddressDataGridView = new DataGridView();
            TotalTimelabel = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            CallServerButton = new Button();
            GenderComboBox = new ComboBox();
            ErrorGenderComboBox = new Label();
            label4 = new Label();
            BirthdateDateTimePicker = new DateTimePicker();
            label7 = new Label();
            NameErrorLable = new Label();
            label8 = new Label();
            ErrorUserNameLabel = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ErrorIsActivelabel = new Label();
            ErrorIsAdminLable = new Label();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddressDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(114, 267);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(694, 27);
            PasswordTextBox.TabIndex = 0;
            PasswordTextBox.KeyPress += PasswordTextBox_KeyPress;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(114, 215);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(694, 27);
            EmailTextBox.TabIndex = 1;
            EmailTextBox.KeyPress += EmailTextBox_KeyPress;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(114, 161);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(694, 27);
            UserNameTextBox.TabIndex = 2;
            UserNameTextBox.KeyPress += UserNameTextBox_KeyPress;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(114, 105);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(694, 27);
            LastNameTextBox.TabIndex = 3;
            LastNameTextBox.KeyPress += LastNameTextBox_KeyPress;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(114, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(694, 27);
            NameTextBox.TabIndex = 4;
            NameTextBox.KeyPress += NameTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 47);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(183, 489);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(149, 38);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(183, 545);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(149, 44);
            ResetButton.TabIndex = 7;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(16, 489);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(149, 41);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(16, 542);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(149, 47);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(858, 401);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowHeadersWidth = 51;
            CustomerDataGridView.Size = new Size(745, 188);
            CustomerDataGridView.TabIndex = 10;
            CustomerDataGridView.CellClick += CustomerDataGridView_CellClick;
            // 
            // ErrorLastNameLable
            // 
            ErrorLastNameLable.AutoSize = true;
            ErrorLastNameLable.Location = new Point(140, 135);
            ErrorLastNameLable.Name = "ErrorLastNameLable";
            ErrorLastNameLable.Size = new Size(0, 20);
            ErrorLastNameLable.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 164);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "User name";
            // 
            // ErrorEmailLabel
            // 
            ErrorEmailLabel.AutoSize = true;
            ErrorEmailLabel.Location = new Point(119, 245);
            ErrorEmailLabel.Name = "ErrorEmailLabel";
            ErrorEmailLabel.Size = new Size(0, 20);
            ErrorEmailLabel.TabIndex = 5;
            // 
            // ErrorPhonNumberLabel
            // 
            ErrorPhonNumberLabel.AutoSize = true;
            ErrorPhonNumberLabel.Location = new Point(119, 352);
            ErrorPhonNumberLabel.Name = "ErrorPhonNumberLabel";
            ErrorPhonNumberLabel.Size = new Size(0, 20);
            ErrorPhonNumberLabel.TabIndex = 5;
            // 
            // ErrorPasswordLabel
            // 
            ErrorPasswordLabel.AutoSize = true;
            ErrorPasswordLabel.Location = new Point(126, 299);
            ErrorPasswordLabel.Name = "ErrorPasswordLabel";
            ErrorPasswordLabel.Size = new Size(0, 20);
            ErrorPasswordLabel.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, productToolStripMenuItem, orderToolStripMenuItem, addressToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1611, 28);
            menuStrip1.TabIndex = 13;
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
            // addressToolStripMenuItem
            // 
            addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            addressToolStripMenuItem.Size = new Size(76, 24);
            addressToolStripMenuItem.Text = "Address";
            addressToolStripMenuItem.Click += addressToolStripMenuItem_Click;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(114, 322);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(694, 27);
            PhoneNumberTextBox.TabIndex = 12;
            PhoneNumberTextBox.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // IsActiveCheckBox
            // 
            IsActiveCheckBox.AutoSize = true;
            IsActiveCheckBox.Location = new Point(375, 497);
            IsActiveCheckBox.Name = "IsActiveCheckBox";
            IsActiveCheckBox.Size = new Size(82, 24);
            IsActiveCheckBox.TabIndex = 15;
            IsActiveCheckBox.Text = "IsActive";
            IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsAdminCheckBox
            // 
            IsAdminCheckBox.AutoSize = true;
            IsAdminCheckBox.Location = new Point(375, 524);
            IsAdminCheckBox.Name = "IsAdminCheckBox";
            IsAdminCheckBox.Size = new Size(87, 24);
            IsAdminCheckBox.TabIndex = 16;
            IsAdminCheckBox.Text = "Is admin";
            IsAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddressDataGridView
            // 
            AddressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddressDataGridView.Location = new Point(858, 161);
            AddressDataGridView.Name = "AddressDataGridView";
            AddressDataGridView.RowHeadersWidth = 51;
            AddressDataGridView.Size = new Size(745, 188);
            AddressDataGridView.TabIndex = 17;
            // 
            // TotalTimelabel
            // 
            TotalTimelabel.AutoSize = true;
            TotalTimelabel.Location = new Point(395, 452);
            TotalTimelabel.Name = "TotalTimelabel";
            TotalTimelabel.Size = new Size(82, 20);
            TotalTimelabel.TabIndex = 19;
            TotalTimelabel.Text = "Total Time:";
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1145, 122);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 20;
            label2.Text = "Address data grid view";
            // 
            // CallServerButton
            // 
            CallServerButton.Location = new Point(96, 595);
            CallServerButton.Name = "CallServerButton";
            CallServerButton.Size = new Size(149, 45);
            CallServerButton.TabIndex = 21;
            CallServerButton.Text = "Call server";
            CallServerButton.UseVisualStyleBackColor = true;
            CallServerButton.Click += CallServerButton_Click;
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(114, 401);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(203, 28);
            GenderComboBox.TabIndex = 22;
            GenderComboBox.SelectedIndexChanged += GenderComboBox_SelectedIndexChanged;
            // 
            // ErrorGenderComboBox
            // 
            ErrorGenderComboBox.AutoSize = true;
            ErrorGenderComboBox.Location = new Point(333, 404);
            ErrorGenderComboBox.Name = "ErrorGenderComboBox";
            ErrorGenderComboBox.Size = new Size(0, 20);
            ErrorGenderComboBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1135, 368);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 20;
            label4.Text = "Customer data grid view";
            // 
            // BirthdateDateTimePicker
            // 
            BirthdateDateTimePicker.Location = new Point(114, 445);
            BirthdateDateTimePicker.Name = "BirthdateDateTimePicker";
            BirthdateDateTimePicker.Size = new Size(250, 27);
            BirthdateDateTimePicker.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 452);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 5;
            label7.Text = "Birthdate";
            // 
            // NameErrorLable
            // 
            NameErrorLable.AutoSize = true;
            NameErrorLable.ForeColor = Color.White;
            NameErrorLable.Location = new Point(165, 74);
            NameErrorLable.Name = "NameErrorLable";
            NameErrorLable.Size = new Size(0, 20);
            NameErrorLable.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 112);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 5;
            label8.Text = "Last name";
            // 
            // ErrorUserNameLabel
            // 
            ErrorUserNameLabel.AutoSize = true;
            ErrorUserNameLabel.Location = new Point(126, 192);
            ErrorUserNameLabel.Name = "ErrorUserNameLabel";
            ErrorUserNameLabel.Size = new Size(0, 20);
            ErrorUserNameLabel.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 270);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 5;
            label9.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 222);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 5;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 325);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 5;
            label11.Text = "Phone number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 409);
            label12.Name = "label12";
            label12.Size = new Size(57, 20);
            label12.TabIndex = 5;
            label12.Text = "Gender";
            // 
            // ErrorIsActivelabel
            // 
            ErrorIsActivelabel.AutoSize = true;
            ErrorIsActivelabel.Location = new Point(478, 498);
            ErrorIsActivelabel.Name = "ErrorIsActivelabel";
            ErrorIsActivelabel.Size = new Size(0, 20);
            ErrorIsActivelabel.TabIndex = 5;
            // 
            // ErrorIsAdminLable
            // 
            ErrorIsAdminLable.AutoSize = true;
            ErrorIsAdminLable.Location = new Point(478, 528);
            ErrorIsAdminLable.Name = "ErrorIsAdminLable";
            ErrorIsAdminLable.Size = new Size(0, 20);
            ErrorIsAdminLable.TabIndex = 5;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 653);
            Controls.Add(NameErrorLable);
            Controls.Add(BirthdateDateTimePicker);
            Controls.Add(GenderComboBox);
            Controls.Add(CallServerButton);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(TotalTimelabel);
            Controls.Add(AddressDataGridView);
            Controls.Add(IsAdminCheckBox);
            Controls.Add(IsActiveCheckBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(CustomerDataGridView);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(ResetButton);
            Controls.Add(SaveButton);
            Controls.Add(ErrorPasswordLabel);
            Controls.Add(label7);
            Controls.Add(ErrorIsAdminLable);
            Controls.Add(ErrorIsActivelabel);
            Controls.Add(label12);
            Controls.Add(ErrorGenderComboBox);
            Controls.Add(label11);
            Controls.Add(ErrorPhonNumberLabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(ErrorEmailLabel);
            Controls.Add(ErrorUserNameLabel);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(ErrorLastNameLable);
            Controls.Add(label1);
            Controls.Add(NameTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CustomerForm";
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddressDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private TextBox UserNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox NameTextBox;
        private Label label1;
        private Button SaveButton;
        private Button ResetButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private DataGridView CustomerDataGridView;
        private Label ErrorLastNameLable;
        private Label label3;
        private Label ErrorEmailLabel;
        private Label label5;
        private Label ErrorPasswordLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private TextBox PhoneNumberTextBox;
        private CheckBox IsActiveCheckBox;
        private CheckBox IsAdminCheckBox;
        private DataGridView AddressDataGridView;
        private Label TotalTimelabel;
        private System.Windows.Forms.Timer Timer;
        private Label label2;
        private Button CallServerButton;
        private ComboBox GenderComboBox;
        private Label ErrorGenderComboBox;
        private Label label4;
        private DateTimePicker BirthdateDateTimePicker;
        private Label label7;
        private ToolStripMenuItem addressToolStripMenuItem;
        private Label NameErrorLable;
        private Label label8;
        private Label ErrorUserNameLabel;
        private Label label9;
        private Label label10;
        private Label ErrorPhonNumberLabel;
        private Label label11;
        private Label label12;
        private Label ErrorIsActivelabel;
        private Label ErrorIsAdminLable;
    }
}