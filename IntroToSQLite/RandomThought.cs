using System;
using SQLite.Net.Attributes;

namespace IntroToSQLite
{
	public class RandomThought
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Thought { get; set; }
		public DateTime CreatedOn { get; set; }

		public RandomThought ()
		{
		}
	}
}