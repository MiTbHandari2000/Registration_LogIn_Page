using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Registration_LogIn_Page
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        TextView textView, loginPG;
        ImageButton googleBT, facebookBT;
        Button registerBT;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            UIreferences();

            TextPaint paint = textView.Paint;
            float width = paint.MeasureText(textView.Text);

            int[] vs = new int[]{
                        Color.ParseColor("#301934"),
                        Color.ParseColor("#301934"),
                        Color.ParseColor("#00008B"),
                        Color.ParseColor("#209FF1"),
                        Color.ParseColor("#209FF1"),
                    };
            Shader textShader = new LinearGradient(0, 0, width, textView.TextSize,
                    vs, null, Shader.TileMode.Clamp);
            textView.Paint.SetShader(textShader);
            registerBT.Click += RegisterBT_Click;
            loginPG.Click += LoginPG_Click;
            googleBT.Click += GoogleBT_Click;
            facebookBT.Click += FacebookBT_Click;
        }

        private void FacebookBT_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You have been Registered in by Facebook", ToastLength.Short).Show();
        }

        private void GoogleBT_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You have been Registered in by Google", ToastLength.Short).Show();
        }

        private void LoginPG_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(login));
            StartActivity(intent);
        }

        private void RegisterBT_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Registered Successfully", ToastLength.Short).Show();
        }

        private void UIreferences()
        {
            facebookBT = FindViewById<ImageButton>(Resource.Id.facebookbutton);
            googleBT = FindViewById<ImageButton>(Resource.Id.googlebutton);
            registerBT = FindViewById<Button>(Resource.Id.registerButton);
            textView = FindViewById<TextView>(Resource.Id.textView1);
            loginPG = FindViewById<TextView>(Resource.Id.loginTextView);
        }
    }
}