using Xamarin.Forms;

namespace FlyoutMenu.Menu
{
    public class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }

        public MenuPage()
        {
            Title = "Menu";
            BackgroundColor = Color.FromHex("FF8CB9");

            Menu = new MenuListView();        

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = 5
            };

            layout.Children.Add(Menu);

            Content = layout;
        }
    }
}
