using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class AddressSearch : Form
    {
        string searchStr = "SELECT * FROM address WHERE";
        string savedSearchStr = "";
        public AddressSearch()
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
                searchStr += $" addressId = {idBox.Text}";
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

            if (addressBox2.Text.Length > 0 && flag)
            {
                searchStr += $" AND address2 LIKE \'%{addressBox2.Text}%\'";
            }
            else if (addressBox2.Text.Length > 0 && !flag)
            {
                searchStr += $" address2 LIKE \'%{addressBox2.Text}%\'";
                flag = true;
            }

            if (phoneBox.Text.Length > 0 && flag)
            {
                searchStr += $" AND phone LIKE \'%{phoneBox.Text}%\'";
            }
            else if (phoneBox.Text.Length > 0 && !flag)
            {
                searchStr += $" phone LIKE \'%{phoneBox.Text}%\'";
                flag = true;
            }

            if (cityBox.Text.Length > 0 && flag)
            {
                searchStr += $" AND cityId = {Address.returnCityId(cityBox.Text)}";
            }
            else if (cityBox.Text.Length > 0 && !flag)
            {
                searchStr += $" cityId = {Address.returnCityId(cityBox.Text)}";
                flag = true;
            }

            if (postalCodeBox.Text.Length > 0 && flag)
            {
                searchStr += $" AND postalCode = \'{postalCodeBox.Text}\'";
            }
            else if (postalCodeBox.Text.Length > 0 && !flag)
            {
                searchStr += $" postalCode = \'{postalCodeBox.Text}\'";
                flag = true;
            }
            if (phoneBox.Text.Length > 0 && flag)
            {
                searchStr += $" AND phone = \'{phoneBox.Text}\'";
            }
            else if (phoneBox.Text.Length > 0 && !flag)
            {
                searchStr += $" phone = \'{phoneBox.Text}\'";
                flag = true;
            }

            if (searchStr == "SELECT * FROM address WHERE")
            {
                return;
            }

            searchStr += ";";
            addrList.DataSource = Address.getAddresses(searchStr);
            savedSearchStr = searchStr;
            searchStr = "SELECT * FROM address WHERE";
        }

        private void modAddrBtn_Click(object sender, EventArgs e)
        {
            bool isNull = (addrList.CurrentRow == null) ? true : false;
            if (isNull)
            {
                return;
            }
            ModifyAddressScreen modifyAddressScreen = new ModifyAddressScreen(addrList.CurrentRow);
            modifyAddressScreen.Show();
            modifyAddressScreen.Focus();

        }

        private void delAddrBtn_Click(object sender, EventArgs e)
        {

            MySqlDataReader reader;
            DataGridViewSelectedRowCollection deleteRows = addrList.SelectedRows;
            if (addrList.SelectedRows.Count == 0)
            {
                return;
            }

            Address delAddr = (Address)deleteRows[0].DataBoundItem;
            // Block deletion if any customer records rely on this address.
            if (Customer.custHasAddress(delAddr.Id))
            {
                MessageBox.Show("You cannot delete an address which is currently assigned to a customer.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlCommand delCmd = new MySqlCommand($"DELETE FROM address WHERE addressId = {delAddr.Id}", DatabaseConnection.connection);
                reader = delCmd.ExecuteReader();
                reader.Close();
                refreshList(null, null);
            }

        }

        private void refreshList(object sender, EventArgs e)
        {
            addrList.DataSource = null;
            addrList.DataSource = Address.getAddresses(savedSearchStr);
        }
    }
}
