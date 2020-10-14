using System.Collections.Generic;

namespace MyDotNetCoreTemplate.Web.Views.Shared.Components.SideBarMenu
{
    public class UserMenuItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
        public string Url { get; set; }
        public object CustomData { get; set; }
        public string Target { get; set; }
        public bool IsVisible { get; set; }
        public IList<UserMenuItem> Items { get; set; }
    }

    public class SideBarMenuViewModel
    {
        public IList<UserMenuItem> MainMenuItems { get; set; }
    }
}
