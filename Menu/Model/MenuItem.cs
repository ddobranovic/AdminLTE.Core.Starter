using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace AdminLte.Core.Starter.Model
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string PageUrl { get; set; }
        public string Class { get; set; }
        public List<MenuItem> Subitems { get; set; } = null;
    }
}
