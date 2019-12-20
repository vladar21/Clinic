namespace Clinic
{
    partial class Appointment
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
            this.comboBoxChooseDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAppointmentOk = new System.Windows.Forms.Button();
            this.textBoxYourID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment to the doctor";
            // 
            // comboBoxChooseDoc
            // 
            this.comboBoxChooseDoc.FormattingEnabled = true;
            this.comboBoxChooseDoc.Location = new System.Drawing.Point(198, 66);
            this.comboBoxChooseDoc.Name = "comboBoxChooseDoc";
            this.comboBoxChooseDoc.Size = new System.Drawing.Size(44, 21);
            this.comboBoxChooseDoc.TabIndex = 11;
            this.comboBoxChooseDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseDoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose the doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(84, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Choose the date:";
            // 
            // btnAppointmentOk
            // 
            this.btnAppointmentOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAppointmentOk.Location = new System.Drawing.Point(114, 286);
            this.btnAppointmentOk.Name = "btnAppointmentOk";
            this.btnAppointmentOk.Size = new System.Drawing.Size(75, 31);
            this.btnAppointmentOk.TabIndex = 14;
            this.btnAppointmentOk.Text = "Ok";
            this.btnAppointmentOk.UseVisualStyleBackColor = true;
            this.btnAppointmentOk.Click += new System.EventHandler(this.btnAppointmentOk_Click);
            // 
            // textBoxYourID
            // 
            this.textBoxYourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYourID.Location = new System.Drawing.Point(198, 41);
            this.textBoxYourID.Name = "textBoxYourID";
            this.textBoxYourID.Size = new System.Drawing.Size(41, 24);
            this.textBoxYourID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(129, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Your ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 109);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 12, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 335);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxYourID);
            this.Controls.Add(this.btnAppointmentOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxChooseDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Appointment_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxChooseDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAppointmentOk;
        private System.Windows.Forms.TextBox textBoxYourID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}