namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
            this.generateBtton = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNamesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // generateBtton
            // 
            this.generateBtton.Location = new System.Drawing.Point(12, 12);
            this.generateBtton.Name = "generateBtton";
            this.generateBtton.Size = new System.Drawing.Size(293, 23);
            this.generateBtton.TabIndex = 0;
            this.generateBtton.Text = "Generate";
            this.generateBtton.UseVisualStyleBackColor = true;
            this.generateBtton.Click += new System.EventHandler(this.GenerateBtton_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(98, 41);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(207, 23);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 70);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(293, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 44);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(80, 16);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "Full Name";
            // 
            // fullNamesListBox
            // 
            this.fullNamesListBox.FormattingEnabled = true;
            this.fullNamesListBox.ItemHeight = 16;
            this.fullNamesListBox.Location = new System.Drawing.Point(12, 99);
            this.fullNamesListBox.Name = "fullNamesListBox";
            this.fullNamesListBox.Size = new System.Drawing.Size(293, 212);
            this.fullNamesListBox.TabIndex = 3;
            this.fullNamesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FullNamesListBox_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 322);
            this.Controls.Add(this.fullNamesListBox);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.generateBtton);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button generateBtton;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.ListBox fullNamesListBox;
    }
}
