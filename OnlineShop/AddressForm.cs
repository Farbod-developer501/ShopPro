using ShopPro.BaseBackend.Models;
using ShopPro.BaseBackend.Repositories;
using System.Data.SqlClient;


namespace ShopPro;

public partial class AddressForm : Form
{
    public delegate void RefreshDataDelegate();
    public event RefreshDataDelegate RefreshdataEvent;
    Address selectedAddress;
    Customer selectedCustomer;
    public AddressForm()
    {
        InitializeComponent();
        RefreshdataEvent += RefreshData;
        LoadFromData();
    }
    private void RefreshData()
    {
        AddressRepository repository = new AddressRepository();
        List<Address> addresses = repository.GetAll();
        AddressDataGridView.DataSource = null;
        AddressDataGridView.DataSource = addresses;
        AddressDataGridView.Refresh();
        CustomerRepository customerRepository = new CustomerRepository();
        List<Customer> customers = customerRepository.GetAll();
        CustomerDataGridView.DataSource = null;
        CustomerDataGridView.DataSource = customers;
        CustomerDataGridView.Refresh();
    }
    private void LoadFromData()
    {
        RefreshData();
    }
    private bool ValidateAddressData()
    {
        if (string.IsNullOrEmpty(CountryTextBox.Text) ||
            string.IsNullOrEmpty(CountryCodeTextBox.Text) ||
            string.IsNullOrEmpty(DescriptionTextBox.Text) ||
            string.IsNullOrEmpty(CityTextBox.Text) ||
            string.IsNullOrEmpty(PostalCodeTextBox.Text) ||
            string.IsNullOrEmpty(StreetLineTextBox.Text) ||
            string.IsNullOrEmpty(StreetTextBox.Text) ||
            string.IsNullOrEmpty(StateTextBox.Text))
        {

            MessageBox.Show("Error: Please fill in all required address fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        short postalCode;
        if (!short.TryParse(PostalCodeTextBox.Text, out postalCode))
        {

            MessageBox.Show("Error: Postal code must be a valid 3-character numeric value. and less than 250 value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (selectedCustomer.Id == 0 )
        {
            MessageBox.Show("Error: Postal code must be a valid 3-character numeric value. and less than 250 value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        short streetLine;
        if (!short.TryParse(StreetLineTextBox.Text, out streetLine))
        {

            MessageBox.Show("Error: Street line must be a valid numeric value. and less than 250 value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }
    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (ValidateAddressData())
        {
            Address address = new Address()
            {
                Country = CountryTextBox.Text,
                CountryCode = CountryCodeTextBox.Text,
                Description = DescriptionTextBox.Text,
                City = CityTextBox.Text,
                PostalCode = short.Parse(PostalCodeTextBox.Text),
                StreetLine = short.Parse(StreetLineTextBox.Text),
                CustomerId = selectedCustomer.Id,
                Street = StreetTextBox.Text,
                State = StateTextBox.Text,
                IsActive = IsActiveCheckBox.Checked,
            };
            AddressRepository repository = new AddressRepository();
            repository.Insert(address);
            RefreshdataEvent?.Invoke();
            Clear();
        }
    }


    private void Clear()
    {
        CountryTextBox.Text = default;
        CountryCodeTextBox.Text = default;
        CityTextBox.Text = default;
        PostalCodeTextBox.Text = default;
        StreetLineTextBox.Text = default;
        StateTextBox.Text = default;
        IsActiveCheckBox.Checked = default;
        StreetTextBox.Text = default;
        StreetLineTextBox.Text = default;
        PostalCodeTextBox.Text = default;
        StreetTextBox.Text = default;
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        if (selectedAddress is null)
        {
            MessageBox.Show("Please select an item in address data grid view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        AddressRepository repository = new AddressRepository();
        selectedAddress.Country = CountryTextBox.Text;
        selectedAddress.CountryCode = CountryCodeTextBox.Text;
        selectedAddress.PostalCode = short.Parse(PostalCodeTextBox.Text);
        selectedAddress.City = CityTextBox.Text;
        selectedAddress.State = StateTextBox.Text;
        selectedAddress.Description = DescriptionTextBox.Text;
        selectedAddress.Street = StreetTextBox.Text;
        selectedAddress.StreetLine = short.Parse(StreetLineTextBox.Text);
        selectedAddress.CustomerId = selectedCustomer.Id;
        selectedAddress.IsActive = IsActiveCheckBox.Checked;
        repository.Update(selectedAddress);
        RefreshdataEvent?.Invoke();
        Clear();
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
            selectedCustomer = customer;
        }
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (selectedAddress is null)
        {
            MessageBox.Show("Please select an item in the customer data grid view");
            return;
        }

        AddressRepository repository = new AddressRepository();
        try
        {
            repository.Delete(id: selectedAddress.Id);
            RefreshdataEvent?.Invoke();
            Clear();
        }
        catch (SqlException ex) when (ex.Number == 547)
        {
            Console.WriteLine("Foreign key constraint violation occurred.");
            MessageBox.Show("Sorry, We cannot delete this record as it may be referenced by CustomerForm or OrderForm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void AddressDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (AddressDataGridView.SelectedCells.Count > 0)
        {
            var selectedindex = AddressDataGridView.SelectedCells[0].RowIndex;
            var row = AddressDataGridView.Rows[selectedindex];
            int id = int.Parse(row.Cells["Id"].Value.ToString());
            AddressRepository repository = new AddressRepository();
            Address address = repository.GetById(id);
            CountryTextBox.Text = address.Country;
            CountryCodeTextBox.Text = address.CountryCode;
            PostalCodeTextBox.Text = address.PostalCode.ToString();
            CityTextBox.Text = address.City;
            StateTextBox.Text = address.State;
            DescriptionTextBox.Text = address.Description;
            StreetTextBox.Text = address.Street;
            StreetLineTextBox.Text = address.StreetLine.ToString();
            IsActiveCheckBox.Checked = address.IsActive;
            selectedAddress = address;
        }
    }
    private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar)) // Check if the entered character is a digit
        {
            e.Handled = true; // Prevent the digit from being entered into the textbox
            ErrorCountrylabel.Text = "Error: Numbers are not allowed in the Country"; // Display the error message
            ErrorCountrylabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorCountrylabel.Visible = true; // Make the error label visible
        }
        else if (CountryTextBox.Text.Length < 3)
        {
            ErrorCountrylabel.Text = "Error: Country must be at least four characters long"; // Display the error message
            ErrorCountrylabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorCountrylabel.Visible = true; // Make the error label visible
        }
        else if (ErrorCountrylabel.Text.Length > 300 && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true; // Prevent the character from being entered into the textbox
            ErrorCountrylabel.Text = "Error: Country cannot exceed 300 characters"; // Display the error message
            ErrorCountrylabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorCountrylabel.Visible = true; // Make the error label visible
        }
        else
        {
            e.Handled = false;
            ErrorCountrylabel.Visible = false;
        }
    }
    private void CountryCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            ErrorCountryCodelabel.ForeColor = Color.Red;
            ErrorCountryCodelabel.Text = "You can't enter words in CountryCode text box";
            ErrorCountryCodelabel.Visible = true;
            e.Handled = true;
        }
        else if (CountryCodeTextBox.Text.Length >= 150 && !char.IsControl(e.KeyChar))
        {
            ErrorCountryCodelabel.ForeColor = Color.Red;
            ErrorCountryCodelabel.Text = "Country Code must be 150 character";
            ErrorCountryCodelabel.Visible = true;
            e.Handled = true;
        }
        else
        {
            e.Handled = false;
            ErrorCountryCodelabel.Visible = false;
        }
    }

    private void PostalCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            ErrorPostalCodelabel.ForeColor = Color.Red;
            ErrorPostalCodelabel.Text = "You can't enter words in PostalCode text box";
            ErrorPostalCodelabel.Visible = true;
            e.Handled = true;
        }
        else if (PostalCodeTextBox.Text.Length >= 3 && !char.IsControl(e.KeyChar))
        {
            ErrorPostalCodelabel.ForeColor = Color.Red;
            ErrorPostalCodelabel.Text = "PostalCode must be 3 character";
            ErrorPostalCodelabel.Visible = true;
            e.Handled = true;
        }
        else
        {
            e.Handled = false;
            ErrorPostalCodelabel.Visible = false;
        }
    }

    private void CityTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar)) // Check if the entered character is a digit
        {
            e.Handled = true; // Prevent the digit from being entered into the textbox
            ErrorCitylabel.Text = "Error: Numbers are not allowed in the City"; // Display the error message
            ErrorCitylabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorCitylabel.Visible = true; // Make the error label visible
        }
        else if (CityTextBox.Text.Length < 4)
        {
            ErrorCitylabel.Text = "Error: City must be at least 4 characters long"; // Display the error message
            ErrorCitylabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorCitylabel.Visible = true; // Make the error label visible
        }
        else if (CityTextBox.Text.Length > 150 && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true; // Prevent the character from being entered into the textbox
            ErrorCitylabel.Text = "Error: City cannot exceed 150 characters"; // Display the error message
            ErrorCitylabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorCitylabel.Visible = true; // Make the error label visible
        }
        else
        {
            e.Handled = false;
            ErrorCitylabel.Visible = false;
        }
    }

    private void StateTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar)) // Check if the entered character is a digit
        {
            e.Handled = true; // Prevent the digit from being entered into the textbox
            ErrorStatelabel.Text = "Error: Numbers are not allowed in the state"; // Display the error message
            ErrorStatelabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorStatelabel.Visible = true; // Make the error label visible
        }
        else if (StateTextBox.Text.Length < 4)
        {
            ErrorStatelabel.Text = "Error: State must be at least five characters long"; // Display the error message
            ErrorStatelabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorStatelabel.Visible = true; // Make the error label visible
        }
        else if (StateTextBox.Text.Length > 150 && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true; // Prevent the character from being entered into the textbox
            ErrorStatelabel.Text = "Error: Name cannot exceed 50 characters"; // Display the error message
            ErrorStatelabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorStatelabel.Visible = true; // Make the error label visible
        }
        else
        {
            ErrorStatelabel.Visible = false;
        }
    }
    private void StreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar)) // Check if the entered character is a digit
        {
            e.Handled = true; // Prevent the digit from being entered into the textbox
            ErrorStreetlabel.Text = "Error: Numbers are not allowed in the street"; // Display the error message
            ErrorStreetlabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorStreetlabel.Visible = true; // Make the error label visible
        }
        else if (StreetTextBox.Text.Length < 3)
        {
            ErrorStreetlabel.Text = "Error: Street must be at least five characters long"; // Display the error message
            ErrorStreetlabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorStreetlabel.Visible = true; // Make the error label visible
        }
        else if (StreetTextBox.Text.Length > 100 && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true; // Prevent the character from being entered into the textbox
            ErrorStreetlabel.Text = "Error: Street cannot exceed 50 characters"; // Display the error message
            ErrorStreetlabel.ForeColor = Color.Red; // Set the error label color to red
            ErrorStreetlabel.Visible = true; // Make the error label visible
        }
        else
        {
            e.Handled = false;
            ErrorStreetlabel.Visible = false;
        }
    }
    private void StreetLineTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            ErrorStreetLinelabel.ForeColor = Color.Red;
            ErrorStreetLinelabel.Text = "You can't enter words in number street line text box";
            ErrorStreetLinelabel.Visible = true;
            e.Handled = true;
        }
        else if (StreetLineTextBox.Text.Length >= 3 && !char.IsControl(e.KeyChar))
        {
            ErrorStreetLinelabel.ForeColor = Color.Red;
            ErrorStreetLinelabel.Text = "street line must be 3 character";
            ErrorStreetLinelabel.Visible = true;
            e.Handled = true;
        }
        else
        {
            e.Handled = false;
            ErrorStreetLinelabel.Visible = false;
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

    private void customerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CustomerForm customerForm = new CustomerForm();
        customerForm.Show();
        this.Close();
    }

    

    private void AddressForm_Load(object sender, EventArgs e)
    {

    }

}
