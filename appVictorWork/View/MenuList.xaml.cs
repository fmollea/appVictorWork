using System;
using System.Collections.Generic;
using appVictorWork.Model;
using appVictorWork.ViewModel;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace appVictorWork.View
{
    public partial class MenuList : PopupPage
    {
        public MenuList(MyModel currentItem)
        {
            InitializeComponent();
            BindingContext = new MenuListViewModel(currentItem);
        }
    }
}
