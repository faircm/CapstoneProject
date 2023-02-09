
namespace C969Assessment
{
    partial class CustomerScreen
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
            this.delCustBtn = new System.Windows.Forms.Button();
            this.modCustBtn = new System.Windows.Forms.Button();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.customerList = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 385);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(105, 35);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // delCustBtn
            // 
            this.delCustBtn.Location = new System.Drawing.Point(683, 385);
            this.delCustBtn.Name = "delCustBtn";
            this.delCustBtn.Size = new System.Drawing.Size(105, 35);
            this.delCustBtn.TabIndex = 10;
            this.delCustBtn.Text = "Delete Customer";
            this.delCustBtn.UseVisualStyleBackColor = true;
            this.delCustBtn.Click += new System.EventHandler(this.delCustBtn_Click);
            // 
            // modCustBtn
            // 
            this.modCustBtn.Location = new System.Drawing.Point(572, 385);
            this.modCustBtn.Name = "modCustBtn";
            this.modCustBtn.Size = new System.Drawing.Size(105, 35);
            this.modCustBtn.TabIndex = 9;
            this.modCustBtn.Text = "Modify Customer";
            this.modCustBtn.UseVisualStyleBackColor = true;
            this.modCustBtn.Click += new System.EventHandler(this.modCustBtn_Click);
            // 
            // addCustBtn
            // 
            this.addCustBtn.Location = new System.Drawing.Point(461, 385);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(105, 35);
            this.addCustBtn.TabIndex = 8;
            this.addCustBtn.Text = "Add Customer";
            this.addCustBtn.UseVisualStyleBackColor = true;
            this.addCustBtn.Click += new System.EventHandler(this.addCustBtn_Click);
            // 
            // customerList
            // 
            this.customerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customerList.Location = new System.Drawing.Point(12, 31);
            this.customerList.MultiSelect = false;
            this.customerList.Name = "customerList";
            this.customerList.RowHeadersVisible = false;
            this.customerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerList.Size = new System.Drawing.Size(776, 348);
            this.customerList.TabIndex = 7;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(C969Assessment.Appointment);
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.delCustBtn);
            this.Controls.Add(this.modCustBtn);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.customerList);
            this.Name = "CustomerScreen";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button delCustBtn;
        private System.Windows.Forms.Button modCustBtn;
        private System.Windows.Forms.Button addCustBtn;
        public System.Windows.Forms.DataGridView customerList;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
    }
}