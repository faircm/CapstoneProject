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
            // Set flag to determine if query has multiple parameters
            bool flag = false;

            if (idBox.Text.Length > 0)
            {
                searchStr += $" customerId = {idBox.Text}";
                flag = true;
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
                searchStr += $" AND address LIKE \'%{addressBox.Text}%\'";
            }
            else if (addressBox.Text.Length > 0 && !flag)
            {
                searchStr += $" address LIKE \'%{addressBox.Text}%\'";
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


            searchStr += ";";
            custList.DataSource = Customer.getCustomers(searchStr);
            savedSearchStr = searchStr;
            searchStr = "SELECT * FROM customer WHERE";
        }

        private void modCustBtn_Click(object sender, EventArgs e)
        {
            ModifyCustomerScreen modifyCustomerScreen = new ModifyCustomerScreen(custList.CurrentRow);
            modifyCustomerScreen.Show();
            modifyCustomerScreen.Focus();
        }

        private void delCustBtn_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            DataGridViewSelectedRowCollection deleteRows = custList.SelectedRows;
            Customer delCust = (Customer)deleteRows[0].DataBoundItem;

            if (Appointment.getCustAppts(delCust.Id).Count > 0)
            {
                MessageBox.Show("You cannot delete a customer associated with one or more appointments.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MySqlCommand delCmd = new MySqlCommand($"DELETE FROM customer WHERE customerId = {delCust.Id}", DatabaseConnection.connection);
                reader = delCmd.ExecuteReader();
                reader.Close();
                custList.DataSource = Customer.getCustomers(savedSearchStr);
            }
           
        }
    }
}
