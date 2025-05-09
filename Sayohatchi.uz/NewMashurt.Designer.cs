﻿namespace Sayohatchi.uz
{
    partial class NewMashurt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TripNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.AddTripBtn = new System.Windows.Forms.Button();
            this.BudgetNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sayohatchilarni ko\'rish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sayohat Nomi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Boshlanish sanasi";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(399, 219);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.StartDateTimePicker.TabIndex = 19;
            // 
            // TripNametxt
            // 
            this.TripNametxt.Location = new System.Drawing.Point(399, 183);
            this.TripNametxt.Name = "TripNametxt";
            this.TripNametxt.Size = new System.Drawing.Size(274, 30);
            this.TripNametxt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tugash sanasi";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(399, 261);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(274, 30);
            this.EndDateTimePicker.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Byujet summasi";
            // 
            // AddTripBtn
            // 
            this.AddTripBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.AddTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTripBtn.ForeColor = System.Drawing.Color.White;
            this.AddTripBtn.Location = new System.Drawing.Point(336, 362);
            this.AddTripBtn.Name = "AddTripBtn";
            this.AddTripBtn.Size = new System.Drawing.Size(134, 36);
            this.AddTripBtn.TabIndex = 25;
            this.AddTripBtn.Text = "Qo\'shish";
            this.AddTripBtn.UseVisualStyleBackColor = false;
            this.AddTripBtn.Click += new System.EventHandler(this.AddTripBtn_Click);
            // 
            // BudgetNumeric
            // 
            this.BudgetNumeric.Location = new System.Drawing.Point(399, 298);
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
            this.BudgetNumeric.TabIndex = 26;
            this.BudgetNumeric.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // NewMashurt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.BudgetNumeric);
            this.Controls.Add(this.AddTripBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TripNametxt);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewMashurt";
            this.Text = "NewMashurt";
            this.Load += new System.EventHandler(this.NewMashurt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.TextBox TripNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddTripBtn;
        private System.Windows.Forms.NumericUpDown BudgetNumeric;
    }
}