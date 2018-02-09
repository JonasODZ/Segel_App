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

        private string[] races = { "Race 1", "Race 2", "Race 3", "Race 4", "Race 5" };
        private string[] raceTimes = { "09.00", "09.15", "09.30", "09.45", "10.00" };

		public StarterMain ()
		{
            
            InitializeComponent ();

            var starterLayout = new AbsoluteLayout();

            var starterPageTitle = new Label
            {
                Text = "Starter Home",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 40                
            };
            AbsoluteLayout.SetLayoutBounds(starterPageTitle, new Rectangle(.5, 0, .8, .1));
            AbsoluteLayout.SetLayoutFlags(starterPageTitle, AbsoluteLayoutFlags.All);

            async void OnUserButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new CreateHeat());
            }

            var createHeatButton = new Button
            {
                Text = "Create Heat",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center
            };
            AbsoluteLayout.SetLayoutBounds(createHeatButton, new Rectangle(.1, .2, .3, .2));
            AbsoluteLayout.SetLayoutFlags(createHeatButton, AbsoluteLayoutFlags.All);
            createHeatButton.Clicked += OnUserButtonClicked;

            var raceList = new ListView();
            raceList.ItemsSource = races;
            AbsoluteLayout.SetLayoutBounds(raceList, new Rectangle(0, 1, 1, .5));
            AbsoluteLayout.SetLayoutFlags(raceList, AbsoluteLayoutFlags.All);



            starterLayout.Children.Add(raceList);
            starterLayout.Children.Add(starterPageTitle);
            starterLayout.Children.Add(createHeatButton);

            Content = starterLayout;
        }
	}
}