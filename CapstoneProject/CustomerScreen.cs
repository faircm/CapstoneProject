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
            bool isNull = (customerList.CurrentRow == null) ? true : false;
            if (isNull)
            {
                return;
            }

            ModifyCustomerScreen modifyCustomerScreen = new ModifyCustomerScreen(
                customerList.CurrentRow
            );
            modifyCustomerScreen.Show();
            modifyCustomerScreen.Focus();
        }

        private void delCustBtn_Click(object sender, System.EventArgs e)
        {
            if (customerList.SelectedRows.Count == 0)
            {
                return;
            }
            MySqlDataReader reader;
            DataGridViewSelectedRowCollection deleteRows = customerList.SelectedRows;

            foreach (DataGridViewRow row in deleteRows)
            {
                Customer newCust = (Customer)row.DataBoundItem;

                if (Appointment.getCustAppts(newCust.Id).Count > 0)
                {
                    MessageBox.Show(
                        "You cannot delete a customer associated with one or more appointments.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                else
                {
                    MySqlCommand command = new MySqlCommand(
                        $"DELETE FROM customer WHERE customerId = {newCust.Id}",
                        DatabaseConnection.connection
                    );
                    reader = command.ExecuteReader();
                    reader.Close();

                    Customer.custList.Remove(newCust);
                }
            }
            refreshBtn_Click(null, null);
        }

        private void refreshBtn_Click(object sender, System.EventArgs e)
        {
            customerList.DataSource = null;
            Customer.custList = Customer.getCustomers();
            customerList.DataSource = Customer.custList;
        }

        private void searchBtn_Click(object sender, System.EventArgs e)
        {
            CustomerSearch customerSearch = new CustomerSearch();
            customerSearch.Show();
            customerSearch.Focus();
        }
    }
}
