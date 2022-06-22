using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamurai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        private SampleViewModel mViewModel { get; }

        public Command<Car> DeleteCommand { get; }

        public bool SwipeEnabled { get; set; } = true;

        public ListViewPage()
        {
            DeleteCommand = new Command<Car>(DeletePressed);
            BindingContext = mViewModel = new SampleViewModel();
            InitializeComponent();
        }

        private async void DeletePressed(Car car)
        {
            bool delete = await DisplayAlert("Delete?", $"Are you sure you want to delete {car.Name}?", "Yes", "No");
            if (delete)
            {
                mViewModel.Cars.Remove(car);
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width > height)
            {
                MainCollectionView.ItemsLayout = LinearItemsLayout.Horizontal;
                SwipeEnabled = false;
            }
            else
            {
                MainCollectionView.ItemsLayout = LinearItemsLayout.Vertical;
                SwipeEnabled = true;
            }
        }
    }
}