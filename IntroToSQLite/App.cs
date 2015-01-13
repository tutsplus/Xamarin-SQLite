using System;
using Xamarin.Forms;

namespace IntroToSQLite
{
	public class App
	{

		public static Page GetMainPage ()
		{	
			var database = new RandomThoughtDatabase ();

			return new NavigationPage (new RandomThoughtsPage (database));
		}
	}




}

