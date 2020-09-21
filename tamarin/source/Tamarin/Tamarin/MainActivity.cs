using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Core;
using Xamarin.Essentials;

namespace Tamarin
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			((Activity)this).OnCreate(savedInstanceState);
			Platform.Init((Activity)(object)this, savedInstanceState);
			((Activity)this).SetContentView(2131427356);
			EditText flagText = ((Activity)this).FindViewById<EditText>(2131230795);
			Button val = ((Activity)this).FindViewById<Button>(2131230763);
			string empty = string.Empty;
			((View)val).add_Click((EventHandler)delegate
			{
				if (Check.Func4(((TextView)flagText).get_Text()))
				{
					((TextView)flagText).set_Text("The flag is TWCTF{" + ((TextView)flagText).get_Text() + "}");
				}
				else
				{
					((TextView)flagText).set_Text("Invalid");
				}
			});
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
		{
			Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
			((Activity)this).OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}

		public MainActivity()
			: this()
		{
		}
	}
}
