namespace Devin_Perdue_Software2
{
    partial class Add_Customer
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
            this.label7 = new System.Windows.Forms.Label();
            this.cancelCustomer = new System.Windows.Forms.Button();
            this.saveCustomer = new System.Windows.Forms.Button();
            this.customerCountryName = new System.Windows.Forms.TextBox();
            this.customerCityName = new System.Windows.Forms.TextBox();
            this.customerPhoneNumber = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add Customer Information:";
            // 
            // cancelCustomer
            // 
            this.cancelCustomer.Location = new System.Drawing.Point(190, 356);
            this.cancelCustomer.Name = "cancelCustomer";
            this.cancelCustomer.Size = new System.Drawing.Size(75, 23);
            this.cancelCustomer.TabIndex = 28;
            this.cancelCustomer.Text = "Cancel";
            this.cancelCustomer.UseVisualStyleBackColor = true;
            this.cancelCustomer.Click += new System.EventHandler(this.cancelCustomer_Click);
            // 
            // saveCustomer
            // 
            this.saveCustomer.Location = new System.Drawing.Point(62, 356);
            this.saveCustomer.Name = "saveCustomer";
            this.saveCustomer.Size = new System.Drawing.Size(75, 23);
            this.saveCustomer.TabIndex = 27;
            this.saveCustomer.Text = "Save";
            this.saveCustomer.UseVisualStyleBackColor = true;
            this.saveCustomer.Click += new System.EventHandler(this.saveCustomer_Click);
            // 
            // customerCountryName
            // 
            this.customerCountryName.Location = new System.Drawing.Point(126, 297);
            this.customerCountryName.Name = "customerCountryName";
            this.customerCountryName.Size = new System.Drawing.Size(100, 20);
            this.customerCountryName.TabIndex = 26;
            this.customerCountryName.TextChanged += new System.EventHandler(this.customerCountryName_TextChanged);
            // 
            // customerCityName
            // 
            this.customerCityName.Location = new System.Drawing.Point(126, 246);
            this.customerCityName.Name = "customerCityName";
            this.customerCityName.Size = new System.Drawing.Size(100, 20);
            this.customerCityName.TabIndex = 25;
            this.customerCityName.TextChanged += new System.EventHandler(this.customerCityName_TextChanged);
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.Location = new System.Drawing.Point(126, 202);
            this.customerPhoneNumber.Name = "customerPhoneNumber";
            this.customerPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.customerPhoneNumber.TabIndex = 24;
            this.customerPhoneNumber.TextChanged += new System.EventHandler(this.customerPhoneNumber_TextChanged);
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(126, 167);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(100, 20);
            this.customerAddress.TabIndex = 23;
            this.customerAddress.TextChanged += new System.EventHandler(this.customerAddress_TextChanged);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(126, 120);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(100, 20);
            this.customerName.TabIndex = 22;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Country Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "City Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customer Name";
            // 
            // customerID
            // 
            this.customerID.Enabled = false;
            this.customerID.Location = new System.Drawing.Point(126, 82);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(100, 20);
            this.customerID.TabIndex = 16;
            this.customerID.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer ID";
            // 
            // Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 486);
            this.Controls.Add(this.cancelCustomer);
            this.Controls.Add(this.saveCustomer);
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
            this.Controls.Add(this.label7);
            this.Name = "Add_Customer";
            this.Text = "Add_Customer";
            this.Load += new System.EventHandler(this.Add_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelCustomer;
        private System.Windows.Forms.Button saveCustomer;
        private System.Windows.Forms.TextBox customerCountryName;
        private System.Windows.Forms.TextBox customerCityName;
        private System.Windows.Forms.TextBox customerPhoneNumber;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label1;
    }
}