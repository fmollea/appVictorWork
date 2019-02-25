using System;
using System.Collections.Generic;
using appVictorWork.ViewModel;
using Xamarin.Forms;

namespace appVictorWork.View
{
    public partial class MainDetailTab2 : ContentPage
    {
        public MainDetailTab2()
        {
            InitializeComponent();
            BindingContext = new MainDetailTab2ViewModel();
        }
    }
}
