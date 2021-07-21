using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace ArtAuction
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
        	return new Microsoft.Maui.Controls.Window(new MainPage());
        }

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
        }
    }
}
