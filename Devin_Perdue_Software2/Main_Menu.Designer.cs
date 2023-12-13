namespace Devin_Perdue_Software2
{
    partial class Main_Menu
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
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.addCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.appointmentDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteAppointment = new System.Windows.Forms.Button();
            this.updateAppointment = new System.Windows.Forms.Button();
            this.addAppointment = new System.Windows.Forms.Button();
            this.filterAppointments = new System.Windows.Forms.Button();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDGV
            // 
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.customerDGV.Location = new System.Drawing.Point(22, 82);
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.Size = new System.Drawing.Size(643, 270);
            this.customerDGV.TabIndex = 0;
            this.customerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Customer);
            this.customerDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "customerId";
            this.Column6.HeaderText = "Customer ID";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "customerName";
            this.Column1.HeaderText = "Customer Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "address";
            this.Column2.HeaderText = "Address";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "phone";
            this.Column3.HeaderText = "Phone Number";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "city";
            this.Column4.HeaderText = "City";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "country";
            this.Column5.HeaderText = "Country";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "addressId";
            this.Column7.HeaderText = "AddressId";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "cityId";
            this.Column8.HeaderText = "CityId";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "countryId";
            this.Column9.HeaderText = "CountryId";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customers";
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(428, 372);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(75, 23);
            this.addCustomer.TabIndex = 4;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Location = new System.Drawing.Point(509, 372);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(75, 23);
            this.updateCustomer.TabIndex = 5;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(590, 372);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.deleteCustomer.TabIndex = 6;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // appointmentDGV
            // 
            this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column15,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.appointmentDGV.Location = new System.Drawing.Point(22, 436);
            this.appointmentDGV.Name = "appointmentDGV";
            this.appointmentDGV.Size = new System.Drawing.Size(668, 258);
            this.appointmentDGV.TabIndex = 7;
            this.appointmentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Appointment);
            this.appointmentDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.customerDataBinding);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Appointments";
            // 
            // deleteAppointment
            // 
            this.deleteAppointment.Location = new System.Drawing.Point(615, 714);
            this.deleteAppointment.Name = "deleteAppointment";
            this.deleteAppointment.Size = new System.Drawing.Size(75, 23);
            this.deleteAppointment.TabIndex = 11;
            this.deleteAppointment.Text = "Delete";
            this.deleteAppointment.UseVisualStyleBackColor = true;
            this.deleteAppointment.Click += new System.EventHandler(this.deleteAppointment_Click);
            // 
            // updateAppointment
            // 
            this.updateAppointment.Location = new System.Drawing.Point(534, 714);
            this.updateAppointment.Name = "updateAppointment";
            this.updateAppointment.Size = new System.Drawing.Size(75, 23);
            this.updateAppointment.TabIndex = 10;
            this.updateAppointment.Text = "Update";
            this.updateAppointment.UseVisualStyleBackColor = true;
            this.updateAppointment.Click += new System.EventHandler(this.updateAppointment_Click);
            // 
            // addAppointment
            // 
            this.addAppointment.Location = new System.Drawing.Point(453, 714);
            this.addAppointment.Name = "addAppointment";
            this.addAppointment.Size = new System.Drawing.Size(75, 23);
            this.addAppointment.TabIndex = 9;
            this.addAppointment.Text = "Add";
            this.addAppointment.UseVisualStyleBackColor = true;
            this.addAppointment.Click += new System.EventHandler(this.addAppointment_Click);
            // 
            // filterAppointments
            // 
            this.filterAppointments.Location = new System.Drawing.Point(453, 756);
            this.filterAppointments.Name = "filterAppointments";
            this.filterAppointments.Size = new System.Drawing.Size(75, 23);
            this.filterAppointments.TabIndex = 12;
            this.filterAppointments.Text = "Filter";
            this.filterAppointments.UseVisualStyleBackColor = true;
            this.filterAppointments.Click += new System.EventHandler(this.filterAppointments_Click);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "userId";
            this.Column10.HeaderText = "User ID";
            this.Column10.Name = "Column10";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "appointmentId";
            this.Column15.HeaderText = "Appointment ID";
            this.Column15.Name = "Column15";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "customerId";
            this.Column11.HeaderText = "Customer ID";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "customerName";
            this.Column12.HeaderText = "Customer Name";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "type";
            this.Column13.HeaderText = "Appointment Type";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "start";
            this.Column14.HeaderText = "Meeting Time";
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(534, 756);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 13;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 809);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.filterAppointments);
            this.Controls.Add(this.deleteAppointment);
            this.Controls.Add(this.updateAppointment);
            this.Controls.Add(this.addAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appointmentDGV);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerDGV);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView appointmentDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteAppointment;
        private System.Windows.Forms.Button updateAppointment;
        private System.Windows.Forms.Button addAppointment;
        private System.Windows.Forms.Button filterAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button reportButton;
    }
}