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

        private double width;
        private double height;
        private Grid mainLayout;
        private Grid innerGrid;
        private Label titleLabel;
        private Button userButton;
        private Button starterButton;


        public MainPage()
		{
            
			InitializeComponent();

            mainLayout = new Grid();
            mainLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            mainLayout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            innerGrid = new Grid();
                      
            titleLabel = new Label
            {
                Text = "Segel Appen",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                
            };
            
            
            userButton = new Button
            {                
                Text = "User",
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };
            
            
            userButton.Clicked += OnUserButtonClicked;

            async void OnUserButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new UserMain());
            }

            starterButton = new Button
            {
                Text = "Starter",
                Font = Font.SystemFontOfSize(NamedSize.Large),
            };
            
            
            starterButton.Clicked += OnStarterButtonClicked;

            async void OnStarterButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new StarterMain());
            }

            mainLayout.Children.Add(innerGrid);
            innerGrid.Children.Add(titleLabel);
            innerGrid.Children.Add(userButton);
            innerGrid.Children.Add(starterButton);

            Content = mainLayout;
            
            
            
            
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                if (width > height)
                {
                    innerGrid.RowDefinitions.Clear();
                    innerGrid.ColumnDefinitions.Clear();
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    innerGrid.Children.Remove(innerGrid);
                    innerGrid.Children.Add(titleLabel, 0, 0);
                    Grid.SetColumnSpan(titleLabel, 2);
                    innerGrid.Children.Add(userButton, 0, 1);
                    innerGrid.Children.Add(starterButton, 1, 1);
                }
                else
                {
                    innerGrid.RowDefinitions.Clear();
                    innerGrid.ColumnDefinitions.Clear();
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    innerGrid.Children.Remove(innerGrid);
                    innerGrid.Children.Add(titleLabel, 0, 0);
                    innerGrid.Children.Add(userButton, 0, 1);
                    innerGrid.Children.Add(starterButton, 0, 2);
                    Grid.SetColumnSpan(titleLabel, 2);
                    Grid.SetColumnSpan(userButton, 2);
                    Grid.SetColumnSpan(starterButton, 2);
                }
            }
        }
    }
}
