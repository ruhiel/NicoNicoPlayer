using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicoNicoPlayer
{
	public partial class MyListForm : Form
	{
		private MainForm form;

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
				Settings.LoadFromXmlFile("test.xml");

				NicoNico niconico = new NicoNico(Settings.Instance.Email, Settings.Instance.Password);
				foreach (var m in niconico.GetMyList())
				{
					this.myListBindingSource.Add(m);
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
				var myList = myListBindingSource[e.RowIndex] as MyList;
				form.MyListShow(myList.VideoID);
			}
		}
	}
}
