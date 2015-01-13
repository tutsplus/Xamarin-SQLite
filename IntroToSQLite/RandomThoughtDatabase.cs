using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace IntroToSQLite
{
	public class RandomThoughtDatabase
	{
		private SQLiteConnection _connection;

		public RandomThoughtDatabase ()
		{
			_connection = DependencyService.Get<ISQLite> ().GetConnection ();
			_connection.CreateTable<RandomThought> ();
		}

		public IEnumerable<RandomThought> GetThoughts() {
			return (from t in _connection.Table<RandomThought> ()
			        select t).ToList ();
		}

		public RandomThought GetThought(int id) {
			return _connection.Table<RandomThought> ().FirstOrDefault (t => t.ID == id);
		}

		public void DeleteThought(int id) {
			_connection.Delete<RandomThought> (id);
		}

		public void AddThought(string thought) {
			var newThought = new RandomThought {
				Thought = thought,
				CreatedOn = DateTime.Now
			};

			_connection.Insert (newThought);
		}
	}
}