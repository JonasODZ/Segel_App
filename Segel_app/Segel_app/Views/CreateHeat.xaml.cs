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
	public partial class CreateHeat : ContentPage
	{
		public CreateHeat ()
		{
			InitializeComponent ();

            var mainLayout = new AbsoluteLayout();

            var createPageTitle = new Label
            {
                Text = "Create Race",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 40
            };
            AbsoluteLayout.SetLayoutBounds(createPageTitle, new Rectangle( .5, 0, .8, .1));
            AbsoluteLayout.SetLayoutFlags(createPageTitle, AbsoluteLayoutFlags.All);

            var startDatePicker = new DatePicker
            {
                Format = "d"
            };
            AbsoluteLayout.SetLayoutBounds(startDatePicker, new Rectangle(.5, .2, .8, .1));
            AbsoluteLayout.SetLayoutFlags(startDatePicker, AbsoluteLayoutFlags.All);

            var startTimePicker = new TimePicker
            {
                Format = "T",                
            };
            AbsoluteLayout.SetLayoutBounds(startTimePicker, new Rectangle(.5, .4, .8, .1));
            AbsoluteLayout.SetLayoutFlags(startTimePicker, AbsoluteLayoutFlags.All);


            var raceNameEntry = new Entry
            {
                Placeholder = "Input Race Name"
            };
            AbsoluteLayout.SetLayoutBounds(raceNameEntry, new Rectangle(.5, .6, .8, .1));
            AbsoluteLayout.SetLayoutFlags(raceNameEntry, AbsoluteLayoutFlags.All);

            var saveButton = new Button
            {
                Text = "Save"
            };
            AbsoluteLayout.SetLayoutBounds(saveButton, new Rectangle(.9, .8, .3, .1));
            AbsoluteLayout.SetLayoutFlags(saveButton, AbsoluteLayoutFlags.All);

            mainLayout.Children.Add(saveButton);
            mainLayout.Children.Add(createPageTitle);
            mainLayout.Children.Add(startDatePicker);
            mainLayout.Children.Add(startTimePicker);
            mainLayout.Children.Add(raceNameEntry);

            Content = mainLayout;
        }
	}
}