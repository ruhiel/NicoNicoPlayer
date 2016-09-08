namespace NicoNicoPlayer
{
	partial class SettingForm
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
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.PassWordTextBox = new System.Windows.Forms.TextBox();
			this.OKButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(12, 13);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(260, 19);
			this.EmailTextBox.TabIndex = 0;
			// 
			// PassWordTextBox
			// 
			this.PassWordTextBox.Location = new System.Drawing.Point(12, 47);
			this.PassWordTextBox.Name = "PassWordTextBox";
			this.PassWordTextBox.PasswordChar = '*';
			this.PassWordTextBox.Size = new System.Drawing.Size(260, 19);
			this.PassWordTextBox.TabIndex = 1;
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(96, 87);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 2;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 139);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.PassWordTextBox);
			this.Controls.Add(this.EmailTextBox);
			this.Name = "SettingForm";
			this.Text = "SettingForm";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox PassWordTextBox;
		private System.Windows.Forms.Button OKButton;
	}
}