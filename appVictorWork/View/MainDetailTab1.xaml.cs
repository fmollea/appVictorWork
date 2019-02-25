using System;
using System.Collections.Generic;
using appVictorWork.ViewModel;
using Xamarin.Forms;

namespace appVictorWork.View
{
    public partial class MainDetailTab1 : ContentPage
    {
        public MainDetailTab1()
        {
            InitializeComponent();
            BindingContext = new MainDetailTab1ViewModel(Navigation);
        }
    }
}
