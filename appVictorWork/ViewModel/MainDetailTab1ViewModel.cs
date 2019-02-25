using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using appVictorWork.Helpers;
using appVictorWork.Model;
using appVictorWork.View;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace appVictorWork.ViewModel
{
    public class MainDetailTab1ViewModel : INotifyPropertyChanged
    {
        //Definicion de variables y objetos.
        public string TitlePage { get; set; }
        private INavigation navigation { get; set; }

        //Definición de commands.
        public Command SearchCommand;
        public Command RefreshCommand;
        public Command Button1Command { get; set; }
        public Command Button2Command { get; set; }
        public Command ItemTappedCommand { get; set; }

        private MyModel _currentItem;

        public MyModel CurrentItem
        {
            get { return _currentItem; }
            set
            {
                _currentItem = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<Grouping<string, MyModel>> _myList { get; set; }
        public ObservableCollection<Grouping<string, MyModel>> myList 
        {
            get { return _myList; }
            set
            {
                _myList = value;
                NotifyPropertyChanged();
            }
        }

        private IList<MyModel> listAux { get; set; }
        private IList<Grouping<string, MyModel>> listAux2 { get; set; }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                if (_isRefreshing != value)
                {
                    _isRefreshing = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRefreshing)));
                }
            }
        }

        private string _filter;
        public string Filter
        {
            get { return _filter; }
            set
            {
                if (_filter != value)
                {
                    _filter = value;
                    Search();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Filter)));
                }
            }
        }

        //Constructor de la clase
        public MainDetailTab1ViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            InitView();
            InitCommands();
        }

        //Methods definition
        private void InitView()
        {
            TitlePage = "OTOTOTOTO";
            myList = new ObservableCollection<Grouping<string, MyModel>>();
            listAux = new List<MyModel>();
            listAux2 = new List<Grouping<string, MyModel>>();
            LoadList();
        }

        private void InitCommands()
        {
            SearchCommand = new Command(Search);
            RefreshCommand = new Command(LoadList);
            Button1Command = new Command(async () => await Button1Cmd());
            Button2Command = new Command(async () => await Button2Cmd());
            ItemTappedCommand = new Command(async () => await OpenMenuList());
        }

        private void LoadList()
        {
            IsRefreshing = true;
            myList.Clear();
            var assembly = typeof(MainDetailTab1ViewModel).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("appVictorWork.Data.json");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                listAux = JsonConvert.DeserializeObject<List<MyModel>>(json);

            }

            Search();
            IsRefreshing = false;
        }

       

        private void Search()
        {
            IsRefreshing = true;

            if (string.IsNullOrEmpty(Filter))
            {
                var sorted =
                from f in listAux
                orderby f.firstLine
                group f by f.firstLine[0].ToString()
                into theGroup
                select
                new Grouping<string, MyModel>
                (theGroup.Key, theGroup);

                myList = new
                ObservableCollection
                <Grouping<string, MyModel>>(sorted);
            }
            else
            {
                var sorted =
                from f in listAux
                where f.firstLine.ToLower().Contains(Filter.ToLower())
                orderby f.firstLine
                group f by f.firstLine[0].ToString()
                into theGroup
                select
                new Grouping<string, MyModel>
                (theGroup.Key, theGroup);

                myList = new
                    ObservableCollection
                    <Grouping<string, MyModel>>(sorted);
            }

            IsRefreshing = false;

        }

        private async Task Button1Cmd()
        {
            await navigation.PushAsync(new ViewButton1());
        }

        private async Task Button2Cmd()
        {
            await navigation.PushAsync(new ViewButton2());
        }

        private async Task OpenMenuList()
        {
            await PopupNavigation.PushAsync(new MenuList(CurrentItem));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
