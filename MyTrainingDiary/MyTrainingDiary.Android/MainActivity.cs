using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MyTrainingDiary.DAL;
using System.IO;

namespace MyTrainingDiary.Droid
{
    [Activity(Label = "MyTrainingDiary", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);  
            
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var dbPath = Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.LocalApplicationData), "mtddb.db");

            LoadApplication(new App(dbPath));
        }
    }
}