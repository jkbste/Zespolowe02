using System;
using Xamarin.Forms;

namespace Forms
{

    public class MainPageMenuItem
    {
        public MainPageMenuItem()
        {
            TargetType = typeof(MainPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgSource { get; set; }
        

        public Type TargetType { get; set; }
    }
}