
namespace C969Assessment
{
    partial class ReportsScreen
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
            this.apptTypeReportBtn = new System.Windows.Forms.Button();
            this.userSchedBtn = new System.Windows.Forms.Button();
            this.custSchedBtn = new System.Windows.Forms.Button();
            this.userSelectBox = new System.Windows.Forms.ComboBox();
            this.custSelectBox = new System.Windows.Forms.ComboBox();
            this.monthSelectBox = new System.Windows.Forms.ComboBox();
            this.ReportViewer = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.apptCountBox = new System.Windows.Forms.RichTextBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.dateTimeStamp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // apptTypeReportBtn
            // 
            this.apptTypeReportBtn.Location = new System.Drawing.Point(12, 19);
            this.apptTypeReportBtn.Name = "apptTypeReportBtn";
            this.apptTypeReportBtn.Size = new System.Drawing.Size(121, 80);
            this.apptTypeReportBtn.TabIndex = 0;
            this.apptTypeReportBtn.Text = "Appointment Types by Month";
            this.apptTypeReportBtn.UseVisualStyleBackColor = true;
            this.apptTypeReportBtn.Click += new System.EventHandler(this.apptTypeReportBtn_Click);
            // 
            // userSchedBtn
            // 
            this.userSchedBtn.Location = new System.Drawing.Point(12, 168);
            this.userSchedBtn.Name = "userSchedBtn";
            this.userSchedBtn.Size = new System.Drawing.Size(121, 80);
            this.userSchedBtn.TabIndex = 1;
            this.userSchedBtn.Text = "User Schedule";
            this.userSchedBtn.UseVisualStyleBackColor = true;
            this.userSchedBtn.Click += new System.EventHandler(this.userSchedBtn_Click);
            // 
            // custSchedBtn
            // 
            this.custSchedBtn.Location = new System.Drawing.Point(12, 324);
            this.custSchedBtn.Name = "custSchedBtn";
            this.custSchedBtn.Size = new System.Drawing.Size(121, 80);
            this.custSchedBtn.TabIndex = 2;
            this.custSchedBtn.Text = "Customer Schedule";
            this.custSchedBtn.UseVisualStyleBackColor = true;
            this.custSchedBtn.Click += new System.EventHandler(this.custSchedBtn_Click);
            // 
            // userSelectBox
            // 
            this.userSelectBox.FormattingEnabled = true;
            this.userSelectBox.Location = new System.Drawing.Point(12, 254);
            this.userSelectBox.Name = "userSelectBox";
            this.userSelectBox.Size = new System.Drawing.Size(121, 21);
            this.userSelectBox.TabIndex = 3;
            // 
            // custSelectBox
            // 
            this.custSelectBox.FormattingEnabled = true;
            this.custSelectBox.Location = new System.Drawing.Point(12, 410);
            this.custSelectBox.Name = "custSelectBox";
            this.custSelectBox.Size = new System.Drawing.Size(121, 21);
            this.custSelectBox.TabIndex = 4;
            // 
            // monthSelectBox
            // 
            this.monthSelectBox.FormattingEnabled = true;
            this.monthSelectBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthSelectBox.Location = new System.Drawing.Point(12, 105);
            this.monthSelectBox.Name = "monthSelectBox";
            this.monthSelectBox.Size = new System.Drawing.Size(121, 21);
            this.monthSelectBox.TabIndex = 5;
            // 
            // ReportViewer
            // 
            this.ReportViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportViewer.Location = new System.Drawing.Point(218, 19);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.Size = new System.Drawing.Size(557, 385);
            this.ReportViewer.TabIndex = 6;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(700, 415);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // apptCountBox
            // 
            this.apptCountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptCountBox.Location = new System.Drawing.Point(218, 19);
            this.apptCountBox.Name = "apptCountBox";
            this.apptCountBox.Size = new System.Drawing.Size(557, 385);
            this.apptCountBox.TabIndex = 10;
            this.apptCountBox.Text = "";
            this.apptCountBox.Visible = false;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(588, 415);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(106, 23);
            this.downloadBtn.TabIndex = 11;
            this.downloadBtn.Text = "Download Report";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // dateTimeStamp
            // 
            this.dateTimeStamp.AutoSize = true;
            this.dateTimeStamp.Location = new System.Drawing.Point(215, 418);
            this.dateTimeStamp.Name = "dateTimeStamp";
            this.dateTimeStamp.Size = new System.Drawing.Size(0, 13);
            this.dateTimeStamp.TabIndex = 12;
            // 
            // ReportsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeStamp);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.apptCountBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.ReportViewer);
            this.Controls.Add(this.monthSelectBox);
            this.Controls.Add(this.custSelectBox);
            this.Controls.Add(this.userSelectBox);
            this.Controls.Add(this.custSchedBtn);
            this.Controls.Add(this.userSchedBtn);
            this.Controls.Add(this.apptTypeReportBtn);
            this.Name = "ReportsScreen";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apptTypeReportBtn;
        private System.Windows.Forms.Button userSchedBtn;
        private System.Windows.Forms.Button custSchedBtn;
        private System.Windows.Forms.ComboBox userSelectBox;
        private System.Windows.Forms.ComboBox custSelectBox;
        private System.Windows.Forms.ComboBox monthSelectBox;
        private System.Windows.Forms.DataGridView ReportViewer;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox apptCountBox;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Label dateTimeStamp;
    }
}