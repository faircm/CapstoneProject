namespace C969Assessment
{
    partial class AddressSearch
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.modAddrBtn = new System.Windows.Forms.Button();
            this.delAddrBtn = new System.Windows.Forms.Button();
            this.addrList = new System.Windows.Forms.DataGridView();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addrList)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(410, 140);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(105, 35);
            this.searchBtn.TabIndex = 42;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Postal Code:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(114, 96);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(155, 20);
            this.cityBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "City:";
            // 
            // addressBox2
            // 
            this.addressBox2.Location = new System.Drawing.Point(114, 68);
            this.addressBox2.Name = "addressBox2";
            this.addressBox2.Size = new System.Drawing.Size(155, 20);
            this.addressBox2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Address Line 2:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(114, 40);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(155, 20);
            this.addressBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Address Line 1:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(114, 12);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(155, 20);
            this.idBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Address ID: ";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(408, 448);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 35);
            this.cancelBtn.TabIndex = 29;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // modAddrBtn
            // 
            this.modAddrBtn.Location = new System.Drawing.Point(186, 448);
            this.modAddrBtn.Name = "modAddrBtn";
            this.modAddrBtn.Size = new System.Drawing.Size(105, 35);
            this.modAddrBtn.TabIndex = 28;
            this.modAddrBtn.Text = "Modify Address";
            this.modAddrBtn.UseVisualStyleBackColor = true;
            this.modAddrBtn.Click += new System.EventHandler(this.modAddrBtn_Click);
            // 
            // delAddrBtn
            // 
            this.delAddrBtn.Location = new System.Drawing.Point(297, 448);
            this.delAddrBtn.Name = "delAddrBtn";
            this.delAddrBtn.Size = new System.Drawing.Size(105, 35);
            this.delAddrBtn.TabIndex = 27;
            this.delAddrBtn.Text = "Delete Address";
            this.delAddrBtn.UseVisualStyleBackColor = true;
            this.delAddrBtn.Click += new System.EventHandler(this.delAddrBtn_Click);
            // 
            // addrList
            // 
            this.addrList.AllowUserToAddRows = false;
            this.addrList.AllowUserToDeleteRows = false;
            this.addrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addrList.Location = new System.Drawing.Point(13, 191);
            this.addrList.MultiSelect = false;
            this.addrList.Name = "addrList";
            this.addrList.ReadOnly = true;
            this.addrList.RowHeadersVisible = false;
            this.addrList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addrList.Size = new System.Drawing.Size(502, 241);
            this.addrList.TabIndex = 26;
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(114, 128);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(155, 20);
            this.postalCodeBox.TabIndex = 43;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(367, 12);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(155, 20);
            this.phoneBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Phone Number:";
            // 
            // AddressSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 495);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.modAddrBtn);
            this.Controls.Add(this.delAddrBtn);
            this.Controls.Add(this.addrList);
            this.Name = "AddressSearch";
            this.Text = "AddressSearch";
            this.Activated += new System.EventHandler(this.refreshList);
            ((System.ComponentModel.ISupportInitialize)(this.addrList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button modAddrBtn;
        private System.Windows.Forms.Button delAddrBtn;
        private System.Windows.Forms.DataGridView addrList;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label6;
    }
}