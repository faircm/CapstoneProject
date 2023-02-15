using System;
using System.Linq;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class ModifyAddressScreen : Form
    {
        public ModifyAddressScreen(DataGridViewRow address)
        {
            // 12 FEB 2023 - Updated form to show combobox of city names, ID fetched using Address.returnCityIt()

            InitializeComponent();

            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string currentTimeUTC = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            lastUpdatePicker.Format = DateTimePickerFormat.Custom;
            lastUpdatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            createDatePicker.Format = DateTimePickerFormat.Custom;
            createDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            lastUpdatePicker.Value = DateTime.Now;
            Address selectedAdd = (Address)address.DataBoundItem;

            addIdBox.Text = selectedAdd.Id.ToString();
            addLine1Box.Text = selectedAdd.address;
            addLine2Box.Text = selectedAdd.address2;
            cityBox.DataSource = Address.cityDict.Values.ToList<string>();
            postalCodeBox.Text = selectedAdd.postalCode;
            phoneNumBox.Text = selectedAdd.phone;
            createDatePicker.Value = DateTime.Parse(selectedAdd.createDate);
            createdByBox.Text = selectedAdd.createdBy;
            lastUpdateByBox.Text = userContext.getUsername();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Address newAdd = new Address(Int32.Parse(addIdBox.Text), addLine1Box.Text, addLine2Box.Text, Address.returnCityId(cityBox.SelectedItem.ToString()), postalCodeBox.Text, phoneNumBox.Text, createDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), createdByBox.Text, lastUpdatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), lastUpdateByBox.Text); ;

                Address.modifyDb(newAdd);

                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("All fields must be filled out correctly before continuing.", "Error adding appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}