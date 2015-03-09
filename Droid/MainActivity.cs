using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Parse;

namespace SampleList.Droid
{
	[Activity(Label = "DataList", MainLauncher = true, Icon = "@drawable/icon")]
	public class HomeScreen : ListActivity {
		string[] items;
		protected async override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			ParseClient.Initialize("6jg1ny9edOT5Ezjvyj6zGDw5wnxvWsITjid1wrgy","ohSxCU4RsFrReBUe3AJeL9lRhFD5EHKJl1tNvgMc");


			{
				var itemList = new ParseObject ("ItemList");
				itemList ["ItemName"] = "Book";
				itemList ["ItemPrice"] = 200;
				itemList["ItemSize"] = "Big";
				await itemList.SaveAsync ();
			}
			items = new string[] { "Item1","Item2","Item3","Item4","Item6","Item7" };
			ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
		}
		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var t = items[position];
			Android.Widget.Toast.MakeText(this, t, Android.Widget.ToastLength.Short).Show();
		}
	}
}

	

