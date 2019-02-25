using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appVictorWork.ViewModel;
using Xamarin.Forms;

namespace appVictorWork.View
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Master = new MainMaster();
            this.Detail = new NavigationPage(new MainDetail());
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new MainPageViewModel();
        }
    }
}
