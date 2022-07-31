using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;


namespace JOHNConvert
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        //views
        private Button convertBtn;
        private RadioButton rb1, rb2, rb3, rb4, rb5, rb6;
        private EditText input;
        private TextView output, textView1, textView2;
        double insert, converted;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            FindView();
            EventHandlers();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void FindView()
        {
            convertBtn = FindViewById<Button>(Resource.Id.convertBtn);
            output = FindViewById<TextView>(Resource.Id.output);
            textView1 = FindViewById<TextView>(Resource.Id.textView1);
            textView2 = FindViewById<TextView>(Resource.Id.textView2);
            rb1 = FindViewById<RadioButton>(Resource.Id.rb1);
            rb2 = FindViewById<RadioButton>(Resource.Id.rb2);
            rb3 = FindViewById<RadioButton>(Resource.Id.rb3);
            rb4 = FindViewById<RadioButton>(Resource.Id.rb4);
            rb5 = FindViewById<RadioButton>(Resource.Id.rb5);
            rb6 = FindViewById<RadioButton>(Resource.Id.rb6);
            input = FindViewById<EditText>(Resource.Id.input);
        }

        private void EventHandlers()
        {
            convertBtn.Click += btnCompute;
            rb1.Click += changeText;
            rb2.Click += changeText;
            rb3.Click += changeText;
            rb4.Click += changeText;
            rb5.Click += changeText;
            rb6.Click += changeText;
        }

        private void changeText(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                textView1.Text = "Milliliters (mL):";
                textView2.Text = "Litres (L):";
                output.Text = "";
            }
            else if (rb2.Checked == true)
            {
                textView1.Text = "Litres (L):";
                textView2.Text = "Milliliters (mL):";
                output.Text = "";
            }
            else if (rb3.Checked == true)
            {
                textView1.Text = "Litres (L):";
                textView2.Text = "Gallon (G):";
                output.Text = "";
            }
            else if (rb4.Checked == true)
            {
                textView1.Text = "Gallon (G):";
                textView2.Text = "Litres (L):";
                output.Text = "";
            }
            else if (rb5.Checked == true)
            {
                textView1.Text = "Kilometers (KM):";
                textView2.Text = "Lightyears (LY):";
                output.Text = "";
            }
            else if (rb6.Checked == true)
            {
                textView1.Text = "Lightyears (LY):";
                textView2.Text = "Kilometers (KM):";
                output.Text = "";
            }
        }

        public void btnCompute(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                Toast.MakeText(this, "Enter a Value First", ToastLength.Short).Show();
            }
            else if (rb1.Checked == true)
            {
                insert = double.Parse(input.Text);
                double mL = 0.001;

                converted = insert * mL;
                output.Text = converted.ToString();

            }
            else if (rb2.Checked == true)
            {
                insert = double.Parse(input.Text);
                double L = 1000;

                converted = insert * L;
                output.Text = converted.ToString();
            }
            else if (rb3.Checked == true)
            {
                insert = double.Parse(input.Text);
                double L2 = 0.264172;

                converted = insert * L2;
                output.Text = converted.ToString();
            }
            else if (rb4.Checked == true)
            {
                insert = double.Parse(input.Text);
                double G = 3.78541;

                converted = insert * G;
                output.Text = converted.ToString();
            }
            else if (rb5.Checked == true)
            {
                insert = double.Parse(input.Text);
                double LY = 9460730472580;

                converted = insert / LY;
                output.Text = converted.ToString();
            }
            else if (rb6.Checked == true)
            {
                insert = double.Parse(input.Text);
                double KM = 9460730472580;

                converted = insert * KM;
                output.Text = converted.ToString();
            }
            input.Text = "";

        }
    }
}