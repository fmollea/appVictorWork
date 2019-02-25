using System;
using System.Collections.Generic;
using appVictorWork.ViewModel;
using Xamarin.Forms;

namespace appVictorWork.View
{
    public partial class MainDetail : TabbedPage
    {
        public MainDetail()
        {
            InitializeComponent();
            BindingContext = new MainDetailViewModel();

        }
    }
}
