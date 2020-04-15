using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetworkStatus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NetworkViewPage : ContentPage
    {
        public NetworkViewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ConnectionDetails.Text = CrossConnectivity.Current.ConnectionTypes.First().ToString();
            CrossConnectivity.Current.ConnectivityTypeChanged += HandleConnectivityChanged;
        }

        private void HandleConnectivityChanged(object sender, ConnectivityTypeChangedEventArgs e)
        {
            ConnectionDetails.Text = CrossConnectivity.Current.ConnectionTypes.First().ToString();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CrossConnectivity.Current.ConnectivityTypeChanged -= HandleConnectivityChanged;
        }
    }
}