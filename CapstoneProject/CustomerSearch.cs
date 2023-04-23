using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class CustomerSearch : Form
    {
        string searchStr = "SELECT * FROM customer WHERE";
        string savedSearchStr = "";

        public CustomerSearch()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;

                if (idBox.Text.Length > 0)
                {
                    int id = 0;
                    if (Int32.TryParse(idBox.Text, out id))
                    {
                        searchStr += $" customerId = {idBox.Text}";
                        flag = true;
                    }
                }

                if (nameBox.Text.Length > 0 && flag)
                {
                    searchStr += $" AND customerName LIKE \'%{nameBox.Text}%\'";
                }
                else if (nameBox.Text.Length > 0 && !flag)
                {
                    searchStr += $" customerName LIKE \'%{nameBox.Text}%\'";
                    flag = true;
                }

                if (addressBox.Text.Length > 0 && flag)
                {
                    searchStr +=
                        $" AND addressId IN ({Address.getIdByAddressSearch(addressBox.Text)})";
                }
                else if (addressBox.Text.Length > 0 && !flag)
                {
                    searchStr += $" addressId IN ({Address.getIdByAddressSearch(addressBox.Text)})";
                    flag = true;
                }

                if (trueRadio.Checked)
                {
                    if (flag)
                    {
                        searchStr += " AND active = 1";
                    }
                    else
                    {
                        searchStr += " active = 1";
                    }
                }
                else if (falseRadio.Checked)
                {
                    {
                        if (flag)
                        {
                            searchStr += " AND active = 0";
                        }
                        else
                        {
                            searchStr += " active = 0";
                        }
                    }
                }

                if (searchStr == "SELECT * FROM customer WHERE")
                {
                    return;
                }
                searchStr += ";";
                custList.DataSource = Customer.getCustomers(searchStr);
                savedSearchStr = searchStr;
                searchStr = "SELECT * FROM customer WHERE";
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return;
            }
        }

        private void modCustBtn_Click(object sender, EventArgs e)
        {
            bool isNull = (custList.CurrentRow == null) ? true : false;
            if (isNull)
            {
                return;
            }
            ModifyCustomerScreen modifyCustomerScreen = new ModifyCustomerScreen(
                custList.CurrentRow
            );
            modifyCustomerScreen.Show();
            modifyCustomerScreen.Focus();
        }

        private void delCustBtn_Click(object sender, EventArgs e)
        {
            if (custList.SelectedRows.Count == 0)
            {
                return;
            }
            MySqlDataReader reader;
            DataGridViewSelectedRowCollection deleteRows = custList.SelectedRows;
            Customer delCust = (Customer)deleteRows[0].DataBoundItem;

            if (Appointment.getCustAppts(delCust.Id).Count > 0)
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
                MySqlCommand delCmd = new MySqlCommand(
                    $"DELETE FROM customer WHERE customerId = {delCust.Id}",
                    DatabaseConnection.connection
                );
                reader = delCmd.ExecuteReader();
                reader.Close();
                custList.DataSource = Customer.getCustomers(savedSearchStr);
            }
        }

        private void refreshList(object sender, EventArgs e)
        {
            custList.DataSource = null;
            custList.DataSource = Customer.getCustomers(savedSearchStr);
        }
    }
}
