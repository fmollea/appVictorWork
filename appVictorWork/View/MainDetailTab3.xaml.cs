using System;
using System.Collections.Generic;
using appVictorWork.ViewModel;
using Xamarin.Forms;

namespace appVictorWork.View
{
    public partial class MainDetailTab3 : ContentPage
    {
        public MainDetailTab3()
        {
            InitializeComponent();
            BindingContext = new MainDetailTab3ViewModel();
        }
    }
}
