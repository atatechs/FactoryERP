﻿using STORM;
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

        public void FactoryERPBusiness()
        {
            EBO Login = new EBO("Login");
            Login.AddAttribute("Username", "_string", NULL.NotNull);
            Login.AddAttribute("Password", "_string");
            Login.AddAttribute("Active", "_bool");
            Login.AddAttribute("Lock", "_bool");
            Login.AddAttribute("LastLogin", "_datetime");
            Login.AddAttribute("LastUnsuccessfulLogin", "_datetime");
            Login.AddAttribute("LastRecoveryUsed", "_datetime");
            Login.AddAttribute("CreatedDate", "_datetime");
            Login.AddAttribute("LastModified", "_datetime");
            Login.AddAttribute("LastPassword", "_string");
            Login.AddAttribute("Role", "Role");

            Login.AddCandidateKey("Username");
            Framework.AddEBO(Login);

            EBO Role = new EBO("Role");
            Role.AddAttribute("RoleName", "_string", NULL.NotNull);
            Role.AddAttribute("Active", "_bool");
            Role.AddAttribute("CreatedDate", "_datetime");
            Role.AddAttribute("UpdatedDate", "_datetime");

            Role.AddCandidateKey("RoleName");
            Framework.AddEBO(Role);

            EBO Menu = new EBO("Menu");
            Menu.AddAttribute("ParentMenu", "Menu", NULL.NotNull);
            Menu.AddAttribute("MenuName", "_string");
            Menu.AddAttribute("MenuIcon", "_string");
            Menu.AddAttribute("Page", "Page");

            Menu.AddCandidateKey("MenuName");
            Framework.AddEBO(Menu);

            SBO MenuMapping = new SBO("MenuMapping", "Role");
            MenuMapping.AddAttribute("Menu", "Menu");
            MenuMapping.AddAttribute("CreatedDate", "_datetime");
            MenuMapping.AddAttribute("UpdatedDate", "_datetime");

            Framework.AddSBO(MenuMapping);

            EBO ControllerMethod = new EBO("ControllerMethod");
            ControllerMethod.AddAttribute("ControllerName", "Menu");
            ControllerMethod.AddAttribute("ActionName", "_string");
            ControllerMethod.AddAttribute("Type", "_int");
            ControllerMethod.AddAttribute("CreatedDate", "_datetime");
            ControllerMethod.AddAttribute("UpdatedDate", "_datetime");

            ControllerMethod.AddCandidateKey("ControllerName");
            Framework.AddEBO(ControllerMethod);

            SBO ControllerMapping = new SBO("ControllerMapping", "Role");
            ControllerMapping.AddAttribute("Controller", "Controller");
            ControllerMapping.AddAttribute("CreatedDate", "_datetime");
            ControllerMapping.AddAttribute("UpdatedDate", "_datetime");

            Framework.AddSBO(ControllerMapping);

            EBO RistrictedSection = new EBO("RistrictedSection");
            RistrictedSection.AddAttribute("DivID", "_int");
            RistrictedSection.AddAttribute("Comments", "_string");
            RistrictedSection.AddAttribute("Page", "_int");
            RistrictedSection.AddAttribute("CreatedDate", "_datetime");
            RistrictedSection.AddAttribute("UpdatedDate", "_datetime");

            ControllerMethod.AddCandidateKey("DivID");
            Framework.AddEBO(RistrictedSection);

            Framework.GenerateBusiness("FactoryERP", @"data source=Lenovo-PC\SQLEXPRESS; user id=sa; password=123;", "FactoryERP");
        }
    }
}