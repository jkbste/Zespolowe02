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
    public partial class MainPageDetail : TabbedPage
    {
        public MainPageDetail()
        {
            InitializeComponent();

            Children.Add(new MainTab());
            Children.Add(new AuctionsTab());
            Children.Add(new GameRoomsTab());
            Children.Add(new MessagesTab());
        }

        protected override void OnCurrentPageChanged()
        {
            if (CurrentPage.GetType() == typeof(MainTab))
            {
                Title = "Main";
            }
            else if(CurrentPage.GetType() == typeof(AuctionsTab))
            {
                Title = "Aukcje";
            }
            else if (CurrentPage.GetType() == typeof(GameRoomsTab))
            {
                Title = "GameRooms";
            }
            else if (CurrentPage.GetType() == typeof(MessagesTab))
            {
                Title = "Wiadomości";
            }
        }
    }
}