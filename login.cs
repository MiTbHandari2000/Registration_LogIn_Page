using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registration_LogIn_Page
{
    [Activity(Label = "login", MainLauncher = false)]
    public class login : Activity
    {
        TextView createnew, textView1;
        Button mainloginBT;
        ImageButton googleBT, facebookBT;
        ImageButton loginWTgoogle, loginWTfacebook;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.loginactivity);
            createnew = FindViewById<TextView>(Resource.Id.createlogic);
            createnew.Click += Createnew_Click;

            loginWTgoogle = FindViewById<ImageButton>(Resource.Id.Loginwithgoogle);
            mainloginBT = FindViewById<Button>(Resource.Id.LoginButton);
            textView1 = FindViewById<TextView>(Resource.Id.textView1);
            loginWTfacebook = FindViewById<ImageButton>(Resource.Id.Loginwithfacebook);
            loginWTgoogle.Click += LoginWTgoogle_Click;
            loginWTfacebook.Click += LoginWTfacebook_Click;
            mainloginBT.Click += MainloginBT_Click;
            TextPaint paint = textView1.Paint;
            float width = paint.MeasureText(textView1.Text);

            int[] vs = new int[]{
                           Color.ParseColor("#001cb8"),
                        Color.ParseColor("#001cb8"),
                        Color.ParseColor("#00008B"),
                        Color.ParseColor("#209FF1"),
                        Color.ParseColor("#000000"),

                    };
            Shader textShader = new LinearGradient(0, 0, width, textView1.TextSize,
                    vs, null, Shader.TileMode.Clamp);
            textView1.Paint.SetShader(textShader);
            // Create your application here
        }

        private void MainloginBT_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "login Successfull", ToastLength.Short).Show();

        }

        private void LoginWTfacebook_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You have been Logged in by Google", ToastLength.Short).Show();
        }

        private void LoginWTgoogle_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You have been Logged in by Google", ToastLength.Short).Show();
        }



        private void Createnew_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}