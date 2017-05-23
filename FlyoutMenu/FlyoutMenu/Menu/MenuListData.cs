using System.Collections.Generic;

namespace FlyoutMenu.Menu
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Titulo = "Home",
                Icon = "ic_home.png",
                TargetType = typeof(MainPage)
            });

            this.Add(new MenuItem()
            {
                Titulo = "Foundation",
                Icon = "ic_foundation.png",
                TargetType = typeof(Foundation)
            });

            this.Add(new MenuItem()
            {
                Titulo = "Lipstick",
                Icon = "ic_lipstick.png",
                TargetType = typeof(Lipstick)
            });
            this.Add(new MenuItem()
            {
                Titulo = "Mascara",
                Icon = "ic_mascara.png",
                TargetType = typeof(Mascara)
            });
            this.Add(new MenuItem()
            {
                Titulo = "Nails",
                Icon = "ic_nail.png",
                TargetType = typeof(Nail)
            });
        }
    }
}
