using System.Collections.Generic;
using Xamarin.Forms;

namespace FlyoutMenu.Menu
{
    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetBinding(ImageCell.TextProperty, "Titulo");
            cell.SetBinding(ImageCell.ImageSourceProperty, new Binding("Icon"));
            cell.SetValue(ImageCell.TextColorProperty, Color.White);

            SeparatorVisibility = SeparatorVisibility.Default;

            ItemTemplate = cell;
        }
    }
}
