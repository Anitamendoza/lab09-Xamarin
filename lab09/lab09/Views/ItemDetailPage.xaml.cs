using lab09.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lab09.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}