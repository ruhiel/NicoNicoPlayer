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
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			Settings.LoadFromXmlFile("test.xml");
			this.EmailTextBox.Text = Settings.Instance.Email;
			this.PassWordTextBox.Text = Settings.Instance.Password;
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			Settings.Instance.Email = this.EmailTextBox.Text;
			Settings.Instance.Password = this.PassWordTextBox.Text;
			Settings.SaveToXmlFile("test.xml");
			Close();
		}
	}
}
