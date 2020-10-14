using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDotNetCoreTemplate.Web.Views.Shared.Components.SideBarMenu
{
    public class SideBarMenuViewComponent : ViewComponent
    {
        public SideBarMenuViewComponent()
        {
        }

        SideBarMenuViewModel InitUserMenu()
        {
            SideBarMenuViewModel model = new SideBarMenuViewModel();
            model.MainMenuItems = new List<UserMenuItem>()
            {
                new UserMenuItem()
                {
                    Name = "首页",
                    Icon = "far fa-circle",
                    IsVisible = true,
                    Url = "/",
                },
                new UserMenuItem()
                {
                    Name = "账号管理",
                    Icon = "far fa-user",
                    IsVisible = true,
                    Items = new List<UserMenuItem>() {
                        new UserMenuItem()
                        {
                            Name = "我的资料",
                            Icon = "far fa-circle",
                            IsVisible = true,
                            Url = "/Account/Manage",
                        },
                        new UserMenuItem()
                        {
                            Name = "修改密码",
                            Icon = "far fa-circle",
                            IsVisible = true,
                            Url = "/Account/Manage/ChangePassword",
                        },  
                    }
                }
            };
            return model;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string routePath = HttpContext.Request.Path.Value ?? "/";
            ViewBag.CurrentRoutePath = routePath;

            var model = InitUserMenu();

            return View(model);
        }
    }
}
