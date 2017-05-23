using System;
using Xamarin.Forms;

namespace FlyoutMenu.Menu
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;

        public RootPage()
        {
            menuPage = new MenuPage();

            menuPage.Menu.ItemSelected +=
                (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

            Master = menuPage;

            Detail = new NavigationPage(new MainPage());

            MasterBehavior = MasterBehavior.Popover;
        }

        void NavigateTo(MenuItem menu)
        {
            if (menu == null)
                return;

            Page displayPage = null;            

            switch (menu.TargetType.Name)
            {
                case "Foundation":
                case "Mascara":
                case "Lipstick":
                case "Nails":
                default:
                    displayPage = (Page)Activator.CreateInstance(menu.TargetType);
                    break;       
            };

            try
            {          
                Detail = new NavigationPage(displayPage);
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("ERRO", "Erro " + ex.Message, "OK");
            }

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}
