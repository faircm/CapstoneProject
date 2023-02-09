
namespace C969Assessment
{
    partial class AppointmentScreen
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
            this.appointmentList = new System.Windows.Forms.DataGridView();
            this.addApptBtn = new System.Windows.Forms.Button();
            this.modApptBtn = new System.Windows.Forms.Button();
            this.delApptBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentList
            // 
            this.appointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.appointmentList.Location = new System.Drawing.Point(12, 31);
            this.appointmentList.MultiSelect = false;
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.RowHeadersVisible = false;
            this.appointmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentList.Size = new System.Drawing.Size(776, 348);
            this.appointmentList.TabIndex = 0;
            // 
            // addApptBtn
            // 
            this.addApptBtn.Location = new System.Drawing.Point(461, 385);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(105, 35);
            this.addApptBtn.TabIndex = 3;
            this.addApptBtn.Text = "Add Appointment";
            this.addApptBtn.UseVisualStyleBackColor = true;
            this.addApptBtn.Click += new System.EventHandler(this.addApptBtn_Click);
            // 
            // modApptBtn
            // 
            this.modApptBtn.Location = new System.Drawing.Point(572, 385);
            this.modApptBtn.Name = "modApptBtn";
            this.modApptBtn.Size = new System.Drawing.Size(105, 35);
            this.modApptBtn.TabIndex = 4;
            this.modApptBtn.Text = "Modify Appointment";
            this.modApptBtn.UseVisualStyleBackColor = true;
            this.modApptBtn.Click += new System.EventHandler(this.modApptBtn_Click);
            // 
            // delApptBtn
            // 
            this.delApptBtn.Location = new System.Drawing.Point(683, 385);
            this.delApptBtn.Name = "delApptBtn";
            this.delApptBtn.Size = new System.Drawing.Size(105, 35);
            this.delApptBtn.TabIndex = 5;
            this.delApptBtn.Text = "Delete Appointment";
            this.delApptBtn.UseVisualStyleBackColor = true;
            this.delApptBtn.Click += new System.EventHandler(this.delApptBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 385);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(105, 35);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(C969Assessment.Appointment);
            // 
            // AppointmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.delApptBtn);
            this.Controls.Add(this.modApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Controls.Add(this.appointmentList);
            this.Name = "AppointmentScreen";
            this.Text = "Appointments";
            this.Enter += new System.EventHandler(this.AppointmentScreen_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addApptBtn;
        private System.Windows.Forms.Button modApptBtn;
        private System.Windows.Forms.Button delApptBtn;
        public System.Windows.Forms.DataGridView appointmentList;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Button refreshBtn;
    }
}