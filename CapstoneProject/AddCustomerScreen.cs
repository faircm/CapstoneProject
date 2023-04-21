using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class AddCustomerScreen : Form
    {
        // 8 FEB 2023, modified form to allow address selection from combobox rather than requiring ID input
        List<string> addressDataSource = new List<string>();

        public AddCustomerScreen()
        {
            InitializeComponent();

            if (Customer.custList.Count == 0)
            {
                custIdBox.Text = "1";
            }
            else
            {
                custIdBox.Text = (Customer.custList[Customer.custList.Count - 1].Id + 1).ToString();
            }

            createDatePicker.Format = DateTimePickerFormat.Custom;
            createDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            lastUpdatePicker.Format = DateTimePickerFormat.Custom;
            lastUpdatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            createDatePicker.Value = DateTime.Now;
            createdByBox.Text = userContext.getUsername();
            lastUpdatePicker.Value = DateTime.Now;
            lastUpdateByBox.Text = userContext.getUsername();

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
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            byte isActive = 0;
            try
            {
                if (activeCombo.Text != "False")
                {
                    if (activeCombo.Text == "True")
                    {
                        isActive = 1;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                Customer newCustomer = new Customer(Int32.Parse(custIdBox.Text), custNameBox.Text, Address.returnAddressId(addressBox.SelectedItem.ToString()), isActive, createDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), createdByBox.Text, lastUpdatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), lastUpdateByBox.Text);
                Customer.addToDb(newCustomer);
            }
            catch (FormatException)
            {
                MessageBox.Show("All fields must be filled out correctly before continuing.", "Error adding customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}