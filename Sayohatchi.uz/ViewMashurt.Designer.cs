namespace Sayohatchi.uz
{
    partial class ViewMashurt
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
            this.ViewMashurtDataGridView = new System.Windows.Forms.DataGridView();
            this.TripsIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BudgetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteTripBtn = new System.Windows.Forms.Button();
            this.TripNameTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMashurtDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sayohatchilarni ko\'rish";
            // 
            // ViewMashurtDataGridView
            // 
            this.ViewMashurtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewMashurtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripsIDColumn,
            this.TripNameColumn,
            this.StartDateColumn,
            this.EndDateColumn,
            this.BudgetColumn});
            this.ViewMashurtDataGridView.Location = new System.Drawing.Point(34, 80);
            this.ViewMashurtDataGridView.Name = "ViewMashurtDataGridView";
            this.ViewMashurtDataGridView.RowHeadersWidth = 51;
            this.ViewMashurtDataGridView.RowTemplate.Height = 24;
            this.ViewMashurtDataGridView.Size = new System.Drawing.Size(861, 402);
            this.ViewMashurtDataGridView.TabIndex = 27;
            this.ViewMashurtDataGridView.SelectionChanged += new System.EventHandler(this.ViewMashurtDataGridView_SelectionChanged);
            // 
            // TripsIDColumn
            // 
            this.TripsIDColumn.HeaderText = "ID";
            this.TripsIDColumn.MinimumWidth = 6;
            this.TripsIDColumn.Name = "TripsIDColumn";
            this.TripsIDColumn.Width = 50;
            // 
            // TripNameColumn
            // 
            this.TripNameColumn.HeaderText = "Sayohat nomi";
            this.TripNameColumn.MinimumWidth = 6;
            this.TripNameColumn.Name = "TripNameColumn";
            this.TripNameColumn.Width = 250;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.HeaderText = "Boshlanish sana";
            this.StartDateColumn.MinimumWidth = 6;
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.Width = 200;
            // 
            // EndDateColumn
            // 
            this.EndDateColumn.HeaderText = "Tugash sana";
            this.EndDateColumn.MinimumWidth = 6;
            this.EndDateColumn.Name = "EndDateColumn";
            this.EndDateColumn.Width = 200;
            // 
            // BudgetColumn
            // 
            this.BudgetColumn.HeaderText = "Byujet";
            this.BudgetColumn.MinimumWidth = 6;
            this.BudgetColumn.Name = "BudgetColumn";
            this.BudgetColumn.Width = 150;
            // 
            // DeleteTripBtn
            // 
            this.DeleteTripBtn.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTripBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteTripBtn.Location = new System.Drawing.Point(771, 489);
            this.DeleteTripBtn.Name = "DeleteTripBtn";
            this.DeleteTripBtn.Size = new System.Drawing.Size(125, 36);
            this.DeleteTripBtn.TabIndex = 42;
            this.DeleteTripBtn.Text = "O\'chirish";
            this.DeleteTripBtn.UseVisualStyleBackColor = false;
            this.DeleteTripBtn.Click += new System.EventHandler(this.DeleteTripBtn_Click);
            // 
            // TripNameTxt
            // 
            this.TripNameTxt.AutoSize = true;
            this.TripNameTxt.Location = new System.Drawing.Point(156, 495);
            this.TripNameTxt.Name = "TripNameTxt";
            this.TripNameTxt.Size = new System.Drawing.Size(133, 25);
            this.TripNameTxt.TabIndex = 41;
            this.TripNameTxt.Text = "Tanlanmagan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Sayohatchi ";
            // 
            // ViewMashurt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.DeleteTripBtn);
            this.Controls.Add(this.TripNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewMashurtDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewMashurt";
            this.Text = "ViewMashurt";
            this.Load += new System.EventHandler(this.ViewMashurt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewMashurtDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewMashurtDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripsIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BudgetColumn;
        private System.Windows.Forms.Button DeleteTripBtn;
        private System.Windows.Forms.Label TripNameTxt;
        private System.Windows.Forms.Label label2;
    }
}