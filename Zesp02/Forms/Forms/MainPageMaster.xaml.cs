using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ListView ListView;

        public MainPageMaster()
        {
            InitializeComponent();

            BindingContext = new MainPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }
            
            public MainPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
                {
                    new MainPageMenuItem
                    {
                        Id = 0,
                        Title = "Profil",
                        ImgSource = "ic_account_circle_black_24dp.png"
                    },
                    new MainPageMenuItem
                    {
                        Id = 1,
                        Title = "Ustawienia",
                        ImgSource = "ic_settings_black_24dp.png"
                    },
                    new MainPageMenuItem
                    {
                        Id = 2,
                        Title = "Pomoc",
                        ImgSource = "ic_help_black_24dp.png"
                    },
                    new MainPageMenuItem
                    {
                        Id = 3,
                        Title = "O aplikacji",
                        ImgSource = "ic_info_black_24dp.png"
                    },
                    new MainPageMenuItem
                    {
                        Id = 4,
                        Title = "Wyloguj się",
                        ImgSource = "ic_power_settings_new_black_24dp.png"
                    },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}