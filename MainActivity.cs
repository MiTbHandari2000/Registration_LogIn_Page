using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Registration_LogIn_Page
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            textView = FindViewById<TextView>(Resource.Id.textView1);            

            TextPaint paint = textView.Paint;
            float width = paint.MeasureText(textView.Text);

            int[] vs = new int[]{
                        Color.ParseColor("#F97C3C"),
                        Color.ParseColor("#FDB54E"),
                        Color.ParseColor("#64B678"),
                        Color.ParseColor("#478AEA"),
                        Color.ParseColor("#8446CC"),
                    };
            Shader textShader = new LinearGradient(0, 0, width, textView.TextSize,
                    vs, null, Shader.TileMode.Clamp);
            textView.Paint.SetShader(textShader);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}