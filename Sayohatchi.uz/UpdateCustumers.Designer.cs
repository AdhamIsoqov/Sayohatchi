namespace Sayohatchi.uz
{
    partial class UpdateCustumers
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
            this.Phonetxtmasked = new System.Windows.Forms.MaskedTextBox();
            this.AgeTxtNumeric = new System.Windows.Forms.NumericUpDown();
            this.UpdateCustumersBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Famale = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.FISHComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTxtNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sayohatchini yangilash";
            // 
            // Phonetxtmasked
            // 
            this.Phonetxtmasked.Location = new System.Drawing.Point(386, 236);
            this.Phonetxtmasked.Mask = "(00) 000-00-00";
            this.Phonetxtmasked.Name = "Phonetxtmasked";
            this.Phonetxtmasked.Size = new System.Drawing.Size(333, 30);
            this.Phonetxtmasked.TabIndex = 24;
            // 
            // AgeTxtNumeric
            // 
            this.AgeTxtNumeric.Location = new System.Drawing.Point(386, 200);
            this.AgeTxtNumeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.AgeTxtNumeric.Name = "AgeTxtNumeric";
            this.AgeTxtNumeric.Size = new System.Drawing.Size(333, 30);
            this.AgeTxtNumeric.TabIndex = 23;
            // 
            // UpdateCustumersBtn
            // 
            this.UpdateCustumersBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.UpdateCustumersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustumersBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateCustumersBtn.Location = new System.Drawing.Point(392, 380);
            this.UpdateCustumersBtn.Name = "UpdateCustumersBtn";
            this.UpdateCustumersBtn.Size = new System.Drawing.Size(134, 36);
            this.UpdateCustumersBtn.TabIndex = 22;
            this.UpdateCustumersBtn.Text = "Yangilash";
            this.UpdateCustumersBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Famale);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Location = new System.Drawing.Point(386, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 25);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Famale
            // 
            this.Famale.AutoSize = true;
            this.Famale.Location = new System.Drawing.Point(255, -2);
            this.Famale.Name = "Famale";
            this.Famale.Size = new System.Drawing.Size(72, 29);
            this.Famale.TabIndex = 1;
            this.Famale.TabStop = true;
            this.Famale.Text = "Ayol";
            this.Famale.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(6, 0);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(83, 29);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "Erkak";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Jinsi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-Pochta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefon raqam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Yosh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "F.I.SH";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(386, 272);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(333, 30);
            this.Emailtxt.TabIndex = 25;
            // 
            // FISHComboBox
            // 
            this.FISHComboBox.FormattingEnabled = true;
            this.FISHComboBox.Location = new System.Drawing.Point(386, 161);
            this.FISHComboBox.Name = "FISHComboBox";
            this.FISHComboBox.Size = new System.Drawing.Size(333, 33);
            this.FISHComboBox.TabIndex = 26;
            // 
            // UpdateCustumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.FISHComboBox);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Phonetxtmasked);
            this.Controls.Add(this.AgeTxtNumeric);
            this.Controls.Add(this.UpdateCustumersBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateCustumers";
            this.Text = "UpdateCustumers";
            this.Load += new System.EventHandler(this.UpdateCustumers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgeTxtNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Phonetxtmasked;
        private System.Windows.Forms.NumericUpDown AgeTxtNumeric;
        private System.Windows.Forms.Button UpdateCustumersBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Famale;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.ComboBox FISHComboBox;
    }
}