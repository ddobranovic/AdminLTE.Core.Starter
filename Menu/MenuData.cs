using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLte.Core.Starter.Model;

namespace AdminLte.Core.Starter.Menu
{
    public static class MenuData
    {
        public static List<MenuItem> MenuItems = new List<MenuItem>()
        {
            new MenuItem()
            {
                Name = "Dashboard",
                Class = "fas fa-tachometer-alt",
                Subitems = new List<MenuItem>()
                {
                    new MenuItem()
                        { Name = "Dashboard v1", PageUrl = "/Dashboard/Dashboard1", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Dashboard v2", PageUrl = "/Dashboard/Dashboard2", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Dashboard v3", PageUrl = "/Dashboard/Dashboard3", Class = "fa-circle nav-icon", Subitems = null },
                }
            },
            new MenuItem()
            {
                Name = "Forms",
                Class = "fas fa-edit",
                Subitems = new List<MenuItem>()
                {
                    new MenuItem()
                        { Name = "General Elements", PageUrl = "/Forms/General", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Advanced Elements", PageUrl = "/Forms/Advanced", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Validation", PageUrl = "/Forms/Validation", Class = "fa-circle nav-icon", Subitems = null }
                }
            },
            new MenuItem()
            {
                Name = "Tables",
                Class = "fas fa-table",
                Subitems = new List<MenuItem>()
                {
                    new MenuItem()
                        { Name = "Simple", PageUrl = "/Tables/Simple", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Datatables.net", PageUrl = "/Tables/Datatables", Class = "fa-circle nav-icon", Subitems = null }
                }
            },
            new MenuItem()
            {
                Name = "Pages",
                Class = "fas fa-book",
                Subitems = new List<MenuItem>()
                {
                    new MenuItem()
                        { Name = "Inovice", PageUrl = "/ExamplePages/Invoice", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Faq", PageUrl = "/ExamplePages/FAQ", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Contact us", PageUrl = "/ExamplePages/ContactUs", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Projects", PageUrl = "/ExamplePages/Projects", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Project add", PageUrl = "/ExamplePages/ProjectAdd", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Project edit", PageUrl = "/ExamplePages/ProjectEdit", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Project details", PageUrl = "/ExamplePages/ProjectDetails", Class = "fa-circle nav-icon", Subitems = null },
                }
            },
            new MenuItem()
            {
                Name = "Test",
                Class = "fas fa-tachometer-alt",
                Subitems = new List<MenuItem>()
                {
                    new MenuItem()
                        { Name = "Privacy", PageUrl = "/Privacy", Class = "fa-circle nav-icon", Subitems = null },
                    new MenuItem()
                        { Name = "Error", PageUrl = "/Error", Class = "fa-circle nav-icon", Subitems = null }
                }
        }
        };
    }
}
