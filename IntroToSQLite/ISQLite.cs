using System;
using SQLite.Net;

namespace IntroToSQLite
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}