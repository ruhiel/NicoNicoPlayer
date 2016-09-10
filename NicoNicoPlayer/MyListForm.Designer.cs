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
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.videoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.myListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.myListdataGridView)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.myListBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// myListdataGridView
			// 
			this.myListdataGridView.AllowUserToAddRows = false;
			this.myListdataGridView.AllowUserToDeleteRows = false;
			this.myListdataGridView.AllowUserToResizeColumns = false;
			this.myListdataGridView.AllowUserToResizeRows = false;
			this.myListdataGridView.AutoGenerateColumns = false;
			this.myListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myListdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.videoIDDataGridViewTextBoxColumn});
			this.myListdataGridView.DataSource = this.myListBindingSource;
			this.myListdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myListdataGridView.Location = new System.Drawing.Point(3, 23);
			this.myListdataGridView.Name = "myListdataGridView";
			this.myListdataGridView.RowTemplate.Height = 21;
			this.myListdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.myListdataGridView.Size = new System.Drawing.Size(613, 235);
			this.myListdataGridView.TabIndex = 0;
			this.myListdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myListdataGridView_CellContentClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.myListdataGridView, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 261);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.Width = 300;
			// 
			// videoIDDataGridViewTextBoxColumn
			// 
			this.videoIDDataGridViewTextBoxColumn.DataPropertyName = "VideoID";
			this.videoIDDataGridViewTextBoxColumn.HeaderText = "VideoID";
			this.videoIDDataGridViewTextBoxColumn.Name = "videoIDDataGridViewTextBoxColumn";
			// 
			// myListBindingSource
			// 
			this.myListBindingSource.DataSource = typeof(NicoNicoPlayer.MyList);
			// 
			// MyListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 261);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "MyListForm";
			this.Text = "マイリスト";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyListForm_FormClosed);
			this.Load += new System.EventHandler(this.MyListForm_Load);
			this.SizeChanged += new System.EventHandler(this.MyListForm_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.myListdataGridView)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.myListBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView myListdataGridView;
		private System.Windows.Forms.BindingSource myListBindingSource;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn videoIDDataGridViewTextBoxColumn;
	}
}