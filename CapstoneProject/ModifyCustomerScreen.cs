using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class ModifyCustomerScreen : Form
    {
        // 8 FEB 2023, modified form to allow address selection from combobox rather than requiring ID input
        List<string> addressDataSource = new List<string>();
        public ModifyCustomerScreen(DataGridViewRow currentRow)
        {
            InitializeComponent();
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string currentTimeUTC = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            lastUpdatePicker.Format = DateTimePickerFormat.Custom;
            lastUpdatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            createDatePicker.Format = DateTimePickerFormat.Custom;
            createDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            lastUpdatePicker.Value = DateTime.Now;
            Customer selectedCust = (Customer)currentRow.DataBoundItem;

            foreach (Address address in Address.addressList)
            {
                if (address.address2.Length > 0)
                {
                    addressDataSource.Add(address.address + ", " + address.address2);
                }
                else
                {
                    addressDataSource.Add(address.address);
                }

            }
            addressBox.DataSource = addressDataSource;

            custIdBox.Text = selectedCust.Id.ToString();
            custNameBox.Text = selectedCust.customerName;

            addressBox.SelectedItem = Address.returnAddressStr(selectedCust.addressId);
            createDatePicker.Value = DateTime.Parse(selectedCust.createDate);
            createdByBox.Text = selectedCust.createdBy;
            lastUpdatePicker.Value = DateTime.Now;
            lastUpdateByBox.Text = userContext.getUsername();

            if (selectedCust.active == 1)
            {
                activeCombo.Text = "True";

            }
            else
                activeCombo.Text = "False";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            byte activeVal = 0;
            try
            {
                if (activeCombo.Text == "True")
                {
                    activeCombo.Text = "True";
                    activeVal = 1;
                }

                Customer newCustomer = new Customer(Int32.Parse(custIdBox.Text), custNameBox.Text, Address.returnAddressId(addressBox.SelectedItem.ToString()), activeVal, createDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), createdByBox.Text, lastUpdatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), lastUpdateByBox.Text);

                Customer.modifyDb(newCustomer);
            }
            catch (FormatException)
            {
                MessageBox.Show("All fields must be filled out correctly before continuing.", "Error adding appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
