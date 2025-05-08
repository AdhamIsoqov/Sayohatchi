namespace Sayohatchi.uz
{
    partial class NewCosts
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TripName = new System.Windows.Forms.ComboBox();
            this.TravelersFISH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CostsDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TripsBudget = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpenseAmount = new System.Windows.Forms.Label();
            this.DeleteCostBtn = new System.Windows.Forms.Button();
            this.UpdateCostBtn = new System.Windows.Forms.Button();
            this.AddNewCostBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExpenseNameTxt = new System.Windows.Forms.TextBox();
            this.ExpenseAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseIdColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CostsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Xarajatlarni qo\'shish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sayohat nomi";
            // 
            // TripName
            // 
            this.TripName.FormattingEnabled = true;
            this.TripName.Location = new System.Drawing.Point(216, 110);
            this.TripName.Name = "TripName";
            this.TripName.Size = new System.Drawing.Size(247, 33);
            this.TripName.TabIndex = 18;
            this.TripName.SelectedIndexChanged += new System.EventHandler(this.TripName_SelectedIndexChanged);
            // 
            // TravelersFISH
            // 
            this.TravelersFISH.FormattingEnabled = true;
            this.TravelersFISH.Location = new System.Drawing.Point(633, 113);
            this.TravelersFISH.Name = "TravelersFISH";
            this.TravelersFISH.Size = new System.Drawing.Size(247, 33);
            this.TravelersFISH.TabIndex = 20;
            this.TravelersFISH.SelectedIndexChanged += new System.EventHandler(this.TravelersFISH_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sayohatchi ismi";
            // 
            // CostsDataGridView
            // 
            this.CostsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CostsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2,
            this.ExpenseIdColum});
            this.CostsDataGridView.Location = new System.Drawing.Point(66, 156);
            this.CostsDataGridView.Name = "CostsDataGridView";
            this.CostsDataGridView.RowHeadersWidth = 51;
            this.CostsDataGridView.RowTemplate.Height = 24;
            this.CostsDataGridView.Size = new System.Drawing.Size(814, 259);
            this.CostsDataGridView.TabIndex = 21;
            this.CostsDataGridView.SelectionChanged += new System.EventHandler(this.CostsDataGridView_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Byujet :";
            // 
            // TripsBudget
            // 
            this.TripsBudget.AutoSize = true;
            this.TripsBudget.Location = new System.Drawing.Point(133, 484);
            this.TripsBudget.Name = "TripsBudget";
            this.TripsBudget.Size = new System.Drawing.Size(42, 25);
            this.TripsBudget.TabIndex = 23;
            this.TripsBudget.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Xarajatlar : ";
            // 
            // ExpenseAmount
            // 
            this.ExpenseAmount.AutoSize = true;
            this.ExpenseAmount.Location = new System.Drawing.Point(354, 484);
            this.ExpenseAmount.Name = "ExpenseAmount";
            this.ExpenseAmount.Size = new System.Drawing.Size(42, 25);
            this.ExpenseAmount.TabIndex = 25;
            this.ExpenseAmount.Text = "null";
            // 
            // DeleteCostBtn
            // 
            this.DeleteCostBtn.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteCostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCostBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteCostBtn.Location = new System.Drawing.Point(755, 478);
            this.DeleteCostBtn.Name = "DeleteCostBtn";
            this.DeleteCostBtn.Size = new System.Drawing.Size(125, 36);
            this.DeleteCostBtn.TabIndex = 38;
            this.DeleteCostBtn.Text = "O\'chirish";
            this.DeleteCostBtn.UseVisualStyleBackColor = false;
            this.DeleteCostBtn.Click += new System.EventHandler(this.DeleteCostBtn_Click);
            // 
            // UpdateCostBtn
            // 
            this.UpdateCostBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.UpdateCostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCostBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateCostBtn.Location = new System.Drawing.Point(624, 478);
            this.UpdateCostBtn.Name = "UpdateCostBtn";
            this.UpdateCostBtn.Size = new System.Drawing.Size(125, 36);
            this.UpdateCostBtn.TabIndex = 40;
            this.UpdateCostBtn.Text = "Yangilash";
            this.UpdateCostBtn.UseVisualStyleBackColor = false;
            this.UpdateCostBtn.Click += new System.EventHandler(this.UpdateCostBtn_Click);
            // 
            // AddNewCostBtn
            // 
            this.AddNewCostBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.AddNewCostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewCostBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewCostBtn.Location = new System.Drawing.Point(493, 478);
            this.AddNewCostBtn.Name = "AddNewCostBtn";
            this.AddNewCostBtn.Size = new System.Drawing.Size(125, 36);
            this.AddNewCostBtn.TabIndex = 41;
            this.AddNewCostBtn.Text = "Qo\'shish";
            this.AddNewCostBtn.UseVisualStyleBackColor = false;
            this.AddNewCostBtn.Click += new System.EventHandler(this.AddNewCostBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Xarajat nomi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Xarajat summasi";
            // 
            // ExpenseNameTxt
            // 
            this.ExpenseNameTxt.Location = new System.Drawing.Point(199, 439);
            this.ExpenseNameTxt.Name = "ExpenseNameTxt";
            this.ExpenseNameTxt.Size = new System.Drawing.Size(264, 30);
            this.ExpenseNameTxt.TabIndex = 44;
            // 
            // ExpenseAmountNumericUpDown
            // 
            this.ExpenseAmountNumericUpDown.DecimalPlaces = 2;
            this.ExpenseAmountNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ExpenseAmountNumericUpDown.Location = new System.Drawing.Point(633, 437);
            this.ExpenseAmountNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ExpenseAmountNumericUpDown.Name = "ExpenseAmountNumericUpDown";
            this.ExpenseAmountNumericUpDown.Size = new System.Drawing.Size(247, 30);
            this.ExpenseAmountNumericUpDown.TabIndex = 45;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sayohat nomi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 225;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sayohatchi ismi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 225;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xarajat Nomi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 185;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Xarajat summasi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // ExpenseIdColum
            // 
            this.ExpenseIdColum.HeaderText = "ID";
            this.ExpenseIdColum.MinimumWidth = 6;
            this.ExpenseIdColum.Name = "ExpenseIdColum";
            this.ExpenseIdColum.Width = 125;
            // 
            // NewCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.ExpenseAmountNumericUpDown);
            this.Controls.Add(this.ExpenseNameTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddNewCostBtn);
            this.Controls.Add(this.UpdateCostBtn);
            this.Controls.Add(this.DeleteCostBtn);
            this.Controls.Add(this.ExpenseAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TripsBudget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CostsDataGridView);
            this.Controls.Add(this.TravelersFISH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TripName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewCosts";
            this.Text = "NewCosts";
            this.Load += new System.EventHandler(this.NewCosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CostsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TripName;
        private System.Windows.Forms.ComboBox TravelersFISH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CostsDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TripsBudget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ExpenseAmount;
        private System.Windows.Forms.Button DeleteCostBtn;
        private System.Windows.Forms.Button UpdateCostBtn;
        private System.Windows.Forms.Button AddNewCostBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExpenseNameTxt;
        private System.Windows.Forms.NumericUpDown ExpenseAmountNumericUpDown;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseIdColum;
    }
}