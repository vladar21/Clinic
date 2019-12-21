namespace Clinic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnApp = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.comboBoxChooseStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxChooseIDpatients = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChooseIDdocs = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinic";
            // 
            // btnApp
            // 
            this.btnApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApp.Location = new System.Drawing.Point(115, 146);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(116, 31);
            this.btnApp.TabIndex = 1;
            this.btnApp.Text = "Appointments to the doctor";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(115, 212);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(116, 31);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Registration";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // comboBoxChooseStatus
            // 
            this.comboBoxChooseStatus.FormattingEnabled = true;
            this.comboBoxChooseStatus.Location = new System.Drawing.Point(180, 88);
            this.comboBoxChooseStatus.Name = "comboBoxChooseStatus";
            this.comboBoxChooseStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseStatus.TabIndex = 8;
            this.comboBoxChooseStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(51, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patient or Doc?";
            // 
            // comboBoxChooseIDpatients
            // 
            this.comboBoxChooseIDpatients.FormattingEnabled = true;
            this.comboBoxChooseIDpatients.Location = new System.Drawing.Point(179, 114);
            this.comboBoxChooseIDpatients.Name = "comboBoxChooseIDpatients";
            this.comboBoxChooseIDpatients.Size = new System.Drawing.Size(44, 21);
            this.comboBoxChooseIDpatients.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose your ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "If you don\'t have ID, you have to register:";
            // 
            // comboBoxChooseIDdocs
            // 
            this.comboBoxChooseIDdocs.FormattingEnabled = true;
            this.comboBoxChooseIDdocs.Location = new System.Drawing.Point(179, 114);
            this.comboBoxChooseIDdocs.Name = "comboBoxChooseIDdocs";
            this.comboBoxChooseIDdocs.Size = new System.Drawing.Size(44, 21);
            this.comboBoxChooseIDdocs.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(87, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "CommonSchedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxChooseIDdocs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxChooseIDpatients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxChooseStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ComboBox comboBoxChooseStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxChooseIDpatients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxChooseIDdocs;
        private System.Windows.Forms.Button button1;
    }
}

