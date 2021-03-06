﻿using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;

namespace XamarinPOC.Droid
{
    [Activity(
        Label = "MvxForms"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]


    public class SplashScreen : MvxFormsSplashScreenActivity<Setup, CoreApp, App>
    {
        public SplashScreen()
              : base(Resource.Layout.SplashScreen)
        {
        }


        /// <summary>
        /// Runs the app start.
        /// </summary>
        /// <param name="bundle">Bundle.</param>
		protected override void RunAppStart(Bundle bundle)
        {
           StartActivity(typeof(MainActivity));
            base.RunAppStart(bundle);
        }

    }
}
