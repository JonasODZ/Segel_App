using Segel_app.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Segel_app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserMain : ContentPage
	{
        private List<RaceData> RaceDataList = new List<RaceData>();
        
        public UserMain ()
		{
			InitializeComponent ();

            RaceDataList.Add(new RaceData("Race 1", new DateTime(2018, 4, 20, 9, 0, 0)));
            RaceDataList.Add(new RaceData("Race 2", new DateTime(2018, 4, 20, 9, 15, 0)));
            RaceDataList.Add(new RaceData("Race 3", new DateTime(2018, 4, 20, 9, 30, 0)));
            RaceDataList.Add(new RaceData("Race 4", new DateTime(2018, 4, 20, 9, 45, 0)));
            RaceDataList.Add(new RaceData("Race 5", new DateTime(2018, 4, 20, 10, 0, 0)));

            
            var userGridLayout = new Grid();

            
            for (int i = 0; i < RaceDataList.Count; i++)
            {
                userGridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });                
            }

            userGridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(.5, GridUnitType.Star) });
            userGridLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(.5, GridUnitType.Star) });

            for (int i = 0; i < RaceDataList.Count; i++)
            {
                var Time = RaceDataList[i].StartTime;
                userGridLayout.Children.Add(new Label()  // adding the item as label
                {
                    Text = Time.ToString(),
                    TextColor = Color.White,
                    BackgroundColor = Color.Blue,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                }, 0, i);

                userGridLayout.Children.Add(new Label()  // adding the item as label
                {
                    Text = RaceDataList[i].Name,
                    TextColor = Color.White,
                    BackgroundColor = Color.Blue,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                }, 1, i);               
            }



            Content = userGridLayout;
            
        }
	}
}