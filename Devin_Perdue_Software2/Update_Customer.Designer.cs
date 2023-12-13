namespace Devin_Perdue_Software2
{
    partial class Update_Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.customerPhoneNumber = new System.Windows.Forms.TextBox();
            this.customerCityName = new System.Windows.Forms.TextBox();
            this.customerCountryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveCustomer = new System.Windows.Forms.Button();
            this.cancelCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // customerID
            // 
            this.customerID.Enabled = false;
            this.customerID.Location = new System.Drawing.Point(137, 85);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(100, 20);
            this.customerID.TabIndex = 1;
            this.customerID.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "City Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Country Name";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(137, 139);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(100, 20);
            this.customerName.TabIndex = 7;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(137, 186);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(100, 20);
            this.customerAddress.TabIndex = 8;
            this.customerAddress.TextChanged += new System.EventHandler(this.customerAddress_TextChanged);
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.Location = new System.Drawing.Point(137, 221);
            this.customerPhoneNumber.Name = "customerPhoneNumber";
            this.customerPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.customerPhoneNumber.TabIndex = 9;
            this.customerPhoneNumber.TextChanged += new System.EventHandler(this.customerPhoneNumber_TextChanged);
            // 
            // customerCityName
            // 
            this.customerCityName.Location = new System.Drawing.Point(137, 265);
            this.customerCityName.Name = "customerCityName";
            this.customerCityName.Size = new System.Drawing.Size(100, 20);
            this.customerCityName.TabIndex = 10;
            this.customerCityName.TextChanged += new System.EventHandler(this.customerCityName_TextChanged);
            // 
            // customerCountryName
            // 
            this.customerCountryName.Location = new System.Drawing.Point(137, 316);
            this.customerCountryName.Name = "customerCountryName";
            this.customerCountryName.Size = new System.Drawing.Size(100, 20);
            this.customerCountryName.TabIndex = 11;
            this.customerCountryName.TextChanged += new System.EventHandler(this.customerCountryName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(406, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Update Customer Information:";
            // 
            // saveCustomer
            // 
            this.saveCustomer.Location = new System.Drawing.Point(73, 375);
            this.saveCustomer.Name = "saveCustomer";
            this.saveCustomer.Size = new System.Drawing.Size(75, 23);
            this.saveCustomer.TabIndex = 13;
            this.saveCustomer.Text = "Save";
            this.saveCustomer.UseVisualStyleBackColor = true;
            this.saveCustomer.Click += new System.EventHandler(this.saveCustomer_Click);
            // 
            // cancelCustomer
            // 
            this.cancelCustomer.Location = new System.Drawing.Point(201, 375);
            this.cancelCustomer.Name = "cancelCustomer";
            this.cancelCustomer.Size = new System.Drawing.Size(75, 23);
            this.cancelCustomer.TabIndex = 14;
            this.cancelCustomer.Text = "Cancel";
            this.cancelCustomer.UseVisualStyleBackColor = true;
            this.cancelCustomer.Click += new System.EventHandler(this.cancelCustomer_Click);
            // 
            // Update_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 505);
            this.Controls.Add(this.cancelCustomer);
            this.Controls.Add(this.saveCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customerCountryName);
            this.Controls.Add(this.customerCityName);
            this.Controls.Add(this.customerPhoneNumber);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.label1);
            this.Name = "Update_Customer";
            this.Text = "Update_Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox customerPhoneNumber;
        private System.Windows.Forms.TextBox customerCityName;
        private System.Windows.Forms.TextBox customerCountryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveCustomer;
        private System.Windows.Forms.Button cancelCustomer;
    }
}