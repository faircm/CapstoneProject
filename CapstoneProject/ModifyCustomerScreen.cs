using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class ModifyCustomerScreen : Form
    {
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

            custIdBox.Text = selectedCust.Id.ToString();
            custNameBox.Text = selectedCust.customerName;
            addressIdBox.Text = selectedCust.addressId.ToString();
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

                Customer newCustomer = new Customer(Int32.Parse(custIdBox.Text), custNameBox.Text, Int32.Parse(addressIdBox.Text), activeVal, createDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), createdByBox.Text, lastUpdatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), lastUpdateByBox.Text);

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
