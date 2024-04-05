using Newtonsoft.Json;
using RestSharp;
using ShopPro.BaseBackend.ApiModels;
using ShopPro.BaseBackend.Enums;
using ShopPro.BaseBackend.Models;
using ShopPro.BaseBackend.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopPro;

public partial class CustomerForm : Form
{
    public delegate void RefreshDataDelegate();
    public event RefreshDataDelegate RefreshDataEvent;
    Customer selectedCustomer;
    Address selectedAddress;
    public CustomerForm()
    {
        InitializeComponent();
        RefreshDataEvent += RefreshDate; //Delegate
        LoadFromData();
    }

    private void RefreshDate()
    {
        CustomerRepository repository = new CustomerRepository();
        List<Customer> customers = repository.GetAll();
        CustomerDataGridView.DataSource = null;
        CustomerDataGridView.DataSource = customers;
        CustomerDataGridView.Refresh();
        AddressRepository addressRepository = new AddressRepository();
        List<Address> addresses = addressRepository.GetAll();
        AddressDataGridView.DataSource = null;
        AddressDataGridView.DataSource = addresses;
        AddressDataGridView.Refresh();
        GenderComboBox.DataSource = Enum.GetValues(typeof(GenderEnum));

    }
    public void LoadFromData()
    {
        RefreshDate();
    }
    private bool ValidateCustomerData()
    {
        if (string.IsNullOrEmpty(NameTextBox.Text) ||
            string.IsNullOrEmpty(LastNameTextBox.Text) ||
            string.IsNullOrEmpty(UserNameTextBox.Text) ||
            string.IsNullOrEmpty(EmailTextBox.Text) ||
            string.IsNullOrEmpty(PasswordTextBox.Text) ||
            GenderComboBox.SelectedIndex == 0 ||
            string.IsNullOrEmpty(PhoneNumberTextBox.Text))
        {

            MessageBox.Show("Error: Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (NameTextBox.Text.Length < 2 || LastNameTextBox.Text.Length < 2 || UserNameTextBox.Text.Length < 2)
        {

            MessageBox.Show("Error: Name, Last Name, and Username must be at least 2 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (PasswordTextBox.Text.Length <= 7)
        {

            MessageBox.Show("Error: Password must be longer than 7 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (PhoneNumberTextBox.Text.Length != 11)
        {

            MessageBox.Show("Error: Phone number must have 11 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        try
        {
            var mailAddress = new System.Net.Mail.MailAddress(EmailTextBox.Text);
        }
        catch (FormatException)
        {

            MessageBox.Show("Error: Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }
    private async void SaveButton_Click(object sender, EventArgs e)
    {
        if (ValidateCustomerData())
        {
            var customer = new Customer()
            {
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text,
                UserName = UserNameTextBox.Text,
                Email = EmailTextBox.Text,
                Password = PasswordTextBox.Text,
                GenderId = (GenderEnum)GenderComboBox.SelectedIndex,
                Birthdate = BirthdateDateTimePicker.Value,
                PhoneNumber = PhoneNumberTextBox.Text,
                IsAdmin = IsAdminCheckBox.Checked,
                IsActive = IsActiveCheckBox.Checked,
            };
            CustomerRepository repository = new CustomerRepository();
            repository.Insert(customer);
            RefreshDataEvent?.Invoke();
            Clear();
        }
    }
    private void ResetButton_Click(object sender, EventArgs e)
    {
        Clear();
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {

        if (selectedCustomer is null)
        {
            MessageBox.Show("Please select an item in data grid view");
            return;
        }
        CustomerRepository repository = new CustomerRepository();
        selectedCustomer.Name = NameTextBox.Text;
        selectedCustomer.LastName = LastNameTextBox.Text;
        selectedCustomer.UserName = UserNameTextBox.Text;
        selectedCustomer.Email = EmailTextBox.Text;
        selectedCustomer.Password = PasswordTextBox.Text;
        selectedCustomer.Birthdate = BirthdateDateTimePicker.Value;
        selectedCustomer.GenderId = (GenderEnum)GenderComboBox.SelectedIndex;
        selectedCustomer.PhoneNumber = PhoneNumberTextBox.Text;
        selectedCustomer.IsActive = IsActiveCheckBox.Checked;
        selectedCustomer.IsAdmin = IsAdminCheckBox.Checked;
        repository.Update(selectedCustomer);
        RefreshDataEvent?.Invoke();
        Clear();
    }
    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (selectedCustomer is null)
        {
            MessageBox.Show("Please select an item in the customer data grid view");
            return;
        }

        CustomerRepository repository = new CustomerRepository();
        try
        {
            repository.Delete(id: selectedCustomer.Id);
            RefreshDataEvent?.Invoke();
            Clear();
        }
        catch (SqlException ex) when (ex.Number == 547)
        {
            Console.WriteLine("Foreign key constraint violation occurred.");
            MessageBox.Show("Sorry, We cannot delete this record as it may be referenced by OrderForm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (CustomerDataGridView.SelectedCells.Count > 0)
        {
            var selectedindex = CustomerDataGridView.SelectedCells[0].RowIndex;
            var row = CustomerDataGridView.Rows[selectedindex];
            int id = int.Parse(row.Cells["Id"].Value.ToString());
            CustomerRepository repository = new CustomerRepository();
            Customer customer = repository.GetById(id);
            NameTextBox.Text = customer.Name;
            LastNameTextBox.Text = customer.LastName;
            UserNameTextBox.Text = customer.UserName;
            EmailTextBox.Text = customer.Email;
            PasswordTextBox.Text = customer.Password;
            BirthdateDateTimePicker.Value = customer.Birthdate;
            GenderComboBox.Text = customer.GenderId.ToString();
            PhoneNumberTextBox.Text = customer.PhoneNumber;
            IsActiveCheckBox.Checked = customer.IsActive;
            IsAdminCheckBox.Checked = customer.IsAdmin;
            selectedCustomer = customer;
        }
    }
    private void Clear()
    {
        NameTextBox.Text = string.Empty;
        LastNameTextBox.Text = string.Empty;
        UserNameTextBox.Text = string.Empty;
        EmailTextBox.Text = string.Empty;
        PasswordTextBox.Text = string.Empty;
        PhoneNumberTextBox.Text = string.Empty;
        IsActiveCheckBox.Checked = false;
        IsAdminCheckBox.Checked = false;
    }
    private Stopwatch stopwatch;

    private async void CallServerButton_Click(object sender, EventArgs e)
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
        Timer.Start();

        var option = new RestClientOptions("https://reqres.in");
        var client = new RestClient(option);
        var Request = new RestRequest("/api/users?page=2", Method.Get);

        try
        {
            RestResponse response = await client.ExecuteAsync(Request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ReqresApiResponse result = JsonConvert.DeserializeObject<ReqresApiResponse>(response.Content);
                CustomerDataGridView.DataSource = null;
                CustomerDataGridView.DataSource = result.data;
                CustomerDataGridView.Refresh();
            }

            stopwatch.Stop();
            Timer.Stop();
            MessageBox.Show($"The result is {response.StatusCode.ToString()}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            // Handle and log the exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void Timer_Tick(object sender, EventArgs e)
    {
        TotalTimelabel.Text = "Total Time: " + stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.fff");
    }
    private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
            NameErrorLable.Text = "Error: Numbers are not allowed in the name";
            NameErrorLable.ForeColor = Color.Red;
            NameErrorLable.Visible = true;
        }
        else if (NameTextBox.Text.Length <= 2)
        {
            NameErrorLable.Text = "Error: Name must be at least two characters long";
            NameErrorLable.ForeColor = Color.Red;
            NameErrorLable.Visible = true;
        }
        else if (NameTextBox.Text.Length > 50 && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
            NameErrorLable.Text = "Error: Name cannot exceed 50 characters";
            NameErrorLable.ForeColor = Color.Red;
            NameErrorLable.Visible = true;
        }
        else
        {
            NameErrorLable.Visible = false;
        }
    }
    private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
            ErrorLastNameLable.Text = "Error: Numbers are not allowed in the Last name";
            ErrorLastNameLable.ForeColor = Color.Red;
            ErrorLastNameLable.Visible = true;
        }
        else if (LastNameTextBox.Text.Length <= 2)
        {
            ErrorLastNameLable.Text = "Error: Last Name must be at least two characters long";
            ErrorLastNameLable.ForeColor = Color.Red;
            ErrorLastNameLable.Visible = true;
        }
        else if (LastNameTextBox.Text.Length > 50 && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
            ErrorLastNameLable.Text = "Error: Last name cannot exceed 50 characters";
            ErrorLastNameLable.ForeColor = Color.Red;
            ErrorLastNameLable.Visible = true;
        }
        else
        {
            ErrorLastNameLable.Visible = false;
        }
    }

    private void UserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
            ErrorUserNameLabel.Text = "Error: Numbers are not allowed in the Last name";
            ErrorUserNameLabel.ForeColor = Color.Red;
            ErrorUserNameLabel.Visible = true;
        }
        else if (UserNameTextBox.Text.Length <= 2)
        {
            ErrorUserNameLabel.Text = "Error: Last Name must be at least two characters long";
            ErrorUserNameLabel.ForeColor = Color.Red;
            ErrorUserNameLabel.Visible = true;
        }
        else if (UserNameTextBox.Text.Length > 100 && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
            ErrorUserNameLabel.Text = "Error: Last name cannot exceed 50 characters";
            ErrorUserNameLabel.ForeColor = Color.Red;
            ErrorUserNameLabel.Visible = true;
        }
        else
        {
            ErrorUserNameLabel.Visible = false;
        }
    }
    private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        string email = EmailTextBox.Text;

        if (!IsValidEmail(email))
        {
            ErrorEmailLabel.Text = "Invalid email format";
            ErrorEmailLabel.ForeColor = Color.Red;
            ErrorEmailLabel.Visible = true;
            EmailTextBox.Focus();  // Prevent the focus from moving to a different control
        }
        else if (EmailTextBox.Text.Length > 300 && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
            ErrorEmailLabel.Text = "Error: Email address cannot exceed 300 characters";
            ErrorEmailLabel.ForeColor = Color.Red;
            ErrorEmailLabel.Visible = true;
        }
        else
        {
            e.Handled = false;
            ErrorEmailLabel.Visible = false;
        }
    }
    private bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        if (email.Length > 300)
        {
            return false;
        }


        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";


        if (Regex.IsMatch(email, emailPattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        string password = PasswordTextBox.Text + e.KeyChar;

        if (password.Length < 7)
        {
            ErrorPasswordLabel.ForeColor = Color.Red;
            ErrorPasswordLabel.Text = "Password must be at least eight characters long";
            ErrorPasswordLabel.Visible = true;
        }
        else if (!password.Any(char.IsDigit) || !password.Any(char.IsSymbol))
        {
            ErrorPasswordLabel.ForeColor = Color.Red;
            ErrorPasswordLabel.Text = "Password must contain at least one number and one symbol";
            ErrorPasswordLabel.Visible = true;
        }
        else
        {
            ErrorPasswordLabel.Visible = false;
        }
    }
    private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            ErrorPhonNumberLabel.ForeColor = Color.Red;
            ErrorPhonNumberLabel.Text = "You can't enter words in number text box";
            ErrorPhonNumberLabel.Visible = true;
            e.Handled = true;
        }
        else if (PhoneNumberTextBox.Text.Length >= 11 && !char.IsControl(e.KeyChar))
        {
            ErrorPhonNumberLabel.ForeColor = Color.Red;
            ErrorPhonNumberLabel.Text = "Phone number must be 11 character";
            ErrorPhonNumberLabel.Visible = true;
            e.Handled = true;
        }
        else
        {
            e.Handled = false;
            ErrorPhonNumberLabel.Visible = false;
        }
    }
    private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GenderComboBox.SelectedIndex == 0)
        {
            ErrorGenderComboBox.ForeColor = Color.Red;
            ErrorGenderComboBox.Text = "Please select a gender";
            ErrorGenderComboBox.Visible = true;
        }
        else
        {
            ErrorGenderComboBox.Visible = false;
        }
    }
    private void CheckedCheckBoxes()
    {
        if (IsAdminCheckBox.Checked)
        {
            ErrorIsAdminLable.Visible = false;
        }
        else
        {
            ErrorIsAdminLable.ForeColor = Color.Red;
            ErrorIsAdminLable.Text = "Please check the admin status";
            ErrorIsAdminLable.Visible = true;
        }
        if (IsActiveCheckBox.Checked)
        {
            ErrorIsActivelabel.Visible = false;
        }
        else
        {
            ErrorIsActivelabel.ForeColor = Color.Red;
            ErrorIsActivelabel.Text = "Please check the admin status";
            ErrorIsActivelabel.Visible = true;
        }
    }

    private void homeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        HomeForm homeForm = new HomeForm();
        homeForm.Show();
        this.Close();
    }
    private void productToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProductForm productForm = new ProductForm();
        productForm.Show();
        this.Close();
    }
    private void orderToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OrderForm orderForm = new OrderForm();
        orderForm.Show();
        this.Close();
    }
    private void addressToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AddressForm addressForm = new AddressForm();
        addressForm.Show();
    }


}

