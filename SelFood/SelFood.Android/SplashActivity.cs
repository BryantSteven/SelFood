namespace SelFood.Droid
{
    using Android.App;
    using Android.OS;

    [Activity(Theme = "@style/Theme.Splash",
              MainLauncher = true,
              NoHistory = true)]
    public class SplashActivity : Activity
    {
        //Inicializador de app
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //dormir el hilo de la app 2k mili
            System.Threading.Thread.Sleep(2000);
            this.StartActivity(typeof(MainActivity));
        }
    }

}