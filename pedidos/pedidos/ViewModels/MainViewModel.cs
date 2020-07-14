using pedidos.Utils.NotificationProperty;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pedidos.ViewModels
{
    public class MainViewModel : NotificationEnabledObject
    {
        protected async Task<bool> DisplayAlert(string _title, string _message, string _accept, string _cancel)
        {
            return await App.Current.MainPage.DisplayAlert(_title, _message, _accept, _cancel);
        }
        protected async Task NavigateTo(Page _page, bool _animated = true)
        {
            await App.Current.MainPage.Navigation.PushAsync(_page, _animated);
        }
    }
}
