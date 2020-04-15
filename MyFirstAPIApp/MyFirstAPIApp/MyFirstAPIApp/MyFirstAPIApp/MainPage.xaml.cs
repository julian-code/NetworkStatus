using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstAPIApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MovieDataManager _mdm;
        public MainPage()
        {
            _mdm = new MovieDataManager();
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Movies.ItemsSource = await _mdm.GetMovies();
        }
    }
}
