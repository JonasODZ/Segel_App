using Segel_app.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Segel_app
{
	public partial class MainPage : ContentPage
	{
        
        


		public MainPage()
		{
            
            

			InitializeComponent();


            var mainLayout = new StackLayout()
            {
                Padding = new Thickness(5, 50)
            };
           
            var titleLabel = new Label
            {
                Margin = new Thickness(5, 0, 5, 30),
                Text = "Segel Appen",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                FontSize = 40,                
            };
            
            var userButton = new Button
            {
                WidthRequest = 200,
                HeightRequest = 100,
                Margin = new Thickness(5, 20, 5, 20),
                Text = "User",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };
            
            userButton.Clicked += OnUserButtonClicked;

            async void OnUserButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new UserMain());
            }

            var starterButton = new Button
            {
                Margin = new Thickness(5, 50, 5, 0),
                Text = "Starter",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };
            
            starterButton.Clicked += OnStarterButtonClicked;

            async void OnStarterButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new StarterMain());
            }

            
            mainLayout.Children.Add(titleLabel);
            mainLayout.Children.Add(userButton);
            mainLayout.Children.Add(starterButton);

            Content = mainLayout;
            

            
            
        }
        
	}
}
