using Codeplex.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NicoNicoPlayer
{
	public class NicoNico
	{
		private string email;
		private string password;

		public NicoNico(string email, string password)
		{
			this.email = email;
			this.password = password;
		}

		public List<MyList> GetMyList()
		{
			List<MyList> myList = new List<MyList>();

			//ニコニコ動画ログイン用IDとPASSWORDを指定
			string id = this.email;//メアド
			string password = this.password;//パスワード

			//ログイン・ページへのアクセスパラメタ
			//ここで必要な情報は、ログインページのHTMLソースを見て、
			//"input"で検索して調べる
			Hashtable vals = new Hashtable();
			vals["next_url"] = "";
			vals["mail"] = id;
			vals["password"] = password;
			//ログインボタンが押されたときにpostされるURL
			//これもログインページのHTMLを見て、formタグから調べる
			string url = "https://secure.nicovideo.jp/secure/login?site=niconico";

			//パラメタを"param1=value1&param2=value2"の形にまとめる
			string param = "";
			foreach (string k in vals.Keys)
			{
				param += String.Format("{0}={1}&", k, vals[k]);
			}
			byte[] data = Encoding.ASCII.GetBytes(param);

			//HTTP POSTリクエストの作成
			CookieContainer cc = new CookieContainer(); //認証用クッキーを格納するコンテナ
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
			req.Method = "POST";
			req.ContentType = "application/x-www-form-urlencoded";
			req.ContentLength = data.Length;
			req.CookieContainer = cc;

			//POSTを実行
			Stream reqStream = req.GetRequestStream();
			reqStream.Write(data, 0, data.Length);
			reqStream.Close();

			//HTTP GETによるクッキーの取得
			//GET実行
			WebResponse res = req.GetResponse();
			Stream resStream = res.GetResponseStream();

			Encoding encoder = Encoding.GetEncoding("UTF-8");
			StreamReader sr = new StreamReader(resStream, encoder);
			string result = sr.ReadToEnd();
			sr.Close();
			resStream.Close();

			//以降はHTTP GETのみでアクセスできる
			//例として、ニコニコ動画のマイページにアクセスしてみる
			url = "http://www.nicovideo.jp/api/deflist/list";

			//HTTP GET リクエストの作成
			req = (HttpWebRequest)WebRequest.Create(url);
			req.CookieContainer = cc;//取得済みのクッキーコンテナ
			res = req.GetResponse();
			resStream = res.GetResponseStream();
			sr = new StreamReader(resStream, encoder);
			result = sr.ReadToEnd();
			sr.Close();
			resStream.Close();

			dynamic JsonValue = DynamicJson.Parse(result);
			foreach (var item in JsonValue.mylistitem)
			{
				MyList m = new MyList()
				{
					title = item.item_data.title,
					video_id = item.item_data.video_id,
					deleted = item.item_data.deleted
				};
				myList.Add(m);
			}
			return myList;
		}
	}
	/*
	public class Rootobject
	{
		public Mylistitem[] mylistitem { get; set; }
		public string status { get; set; }
	}

	public class Mylistitem
	{
		public string item_type { get; set; }
		public string item_id { get; set; }
		public string description { get; set; }
		public Item_Data item_data { get; set; }
		public int watch { get; set; }
		public int create_time { get; set; }
		public int update_time { get; set; }
	}

	public class Item_Data
	{
		public string video_id { get; set; }
		public string title { get; set; }
		public string thumbnail_url { get; set; }
		public int first_retrieve { get; set; }
		public int update_time { get; set; }
		public string view_counter { get; set; }
		public string mylist_counter { get; set; }
		public string num_res { get; set; }
		public string group_type { get; set; }
		public string length_seconds { get; set; }
		public string deleted { get; set; }
		public string last_res_body { get; set; }
		public string watch_id { get; set; }
	}*/
}
