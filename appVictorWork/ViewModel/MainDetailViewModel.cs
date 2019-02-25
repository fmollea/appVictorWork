using System;
using System.Threading.Tasks;
using appVictorWork.View;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace appVictorWork.ViewModel
{
    public class MainDetailViewModel
    {
        public Command OpenMenuCommand { get; set; }
        public string TitlePage { get; set; }

        public MainDetailViewModel()
        {
            OpenMenuCommand = new Command(async () => await OpenMainMenu());
            TitlePage = "Title App";
        }

        private async Task OpenMainMenu()
        {
            await PopupNavigation.PushAsync(new MenuMain());
        }
    }
}
