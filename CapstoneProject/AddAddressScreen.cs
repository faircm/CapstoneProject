using System;
using System.Linq;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class AddAddressScreen : Form
    {
        public AddAddressScreen()
        {
            InitializeComponent();

            if (Address.addressList.Count == 0)
            {
                addIdBox.Text = "1";
            }
            else
            {
                addIdBox.Text = (
                    Address.addressList[Address.addressList.Count - 1].Id + 1
                ).ToString();
            }

            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string currentTimeUTC = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            lastUpdatePicker.Format = DateTimePickerFormat.Custom;
            lastUpdatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            createDatePicker.Format = DateTimePickerFormat.Custom;
            createDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            lastUpdatePicker.Value = DateTime.Now;
            createDatePicker.Value = DateTime.Now;
            cityBox.DataSource = Address.cityDict.Values.ToList<string>();
            createdByBox.Text = userContext.getUsername();
            lastUpdateByBox.Text = userContext.getUsername();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!cityBox.Items.Contains(cityBox.Text))
            {
                MessageBox.Show(
                    "For \"City\", please choose a value from the drop-down menu.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            try
            {
                if (
                    addIdBox.Text.Length == 0
                    || addLine1Box.Text.Length == 0
                    || cityBox.Text.Length == 0
                    || postalCodeBox.Text.Length == 0
                    || phoneNumBox.Text.Length == 0
                )
                {
                    throw new FormatException();
                }
                int test = 0;
                if (!Int32.TryParse(postalCodeBox.Text, out test))
                {
                    throw new FormatException();
                }

                Address newAddress = new Address(
                    Int32.Parse(addIdBox.Text),
                    addLine1Box.Text,
                    addLine2Box.Text,
                    Address.returnCityId(cityBox.SelectedItem.ToString()),
                    postalCodeBox.Text,
                    phoneNumBox.Text,
                    createDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"),
                    createdByBox.Text,
                    lastUpdatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"),
                    lastUpdateByBox.Text
                );
                Address.addToDb(newAddress);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "All fields must be filled out correctly before continuing.",
                    "Error adding address",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show(
                    "All fields must be filled out correctly before continuing.",
                    "Error adding appointment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
