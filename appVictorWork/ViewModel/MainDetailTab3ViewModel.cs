using System;
namespace appVictorWork.ViewModel
{
    public class MainDetailTab3ViewModel
    {
        public string TitlePage { get; set; }
        public string TextPage { get; set; }

        public MainDetailTab3ViewModel()
        {
            InitView();
        }

        private void InitView()
        {
            TitlePage = "OTO";
            TextPage = "Third Page Xamarin";
        }
    }
}
