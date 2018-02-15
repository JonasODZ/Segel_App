using Segel_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Segel_app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StarterMain : ContentPage
	{
        private double width;
        private double height;
        private Grid starterMainLayout;
        private ScrollView starterScroll;
        private Grid listGrid;
        private Label starterTitle;
        private Button createHeatButton;
        private List<RaceData> RaceDataList = new List<RaceData>();

        public StarterMain ()
		{
            
            InitializeComponent ();

            RaceDataList.Add(new RaceData("Race 1", new DateTime(2018, 4, 20, 9, 0, 0)));
            RaceDataList.Add(new RaceData("Race 2", new DateTime(2018, 4, 20, 9, 15, 0)));
            RaceDataList.Add(new RaceData("Race 3", new DateTime(2018, 4, 20, 9, 30, 0)));
            RaceDataList.Add(new RaceData("Race 4", new DateTime(2018, 4, 20, 9, 45, 0)));
            RaceDataList.Add(new RaceData("Race 5", new DateTime(2018, 4, 20, 10, 0, 0)));
            RaceDataList.Add(new RaceData("Race 6", new DateTime(2018, 4, 20, 10, 15, 0)));
            RaceDataList.Add(new RaceData("Race 7", new DateTime(2018, 4, 20, 10, 30, 0)));
            RaceDataList.Add(new RaceData("Race 8", new DateTime(2018, 4, 20, 10, 45, 0)));
            RaceDataList.Add(new RaceData("Race 9", new DateTime(2018, 4, 20, 11, 0, 0)));
            RaceDataList.Add(new RaceData("Race 10", new DateTime(2018, 4, 20, 11, 15, 0)));

            starterMainLayout = new Grid();
            starterMainLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(.2, GridUnitType.Star) });
            starterMainLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(.2, GridUnitType.Star) });
            starterMainLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(.6, GridUnitType.Star) });
            starterMainLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });


            starterTitle = new Label
            {
                Text = "Starter Home",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 40                
            };
            

            async void OnUserButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new CreateHeat());
            }

            createHeatButton = new Button
            {
                Text = "Create Heat",
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Center
            };
            createHeatButton.Clicked += OnUserButtonClicked;

            starterScroll = new ScrollView();

            listGrid = new Grid();
            starterScroll.Content = listGrid;

            for (int i = 0; i < RaceDataList.Count; i++)
            {
                listGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            }
            listGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(.5, GridUnitType.Star) });
            listGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(.5, GridUnitType.Star) });

            for (int i = 0; i < RaceDataList.Count; i++)
            {
                var Time = RaceDataList[i].StartTime;
                listGrid.Children.Add(new Label()  // adding the item as label
                {
                    Text = Time.ToString(),
                    TextColor = Color.White,
                    BackgroundColor = Color.Blue,
                    HeightRequest = 60,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                    
                }, 0, i);

                listGrid.Children.Add(new Label()  // adding the item as label
                {
                    Text = RaceDataList[i].Name,
                    TextColor = Color.White,
                    BackgroundColor = Color.Blue,
                    HeightRequest = 60,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                }, 1, i);
            }

            starterMainLayout.Children.Add(starterTitle, 0, 0);
            starterMainLayout.Children.Add(createHeatButton, 0, 1);
            starterMainLayout.Children.Add(starterScroll, 0, 2);

            Content = starterMainLayout;
        }
	}
}