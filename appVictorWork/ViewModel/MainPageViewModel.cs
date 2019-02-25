using System;
namespace appVictorWork.ViewModel
{
    public class MainPageViewModel
    {
        public string TitlePage { get; set; }

        public MainPageViewModel()
        {
            InitView();
        }

        private void InitView()
        {
            TitlePage = "Title App";
        }
    }
}
