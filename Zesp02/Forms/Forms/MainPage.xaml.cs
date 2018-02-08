using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainPageMenuItem;
            if (item == null)
                return;

            switch (item.Title)
            {
                case "Profil":
                    await Navi.PushAsync(new Profile());
                    break;
                case "Ustawienia":
                    await Navi.PushAsync(new Settings());
                    break;
                case "Pomoc":
                    await Navi.PushAsync(new Help());
                    break;
                case "O aplikacji":
                    await Navi.PushAsync(new AboutApp());
                    break;
            }

            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}