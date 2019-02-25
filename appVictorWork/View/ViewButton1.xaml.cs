using System;
using System.Collections.Generic;
using appVictorWork.ViewModel;
using Xamarin.Forms;

namespace appVictorWork.View
{
    public partial class ViewButton1 : ContentPage
    {
        public ViewButton1()
        {
            InitializeComponent();
            BindingContext = new ViewButton1ViewModel();
        }
    }
}
