using System;
using Xamarin.Forms;

namespace IntroToSQLite
{
	public class ThoughtEntryPage: ContentPage {
		private RandomThoughtsPage _parent;
		private RandomThoughtDatabase _database;

		public ThoughtEntryPage ( RandomThoughtsPage parent, RandomThoughtDatabase database)
		{
			_parent = parent;
			_database = database;
			Title = "Enter a Thought";

			var entry = new Entry ();
			var button = new Button {
				Text = "Add"
			};

			button.Clicked += async (object sender, EventArgs e) => {
				var thought = entry.Text;

				_database.AddThought(thought);

				await Navigation.PopAsync();


				_parent.Refresh();
			};

			Content = new StackLayout {
				Spacing = 20,
				Padding = new Thickness(20),
				Children = { entry, button },
			};
		}
	}
}

