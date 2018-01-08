using STORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryERP_BAL
{
    public class Login : BusinessObject<Login>
    {
        public string Username { get { return GetFieldData("Username"); } set { SetFieldData("Username", value); } }
        public string Password { get { return GetFieldData("Password"); } set { SetFieldData("Password", value); } }
        public bool Active { get { return GetFieldData("Active"); } set { SetFieldData("Active", value); } }
        public bool Lock { get { return GetFieldData("Lock"); } set { SetFieldData("Lock", value); } }
        public DateTime LastLogin { get { return GetFieldData("LastLogin"); } set { SetFieldData("LastLogin", value); } }
        public DateTime LastUnsuccessfulLogin { get { return GetFieldData("LastUnsuccessfulLogin"); } set { SetFieldData("LastUnsuccessfulLogin", value); } }
        public DateTime LastRecoveryUsed { get { return GetFieldData("LastRecoveryUsed"); } set { SetFieldData("LastRecoveryUsed", value); } }
        public DateTime CreatedDate { get { return GetFieldData("CreatedDate"); } set { SetFieldData("CreatedDate", value); } }
        public DateTime LastModified { get { return GetFieldData("LastModified"); } set { SetFieldData("LastModified", value); } }
        public string LastPassword { get { return GetFieldData("LastPassword"); } set { SetFieldData("LastPassword", value); } }
        public Role Role { get { return GetFieldData("Role"); } set { SetFieldData("Role", value); } }

        public Login()
        {
        }

        public Login(string Username, string Password, bool Active, bool Lock, DateTime LastLogin, DateTime LastUnsuccessfulLogin, DateTime LastRecoveryUsed, DateTime CreatedDate, DateTime LastModified, string LastPassword, Role Role)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("Username", Username);
            Collection.Add("Password", Password);
            Collection.Add("Active", Active);
            Collection.Add("Lock", Lock);
            Collection.Add("LastLogin", LastLogin);
            Collection.Add("LastUnsuccessfulLogin", LastUnsuccessfulLogin);
            Collection.Add("LastRecoveryUsed", LastRecoveryUsed);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("LastModified", LastModified);
            Collection.Add("LastPassword", LastPassword);
            Collection.Add("Role", Role);
            InsertBO(Collection);
        }

        public static Login GetLoginBy(string Username)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("Username", Username);
            return GetBOByKey(Collection);
        }

        public override Dictionary<string, object> UpdatedCollection()
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("Username", Username);
            Collection.Add("Password", Password);
            Collection.Add("Active", Active);
            Collection.Add("Lock", Lock);
            Collection.Add("LastLogin", LastLogin);
            Collection.Add("LastUnsuccessfulLogin", LastUnsuccessfulLogin);
            Collection.Add("LastRecoveryUsed", LastRecoveryUsed);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("LastModified", LastModified);
            Collection.Add("LastPassword", LastPassword);
            Collection.Add("Role", Role);
            return Collection;
        }
    }

    public class Role : BusinessObject<Role>
    {
        public List<MenuMapping> MenuMappingList { get { return GetSubBOList(typeof(MenuMapping)); } set { SetSubBOList(value, typeof(MenuMapping)); } }
        public List<ControllerMapping> ControllerMappingList { get { return GetSubBOList(typeof(ControllerMapping)); } set { SetSubBOList(value, typeof(ControllerMapping)); } }

        public string RoleName { get { return GetFieldData("RoleName"); } set { SetFieldData("RoleName", value); } }
        public bool Active { get { return GetFieldData("Active"); } set { SetFieldData("Active", value); } }
        public DateTime CreatedDate { get { return GetFieldData("CreatedDate"); } set { SetFieldData("CreatedDate", value); } }
        public DateTime UpdatedDate { get { return GetFieldData("UpdatedDate"); } set { SetFieldData("UpdatedDate", value); } }

        public Role()
        {
        }

        public Role(string RoleName, bool Active, DateTime CreatedDate, DateTime UpdatedDate, List<MenuMapping> MenuMappingList, List<ControllerMapping> ControllerMappingList)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("RoleName", RoleName);
            Collection.Add("Active", Active);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("UpdatedDate", UpdatedDate);
            Collection.Add("MenuMapping", MenuMappingList);
            Collection.Add("ControllerMapping", ControllerMappingList);
            InsertBO(Collection);
        }

        public static Role GetRoleBy(string RoleName)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("RoleName", RoleName);
            return GetBOByKey(Collection);
        }

        public override Dictionary<string, object> UpdatedCollection()
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("RoleName", RoleName);
            Collection.Add("Active", Active);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("UpdatedDate", UpdatedDate);
            Collection.Add("MenuMapping", MenuMappingList);
            Collection.Add("ControllerMapping", ControllerMappingList);
            return Collection;
        }
    }

    public class Page : BusinessObject<Page>
    {
        public string PageName { get { return GetFieldData("PageName"); } set { SetFieldData("PageName", value); } }
        public DateTime CreatedDate { get { return GetFieldData("CreatedDate"); } set { SetFieldData("CreatedDate", value); } }
        public DateTime UpdatedDate { get { return GetFieldData("UpdatedDate"); } set { SetFieldData("UpdatedDate", value); } }

        public Page()
        {
        }

        public Page(string PageName, DateTime CreatedDate, DateTime UpdatedDate)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("PageName", PageName);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("UpdatedDate", UpdatedDate);
            InsertBO(Collection);
        }

        public static Page GetPageBy(string PageName)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("PageName", PageName);
            return GetBOByKey(Collection);
        }

        public override Dictionary<string, object> UpdatedCollection()
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("PageName", PageName);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("UpdatedDate", UpdatedDate);
            return Collection;
        }
    }

    public class Menu : BusinessObject<Menu>
    {
        public Menu ParentMenu { get { return GetFieldData("ParentMenu"); } set { SetFieldData("ParentMenu", value); } }
        public string MenuName { get { return GetFieldData("MenuName"); } set { SetFieldData("MenuName", value); } }
        public string MenuIcon { get { return GetFieldData("MenuIcon"); } set { SetFieldData("MenuIcon", value); } }
        public Page Page { get { return GetFieldData("Page"); } set { SetFieldData("Page", value); } }

        public Menu()
        {
        }

        public Menu(Menu ParentMenu, string MenuName, string MenuIcon, Page Page)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("ParentMenu", ParentMenu);
            Collection.Add("MenuName", MenuName);
            Collection.Add("MenuIcon", MenuIcon);
            Collection.Add("Page", Page);
            InsertBO(Collection);
        }

        public static Menu GetMenuBy(string MenuName)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("MenuName", MenuName);
            return GetBOByKey(Collection);
        }

        public override Dictionary<string, object> UpdatedCollection()
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("ParentMenu", ParentMenu);
            Collection.Add("MenuName", MenuName);
            Collection.Add("MenuIcon", MenuIcon);
            Collection.Add("Page", Page);
            return Collection;
        }
    }

    public class ControllerMethod : BusinessObject<ControllerMethod>
    {
        public Menu ControllerName { get { return GetFieldData("ControllerName"); } set { SetFieldData("ControllerName", value); } }
        public string ActionName { get { return GetFieldData("ActionName"); } set { SetFieldData("ActionName", value); } }
        public int Type { get { return GetFieldData("Type"); } set { SetFieldData("Type", value); } }
        public DateTime CreatedDate { get { return GetFieldData("CreatedDate"); } set { SetFieldData("CreatedDate", value); } }
        public DateTime UpdatedDate { get { return GetFieldData("UpdatedDate"); } set { SetFieldData("UpdatedDate", value); } }

        public ControllerMethod()
        {
        }

        public ControllerMethod(Menu ControllerName, string ActionName, int Type, DateTime CreatedDate, DateTime UpdatedDate)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("ControllerName", ControllerName);
            Collection.Add("ActionName", ActionName);
            Collection.Add("Type", Type);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("UpdatedDate", UpdatedDate);
            InsertBO(Collection);
        }

        public static ControllerMethod GetControllerMethodBy(Menu ControllerName)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("ControllerName", ControllerName);
            return GetBOByKey(Collection);
        }

        public override Dictionary<string, object> UpdatedCollection()
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("ControllerName", ControllerName);
            Collection.Add("ActionName", ActionName);
            Collection.Add("Type", Type);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("UpdatedDate", UpdatedDate);
            return Collection;
        }
    }

    public class RistrictedSection : BusinessObject<RistrictedSection>
    {
        public string DivID { get { return GetFieldData("DivID"); } set { SetFieldData("DivID", value); } }
        public string Comments { get { return GetFieldData("Comments"); } set { SetFieldData("Comments", value); } }
        public Page Page { get { return GetFieldData("Page"); } set { SetFieldData("Page", value); } }
        public DateTime CreatedDate { get { return GetFieldData("CreatedDate"); } set { SetFieldData("CreatedDate", value); } }
        public DateTime UpdatedDate { get { return GetFieldData("UpdatedDate"); } set { SetFieldData("UpdatedDate", value); } }

        public RistrictedSection()
        {
        }

        public RistrictedSection(string DivID, string Comments, Page Page, DateTime CreatedDate, DateTime UpdatedDate)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("DivID", DivID);
            Collection.Add("Comments", Comments);
            Collection.Add("Page", Page);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("UpdatedDate", UpdatedDate);
            InsertBO(Collection);
        }

        public static RistrictedSection GetRistrictedSectionBy(string DivID)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("DivID", DivID);
            return GetBOByKey(Collection);
        }

        public override Dictionary<string, object> UpdatedCollection()
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("DivID", DivID);
            Collection.Add("Comments", Comments);
            Collection.Add("Page", Page);
            Collection.Add("CreatedDate", CreatedDate);
            Collection.Add("UpdatedDate", UpdatedDate);
            return Collection;
        }
    }

    public class MenuMapping : SubBO<MenuMapping>
    {
        public Menu Menu { get { return GetFieldData("Menu"); } set { SetFieldData("Menu", value); } }
        public DateTime CreatedDate { get { return GetFieldData("CreatedDate"); } set { SetFieldData("CreatedDate", value); } }
        public DateTime UpdatedDate { get { return GetFieldData("UpdatedDate"); } set { SetFieldData("UpdatedDate", value); } }

        public MenuMapping()
        {
        }

        public MenuMapping(Menu Menu, DateTime CreatedDate, DateTime UpdatedDate)
        {
            this.Menu = Menu;
            this.CreatedDate = CreatedDate;
            this.UpdatedDate = UpdatedDate;
        }
    }

    public class ControllerMapping : SubBO<ControllerMapping>
    {
        public ControllerMethod Controller { get { return GetFieldData("Controller"); } set { SetFieldData("Controller", value); } }
        public DateTime CreatedDate { get { return GetFieldData("CreatedDate"); } set { SetFieldData("CreatedDate", value); } }
        public DateTime UpdatedDate { get { return GetFieldData("UpdatedDate"); } set { SetFieldData("UpdatedDate", value); } }

        public ControllerMapping()
        {
        }

        public ControllerMapping(ControllerMethod Controller, DateTime CreatedDate, DateTime UpdatedDate)
        {
            this.Controller = Controller;
            this.CreatedDate = CreatedDate;
            this.UpdatedDate = UpdatedDate;
        }
    }
}
