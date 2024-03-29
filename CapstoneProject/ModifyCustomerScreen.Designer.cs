﻿
namespace C969Assessment
{
    partial class ModifyCustomerScreen
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
            this.custIdBox = new System.Windows.Forms.TextBox();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lastUpdatePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.lastUpdateByBox = new System.Windows.Forms.TextBox();
            this.createdByBox = new System.Windows.Forms.TextBox();
            this.activeCombo = new System.Windows.Forms.ComboBox();
            this.addressBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // custIdBox
            // 
            this.custIdBox.Enabled = false;
            this.custIdBox.Location = new System.Drawing.Point(107, 24);
            this.custIdBox.Name = "custIdBox";
            this.custIdBox.Size = new System.Drawing.Size(201, 20);
            this.custIdBox.TabIndex = 122;
            // 
            // custNameBox
            // 
            this.custNameBox.Location = new System.Drawing.Point(107, 50);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(201, 20);
            this.custNameBox.TabIndex = 121;
            // 
            // createDatePicker
            // 
            this.createDatePicker.Enabled = false;
            this.createDatePicker.Location = new System.Drawing.Point(108, 131);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(200, 20);
            this.createDatePicker.TabIndex = 120;
            // 
            // lastUpdatePicker
            // 
            this.lastUpdatePicker.Enabled = false;
            this.lastUpdatePicker.Location = new System.Drawing.Point(108, 182);
            this.lastUpdatePicker.Name = "lastUpdatePicker";
            this.lastUpdatePicker.Size = new System.Drawing.Size(200, 20);
            this.lastUpdatePicker.TabIndex = 119;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(150, 248);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 118;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 117;
            this.label15.Text = "Last Updated By";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 116;
            this.label14.Text = "Last Update";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 115;
            this.label13.Text = "Created By";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 114;
            this.label12.Text = "Date Created";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "Active";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Address ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Customer Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Customer ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(231, 248);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 109;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // lastUpdateByBox
            // 
            this.lastUpdateByBox.Enabled = false;
            this.lastUpdateByBox.Location = new System.Drawing.Point(107, 208);
            this.lastUpdateByBox.Name = "lastUpdateByBox";
            this.lastUpdateByBox.Size = new System.Drawing.Size(200, 20);
            this.lastUpdateByBox.TabIndex = 108;
            // 
            // createdByBox
            // 
            this.createdByBox.Enabled = false;
            this.createdByBox.Location = new System.Drawing.Point(107, 156);
            this.createdByBox.Name = "createdByBox";
            this.createdByBox.Size = new System.Drawing.Size(200, 20);
            this.createdByBox.TabIndex = 107;
            // 
            // activeCombo
            // 
            this.activeCombo.FormattingEnabled = true;
            this.activeCombo.Items.AddRange(new object[] {
            "True",
            "False"});
            this.activeCombo.Location = new System.Drawing.Point(107, 105);
            this.activeCombo.Name = "activeCombo";
            this.activeCombo.Size = new System.Drawing.Size(201, 21);
            this.activeCombo.TabIndex = 125;
            // 
            // addressBox
            // 
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Location = new System.Drawing.Point(107, 76);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(200, 21);
            this.addressBox.TabIndex = 126;
            // 
            // ModifyCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 295);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.activeCombo);
            this.Controls.Add(this.custIdBox);
            this.Controls.Add(this.custNameBox);
            this.Controls.Add(this.createDatePicker);
            this.Controls.Add(this.lastUpdatePicker);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.lastUpdateByBox);
            this.Controls.Add(this.createdByBox);
            this.Name = "ModifyCustomerScreen";
            this.Text = "Modify Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox custIdBox;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.DateTimePicker lastUpdatePicker;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox lastUpdateByBox;
        private System.Windows.Forms.TextBox createdByBox;
        private System.Windows.Forms.ComboBox activeCombo;
        private System.Windows.Forms.ComboBox addressBox;
    }
}