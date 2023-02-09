using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class CustomerScreen : Form
    {
        public CustomerScreen()
        {
            InitializeComponent();
            customerList.DataSource = Customer.custList;
        }

        private void addCustBtn_Click(object sender, System.EventArgs e)
        {
            AddCustomerScreen addCustomerScreen = new AddCustomerScreen();
            addCustomerScreen.Show();
            addCustomerScreen.Focus();
        }

        private void modCustBtn_Click(object sender, System.EventArgs e)
        {
            ModifyCustomerScreen modifyCustomerScreen = new ModifyCustomerScreen(customerList.CurrentRow);
            modifyCustomerScreen.Show();
            modifyCustomerScreen.Focus();
        }

        private void delCustBtn_Click(object sender, System.EventArgs e)
        {
            MySqlDataReader reader;
            DataGridViewSelectedRowCollection deleteRows = customerList.SelectedRows;

            foreach (DataGridViewRow row in deleteRows)
            {
                Customer newCust = (Customer)row.DataBoundItem;
                MySqlCommand command = new MySqlCommand($"DELETE FROM customer WHERE customerId = {newCust.Id}", DatabaseConnection.connection);
                reader = command.ExecuteReader();
                reader.Close();

                Customer.custList.Remove(newCust);
            }
        }

        private void refreshBtn_Click(object sender, System.EventArgs e)
        {
            customerList.DataSource = null;
            customerList.DataSource = Customer.custList;
        }
    }
}
