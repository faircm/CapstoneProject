
namespace C969Assessment
{
    partial class AddressScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.delAddBtn = new System.Windows.Forms.Button();
            this.modAddBtn = new System.Windows.Forms.Button();
            this.addAddBtn = new System.Windows.Forms.Button();
            this.addressList = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addressList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 385);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(105, 35);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // delAddBtn
            // 
            this.delAddBtn.Location = new System.Drawing.Point(683, 385);
            this.delAddBtn.Name = "delAddBtn";
            this.delAddBtn.Size = new System.Drawing.Size(105, 35);
            this.delAddBtn.TabIndex = 15;
            this.delAddBtn.Text = "Delete Address";
            this.delAddBtn.UseVisualStyleBackColor = true;
            this.delAddBtn.Click += new System.EventHandler(this.delAddBtn_Click);
            // 
            // modAddBtn
            // 
            this.modAddBtn.Location = new System.Drawing.Point(572, 385);
            this.modAddBtn.Name = "modAddBtn";
            this.modAddBtn.Size = new System.Drawing.Size(105, 35);
            this.modAddBtn.TabIndex = 14;
            this.modAddBtn.Text = "Modify Address";
            this.modAddBtn.UseVisualStyleBackColor = true;
            this.modAddBtn.Click += new System.EventHandler(this.modAddBtn_Click);
            // 
            // addAddBtn
            // 
            this.addAddBtn.Location = new System.Drawing.Point(461, 385);
            this.addAddBtn.Name = "addAddBtn";
            this.addAddBtn.Size = new System.Drawing.Size(105, 35);
            this.addAddBtn.TabIndex = 13;
            this.addAddBtn.Text = "Add Address";
            this.addAddBtn.UseVisualStyleBackColor = true;
            this.addAddBtn.Click += new System.EventHandler(this.addAddBtn_Click);
            // 
            // addressList
            // 
            this.addressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addressList.Location = new System.Drawing.Point(12, 31);
            this.addressList.MultiSelect = false;
            this.addressList.Name = "addressList";
            this.addressList.RowHeadersVisible = false;
            this.addressList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addressList.Size = new System.Drawing.Size(776, 348);
            this.addressList.TabIndex = 12;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(C969Assessment.Appointment);
            // 
            // AddressScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.delAddBtn);
            this.Controls.Add(this.modAddBtn);
            this.Controls.Add(this.addAddBtn);
            this.Controls.Add(this.addressList);
            this.Name = "AddressScreen";
            this.Text = "Addresses";
            ((System.ComponentModel.ISupportInitialize)(this.addressList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button delAddBtn;
        private System.Windows.Forms.Button modAddBtn;
        private System.Windows.Forms.Button addAddBtn;
        public System.Windows.Forms.DataGridView addressList;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
    }
}