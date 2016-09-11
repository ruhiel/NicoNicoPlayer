namespace NicoNicoPlayer
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.認証設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.動作設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.マイリストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.認証ショートカットキーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(91, 19);
			this.textBox1.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 34);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(100, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 22);
			this.button1.TabIndex = 3;
			this.button1.Text = "移動";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(162, 3);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(61, 19);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.webBrowser1, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 293);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 43);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new System.Drawing.Size(380, 271);
			this.webBrowser1.TabIndex = 3;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.マイリストToolStripMenuItem,
            this.認証ショートカットキーToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(386, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ファイルToolStripMenuItem
			// 
			this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
			this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.ファイルToolStripMenuItem.Text = "ファイル";
			// 
			// 設定ToolStripMenuItem
			// 
			this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.認証設定ToolStripMenuItem,
            this.動作設定ToolStripMenuItem});
			this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
			this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.設定ToolStripMenuItem.Text = "設定";
			// 
			// 認証設定ToolStripMenuItem
			// 
			this.認証設定ToolStripMenuItem.Name = "認証設定ToolStripMenuItem";
			this.認証設定ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.認証設定ToolStripMenuItem.Text = "認証";
			this.認証設定ToolStripMenuItem.Click += new System.EventHandler(this.認証設定ToolStripMenuItem_Click);
			// 
			// 動作設定ToolStripMenuItem
			// 
			this.動作設定ToolStripMenuItem.Name = "動作設定ToolStripMenuItem";
			this.動作設定ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.動作設定ToolStripMenuItem.Text = "動作設定";
			this.動作設定ToolStripMenuItem.Click += new System.EventHandler(this.動作設定ToolStripMenuItem_Click);
			// 
			// マイリストToolStripMenuItem
			// 
			this.マイリストToolStripMenuItem.Name = "マイリストToolStripMenuItem";
			this.マイリストToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.マイリストToolStripMenuItem.Text = "マイリスト";
			this.マイリストToolStripMenuItem.Click += new System.EventHandler(this.マイリストToolStripMenuItem_Click);
			// 
			// 認証ショートカットキーToolStripMenuItem
			// 
			this.認証ショートカットキーToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.passwordToolStripMenuItem});
			this.認証ショートカットキーToolStripMenuItem.Name = "認証ショートカットキーToolStripMenuItem";
			this.認証ショートカットキーToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
			this.認証ショートカットキーToolStripMenuItem.Text = "認証ショートカットキー";
			this.認証ショートカットキーToolStripMenuItem.Visible = false;
			// 
			// emailToolStripMenuItem
			// 
			this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
			this.emailToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
			this.emailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.emailToolStripMenuItem.Text = "Email";
			this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
			// 
			// passwordToolStripMenuItem
			// 
			this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
			this.passwordToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
			this.passwordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.passwordToolStripMenuItem.Text = "Password";
			this.passwordToolStripMenuItem.Click += new System.EventHandler(this.passwordToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 317);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "NicoNicoPlayer";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem マイリストToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 認証ショートカットキーToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 認証設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 動作設定ToolStripMenuItem;
	}
}

