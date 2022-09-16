namespace CarRental_OOP2
{
    partial class CarRentalForm
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.nudKilometers = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNeedsCleaning = new System.Windows.Forms.CheckBox();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 97);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(504, 166);
            this.txtResult.TabIndex = 17;
            this.txtResult.TabStop = false;
            // 
            // cbCarType
            // 
            this.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Location = new System.Drawing.Point(67, 12);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(350, 21);
            this.cbCarType.TabIndex = 0;
            this.cbCarType.SelectedIndexChanged += new System.EventHandler(this.cbCarType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Car type:";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(423, 10);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(96, 23);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(423, 39);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // nudKilometers
            // 
            this.nudKilometers.Location = new System.Drawing.Point(319, 42);
            this.nudKilometers.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKilometers.Name = "nudKilometers";
            this.nudKilometers.Size = new System.Drawing.Size(98, 20);
            this.nudKilometers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Returned with kilometers:";
            // 
            // cbNeedsCleaning
            // 
            this.cbNeedsCleaning.AutoCheck = false;
            this.cbNeedsCleaning.AutoSize = true;
            this.cbNeedsCleaning.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbNeedsCleaning.Checked = true;
            this.cbNeedsCleaning.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbNeedsCleaning.Location = new System.Drawing.Point(294, 72);
            this.cbNeedsCleaning.Name = "cbNeedsCleaning";
            this.cbNeedsCleaning.Size = new System.Drawing.Size(123, 17);
            this.cbNeedsCleaning.TabIndex = 25;
            this.cbNeedsCleaning.TabStop = false;
            this.cbNeedsCleaning.Text = "Car needs cleaning: ";
            this.cbNeedsCleaning.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(423, 68);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(96, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // CarRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 275);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.cbNeedsCleaning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudKilometers);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.txtResult);
            this.Name = "CarRentalForm";
            this.Text = "Car Rental";
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.NumericUpDown nudKilometers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbNeedsCleaning;
        private System.Windows.Forms.Button btnClean;
    }
}

