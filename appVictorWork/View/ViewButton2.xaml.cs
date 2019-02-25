using System;
using System.Collections.Generic;
using appVictorWork.ViewModel;
using Xamarin.Forms;

namespace appVictorWork.View
{
    public partial class ViewButton2 : ContentPage
    {
        public ViewButton2()
        {
            InitializeComponent();
            BindingContext = new ViewButton2ViewModel();
        }
    }
}
