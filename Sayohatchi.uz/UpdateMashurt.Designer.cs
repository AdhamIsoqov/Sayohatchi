namespace Sayohatchi.uz
{
    partial class UpdateMashurt
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
            this.BudgetNumeric = new System.Windows.Forms.NumericUpDown();
            this.UpdateTripBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TripNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sayohatchini yangilish";
            // 
            // BudgetNumeric
            // 
            this.BudgetNumeric.Location = new System.Drawing.Point(413, 298);
            this.BudgetNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.BudgetNumeric.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BudgetNumeric.Name = "BudgetNumeric";
            this.BudgetNumeric.Size = new System.Drawing.Size(274, 30);
            this.BudgetNumeric.TabIndex = 35;
            this.BudgetNumeric.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // UpdateTripBtn
            // 
            this.UpdateTripBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.UpdateTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTripBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateTripBtn.Location = new System.Drawing.Point(350, 362);
            this.UpdateTripBtn.Name = "UpdateTripBtn";
            this.UpdateTripBtn.Size = new System.Drawing.Size(134, 36);
            this.UpdateTripBtn.TabIndex = 34;
            this.UpdateTripBtn.Text = "Yangilash";
            this.UpdateTripBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Byujet summasi";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(413, 261);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.EndDateTimePicker.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tugash sanasi";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(413, 219);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.StartDateTimePicker.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Boshlanish sanasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sayohat Nomi";
            // 
            // TripNameComboBox
            // 
            this.TripNameComboBox.FormattingEnabled = true;
            this.TripNameComboBox.Location = new System.Drawing.Point(413, 180);
            this.TripNameComboBox.Name = "TripNameComboBox";
            this.TripNameComboBox.Size = new System.Drawing.Size(274, 33);
            this.TripNameComboBox.TabIndex = 36;
            // 
            // UpdateMashurt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.TripNameComboBox);
            this.Controls.Add(this.BudgetNumeric);
            this.Controls.Add(this.UpdateTripBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateMashurt";
            this.Text = "UpdateMashurt";
            this.Load += new System.EventHandler(this.UpdateMashurt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BudgetNumeric;
        private System.Windows.Forms.Button UpdateTripBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TripNameComboBox;
    }
}