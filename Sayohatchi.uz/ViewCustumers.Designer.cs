namespace Sayohatchi.uz
{
    partial class ViewCustumers
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
            this.ViewCustumersDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TravelersFISHTxt = new System.Windows.Forms.Label();
            this.DeleteTravelerBtn = new System.Windows.Forms.Button();
            this.TravelerIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelerFISHColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelerEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelerPhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelerGenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustumersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sayohatchilarni ko\'rish";
            // 
            // ViewCustumersDataGridView
            // 
            this.ViewCustumersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCustumersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TravelerIDColumn,
            this.TravelerFISHColumn,
            this.TravelerEmailColumn,
            this.TravelerPhoneNumberColumn,
            this.TravelerGenderColumn});
            this.ViewCustumersDataGridView.Location = new System.Drawing.Point(32, 84);
            this.ViewCustumersDataGridView.Name = "ViewCustumersDataGridView";
            this.ViewCustumersDataGridView.RowHeadersWidth = 51;
            this.ViewCustumersDataGridView.RowTemplate.Height = 24;
            this.ViewCustumersDataGridView.Size = new System.Drawing.Size(861, 401);
            this.ViewCustumersDataGridView.TabIndex = 15;
            this.ViewCustumersDataGridView.SelectionChanged += new System.EventHandler(this.ViewCustumersDataGridView_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sayohatchi ";
            // 
            // TravelersFISHTxt
            // 
            this.TravelersFISHTxt.AutoSize = true;
            this.TravelersFISHTxt.Location = new System.Drawing.Point(153, 501);
            this.TravelersFISHTxt.Name = "TravelersFISHTxt";
            this.TravelersFISHTxt.Size = new System.Drawing.Size(133, 25);
            this.TravelersFISHTxt.TabIndex = 17;
            this.TravelersFISHTxt.Text = "Tanlanmagan";
            // 
            // DeleteTravelerBtn
            // 
            this.DeleteTravelerBtn.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteTravelerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTravelerBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteTravelerBtn.Location = new System.Drawing.Point(768, 495);
            this.DeleteTravelerBtn.Name = "DeleteTravelerBtn";
            this.DeleteTravelerBtn.Size = new System.Drawing.Size(125, 36);
            this.DeleteTravelerBtn.TabIndex = 39;
            this.DeleteTravelerBtn.Text = "O\'chirish";
            this.DeleteTravelerBtn.UseVisualStyleBackColor = false;
            this.DeleteTravelerBtn.Click += new System.EventHandler(this.DeleteTravelerBtn_Click);
            // 
            // TravelerIDColumn
            // 
            this.TravelerIDColumn.HeaderText = "ID";
            this.TravelerIDColumn.MinimumWidth = 6;
            this.TravelerIDColumn.Name = "TravelerIDColumn";
            this.TravelerIDColumn.Visible = false;
            this.TravelerIDColumn.Width = 125;
            // 
            // TravelerFISHColumn
            // 
            this.TravelerFISHColumn.HeaderText = "F.I.SH";
            this.TravelerFISHColumn.MinimumWidth = 6;
            this.TravelerFISHColumn.Name = "TravelerFISHColumn";
            this.TravelerFISHColumn.Width = 300;
            // 
            // TravelerEmailColumn
            // 
            this.TravelerEmailColumn.HeaderText = "E-Pochta";
            this.TravelerEmailColumn.MinimumWidth = 6;
            this.TravelerEmailColumn.Name = "TravelerEmailColumn";
            this.TravelerEmailColumn.Width = 208;
            // 
            // TravelerPhoneNumberColumn
            // 
            this.TravelerPhoneNumberColumn.HeaderText = "Telefon raqam";
            this.TravelerPhoneNumberColumn.MinimumWidth = 6;
            this.TravelerPhoneNumberColumn.Name = "TravelerPhoneNumberColumn";
            this.TravelerPhoneNumberColumn.Width = 175;
            // 
            // TravelerGenderColumn
            // 
            this.TravelerGenderColumn.HeaderText = "Jinsi";
            this.TravelerGenderColumn.MinimumWidth = 6;
            this.TravelerGenderColumn.Name = "TravelerGenderColumn";
            this.TravelerGenderColumn.Width = 125;
            // 
            // ViewCustumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.DeleteTravelerBtn);
            this.Controls.Add(this.TravelersFISHTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewCustumersDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewCustumers";
            this.Text = "ViewCustumers";
            this.Load += new System.EventHandler(this.ViewCustumers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustumersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewCustumersDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TravelersFISHTxt;
        private System.Windows.Forms.Button DeleteTravelerBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelerIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelerFISHColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelerEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelerPhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelerGenderColumn;
    }
}