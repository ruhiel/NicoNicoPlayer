namespace NicoNicoPlayer
{
	partial class MyListForm
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
			this.myListdataGridView = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.filterTextBox = new System.Windows.Forms.TextBox();
			this.myListDataSet1 = new NicoNicoPlayer.MyListDataSet();
			this.myListbindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.videoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.myListdataGridView)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.myListDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myListbindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// myListdataGridView
			// 
			this.myListdataGridView.AllowUserToAddRows = false;
			this.myListdataGridView.AllowUserToDeleteRows = false;
			this.myListdataGridView.AllowUserToResizeRows = false;
			this.myListdataGridView.AutoGenerateColumns = false;
			this.myListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myListdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.videoIDDataGridViewTextBoxColumn});
			this.myListdataGridView.DataSource = this.myListbindingSource;
			this.myListdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myListdataGridView.Location = new System.Drawing.Point(3, 23);
			this.myListdataGridView.Name = "myListdataGridView";
			this.myListdataGridView.RowTemplate.Height = 21;
			this.myListdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.myListdataGridView.Size = new System.Drawing.Size(660, 235);
			this.myListdataGridView.TabIndex = 0;
			this.myListdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myListdataGridView_CellContentClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.myListdataGridView, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.filterTextBox, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 261);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// filterTextBox
			// 
			this.filterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filterTextBox.Location = new System.Drawing.Point(3, 3);
			this.filterTextBox.Name = "filterTextBox";
			this.filterTextBox.Size = new System.Drawing.Size(660, 19);
			this.filterTextBox.TabIndex = 1;
			this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
			// 
			// myListDataSet1
			// 
			this.myListDataSet1.DataSetName = "MyListDataSet";
			this.myListDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// myListbindingSource
			// 
			this.myListbindingSource.DataMember = "MyList";
			this.myListbindingSource.DataSource = this.myListDataSet1;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.Width = 400;
			// 
			// videoIDDataGridViewTextBoxColumn
			// 
			this.videoIDDataGridViewTextBoxColumn.DataPropertyName = "VideoID";
			this.videoIDDataGridViewTextBoxColumn.HeaderText = "VideoID";
			this.videoIDDataGridViewTextBoxColumn.Name = "videoIDDataGridViewTextBoxColumn";
			// 
			// MyListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 261);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "MyListForm";
			this.Text = "マイリスト";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyListForm_FormClosed);
			this.Load += new System.EventHandler(this.MyListForm_Load);
			this.SizeChanged += new System.EventHandler(this.MyListForm_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.myListdataGridView)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.myListDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myListbindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView myListdataGridView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox filterTextBox;
		private MyListDataSet myListDataSet1;
		private System.Windows.Forms.BindingSource myListbindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn videoIDDataGridViewTextBoxColumn;
	}
}