﻿using Android.App;
using Android.OS;

namespace Microsoft.Xna.Samples.Draw2D
{
    [Activity(Label = "Draw2D", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.Splash")]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var g = new Game1(this);
            SetContentView(g.Window);
            g.Run();
        }
    }
}

