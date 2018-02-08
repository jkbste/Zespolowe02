using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AuctionsTab : ContentPage
	{
        public class Auction
        {
            public string Title { get; set; }
            public string ToEnd { get; set; }
            public string User { get; set; }
        }

        ObservableCollection<Auction> auctions = new ObservableCollection<Auction>();

		public AuctionsTab ()
		{
			InitializeComponent ();

            listView.ItemsSource = auctions;

            for (int i = 0; i < 15; ++i)
            {
                auctions.Add(new Auction { Title = "Tytuł", ToEnd = "1d 15h 28m", User = "user123" });
            }
        }
    }
}