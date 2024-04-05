using ShopPro.BaseBackend.Models;
using ShopPro.BaseBackend.Repositories;


namespace ShopPro;

public partial class OrderForm : Form
{
    public delegate void RefreshDataDelegate();
    public event RefreshDataDelegate RefreshDataEvent;
    Product selectedProduct;
    Customer selectedCustomer;
    Order selectedOrder;
    Address selectedAddress;
    public OrderForm()
    {
        InitializeComponent();
        RefreshDataEvent += RefreshDate;
        LoadFromDate();
    }
    public void RefreshDate()
    {
        OrderRepository orderRepository = new OrderRepository();
        List<Order> orders = orderRepository.GetAll();
        OrderDataGridView.DataSource = null;
        OrderDataGridView.DataSource = orders;
        OrderDataGridView.Refresh();
        AddressRepository addressRepository = new AddressRepository();
        List<Address> addresses = addressRepository.GetAll();
        AddressDataGridView.DataSource = null;
        AddressDataGridView.DataSource = addresses;
        AddressDataGridView.Refresh();
        CustomerRepository customerRepository = new CustomerRepository();
        List<Customer> customers = customerRepository.GetAll();
        CustomerDataGridView.DataSource = null;
        CustomerDataGridView.DataSource = customers;
        CustomerDataGridView.Refresh();
        ProductRepository productRepository = new ProductRepository();
        List<Product> products = productRepository.GetAll();
        ProductDataGridView.DataSource = null;
        ProductDataGridView.DataSource = products;
        ProductDataGridView.Refresh();
    }
    public void LoadFromDate()
    {
        RefreshDate();
    }
    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (selectedAddress is null || selectedCustomer is null || selectedProduct is null) 
        {
            MessageBox.Show("Please select data grid views");
        }
        
        Guid guid = Guid.NewGuid();
        string _orderCode = guid.ToString("N").Substring(0, 10);
        Order orderData = new Order()
        {
            OrderCode = _orderCode,
            Date = DateTime.Now,
            AddressDescription = AddressDescriptionTextBox.Text,
            OrderDescription = OrderDescriptionTextBox.Text,
            CustomerId = selectedCustomer.Id,
            AddressId = selectedAddress.Id,
            ProductId = selectedProduct.Id,
        };
        OrderRepository orderRepository = new OrderRepository();
        orderRepository.Insert(orderData);
        RefreshDataEvent?.Invoke();
        Clear();
    }
    private void Clear() 
    {
        AddressDescriptionTextBox.Text = null;
        OrderDescriptionTextBox.Text = null;
        IsActiveRadioButton.Checked = false;
    }
    private void ResetButton_Click(object sender, EventArgs e)
    {
        Clear();
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        if (selectedOrder is null)
        {
            MessageBox.Show("Please select an item in data grid view");
            return;
        }
        OrderRepository repository = new OrderRepository();
        selectedOrder.AddressDescription = AddressDescriptionTextBox.Text;
        selectedOrder.OrderDescription = OrderDescriptionTextBox.Text;
        selectedOrder.IsActive = IsActiveRadioButton.Checked;
        selectedOrder.AddressId = selectedAddress.Id;
        selectedOrder.ProductId = selectedProduct.Id;
        selectedOrder.CustomerId = selectedCustomer.Id;
        repository.Update(selectedOrder);
        RefreshDataEvent?.Invoke();
        Clear();
    }
    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (selectedOrder is null)
        {
            MessageBox.Show("Please select an item in customer data grid view");
            return;
        }
        OrderRepository repository = new OrderRepository();
        repository.Delete(id: selectedOrder.Id);
        RefreshDataEvent?.Invoke();
        Clear();
    }
    private void AddressDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (AddressDataGridView.SelectedCells.Count > 0) 
        {
            var selectedIndex = AddressDataGridView.SelectedCells[0].RowIndex;
            var Row = AddressDataGridView.Rows[selectedIndex];
            var id = int.Parse(Row.Cells["Id"].Value.ToString());
            AddressRepository addressRepository = new AddressRepository();
            Address address = addressRepository.GetById(id);
            selectedAddress = address;
        }
    }

    private void OrderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (OrderDataGridView.SelectedCells.Count > 1) 
        {
            var selectedIndex = OrderDataGridView.SelectedCells[0].RowIndex;
            var row = OrderDataGridView.Rows[selectedIndex];
            int id = int.Parse(row.Cells["Id"].Value.ToString());
            OrderRepository orderRepository = new OrderRepository();
            Order order = orderRepository.GetById(id);
            AddressDescriptionTextBox.Text = order.AddressDescription;
            OrderDescriptionTextBox.Text = order.OrderDescription;
            IsActiveRadioButton.Checked = order.IsActive;
            selectedOrder = order;
        }
    }

    private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (ProductDataGridView.SelectedCells.Count > 0)
        {
            var selectedindex = ProductDataGridView.SelectedCells[0].RowIndex;
            var row = ProductDataGridView.Rows[selectedindex];
            int id = int.Parse(row.Cells["Id"].Value.ToString());
            ProductRepository repository = new ProductRepository();
            Product product = repository.GetById(id);
            selectedProduct = product;
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
            selectedCustomer = customer;
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

    private void customerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CustomerForm customerForm = new CustomerForm();
        customerForm.Show();
        this.Close();
    }
    private void addressToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AddressForm addressForm = new AddressForm();
        addressForm.Show();
        this.Close();
    }

   
}
