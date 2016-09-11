using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NicoNicoPlayer.MyListDataSet;

namespace NicoNicoPlayer
{
	public partial class MyListForm : Form
	{
		private MainForm form;

		//最小化されたフォームを元に戻す時の状態
		private FormWindowState preWindowState;

		public MyListForm(MainForm form)
		{
			InitializeComponent();
			this.form = form;
		}

		private void MyListForm_Load(object sender, EventArgs e)
		{
			try
			{
				//DataGridViewButtonColumnの作成
				DataGridViewButtonColumn column = new DataGridViewButtonColumn();
				//列の名前を設定
				column.Name = "Button";
				//全てのボタンに"詳細閲覧"と表示する
				column.UseColumnTextForButtonValue = true;
				column.Text = "表示";
				//DataGridViewに追加する
				myListdataGridView.Columns.Add(column);
				Settings.LoadFromXmlFile();
				

				NicoNico niconico = new NicoNico(Settings.Instance.Email, Settings.Instance.RowPassword);

				// 削除されていないリストを取得
				foreach (var m in niconico.GetMyList().Where(x => x.deleted == "0"))
				{
					this.myListDataSet1.MyList.AddMyListRow(m.title, m.video_id);
				}

				//初期化
				if (this.WindowState == FormWindowState.Minimized)
				{
					this.preWindowState = FormWindowState.Normal;
				}
				else
				{
					this.preWindowState = this.WindowState;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("マイリストの取得に失敗しました。");
			}
		}

		private void myListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			//"Button"列ならば、ボタンがクリックされた
			if (dgv.Columns[e.ColumnIndex].Name == "Button")
			{
				if(Settings.Instance.MinimizeAfterMyList)
				{
					this.WindowState = FormWindowState.Minimized;
				}
				var drv = this.myListbindingSource[e.RowIndex] as DataRowView;
				var myList = drv.Row as MyListRow;
				form.MyListShow(myList.VideoID);
			}
		}

		private void MyListForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			form.DisposeMylist();
		}

		public void RestoreMinimizedWindow()
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = this.preWindowState;
			}
		}

		private void MyListForm_SizeChanged(object sender, EventArgs e)
		{
			//最小化された以外の時に、状態を覚えておく
			if (this.WindowState != FormWindowState.Minimized)
			{
				this.preWindowState = this.WindowState;
			}
		}

		private void filterTextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if(string.IsNullOrEmpty(textBox.Text))
			{
				myListbindingSource.Filter = string.Empty;
			}
			else
			{
				myListbindingSource.Filter = string.Format("Title like '%{0:s}%'", textBox.Text);
			}
			
		}

		private void myListdataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			//列ヘッダーかどうか調べる
			if (e.ColumnIndex < 0 && e.RowIndex >= 0)
			{
				//セルを描画する
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All);

				//行番号を描画する範囲を決定する
				//e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
				Rectangle indexRect = e.CellBounds;
				indexRect.Inflate(-2, -2);
				//行番号を描画する
				TextRenderer.DrawText(e.Graphics,
					(e.RowIndex + 1).ToString(),
					e.CellStyle.Font,
					indexRect,
					e.CellStyle.ForeColor,
					TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
				//描画が完了したことを知らせる
				e.Handled = true;
			}
		}
	}
}
