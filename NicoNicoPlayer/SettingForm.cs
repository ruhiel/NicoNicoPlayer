﻿using System;
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
			Settings.LoadFromXmlFile();
			this.checkBox1.Checked = Settings.Instance.MinimizeAfterMyList;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Instance.MinimizeAfterMyList = checkBox1.Checked;
			Settings.SaveToXmlFile();
			Close();
		}
	}
}
