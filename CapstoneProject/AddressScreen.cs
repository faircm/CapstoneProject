using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class AddressScreen : Form
    {
        public AddressScreen()
        {
            InitializeComponent();
            addressList.DataSource = Address.addressList;
        }

        private void addAddBtn_Click(object sender, EventArgs e)
        {
            AddAddressScreen addAddressScreen = new AddAddressScreen();
            addAddressScreen.Show();
            addAddressScreen.Focus();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            addressList.DataSource = null;
            addressList.DataSource = Address.addressList;
        }

        private void delAddBtn_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            DataGridViewSelectedRowCollection deleteRows = addressList.SelectedRows;

            try
            {
                foreach (DataGridViewRow row in deleteRows)
                {
                    Address newAdd = (Address)row.DataBoundItem;
                    MySqlCommand command = new MySqlCommand($"DELETE FROM address WHERE addressId = {newAdd.Id}", DatabaseConnection.connection);
                    reader = command.ExecuteReader();
                    reader.Close();

                    Address.addressList.Remove(newAdd);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("You cannot delete an address which is currently associated with a customer", "Error deleting address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modAddBtn_Click(object sender, EventArgs e)
        {
            ModifyAddressScreen modifyAddressScreen = new ModifyAddressScreen(addressList.CurrentRow);
            modifyAddressScreen.Show();
            modifyAddressScreen.Focus();
        }
    }
}