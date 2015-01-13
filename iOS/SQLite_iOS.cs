using System;
using System.IO;
using SQLite;
using IntroToSQLite.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]

namespace IntroToSQLite.iOS
{
	public class SQLite_iOS: ISQLite
	{
		public SQLite_iOS ()
		{
		}

		#region ISQLite implementation

		public SQLite.Net.SQLiteConnection GetConnection ()
		{
			var fileName = "RandomThought.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, fileName);

			var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS ();
			var connection = new SQLite.Net.SQLiteConnection (platform, path);

			return connection;
		}

		#endregion
	}
}

