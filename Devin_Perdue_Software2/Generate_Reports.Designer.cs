namespace Devin_Perdue_Software2
{
    partial class Generate_Reports
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
            this.apptByMonth = new System.Windows.Forms.RadioButton();
            this.scheduleForUser = new System.Windows.Forms.RadioButton();
            this.numberOfAppointments = new System.Windows.Forms.RadioButton();
            this.reportTxt = new System.Windows.Forms.TextBox();
            this.reportDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // apptByMonth
            // 
            this.apptByMonth.AutoSize = true;
            this.apptByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptByMonth.Location = new System.Drawing.Point(16, 83);
            this.apptByMonth.Name = "apptByMonth";
            this.apptByMonth.Size = new System.Drawing.Size(197, 24);
            this.apptByMonth.TabIndex = 0;
            this.apptByMonth.TabStop = true;
            this.apptByMonth.Text = "Appointments By Month";
            this.apptByMonth.UseVisualStyleBackColor = true;
            this.apptByMonth.CheckedChanged += new System.EventHandler(this.apptByMonth_CheckedChanged);
            // 
            // scheduleForUser
            // 
            this.scheduleForUser.AutoSize = true;
            this.scheduleForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleForUser.Location = new System.Drawing.Point(12, 141);
            this.scheduleForUser.Name = "scheduleForUser";
            this.scheduleForUser.Size = new System.Drawing.Size(201, 24);
            this.scheduleForUser.TabIndex = 1;
            this.scheduleForUser.TabStop = true;
            this.scheduleForUser.Text = "Schedule For Each User";
            this.scheduleForUser.UseVisualStyleBackColor = true;
            this.scheduleForUser.CheckedChanged += new System.EventHandler(this.scheduleForUser_CheckedChanged);
            // 
            // numberOfAppointments
            // 
            this.numberOfAppointments.AutoSize = true;
            this.numberOfAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfAppointments.Location = new System.Drawing.Point(12, 204);
            this.numberOfAppointments.Name = "numberOfAppointments";
            this.numberOfAppointments.Size = new System.Drawing.Size(243, 24);
            this.numberOfAppointments.TabIndex = 2;
            this.numberOfAppointments.TabStop = true;
            this.numberOfAppointments.Text = "Total Number of Appointments";
            this.numberOfAppointments.UseVisualStyleBackColor = true;
            this.numberOfAppointments.CheckedChanged += new System.EventHandler(this.numberOfAppointments_CheckedChanged);
            // 
            // reportTxt
            // 
            this.reportTxt.Location = new System.Drawing.Point(273, 286);
            this.reportTxt.Multiline = true;
            this.reportTxt.Name = "reportTxt";
            this.reportTxt.ReadOnly = true;
            this.reportTxt.Size = new System.Drawing.Size(420, 279);
            this.reportTxt.TabIndex = 3;
            // 
            // reportDGV
            // 
            this.reportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.reportDGV.Location = new System.Drawing.Point(273, 28);
            this.reportDGV.Name = "reportDGV";
            this.reportDGV.Size = new System.Drawing.Size(420, 252);
            this.reportDGV.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "appointmentId";
            this.Column1.HeaderText = "Appointment ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "type";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "start";
            this.Column3.HeaderText = "Start";
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(618, 584);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Generate_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 631);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.reportDGV);
            this.Controls.Add(this.reportTxt);
            this.Controls.Add(this.numberOfAppointments);
            this.Controls.Add(this.scheduleForUser);
            this.Controls.Add(this.apptByMonth);
            this.Name = "Generate_Reports";
            this.Text = "Generate_Reports";
            this.Load += new System.EventHandler(this.Generate_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton apptByMonth;
        private System.Windows.Forms.RadioButton scheduleForUser;
        private System.Windows.Forms.RadioButton numberOfAppointments;
        private System.Windows.Forms.TextBox reportTxt;
        private System.Windows.Forms.DataGridView reportDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button cancel;
    }
}