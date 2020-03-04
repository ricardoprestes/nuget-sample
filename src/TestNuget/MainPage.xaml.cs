using System.ComponentModel;
using NugetMultiSample.Helpers;
using Xamarin.Forms;

namespace TestNuget
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            LblPath.Text = new FileHelper().GetLocalFilePath("test.txt");
        }
    }
}
