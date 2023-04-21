namespace C969Assessment
{
    partial class CustomerSearch
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
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.modCustBtn = new System.Windows.Forms.Button();
            this.delCustBtn = new System.Windows.Forms.Button();
            this.custList = new System.Windows.Forms.DataGridView();
            this.trueRadio = new System.Windows.Forms.RadioButton();
            this.falseRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.custList)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(409, 142);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(105, 35);
            this.searchBtn.TabIndex = 42;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Active:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(113, 70);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(155, 20);
            this.addressBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Address:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(113, 42);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(155, 20);
            this.nameBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer Name:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(113, 14);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(155, 20);
            this.idBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Customer ID: ";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(407, 450);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 35);
            this.cancelBtn.TabIndex = 29;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // modCustBtn
            // 
            this.modCustBtn.Location = new System.Drawing.Point(185, 450);
            this.modCustBtn.Name = "modCustBtn";
            this.modCustBtn.Size = new System.Drawing.Size(105, 35);
            this.modCustBtn.TabIndex = 28;
            this.modCustBtn.Text = "Modify Customer";
            this.modCustBtn.UseVisualStyleBackColor = true;
            this.modCustBtn.Click += new System.EventHandler(this.modCustBtn_Click);
            // 
            // delCustBtn
            // 
            this.delCustBtn.Location = new System.Drawing.Point(296, 450);
            this.delCustBtn.Name = "delCustBtn";
            this.delCustBtn.Size = new System.Drawing.Size(105, 35);
            this.delCustBtn.TabIndex = 27;
            this.delCustBtn.Text = " Delete Customer";
            this.delCustBtn.UseVisualStyleBackColor = true;
            this.delCustBtn.Click += new System.EventHandler(this.delCustBtn_Click);
            // 
            // custList
            // 
            this.custList.AllowUserToAddRows = false;
            this.custList.AllowUserToDeleteRows = false;
            this.custList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custList.Location = new System.Drawing.Point(12, 193);
            this.custList.MultiSelect = false;
            this.custList.Name = "custList";
            this.custList.ReadOnly = true;
            this.custList.RowHeadersVisible = false;
            this.custList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custList.Size = new System.Drawing.Size(502, 241);
            this.custList.TabIndex = 26;
            // 
            // trueRadio
            // 
            this.trueRadio.AutoSize = true;
            this.trueRadio.Location = new System.Drawing.Point(113, 101);
            this.trueRadio.Name = "trueRadio";
            this.trueRadio.Size = new System.Drawing.Size(47, 17);
            this.trueRadio.TabIndex = 44;
            this.trueRadio.TabStop = true;
            this.trueRadio.Text = "True";
            this.trueRadio.UseVisualStyleBackColor = true;
            // 
            // falseRadio
            // 
            this.falseRadio.AutoSize = true;
            this.falseRadio.Location = new System.Drawing.Point(176, 101);
            this.falseRadio.Name = "falseRadio";
            this.falseRadio.Size = new System.Drawing.Size(50, 17);
            this.falseRadio.TabIndex = 45;
            this.falseRadio.TabStop = true;
            this.falseRadio.Text = "False";
            this.falseRadio.UseVisualStyleBackColor = true;
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 495);
            this.Controls.Add(this.falseRadio);
            this.Controls.Add(this.trueRadio);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.modCustBtn);
            this.Controls.Add(this.delCustBtn);
            this.Controls.Add(this.custList);
            this.Name = "CustomerSearch";
            this.Text = "CustomerSearch";
            this.Activated += new System.EventHandler(this.refreshList);
            ((System.ComponentModel.ISupportInitialize)(this.custList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button modCustBtn;
        private System.Windows.Forms.Button delCustBtn;
        private System.Windows.Forms.DataGridView custList;
        private System.Windows.Forms.RadioButton trueRadio;
        private System.Windows.Forms.RadioButton falseRadio;
    }
}