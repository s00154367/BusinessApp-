﻿using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static readonly List<Contact> Users = new List<Contact>();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            Button btnCreate = FindViewById<Button>(Resource.Id.btnContact);

            }
    }
}

