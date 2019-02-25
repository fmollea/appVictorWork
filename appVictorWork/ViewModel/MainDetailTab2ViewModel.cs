using System;
namespace appVictorWork.ViewModel
{
    public class MainDetailTab2ViewModel
    {
        public string TitlePage { get; set; }
        public string TextPage { get; set; }

        public MainDetailTab2ViewModel()
        {
            InitView();
        }

        private void InitView()
        {
            TitlePage = "OTO";
            TextPage = "Second Page Xamarin";
        }
    }
}
