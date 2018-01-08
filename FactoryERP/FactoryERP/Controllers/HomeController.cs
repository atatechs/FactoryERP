using STORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryERP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public static void FactoryERPBusiness()
        {
            EBO Login = new EBO("Login");
            Login.AddAttribute("Username", "_string", NULL.NotNull);
            Login.AddAttribute("Password", "_string");
            Login.AddAttribute("Active", "_bool");
            Login.AddAttribute("Lock", "_bool");
            Login.AddAttribute("LastLogin", "_DateTime");
            Login.AddAttribute("LastUnsuccessfulLogin", "_DateTime");
            Login.AddAttribute("LastRecoveryUsed", "_DateTime");
            Login.AddAttribute("CreatedDate", "_DateTime");
            Login.AddAttribute("LastModified", "_DateTime");
            Login.AddAttribute("LastPassword", "_string");
            Login.AddAttribute("Role", "Role");

            Login.AddCandidateKey("Username");
            Framework.AddEBO(Login);

            EBO Role = new EBO("Role");
            Role.AddAttribute("RoleName", "_string", NULL.NotNull);
            Role.AddAttribute("Active", "_bool");
            Role.AddAttribute("CreatedDate", "_DateTime");
            Role.AddAttribute("UpdatedDate", "_DateTime");

            Role.AddCandidateKey("RoleName");
            Framework.AddEBO(Role);

            EBO Page = new EBO("Page");
            Page.AddAttribute("PageName", "_string", NULL.NotNull);
            Page.AddAttribute("CreatedDate", "_DateTime");
            Page.AddAttribute("UpdatedDate", "_DateTime");

            Page.AddCandidateKey("PageName");
            Framework.AddEBO(Page);

            EBO Menu = new EBO("Menu");
            Menu.AddAttribute("ParentMenu", "Menu", NULL.NotNull);
            Menu.AddAttribute("MenuName", "_string");
            Menu.AddAttribute("MenuIcon", "_string");
            Menu.AddAttribute("Page", "Page");

            Menu.AddCandidateKey("MenuName");
            Framework.AddEBO(Menu);

            SBO MenuMapping = new SBO("MenuMapping", "Role");
            MenuMapping.AddAttribute("Menu", "Menu");
            MenuMapping.AddAttribute("CreatedDate", "_DateTime");
            MenuMapping.AddAttribute("UpdatedDate", "_DateTime");

            Framework.AddSBO(MenuMapping);

            EBO ControllerMethod = new EBO("ControllerMethod");
            ControllerMethod.AddAttribute("ControllerName", "Menu");
            ControllerMethod.AddAttribute("ActionName", "_string");
            ControllerMethod.AddAttribute("Type", "_int");
            ControllerMethod.AddAttribute("CreatedDate", "_DateTime");
            ControllerMethod.AddAttribute("UpdatedDate", "_DateTime");

            ControllerMethod.AddCandidateKey("ControllerName");
            Framework.AddEBO(ControllerMethod);

            SBO ControllerMapping = new SBO("ControllerMapping", "Role");
            ControllerMapping.AddAttribute("Controller", "ControllerMethod");
            ControllerMapping.AddAttribute("CreatedDate", "_DateTime");
            ControllerMapping.AddAttribute("UpdatedDate", "_DateTime");

            Framework.AddSBO(ControllerMapping);

            EBO RistrictedSection = new EBO("RistrictedSection");
            RistrictedSection.AddAttribute("DivID", "_string");
            RistrictedSection.AddAttribute("Comments", "_string");
            RistrictedSection.AddAttribute("Page", "Page");
            RistrictedSection.AddAttribute("CreatedDate", "_DateTime");
            RistrictedSection.AddAttribute("UpdatedDate", "_DateTime");

            RistrictedSection.AddCandidateKey("DivID");
            Framework.AddEBO(RistrictedSection);

            Framework.GenerateBusiness("FactoryERP", @"data source=Lenovo-PC\SQLEXPRESS; user id=sa; password=123;", "FactoryERP");
        }
    }
}