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
	public partial class AuthSettingForm : Form
	{
		public AuthSettingForm()
		{
			InitializeComponent();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			Settings.LoadFromXmlFile();
			this.EmailTextBox.Text = Settings.Instance.Email;
			this.PassWordTextBox.Text = Settings.Instance.RowPassword;
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			Settings.Instance.Email = this.EmailTextBox.Text;
			Settings.Instance.RowPassword = this.PassWordTextBox.Text;
			Settings.SaveToXmlFile();
			Close();
		}
	}
}
