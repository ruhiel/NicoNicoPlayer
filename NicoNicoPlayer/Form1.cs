﻿using mshtml;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Zoom(int zoomValue)
		{
			SHDocVw.IWebBrowser2 wb = (SHDocVw.IWebBrowser2)webBrowser1.ActiveXInstance;
			SHDocVw.OLECMDID cmdZoom = (SHDocVw.OLECMDID)63;
			Object pvaIn = zoomValue;
			Object pvaOut = null;
			wb.ExecWB(cmdZoom, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref pvaIn, ref pvaOut);
		}

		private void Init()
		{
			IHTMLDocument2 doc = (webBrowser1.Document.DomDocument) as IHTMLDocument2;
			// The first parameter is the url, the second is the index of the added style sheet.
			IHTMLStyleSheet ss = doc.createStyleSheet("", 0);
			this.Text = webBrowser1.DocumentTitle;
			// Now that you have the style sheet you have a few options:
			// 1. You can just set the content as text.
			//ss.cssText = @"div { display: none; }";
			// 2. You can add/remove style rules.
			ss.addRule("div#content", "padding: 0px;");
			ss.addRule("div#siteHeader", "display: none;");
			ss.addRule("div#videoHeader", "display: none;");
			ss.addRule("div#playlist", "display: none;");
			ss.addRule("div#playlistInformation", "display: none;");
			ss.addRule("div#playlistContainer", "display: none;");
			ss.addRule("div#playlistTrashbox", "display: none;");
			ss.addRule("div#videoExplorerExpand", "display: none;");
			ss.addRule("div#bottomContentTabContainer", "display: none;");
			ss.addRule("div#footer", "display: none;");
			ss.addRule("div#playerTabContainer", "display: none;");

			Zoom(50);
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			if(!textBox1.Text.Contains("http://www.nicovideo.jp"))
			{
				textBox1.Text = "http://www.nicovideo.jp/watch/" + textBox1.Text;
			}
			
			this.webBrowser1.Url = new Uri(textBox1.Text);
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			Init();
		}
	}
}