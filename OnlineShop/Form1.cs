using ShopPro.BaseBackend.Models;

namespace OnlineShop;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        var user = new User()
        {
            Name = NameTextBox.Text,
            LastName = LastNameTextBox.Text,
        };
        MessageBox.Show($"The name is {user.Name} and the last name is {user.LastName}");
        Clear();
    }
    private void Clear()
    {   
        NameTextBox.Text  = default;
        LastNameTextBox.Text = default;
    }
}
