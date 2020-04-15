using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetworkStatus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = CrossConnectivity.Current.IsConnected ? new NetworkViewPage() : (Page)new NoNetworkPage();
        }

        protected override void OnStart()
        {
            base.OnStart();
            CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
        }

        void HandleConnectivityChanged (object sender, ConnectivityChangedEventArgs e)
        {
            Type currentPage = this.MainPage.GetType();
            if (e.IsConnected && currentPage != typeof(NetworkViewPage))
                this.MainPage = new NetworkViewPage();
            else if (!e.IsConnected && currentPage != typeof(NoNetworkPage))
                this.MainPage = new NoNetworkPage();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
