namespace C969Assessment
{
    partial class AppointmentSearch
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
            this.apptList = new System.Windows.Forms.DataGridView();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.modApptBtn = new System.Windows.Forms.Button();
            this.delApptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.apptList)).BeginInit();
            this.SuspendLayout();
            // 
            // apptList
            // 
            this.apptList.AllowUserToAddRows = false;
            this.apptList.AllowUserToDeleteRows = false;
            this.apptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptList.Location = new System.Drawing.Point(12, 191);
            this.apptList.MultiSelect = false;
            this.apptList.Name = "apptList";
            this.apptList.ReadOnly = true;
            this.apptList.RowHeadersVisible = false;
            this.apptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apptList.Size = new System.Drawing.Size(502, 241);
            this.apptList.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(407, 448);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 35);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // modApptBtn
            // 
            this.modApptBtn.Location = new System.Drawing.Point(185, 448);
            this.modApptBtn.Name = "modApptBtn";
            this.modApptBtn.Size = new System.Drawing.Size(105, 35);
            this.modApptBtn.TabIndex = 7;
            this.modApptBtn.Text = "Modify Appointment";
            this.modApptBtn.UseVisualStyleBackColor = true;
            this.modApptBtn.Click += new System.EventHandler(this.modApptBtn_Click);
            // 
            // delApptBtn
            // 
            this.delApptBtn.Location = new System.Drawing.Point(296, 448);
            this.delApptBtn.Name = "delApptBtn";
            this.delApptBtn.Size = new System.Drawing.Size(105, 35);
            this.delApptBtn.TabIndex = 6;
            this.delApptBtn.Text = "Delete Appointment";
            this.delApptBtn.UseVisualStyleBackColor = true;
            this.delApptBtn.Click += new System.EventHandler(this.delApptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Appointment ID: ";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(113, 12);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(155, 20);
            this.idBox.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(113, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(155, 20);
            this.nameBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Customer Name:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(113, 68);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(155, 20);
            this.titleBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Appointment Title:";
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(113, 96);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(155, 20);
            this.locationBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Appointment Type:";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Presentation",
            "Scrum",
            "Code Review",
            "Sprint Planning",
            "Sprint Review",
            "Backlog Refinement",
            "Retrospective",
            "Release Planning",
            "One-on-one",
            "Team Building",
            "Quarterly review",
            "All-hands",
            "Other",
            "test"});
            this.typeBox.Location = new System.Drawing.Point(113, 124);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(155, 21);
            this.typeBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Appointment Date Range:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(362, 40);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(150, 20);
            this.startDatePicker.TabIndex = 21;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(409, 140);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(105, 35);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "End";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(362, 68);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(150, 20);
            this.endDatePicker.TabIndex = 24;
            // 
            // AppointmentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 495);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.modApptBtn);
            this.Controls.Add(this.delApptBtn);
            this.Controls.Add(this.apptList);
            this.Name = "AppointmentSearch";
            this.Text = "Appointment Search";
            ((System.ComponentModel.ISupportInitialize)(this.apptList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apptList;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button modApptBtn;
        private System.Windows.Forms.Button delApptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker endDatePicker;
    }
}