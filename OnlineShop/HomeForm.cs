

namespace ShopPro;

public partial class HomeForm : Form
{
    public HomeForm()
    {
        InitializeComponent();
    }

    private void productToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProductForm productForm = new ProductForm();
        productForm.Show();
    }

    private void customerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CustomerForm customerForm = new CustomerForm();
        customerForm.Show();
    }

    private void orderToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OrderForm orderForm = new OrderForm();
        orderForm.Show();
    }
    private void addressToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AddressForm addressForm = new AddressForm();
        addressForm.Show();
    }
    private void HomeForm_Load(object sender, EventArgs e)
    {

    }
}
