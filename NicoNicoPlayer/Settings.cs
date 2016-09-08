﻿using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.Win32;
namespace NicoNicoPlayer
{
	[Serializable()]
	public class Settings
	{
		//設定のプロパティ
		public string Email
		{
			get; set;
		} = string.Empty;
		public string Password
		{
			get;set;
		} = string.Empty;

		//Settingsクラスのただ一つのインスタンス
		[NonSerialized()]
		private static Settings _instance;
		[System.Xml.Serialization.XmlIgnore]
		public static Settings Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Settings();
				return _instance;
			}
			set { _instance = value; }
		}

		/// <summary>
		/// 設定をXMLファイルから読み込み復元する
		/// </summary>
		public static void LoadFromXmlFile(string fileName)
		{
			try
			{
				StreamReader sr = new StreamReader(fileName, new UTF8Encoding(false));
				System.Xml.Serialization.XmlSerializer xs =
					new System.Xml.Serialization.XmlSerializer(typeof(Settings));
				//読み込んで逆シリアル化する
				object obj = xs.Deserialize(sr);
				sr.Close();

				Instance = (Settings)obj;
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// 現在の設定をXMLファイルに保存する
		/// </summary>
		public static void SaveToXmlFile(string fileName)
		{
			try
			{
				StreamWriter sw = new StreamWriter(fileName, false, new UTF8Encoding(false));
				System.Xml.Serialization.XmlSerializer xs =
					new System.Xml.Serialization.XmlSerializer(typeof(Settings));
				//シリアル化して書き込む
				xs.Serialize(sw, Instance);
				sw.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("設定の保存に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
