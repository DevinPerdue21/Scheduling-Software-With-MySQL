namespace Devin_Perdue_Software2
{
    partial class Generate_Schedule
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
            this.reportDGV = new System.Windows.Forms.DataGridView();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateSchedule = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDGV
            // 
            this.reportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.reportDGV.Location = new System.Drawing.Point(409, 92);
            this.reportDGV.Name = "reportDGV";
            this.reportDGV.Size = new System.Drawing.Size(418, 254);
            this.reportDGV.TabIndex = 6;
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(16, 92);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(121, 21);
            this.userComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please Select a User to Generate a Schedule For:";
            // 
            // generateSchedule
            // 
            this.generateSchedule.Location = new System.Drawing.Point(16, 149);
            this.generateSchedule.Name = "generateSchedule";
            this.generateSchedule.Size = new System.Drawing.Size(75, 23);
            this.generateSchedule.TabIndex = 9;
            this.generateSchedule.Text = "Generate";
            this.generateSchedule.UseVisualStyleBackColor = true;
            this.generateSchedule.Click += new System.EventHandler(this.generateSchedule_Click);
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
            this.cancel.Location = new System.Drawing.Point(752, 381);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Generate_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 466);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.generateSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.reportDGV);
            this.Name = "Generate_Schedule";
            this.Text = "Generate_Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDGV;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button cancel;
    }
}