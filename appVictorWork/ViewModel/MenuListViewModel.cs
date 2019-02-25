using System;
using appVictorWork.Model;

namespace appVictorWork.ViewModel
{
    public class MenuListViewModel
    {
        private MyModel CurrentItem { get; set; }
        public string TitlePage { get; set; }

        public MenuListViewModel(MyModel myModel)
        {
            CurrentItem = myModel;
            TitlePage = myModel.firstLine + " options";
        }
    }
}
