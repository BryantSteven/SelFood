
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Content.PM;
using Firebase;

namespace SelFood.Droid
{
    [Activity(Label = "SelFood",
        Icon = "@drawable/Icono",
        MainLauncher = false,
        Theme ="@style/MainTheme",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static FirebaseApp app;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            InitFirebase();
            LoadApplication(new App());
        }
        //Conexion con base de datos
        private void InitFirebase()
        {
            var options = new FirebaseOptions.Builder()
            .SetApplicationId("1:1028475350645:android:82cf6953c70c2c21c1523c")
            .SetApiKey("AIzaSyABSbm6wqsEFaB_4vL8ReIRXMXg1NqbF2E")
            .SetDatabaseUrl("https://selfood-badba.firebaseio.com/")
            .Build();

            if (app == null)
                app = FirebaseApp.InitializeApp(this, options, "Selfood");
        }
        //Acaba conexion con base de datos
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}