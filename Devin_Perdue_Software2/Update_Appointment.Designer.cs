namespace Devin_Perdue_Software2
{
    partial class Update_Appointment
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
            this.cancelAppointment = new System.Windows.Forms.Button();
            this.saveAppointment = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.typeOfAppointment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.customerNamesCombo = new System.Windows.Forms.ComboBox();
            this.appointmentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelAppointment
            // 
            this.cancelAppointment.Location = new System.Drawing.Point(201, 381);
            this.cancelAppointment.Name = "cancelAppointment";
            this.cancelAppointment.Size = new System.Drawing.Size(75, 23);
            this.cancelAppointment.TabIndex = 29;
            this.cancelAppointment.Text = "Cancel";
            this.cancelAppointment.UseVisualStyleBackColor = true;
            this.cancelAppointment.Click += new System.EventHandler(this.cancelAppointment_Click);
            // 
            // saveAppointment
            // 
            this.saveAppointment.Location = new System.Drawing.Point(73, 381);
            this.saveAppointment.Name = "saveAppointment";
            this.saveAppointment.Size = new System.Drawing.Size(75, 23);
            this.saveAppointment.TabIndex = 28;
            this.saveAppointment.Text = "Save";
            this.saveAppointment.UseVisualStyleBackColor = true;
            this.saveAppointment.Click += new System.EventHandler(this.saveAppointment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Update Appointment";
            // 
            // typeOfAppointment
            // 
            this.typeOfAppointment.Location = new System.Drawing.Point(160, 223);
            this.typeOfAppointment.Name = "typeOfAppointment";
            this.typeOfAppointment.Size = new System.Drawing.Size(100, 20);
            this.typeOfAppointment.TabIndex = 23;
            this.typeOfAppointment.TextChanged += new System.EventHandler(this.typeOfAppointment_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Type of Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customer Name";
            // 
            // userID
            // 
            this.userID.Enabled = false;
            this.userID.Location = new System.Drawing.Point(160, 91);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 20);
            this.userID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "User ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // customerNamesCombo
            // 
            this.customerNamesCombo.FormattingEnabled = true;
            this.customerNamesCombo.Location = new System.Drawing.Point(160, 176);
            this.customerNamesCombo.Name = "customerNamesCombo";
            this.customerNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.customerNamesCombo.TabIndex = 31;
            // 
            // appointmentID
            // 
            this.appointmentID.Enabled = false;
            this.appointmentID.Location = new System.Drawing.Point(160, 137);
            this.appointmentID.Name = "appointmentID";
            this.appointmentID.Size = new System.Drawing.Size(100, 20);
            this.appointmentID.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Appointment ID";
            // 
            // Update_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appointmentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerNamesCombo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancelAppointment);
            this.Controls.Add(this.saveAppointment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.typeOfAppointment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label1);
            this.Name = "Update_Appointment";
            this.Text = "Update_Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAppointment;
        private System.Windows.Forms.Button saveAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeOfAppointment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox customerNamesCombo;
        private System.Windows.Forms.TextBox appointmentID;
        private System.Windows.Forms.Label label5;
    }
}