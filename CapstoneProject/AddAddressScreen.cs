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
    public partial class AddAddressScreen : Form
    {
        public AddAddressScreen()
        {
            InitializeComponent();

            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string currentTimeUTC = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            lastUpdatePicker.Format = DateTimePickerFormat.Custom;
            lastUpdatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            createDatePicker.Format = DateTimePickerFormat.Custom;
            createDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            lastUpdatePicker.Value = DateTime.Now;
            createDatePicker.Value = DateTime.Now;

            addIdBox.Text = (Address.addressList[Address.addressList.Count - 1].Id + 1).ToString();
            createdByBox.Text = userContext.getUsername();
            lastUpdateByBox.Text = userContext.getUsername();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Address newAddress = new Address(Int32.Parse(addIdBox.Text), addLine1Box.Text, addLine2Box.Text, Int32.Parse(cityIdBox.Text), postalCodeBox.Text, phoneNumBox.Text, createDatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), createdByBox.Text, lastUpdatePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"), lastUpdateByBox.Text);
                Address.addToDb(newAddress);
            }
            catch (FormatException)
            {
                MessageBox.Show("All fields must be filled out correctly before continuing.", "Error adding address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}